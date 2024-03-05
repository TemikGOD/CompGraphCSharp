using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    internal class SobelX : MatrixFilter
    {
        public SobelX()
        {
            kernel = new float[,] { { -1, 0, 1 }, 
                                    { -2, 0, 2 }, 
                                    { -1, 0, 1 } };
        }
    }
}
