﻿namespace ImageProcessing
{
    partial class MainFrame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFilters = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemMatrix = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemBlur = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemGaussian = new System.Windows.Forms.ToolStripMenuItem();
            this.embossToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sharpeningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motionBlurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scharrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scharrXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scharrYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prewittToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prewittXToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.prewittYToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sobelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soobelXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobelYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maximumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.glovingEgesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSpot = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemBinarization = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemBrightness = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemGrayscale = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemInversion = new System.Windows.Forms.ToolStripMenuItem();
            this.shiftX50ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wavesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WavesXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WavesYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.glassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sepiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorkerProgress = new System.ComponentModel.BackgroundWorker();
            this.labelTime = new System.Windows.Forms.Label();
            this.greyWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfectReflectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFile,
            this.toolStripMenuItemFilters});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(873, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItemFile
            // 
            this.toolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemOpen,
            this.toolStripMenuItemSave,
            this.toolStripMenuItemSaveAs});
            this.toolStripMenuItemFile.Name = "toolStripMenuItemFile";
            this.toolStripMenuItemFile.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItemFile.Text = "File";
            // 
            // toolStripMenuItemOpen
            // 
            this.toolStripMenuItemOpen.Name = "toolStripMenuItemOpen";
            this.toolStripMenuItemOpen.Size = new System.Drawing.Size(121, 22);
            this.toolStripMenuItemOpen.Text = "Open...";
            this.toolStripMenuItemOpen.Click += new System.EventHandler(this.toolStripMenuItemOpen_Click);
            // 
            // toolStripMenuItemSave
            // 
            this.toolStripMenuItemSave.Name = "toolStripMenuItemSave";
            this.toolStripMenuItemSave.Size = new System.Drawing.Size(121, 22);
            this.toolStripMenuItemSave.Text = "Save";
            // 
            // toolStripMenuItemSaveAs
            // 
            this.toolStripMenuItemSaveAs.Name = "toolStripMenuItemSaveAs";
            this.toolStripMenuItemSaveAs.Size = new System.Drawing.Size(121, 22);
            this.toolStripMenuItemSaveAs.Text = "Save as...";
            // 
            // toolStripMenuItemFilters
            // 
            this.toolStripMenuItemFilters.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemMatrix,
            this.toolStripMenuItemSpot});
            this.toolStripMenuItemFilters.Name = "toolStripMenuItemFilters";
            this.toolStripMenuItemFilters.Size = new System.Drawing.Size(50, 20);
            this.toolStripMenuItemFilters.Text = "Filters";
            // 
            // toolStripMenuItemMatrix
            // 
            this.toolStripMenuItemMatrix.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemBlur,
            this.toolStripMenuItemGaussian,
            this.embossToolStripMenuItem,
            this.sharpeningToolStripMenuItem,
            this.motionBlurToolStripMenuItem,
            this.scharrToolStripMenuItem,
            this.prewittToolStripMenuItem,
            this.sobelToolStripMenuItem,
            this.medianToolStripMenuItem,
            this.maximumToolStripMenuItem,
            this.glovingEgesToolStripMenuItem});
            this.toolStripMenuItemMatrix.Name = "toolStripMenuItemMatrix";
            this.toolStripMenuItemMatrix.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemMatrix.Text = "Matrix";
            // 
            // toolStripMenuItemBlur
            // 
            this.toolStripMenuItemBlur.Name = "toolStripMenuItemBlur";
            this.toolStripMenuItemBlur.Size = new System.Drawing.Size(151, 22);
            this.toolStripMenuItemBlur.Text = "Blur";
            this.toolStripMenuItemBlur.Click += new System.EventHandler(this.toolStripMenuItemBlur_Click);
            // 
            // toolStripMenuItemGaussian
            // 
            this.toolStripMenuItemGaussian.Name = "toolStripMenuItemGaussian";
            this.toolStripMenuItemGaussian.Size = new System.Drawing.Size(151, 22);
            this.toolStripMenuItemGaussian.Text = "Gaussian";
            this.toolStripMenuItemGaussian.Click += new System.EventHandler(this.toolStripMenuItemGaussian_Click);
            // 
            // embossToolStripMenuItem
            // 
            this.embossToolStripMenuItem.Name = "embossToolStripMenuItem";
            this.embossToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.embossToolStripMenuItem.Text = "Emboss";
            this.embossToolStripMenuItem.Click += new System.EventHandler(this.embossToolStripMenuItem_Click);
            // 
            // sharpeningToolStripMenuItem
            // 
            this.sharpeningToolStripMenuItem.Name = "sharpeningToolStripMenuItem";
            this.sharpeningToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.sharpeningToolStripMenuItem.Text = "Sharpening";
            this.sharpeningToolStripMenuItem.Click += new System.EventHandler(this.sharpeningToolStripMenuItem_Click);
            // 
            // motionBlurToolStripMenuItem
            // 
            this.motionBlurToolStripMenuItem.Name = "motionBlurToolStripMenuItem";
            this.motionBlurToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.motionBlurToolStripMenuItem.Text = "Motion Blur(3)";
            this.motionBlurToolStripMenuItem.Click += new System.EventHandler(this.motionBlurToolStripMenuItem_Click);
            // 
            // scharrToolStripMenuItem
            // 
            this.scharrToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scharrXToolStripMenuItem,
            this.scharrYToolStripMenuItem});
            this.scharrToolStripMenuItem.Name = "scharrToolStripMenuItem";
            this.scharrToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.scharrToolStripMenuItem.Text = "Scharr";
            // 
            // scharrXToolStripMenuItem
            // 
            this.scharrXToolStripMenuItem.Name = "scharrXToolStripMenuItem";
            this.scharrXToolStripMenuItem.Size = new System.Drawing.Size(81, 22);
            this.scharrXToolStripMenuItem.Text = "X";
            this.scharrXToolStripMenuItem.Click += new System.EventHandler(this.scharrXToolStripMenuItem_Click_1);
            // 
            // scharrYToolStripMenuItem
            // 
            this.scharrYToolStripMenuItem.Name = "scharrYToolStripMenuItem";
            this.scharrYToolStripMenuItem.Size = new System.Drawing.Size(81, 22);
            this.scharrYToolStripMenuItem.Text = "Y";
            this.scharrYToolStripMenuItem.Click += new System.EventHandler(this.scharrYToolStripMenuItem_Click_1);
            // 
            // prewittToolStripMenuItem
            // 
            this.prewittToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prewittXToolStripMenuItem1,
            this.prewittYToolStripMenuItem1});
            this.prewittToolStripMenuItem.Name = "prewittToolStripMenuItem";
            this.prewittToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.prewittToolStripMenuItem.Text = "Prewitt";
            // 
            // prewittXToolStripMenuItem1
            // 
            this.prewittXToolStripMenuItem1.Name = "prewittXToolStripMenuItem1";
            this.prewittXToolStripMenuItem1.Size = new System.Drawing.Size(81, 22);
            this.prewittXToolStripMenuItem1.Text = "X";
            this.prewittXToolStripMenuItem1.Click += new System.EventHandler(this.prewittXToolStripMenuItem1_Click);
            // 
            // prewittYToolStripMenuItem1
            // 
            this.prewittYToolStripMenuItem1.Name = "prewittYToolStripMenuItem1";
            this.prewittYToolStripMenuItem1.Size = new System.Drawing.Size(81, 22);
            this.prewittYToolStripMenuItem1.Text = "Y";
            this.prewittYToolStripMenuItem1.Click += new System.EventHandler(this.prewittYToolStripMenuItem1_Click);
            // 
            // sobelToolStripMenuItem
            // 
            this.sobelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.soobelXToolStripMenuItem,
            this.sobelYToolStripMenuItem});
            this.sobelToolStripMenuItem.Name = "sobelToolStripMenuItem";
            this.sobelToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.sobelToolStripMenuItem.Text = "Sobel";
            // 
            // soobelXToolStripMenuItem
            // 
            this.soobelXToolStripMenuItem.Name = "soobelXToolStripMenuItem";
            this.soobelXToolStripMenuItem.Size = new System.Drawing.Size(81, 22);
            this.soobelXToolStripMenuItem.Text = "X";
            this.soobelXToolStripMenuItem.Click += new System.EventHandler(this.soobelXToolStripMenuItem_Click);
            // 
            // sobelYToolStripMenuItem
            // 
            this.sobelYToolStripMenuItem.Name = "sobelYToolStripMenuItem";
            this.sobelYToolStripMenuItem.Size = new System.Drawing.Size(81, 22);
            this.sobelYToolStripMenuItem.Text = "Y";
            this.sobelYToolStripMenuItem.Click += new System.EventHandler(this.sobelYToolStripMenuItem_Click);
            // 
            // medianToolStripMenuItem
            // 
            this.medianToolStripMenuItem.Name = "medianToolStripMenuItem";
            this.medianToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.medianToolStripMenuItem.Text = "Median";
            this.medianToolStripMenuItem.Click += new System.EventHandler(this.medianToolStripMenuItem_Click);
            // 
            // maximumToolStripMenuItem
            // 
            this.maximumToolStripMenuItem.Name = "maximumToolStripMenuItem";
            this.maximumToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.maximumToolStripMenuItem.Text = "Maximum";
            this.maximumToolStripMenuItem.Click += new System.EventHandler(this.maximumToolStripMenuItem_Click);
            // 
            // glovingEgesToolStripMenuItem
            // 
            this.glovingEgesToolStripMenuItem.Name = "glovingEgesToolStripMenuItem";
            this.glovingEgesToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.glovingEgesToolStripMenuItem.Text = "Gloving eges";
            this.glovingEgesToolStripMenuItem.Click += new System.EventHandler(this.glovingEgesToolStripMenuItem_Click);
            // 
            // toolStripMenuItemSpot
            // 
            this.toolStripMenuItemSpot.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemBinarization,
            this.toolStripMenuItemBrightness,
            this.toolStripMenuItemGrayscale,
            this.toolStripMenuItemInversion,
            this.shiftX50ToolStripMenuItem,
            this.turnToolStripMenuItem,
            this.wavesToolStripMenuItem,
            this.glassToolStripMenuItem,
            this.sepiaToolStripMenuItem,
            this.greyWorldToolStripMenuItem,
            this.perfectReflectorToolStripMenuItem});
            this.toolStripMenuItemSpot.Name = "toolStripMenuItemSpot";
            this.toolStripMenuItemSpot.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemSpot.Text = "Spot";
            // 
            // toolStripMenuItemBinarization
            // 
            this.toolStripMenuItemBinarization.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.toolStripMenuItemBinarization.Name = "toolStripMenuItemBinarization";
            this.toolStripMenuItemBinarization.Size = new System.Drawing.Size(185, 22);
            this.toolStripMenuItemBinarization.Text = "Binarization";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
            this.toolStripMenuItem1.Text = "Otsu metod";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItemBrightness
            // 
            this.toolStripMenuItemBrightness.Name = "toolStripMenuItemBrightness";
            this.toolStripMenuItemBrightness.Size = new System.Drawing.Size(185, 22);
            this.toolStripMenuItemBrightness.Text = "Brightness";
            this.toolStripMenuItemBrightness.Click += new System.EventHandler(this.toolStripMenuItemBrightness_Click);
            // 
            // toolStripMenuItemGrayscale
            // 
            this.toolStripMenuItemGrayscale.Name = "toolStripMenuItemGrayscale";
            this.toolStripMenuItemGrayscale.Size = new System.Drawing.Size(185, 22);
            this.toolStripMenuItemGrayscale.Text = "Grayscale conversion";
            this.toolStripMenuItemGrayscale.Click += new System.EventHandler(this.toolStripMenuItemGrayscale_Click);
            // 
            // toolStripMenuItemInversion
            // 
            this.toolStripMenuItemInversion.Name = "toolStripMenuItemInversion";
            this.toolStripMenuItemInversion.Size = new System.Drawing.Size(185, 22);
            this.toolStripMenuItemInversion.Text = "Inversion";
            this.toolStripMenuItemInversion.Click += new System.EventHandler(this.toolStripMenuItemInversion_Click);
            // 
            // shiftX50ToolStripMenuItem
            // 
            this.shiftX50ToolStripMenuItem.Name = "shiftX50ToolStripMenuItem";
            this.shiftX50ToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.shiftX50ToolStripMenuItem.Text = "ShiftX(-50)";
            this.shiftX50ToolStripMenuItem.Click += new System.EventHandler(this.shiftX50ToolStripMenuItem_Click);
            // 
            // turnToolStripMenuItem
            // 
            this.turnToolStripMenuItem.Name = "turnToolStripMenuItem";
            this.turnToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.turnToolStripMenuItem.Text = "Turn";
            this.turnToolStripMenuItem.Click += new System.EventHandler(this.turnToolStripMenuItem_Click);
            // 
            // wavesToolStripMenuItem
            // 
            this.wavesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WavesXToolStripMenuItem,
            this.WavesYToolStripMenuItem});
            this.wavesToolStripMenuItem.Name = "wavesToolStripMenuItem";
            this.wavesToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.wavesToolStripMenuItem.Text = "Waves";
            // 
            // WavesXToolStripMenuItem
            // 
            this.WavesXToolStripMenuItem.Name = "WavesXToolStripMenuItem";
            this.WavesXToolStripMenuItem.Size = new System.Drawing.Size(81, 22);
            this.WavesXToolStripMenuItem.Text = "X";
            this.WavesXToolStripMenuItem.Click += new System.EventHandler(this.WavesXToolStripMenuItem_Click_1);
            // 
            // WavesYToolStripMenuItem
            // 
            this.WavesYToolStripMenuItem.Name = "WavesYToolStripMenuItem";
            this.WavesYToolStripMenuItem.Size = new System.Drawing.Size(81, 22);
            this.WavesYToolStripMenuItem.Text = "Y";
            this.WavesYToolStripMenuItem.Click += new System.EventHandler(this.WavesYToolStripMenuItem_Click_1);
            // 
            // glassToolStripMenuItem
            // 
            this.glassToolStripMenuItem.Name = "glassToolStripMenuItem";
            this.glassToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.glassToolStripMenuItem.Text = "Glass";
            this.glassToolStripMenuItem.Click += new System.EventHandler(this.glassToolStripMenuItem_Click);
            // 
            // sepiaToolStripMenuItem
            // 
            this.sepiaToolStripMenuItem.Name = "sepiaToolStripMenuItem";
            this.sepiaToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.sepiaToolStripMenuItem.Text = "Sepia";
            this.sepiaToolStripMenuItem.Click += new System.EventHandler(this.sepiaToolStripMenuItem_Click);
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxImage.Location = new System.Drawing.Point(0, 24);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(873, 482);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImage.TabIndex = 2;
            this.pictureBoxImage.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.progressBar1.Location = new System.Drawing.Point(1, 14);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(766, 24);
            this.progressBar1.TabIndex = 3;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCancel.Location = new System.Drawing.Point(797, 14);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 24);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.buttonCancel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 467);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox1.Size = new System.Drawing.Size(873, 39);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // backgroundWorkerProgress
            // 
            this.backgroundWorkerProgress.WorkerReportsProgress = true;
            this.backgroundWorkerProgress.WorkerSupportsCancellation = true;
            this.backgroundWorkerProgress.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorkerProgress.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorkerProgress.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(1, 28);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(33, 13);
            this.labelTime.TabIndex = 6;
            this.labelTime.Text = "Time:";
            // 
            // greyWorldToolStripMenuItem
            // 
            this.greyWorldToolStripMenuItem.Name = "greyWorldToolStripMenuItem";
            this.greyWorldToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.greyWorldToolStripMenuItem.Text = "Grey world";
            this.greyWorldToolStripMenuItem.Click += new System.EventHandler(this.greyWorldToolStripMenuItem_Click);
            // 
            // perfectReflectorToolStripMenuItem
            // 
            this.perfectReflectorToolStripMenuItem.Name = "perfectReflectorToolStripMenuItem";
            this.perfectReflectorToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.perfectReflectorToolStripMenuItem.Text = "Perfect Reflector";
            this.perfectReflectorToolStripMenuItem.Click += new System.EventHandler(this.perfectReflectorToolStripMenuItem_Click);
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 506);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.menuStrip2);
            this.Name = "MainFrame";
            this.Text = "ImgPro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpen;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSave;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSaveAs;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFilters;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSpot;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemGrayscale;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBinarization;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBrightness;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemInversion;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemMatrix;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBlur;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemGaussian;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorkerProgress;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.ToolStripMenuItem embossToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sharpeningToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motionBlurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scharrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prewittToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shiftX50ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wavesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem glassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sepiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WavesXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WavesYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scharrXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scharrYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prewittXToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem prewittYToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sobelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soobelXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobelYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maximumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem glovingEgesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greyWorldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfectReflectorToolStripMenuItem;
    }
}

