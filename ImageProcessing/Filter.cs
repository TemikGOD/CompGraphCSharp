using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Threading;

namespace ImageProcessing
{
    abstract class Filter
    {
        public BitmapData ProcessImage(BitmapData data, int depth, byte[] buffer, System.ComponentModel.BackgroundWorker backgroundWorker1)
        {
            /*byte[] bufferWork = new byte[buffer.Length];
            buffer.CopyTo(bufferWork, 0);*/
            Parallel.Invoke(
                () => {
                    for (int i = 0; i < data.Height; i++)
                    {
                        CalculateNewPixelColor(buffer, 0, i, data.Width, depth);
                        backgroundWorker1.ReportProgress((int)((float)Clamp(i + Environment.ProcessorCount, 0, data.Width) / data.Width * 100));
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
                            CalculateNewPixelColor(buffer, i, j, data.Width, depth);
                        }
                    });
                });
            Marshal.Copy(buffer, 0, data.Scan0, buffer.Length);
            return data;
        }

        public int Clamp(int value, int min, int max)
        {
            if (value < min)
                return min;
            if (value > max) 
                return max;
            return value;
        }

        protected abstract void CalculateNewPixelColor(byte[] buffer, int x, int y, int width, int depth);
    }
}
