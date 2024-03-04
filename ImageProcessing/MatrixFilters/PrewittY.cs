using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    internal class PrewittY : MatrixFilter
    {
        public PrewittY() {
            kernel = new float[,] { { -1, -1, -1 }, { 0, 0, 0 }, { 1, 1, 1 } };
        }
    }
}
