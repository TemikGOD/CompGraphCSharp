using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    internal class InversionFilter : Filter
    {
        protected override byte[] CalculateNewPixelColor(byte[] buffer, int x, int y, int width, int depth)
        {
            var offset = CalculateOffset(x, y, width, depth);
            var resultColor = new byte[depth];
            for (int i = 0; i < depth; i++)
                resultColor[i] = (byte)(255 - buffer[offset[i]]);
            return resultColor;
        }
    }
}
