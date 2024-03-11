using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    internal class GreyWorld : Filter
    {
        private float average;

        private float[] averageIntensity;

        public override Bitmap ProcessImage(Bitmap sourceImage, BackgroundWorker backgroundWorker1)
        {
            var rect = new Rectangle(0, 0, sourceImage.Width, sourceImage.Height);
            var data = sourceImage.LockBits(rect, ImageLockMode.ReadWrite, sourceImage.PixelFormat);
            var depth = Bitmap.GetPixelFormatSize(data.PixelFormat) / 8; //bytes per pixel
            var buffer = new byte[data.Width * data.Height * depth];
            var resultBuffer = new byte[data.Width * data.Height * depth];
            Marshal.Copy(data.Scan0, buffer, 0, buffer.Length);
            averageIntensity = new float[] { 0, 0, 0 };
            Parallel.Invoke(
                () => {
                    for (int i = 0; i < data.Height; i++)
                    {
                        var offset = CalculateOffset(0, i, data.Width, depth);
                        for (int j = 0; j < depth; j++)
                            averageIntensity[j] += buffer[offset[j]];
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
                            for (int k = 0; k < depth; k++)
                                averageIntensity[k] += buffer[offset[k]];
                        }
                    });
                });
            average = (averageIntensity[0] + averageIntensity[1] + averageIntensity[2]) / 3;
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
            var offset = CalculateOffset(x, y, width, depth);
            var newColor = new byte[depth];
            for (int i = 0; i < depth; i++)
                newColor[i] = (byte)Clamp((int)(buffer[offset[i]] * average / averageIntensity[i]), 0, 255);
            return newColor;
        }
    }
}
