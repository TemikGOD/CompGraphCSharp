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
        protected override void CalculateNewPixelColor(byte[] buffer, int x, int y, int width, int depth)
        {
            var offset = ((y * width) + x) * depth;
            buffer[offset + 0] = (byte)(255 - buffer[offset + 0]);
            buffer[offset + 1] = (byte)(255 - buffer[offset + 1]);
            buffer[offset + 2] = (byte)(255 - buffer[offset + 2]);
        }
    }
}
