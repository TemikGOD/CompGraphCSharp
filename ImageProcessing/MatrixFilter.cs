using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    internal class MatrixFilter : Filter
    {
        protected float[,] kernel;
        protected MatrixFilter() { }
        public MatrixFilter(float[,] kernel)
        {
            this.kernel = kernel;
        }

        protected override void CalculateNewPixelColor(byte[] buffer, int x, int y, int width, int depth)
        {
            int radiusX = kernel.GetLength(0) / 2;
            int radiusY = kernel.GetLength(1) / 2;
            float resultR = 0;
            float resultG = 0;
            float resultB = 0;
            for (int l = -radiusY; l <= radiusY; l++)
                for (int k = -radiusX; k <= radiusX; k++)
                {
                    int idX = Clamp(x + k, 0, width - 1);
                    int idY = Clamp(y + l, 0, buffer.Length / depth / width - 1);
                    var offsetNeighbor = ((idY * width) + idX) * depth;
                    resultR += buffer[offsetNeighbor + 0] * kernel[k + radiusX, l + radiusY];
                    resultG += buffer[offsetNeighbor + 1] * kernel[k + radiusX, l + radiusY];
                    resultB += buffer[offsetNeighbor + 2] * kernel[k + radiusX, l + radiusY];
                }
            var offset = ((y * width) + x) * depth;
            buffer[offset + 0] = (byte)Clamp((int)resultR, 0, 255);
            buffer[offset + 1] = (byte)Clamp((int)resultG, 0, 255);
            buffer[offset + 2] = (byte)Clamp((int)resultB, 0, 255);
        }
    }
}
