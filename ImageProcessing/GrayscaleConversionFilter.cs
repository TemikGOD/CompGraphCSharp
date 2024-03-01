using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    internal class GrayscaleConversionFilter : Filter
    {
        private double cLin(byte c)
        {
            double LinC = c / 255.0;
            if (LinC <= 0.04045)
                return LinC / 12.92;
            else
                return Math.Pow((LinC + 0.055) / 1.055, 2.4);
        }

        protected override void CalculateNewPixelColor(byte[] buffer, int x, int y, int width, int depth)
        {
            var offset = ((y * width) + x) * depth;
            // Dummy work    
            // To grayscale (0.2126 R + 0.7152 G + 0.0722 B)
            var yLin = 0.2126 * cLin(buffer[offset + 0]) + 0.7152 * cLin(buffer[offset + 1]) + 0.0722 * cLin(buffer[offset + 2]);
            byte ySRGB;
            if (yLin <= 0.0031308)
                ySRGB = (byte)(12.92 * yLin * 255);
            else
                ySRGB = (byte)((1.055 * Math.Pow(yLin, 1.0 / 2.4) - 0.055) * 255);
            buffer[offset + 0] = buffer[offset + 1] = buffer[offset + 2] = ySRGB;
        }
    }
}
