using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    internal class GlowingEdgesFilter : MatrixFilter
    {
        public override Bitmap ProcessImage(Bitmap sourceImage, BackgroundWorker backgroundWorker1)
        {
            MedianFilter medianFilter = new MedianFilter();
            PrewittY prewittY = new PrewittY();
            MaximumFilter maximumFilter = new MaximumFilter();
            sourceImage = medianFilter.ProcessImage(sourceImage, backgroundWorker1);
            sourceImage = prewittY.ProcessImage(sourceImage, backgroundWorker1);
            sourceImage = maximumFilter.ProcessImage(sourceImage, backgroundWorker1);
            return sourceImage;
        }
    }
}
