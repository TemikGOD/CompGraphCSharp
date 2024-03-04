using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing.DotetFilters
{
    internal class GlassFilter : Filter
    {
        protected Random random;

        public GlassFilter(Random random) { 
            this.random = random;
        }

        protected override byte[] CalculateNewPixelColor(byte[] buffer, int x, int y, int width, int depth)
        {
            var offset = new int[depth];
            var resultColor = new byte[depth];
            int NewX, NewY;
            //Random random = new Random();
            NewX = (int)(x + (random.NextDouble() - 0.5) * 10);
            NewY = (int)(y + (random.NextDouble() - 0.5) * 10);
            if (NewX >= 0 && NewX < width - 1 && NewY >= 0 && NewY < buffer.Length / depth / width - 1)
            {
                for (var i = 0; i < depth; i++)
                    offset[i] = ((NewY * width) + NewX) * depth + i;

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
