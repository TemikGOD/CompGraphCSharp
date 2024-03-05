using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    internal class OtsyBinarizationFilter : BinarizationFilter
    {
        protected override byte CalculateThreshold(Bitmap sourceImage)
        {
            byte min, max;
            min = max = sourceImage.GetPixel(0, 0).R;
            var rect = new Rectangle(0, 0, sourceImage.Width, sourceImage.Height);
            var data = sourceImage.LockBits(rect, ImageLockMode.ReadWrite, sourceImage.PixelFormat);
            var depth = Bitmap.GetPixelFormatSize(data.PixelFormat) / 8; //bytes per pixel
            var buffer = new byte[data.Width * data.Height * depth];
            Marshal.Copy(data.Scan0, buffer, 0, buffer.Length);
            Parallel.For(0, data.Width, i =>
            {
                for (int j = 0; j < data.Height; j++)
                {
                    var offset = CalculateOffset(i, j, data.Width, depth);
                    if (buffer[offset[0]] < min)
                        min = buffer[offset[0]];
                    if (buffer[offset[0]] > max)
                        max = buffer[offset[0]];
                }
            });
            byte histSize = (byte)(max - min + 1);
            int[] histogram = new int[histSize];
            for (int i = 0; i < data.Width; i++)
                for (int j = 0; j < data.Height; j++)
                {
                    var offset = CalculateOffset(i, j, data.Width, depth);
                    histogram[buffer[offset[0]] - min]++;
                }
            int m, n;
            m = n = 0;
            for (int t = 0; t < histSize; t++)
            {
                m += t * histogram[t];
                n += histogram[t];
            }
            float maxSigma = -1;
            byte threshold = 0;
            int alpha, beta;
            alpha = beta = 0;
            for (int t = 0; t < histSize - 1; t++)
            {
                alpha += t * histogram[t];
                beta += histogram[t];
                float w = (float)beta / n;
                float a = (float)alpha / beta - (float)(m - alpha) / (n - beta);
                float sigma = w * (1 - w) * a * a;
                if (sigma > maxSigma)
                {
                    maxSigma = sigma;
                    threshold = (byte)t;
                }
            }
            sourceImage.UnlockBits(data);
            return (byte)(threshold + min);
        }
    }
}
