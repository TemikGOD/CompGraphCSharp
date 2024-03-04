using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing.DotetFilters
{
    internal class Turn : Filter
    {
        protected double deg;
        protected int x0, y0;

        public Turn(double deg, int x0, int y0)
        {
            this.deg = deg;
            this.x0 = x0;
            this.y0 = y0;
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
