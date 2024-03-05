using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    internal class MedianFilter : MatrixFilter
    {
        public MedianFilter()
        {
            kernel = new float[5, 5];
        }

        protected override byte[] CalculateNewPixelColor(byte[] buffer, int x, int y, int width, int depth)
        {
            // создать контейнер с парами ключ(offset)-значение(greycolor), отсортировать по значению, выбрать значение из середины
            var dic = new Dictionary<int, byte>();
            int radiusX = kernel.GetLength(0) / 2;
            int radiusY = kernel.GetLength(1) / 2;
            for (int l = -radiusY; l <= radiusY; l++)
                for (int k = -radiusX; k <= radiusX; k++)
                {
                    int idX = Clamp(x + k, 0, width - 1);
                    int idY = Clamp(y + l, 0, buffer.Length / depth / width - 1);
                    var offsetNeighbor = CalculateOffset(idX, idY, width, depth);
                    GrayscaleConversionFilter grayscaleConversionFilter = new GrayscaleConversionFilter();
                    dic[offsetNeighbor[0]] = grayscaleConversionFilter.GrayscalePixel(buffer, idX, idY, width, depth)[0];
                }
            var sortDic = dic.OrderByDescending(d => d.Value).ThenBy(d => d.Key).ToDictionary(d => d.Key, d => d.Value);
            if (sortDic.Count % 2 == 1)
            {
                var resOffset = sortDic.Keys.ToList()[sortDic.Count / 2];
                var resultColor = new byte[depth];
                for (int i = 0; i < depth; i++)
                    resultColor[i] = buffer[resOffset + i];
                return resultColor;
            }
            else
            {
                var resOffset = (sortDic.Keys.ToList()[sortDic.Count / 2 - 1]) / 2 + (sortDic.Keys.ToList()[sortDic.Count / 2]) / 2;
                var resultColor = new byte[depth];
                for (int i = 0; i < depth; i++)
                    resultColor[i] = buffer[resOffset + i];
                return resultColor;
            } 
        }
    }
}
