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

        private void scharrYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScharrY filter = new ScharrY();
            backgroundWorkerProgress.RunWorkerAsync(filter);
        }

        private void scharrXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScharrX filter = new ScharrX();
            backgroundWorkerProgress.RunWorkerAsync(filter);
        }

        private void prewittToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrewittY filter = new PrewittY();
            backgroundWorkerProgress.RunWorkerAsync(filter);
        }

        private void prewittXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrewittX filter = new PrewittX();
            backgroundWorkerProgress.RunWorkerAsync(filter);
        }

        private void shiftX50ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShiftFilter filter = new ShiftFilter(50, 0);
            backgroundWorkerProgress.RunWorkerAsync(filter);
        }

        private void toolStripMenuItemBrightness_Click(object sender, EventArgs e)
        {

        }

        private void turnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
