using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    internal class EmbossFilter : MatrixFilter
    {
        public EmbossFilter() {
            kernel = new float[,] { { 0, 1, 0 }, 
                                    { 1, 0, -1 }, 
                                    { 0, -1, 0 } };
        }

        public override Bitmap ProcessImage(Bitmap sourceImage, System.ComponentModel.BackgroundWorker backgroundWorker1)
        {
            GrayscaleConversionFilter filter = new GrayscaleConversionFilter();
            sourceImage = filter.ProcessImage(sourceImage, backgroundWorker1);
            var rect = new Rectangle(0, 0, sourceImage.Width, sourceImage.Height);
            var data = sourceImage.LockBits(rect, ImageLockMode.ReadWrite, sourceImage.PixelFormat);
            var depth = Bitmap.GetPixelFormatSize(data.PixelFormat) / 8; //bytes per pixel
            var buffer = new byte[data.Width * data.Height * depth];
            var resultBuffer = new byte[data.Width * data.Height * depth];
            Marshal.Copy(data.Scan0, buffer, 0, buffer.Length);
            Parallel.Invoke(
                () => {
                    for (int i = 0; i < data.Height; i++)
                    {
                        var offset = CalculateOffset(0, i, data.Width, depth);
                        var newColor = CalculateNewPixelColor(buffer, 0, i, data.Width, depth);
                        for (int k = 0; k < depth; k++)
                            resultBuffer[offset[k]] = newColor[k];
                        backgroundWorker1.ReportProgress((int)((float)Clamp(i * Environment.ProcessorCount, 0, data.Width) / data.Width * 100));
                    }
                },
                () =>
                {
                    Parallel.For(1, data.Width, i =>
                    {
                        if (backgroundWorker1.CancellationPending)
                            return;
                        for (int j = 0; j < data.Height; j++)
                        {
                            var offset = CalculateOffset(i, j, data.Width, depth);
                            var newColor = CalculateNewPixelColor(buffer, i, j, data.Width, depth);
                            for (int k = 0; k < depth; k++)
                                resultBuffer[offset[k]] = newColor[k];
                        }
                    });
                });
            Marshal.Copy(resultBuffer, 0, data.Scan0, buffer.Length);
            sourceImage.UnlockBits(data);
            return sourceImage;
        }

        protected override byte[] CalculateNewPixelColor(byte[] buffer, int x, int y, int width, int depth)
        {
            int radiusX = kernel.GetLength(0) / 2;
            int radiusY = kernel.GetLength(1) / 2;
            float result = 0;
            for (int l = -radiusY; l <= radiusY; l++)
                for (int k = -radiusX; k <= radiusX; k++)
                {
                    int idX = Clamp(x + k, 0, width - 1);
                    int idY = Clamp(y + l, 0, buffer.Length / depth / width - 1);
                    var offsetNeighbor = CalculateOffset(idX, idY, width, depth);
                    result += buffer[offsetNeighbor[0]] * kernel[k + radiusX, l + radiusY];
                }

            result = ((int)result + 255) / 2;

            var offset = CalculateOffset(x, y, width, depth);
            var resultColor = new byte[depth];
            for (int i = 0; i < depth; i++)
                resultColor[i] = (byte)result;
            return resultColor;
        }
    }
}
