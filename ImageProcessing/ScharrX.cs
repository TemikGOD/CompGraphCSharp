using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    internal class ScharrX : MatrixFilter
    {
        public ScharrX()
        {
            kernel = new float[,] { { 3, 0, -3 }, { 10, 0, -10 }, { 3, 0, -3 } };
        }
    }
}
