namespace HomeWork_WF
{
    partial class Form1
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
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnProcessImage = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.histogramControl = new HomeWork_WF.HistogramControl();
            this.pbBinarization = new System.Windows.Forms.PictureBox();
            this.pbGrayScale = new System.Windows.Forms.PictureBox();
            this.lblOriginalImage = new System.Windows.Forms.Label();
            this.lblHistogram = new System.Windows.Forms.Label();
            this.lblBinarized = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbSigmaFilter = new System.Windows.Forms.PictureBox();
            this.lblSigma = new System.Windows.Forms.Label();
            this.tbLightMatrix = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbBinarization)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbGrayScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbSigmaFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // tbFileName
            // 
            this.tbFileName.Location = new System.Drawing.Point(12, 12);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(927, 22);
            this.tbFileName.TabIndex = 0;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(945, 12);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(31, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnProcessImage
            // 
            this.btnProcessImage.Location = new System.Drawing.Point(12, 40);
            this.btnProcessImage.Name = "btnProcessImage";
            this.btnProcessImage.Size = new System.Drawing.Size(964, 27);
            this.btnProcessImage.TabIndex = 2;
            this.btnProcessImage.Text = "Process Image";
            this.btnProcessImage.UseVisualStyleBackColor = true;
            this.btnProcessImage.Click += new System.EventHandler(this.btnProcessImage_Click);
            // 
            // pbImage
            // 
            this.pbImage.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Location = new System.Drawing.Point(12, 87);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(309, 260);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 11;
            this.pbImage.TabStop = false;
            // 
            // histogramControl
            // 
            this.histogramControl.Location = new System.Drawing.Point(341, 87);
            this.histogramControl.Name = "histogramControl";
            this.histogramControl.Size = new System.Drawing.Size(309, 260);
            this.histogramControl.TabIndex = 12;
            // 
            // pbBinarization
            // 
            this.pbBinarization.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.pbBinarization.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbBinarization.Location = new System.Drawing.Point(12, 376);
            this.pbBinarization.Name = "pbBinarization";
            this.pbBinarization.Size = new System.Drawing.Size(309, 260);
            this.pbBinarization.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBinarization.TabIndex = 13;
            this.pbBinarization.TabStop = false;
            // 
            // pbGrayScale
            // 
            this.pbGrayScale.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.pbGrayScale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbGrayScale.Location = new System.Drawing.Point(341, 376);
            this.pbGrayScale.Name = "pbGrayScale";
            this.pbGrayScale.Size = new System.Drawing.Size(309, 260);
            this.pbGrayScale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGrayScale.TabIndex = 14;
            this.pbGrayScale.TabStop = false;
            // 
            // lblOriginalImage
            // 
            this.lblOriginalImage.Location = new System.Drawing.Point(12, 350);
            this.lblOriginalImage.Name = "lblOriginalImage";
            this.lblOriginalImage.Size = new System.Drawing.Size(309, 23);
            this.lblOriginalImage.TabIndex = 15;
            this.lblOriginalImage.Text = "Original Image";
            this.lblOriginalImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHistogram
            // 
            this.lblHistogram.Location = new System.Drawing.Point(341, 350);
            this.lblHistogram.Name = "lblHistogram";
            this.lblHistogram.Size = new System.Drawing.Size(309, 23);
            this.lblHistogram.TabIndex = 16;
            this.lblHistogram.Text = "Histogram";
            this.lblHistogram.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBinarized
            // 
            this.lblBinarized.Location = new System.Drawing.Point(12, 639);
            this.lblBinarized.Name = "lblBinarized";
            this.lblBinarized.Size = new System.Drawing.Size(309, 23);
            this.lblBinarized.TabIndex = 17;
            this.lblBinarized.Text = "Binarization Image";
            this.lblBinarized.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(341, 639);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "GrayScale Image";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbSigmaFilter
            // 
            this.pbSigmaFilter.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.pbSigmaFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSigmaFilter.Location = new System.Drawing.Point(667, 376);
            this.pbSigmaFilter.Name = "pbSigmaFilter";
            this.pbSigmaFilter.Size = new System.Drawing.Size(309, 260);
            this.pbSigmaFilter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSigmaFilter.TabIndex = 19;
            this.pbSigmaFilter.TabStop = false;
            // 
            // lblSigma
            // 
            this.lblSigma.Location = new System.Drawing.Point(667, 639);
            this.lblSigma.Name = "lblSigma";
            this.lblSigma.Size = new System.Drawing.Size(309, 23);
            this.lblSigma.TabIndex = 20;
            this.lblSigma.Text = "Image with Sigma Filter";
            this.lblSigma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbLightMatrix
            // 
            this.tbLightMatrix.Location = new System.Drawing.Point(667, 87);
            this.tbLightMatrix.Name = "tbLightMatrix";
            this.tbLightMatrix.Size = new System.Drawing.Size(309, 260);
            this.tbLightMatrix.TabIndex = 21;
            this.tbLightMatrix.Text = "";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(667, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "Light Matrix";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 671);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbLightMatrix);
            this.Controls.Add(this.lblSigma);
            this.Controls.Add(this.pbSigmaFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBinarized);
            this.Controls.Add(this.lblHistogram);
            this.Controls.Add(this.lblOriginalImage);
            this.Controls.Add(this.pbGrayScale);
            this.Controls.Add(this.pbBinarization);
            this.Controls.Add(this.histogramControl);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.btnProcessImage);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.tbFileName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize) (this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbBinarization)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbGrayScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbSigmaFilter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.RichTextBox tbLightMatrix;
        
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.PictureBox pbSigmaFilter;
        private System.Windows.Forms.Label lblSigma;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label lblHistogram;
        private System.Windows.Forms.Label lblBinarized;

        private System.Windows.Forms.PictureBox pbBinarization;
        private System.Windows.Forms.PictureBox pbGrayScale;
        private System.Windows.Forms.Label lblOriginalImage;

        private HomeWork_WF.HistogramControl histogramControl;

        private System.Windows.Forms.Button btnBrowse;

        private System.Windows.Forms.PictureBox pbImage;

        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.Button btnProcessImage;

        #endregion
    }
}