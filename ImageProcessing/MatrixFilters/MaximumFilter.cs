using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    internal class MaximumFilter : MatrixFilter
    {
        public MaximumFilter()
        {
            kernel = new float[3, 3];
        }

        
        protected override byte[] CalculateNewPixelColor(byte[] buffer, int x, int y, int width, int depth)
        {
            List<Dictionary<int, byte>> RGBDirs = new List<Dictionary<int, byte>>
            {
                new Dictionary<int, byte>(),
                new Dictionary<int, byte>(),
                new Dictionary<int, byte>()
            };
            int radiusX = kernel.GetLength(0) / 2;
            int radiusY = kernel.GetLength(1) / 2;
            for (int l = -radiusY; l <= radiusY; l++)
                for (int k = -radiusX; k <= radiusX; k++)
                {
                    int idX = Clamp(x + k, 0, width - 1);
                    int idY = Clamp(y + l, 0, buffer.Length / depth / width - 1);
                    var offsetNeighbor = CalculateOffset(idX, idY, width, depth);
                    for (int i = 0; i < depth; i++)
                        RGBDirs[i][offsetNeighbor[i]] = buffer[offsetNeighbor[i]];
                }
            for (int i = 0; i < depth; i++)
                RGBDirs[i] = RGBDirs[i].OrderByDescending(d => d.Value).ThenBy(d => d.Key).ToDictionary(d => d.Key, d => d.Value);
            var resultColor = new byte[depth];
            for (int i = 0; i < depth; i++)
            {
                var resOffset = RGBDirs[i].Keys.ToList().Last();
                resultColor[i] = buffer[resOffset];
            }
            return resultColor;
        }
    }
}
