using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing.MatrixFilters
{
    internal class ShiftFilter : Filter
    {
        protected int ShiftX, ShiftY;
        public ShiftFilter(int shiftX, int shiftY)
        {
            ShiftX = shiftX;
            ShiftY = shiftY;
        }

        protected override byte[] CalculateNewPixelColor(byte[] buffer, int x, int y, int width, int depth)
        {
            var offset = new int[depth];
            var resultColor = new byte[depth];
            if (x + ShiftX < width - 1 && y + ShiftY < buffer.Length / depth / width - 1)
            {
                for (var i = 0; i < depth; i++)
                    offset[i] = (((y + ShiftY) * width) + x + ShiftX) * depth + i;
                for (int i = 0; i < depth; i++)
                    resultColor[i] = buffer[offset[i]];
            }
            else
            {
                for (int i = 0; i < depth; i++)
                    resultColor[i] = 0;
            }
            return resultColor;
        }
    }
}
