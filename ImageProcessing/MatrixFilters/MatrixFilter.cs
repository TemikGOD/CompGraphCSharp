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

        protected override byte[] CalculateNewPixelColor(byte[] buffer, int x, int y, int width, int depth)
        {
            int radiusX = kernel.GetLength(0) / 2;
            int radiusY = kernel.GetLength(1) / 2;
            var result = new float[depth];
            for (int l = -radiusY; l <= radiusY; l++)
                for (int k = -radiusX; k <= radiusX; k++)
                {
                    int idX = Clamp(x + k, 0, width - 1);
                    int idY = Clamp(y + l, 0, buffer.Length / depth / width - 1);
                    var offsetNeighbor = CalculateOffset(idX, idY, width, depth);
                    for (int i = 0; i < depth; i++) {
                        result[i] += buffer[offsetNeighbor[0]] * kernel[k + radiusX, l + radiusY];
                    }
                }
            var offset = CalculateOffset(x, y, width, depth);
            var resultColor = new byte[depth];
            for (int i = 0; i < depth; i++)
                resultColor[i] = (byte)Clamp((int)result[i], 0, 255); 
            return resultColor;
        }
    }
}
