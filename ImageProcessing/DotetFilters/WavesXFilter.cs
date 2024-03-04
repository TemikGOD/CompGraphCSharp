using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing.DotetFilters
{
    internal class WavesXFilter : Filter
    {
        protected override byte[] CalculateNewPixelColor(byte[] buffer, int x, int y, int width, int depth)
        {
            var offset = new int[depth];
            var resultColor = new byte[depth];
            int NewX;
            NewX = (int)(x+20*Math.Sin(2*Math.PI*y/60));
            if (NewX >= 0 && NewX < width - 1 && y >= 0 && y < buffer.Length / depth / width - 1)
            {
                for (var i = 0; i < depth; i++)
                    offset[i] = ((y * width) + NewX) * depth + i;

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
