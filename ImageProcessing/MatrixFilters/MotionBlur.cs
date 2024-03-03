using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    internal class MotionBlur : MatrixFilter
    {
        public MotionBlur(int n) { 
            kernel = new float[n,n];
            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if (i == j) kernel[i, j] = 1.0f/n;
                    else kernel[i, j] = 0;
                }
            }
        }
    }
}
