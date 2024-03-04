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
            int NewX, NewY;
            NewX = (int)((x - x0) * Math.Cos(deg)) - (int)((y - y0) * Math.Sin(deg)) + x0;
            NewY = (int)((x - x0) * Math.Sin(deg)) + (int)((y - y0) * Math.Cos(deg)) + y0;
            if (NewX>=0 && NewX < width - 1 && NewY>=0 && NewY < buffer.Length / depth / width - 1)
            {
                for (var i = 0; i < depth; i++)
                    offset[i] = ( ( NewY * width) + NewX) * depth + i;
                    
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
