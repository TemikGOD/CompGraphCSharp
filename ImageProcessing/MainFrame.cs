using ImageProcessing.DotetFilters;
using ImageProcessing.MatrixFilters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessing
{
    public partial class MainFrame : Form
    {
        Bitmap image;

        Stopwatch timer = new Stopwatch();

        public MainFrame()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItemOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files|*.png;*.jpg;*.bmp|All files(*.*)|*.*";
            if(openFileDialog.ShowDialog() == DialogResult.OK) {
                image = new Bitmap(openFileDialog.FileName);
                pictureBoxImage.Image = image;
                pictureBoxImage.Refresh();
                
            }
        }

        private void toolStripMenuItemInversion_Click(object sender, EventArgs e)
        {
            InversionFilter filter = new InversionFilter();
            backgroundWorkerProgress.RunWorkerAsync(filter);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            timer.Restart();
            Bitmap newImage = ((Filter)e.Argument).ProcessImage(image, backgroundWorkerProgress);
            if (backgroundWorkerProgress.CancellationPending != true)
                image = newImage;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                pictureBoxImage.Image = image;
                pictureBoxImage.Refresh();

            }
            progressBar1.Value = 0;
            timer.Stop();
            labelTime.Text = timer.Elapsed.ToString();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            backgroundWorkerProgress.CancelAsync();
        }

        private void toolStripMenuItemGrayscale_Click(object sender, EventArgs e)
        {
            GrayscaleConversionFilter filter = new GrayscaleConversionFilter();
            backgroundWorkerProgress.RunWorkerAsync(filter);
        }

        private void toolStripMenuItemBlur_Click(object sender, EventArgs e)
        {
            BlurFilter filter = new BlurFilter();
            backgroundWorkerProgress.RunWorkerAsync(filter);
        }

        private void embossToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmbossFilter filter = new EmbossFilter();
            backgroundWorkerProgress.RunWorkerAsync(filter);
        }

        private void sharpeningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SharpeningFilter filter = new SharpeningFilter();
            backgroundWorkerProgress.RunWorkerAsync(filter);
        }

        private void motionBlurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MotionBlur filter = new MotionBlur(3);
            backgroundWorkerProgress.RunWorkerAsync(filter);
        }

        private void shiftX50ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShiftFilter filter = new ShiftFilter(50, 0);
            backgroundWorkerProgress.RunWorkerAsync(filter);
        }

        private void toolStripMenuItemBrightness_Click(object sender, EventArgs e)
        {
            BrightnessFilter filter = new BrightnessFilter();
            backgroundWorkerProgress.RunWorkerAsync(filter);
        }

        private void turnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Turn filter = new Turn(Math.PI/4, pictureBoxImage.Image.Width/2, pictureBoxImage.Image.Height/2);
            backgroundWorkerProgress.RunWorkerAsync(filter);
        }

        private void wavesYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WavesXFilter filter = new WavesXFilter();
            backgroundWorkerProgress.RunWorkerAsync(filter);
        }

        private void wavesXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WavesYFilter filter = new WavesYFilter();
            backgroundWorkerProgress.RunWorkerAsync(filter);
        }

        private void glassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            GlassFilter filter = new GlassFilter(rand);
            backgroundWorkerProgress.RunWorkerAsync(filter);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OtsyBinarizationFilter filter = new OtsyBinarizationFilter();
            backgroundWorkerProgress.RunWorkerAsync(filter);
        }

        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SepiaFilter filter = new SepiaFilter();
            backgroundWorkerProgress.RunWorkerAsync(filter);
        }

        private void WavesXToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            WavesXFilter wavesXFilter = new WavesXFilter();
            backgroundWorkerProgress.RunWorkerAsync(wavesXFilter);
        }

        private void WavesYToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            WavesYFilter wavesYFilter = new WavesYFilter();
            backgroundWorkerProgress.RunWorkerAsync(wavesYFilter);
        }

        private void scharrXToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ScharrX scharrX = new ScharrX();
            backgroundWorkerProgress.RunWorkerAsync(scharrX);
        }

        private void scharrYToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ScharrY scharrY = new ScharrY();
            backgroundWorkerProgress.RunWorkerAsync(scharrY);
        }

        private void prewittXToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PrewittX prewittX = new PrewittX();
            backgroundWorkerProgress.RunWorkerAsync(prewittX);
        }

        private void prewittYToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PrewittY prewittY = new PrewittY();
            backgroundWorkerProgress.RunWorkerAsync( prewittY);
        }

        private void toolStripMenuItemGaussian_Click(object sender, EventArgs e)
        {
            GaussianFilter gaussianFilter = new GaussianFilter();
            backgroundWorkerProgress.RunWorkerAsync (gaussianFilter);
        }

        private void soobelXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SobelX sobelX = new SobelX();
            backgroundWorkerProgress.RunWorkerAsync(sobelX);
        }

        private void sobelYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SobelY sobelY = new SobelY();
            backgroundWorkerProgress.RunWorkerAsync( sobelY);
        }

        private void medianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MedianFilter medianFilter = new MedianFilter();
            backgroundWorkerProgress.RunWorkerAsync(medianFilter);
        }
    }
}
