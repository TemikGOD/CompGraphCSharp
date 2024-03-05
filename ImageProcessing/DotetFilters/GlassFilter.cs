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
            var resultColor = new byte[depth];
            int NewX, NewY;
            //Random random = new Random();
            NewX = Clamp((int)(x + (random.NextDouble() - 0.5) * 10), x, width - 1);
            NewY = Clamp((int)(y + (random.NextDouble() - 0.5) * 10), y, buffer.Length / width / depth - 1);
            var offset = CalculateOffset(NewX, NewY, width, depth);
            for (int i = 0; i < depth; i++)
                resultColor[i] = buffer[offset[i]];
            return resultColor;
        }
    }
}
