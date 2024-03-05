using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    internal class BrightnessFilter : Filter
    {
        protected byte brightness;

        protected override byte[] CalculateNewPixelColor(byte[] buffer, int x, int y, int width, int depth)
        {
            brightness = 30;
            var offset = CalculateOffset(x, y, width, depth);
            var resultColor = new byte[depth];
            for (int i = 0; i < depth; i++)
                resultColor[i] = (byte)Clamp(buffer[offset[i]] + brightness, 0, 255);
            return resultColor;
        }
    }
}
