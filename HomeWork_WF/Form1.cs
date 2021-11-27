using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using HomeWork_WF.Extension;

namespace HomeWork_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog()
            {
                CheckFileExists = true,
                CheckPathExists = true
            };

            openFileDialog.ShowDialog();

            if (!string.IsNullOrEmpty(openFileDialog.FileName))
            {
                tbFileName.Text = openFileDialog.FileName;
            }
        }

        private void btnProcessImage_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbFileName.Text) || !File.Exists(tbFileName.Text)) 
                return;

            pbImage.Image?.Dispose();
            
            Application.DoEvents();
            
            pbImage.Image = Image.FromFile(tbFileName.Text);
            histogramControl.DrawHistogram(pbImage.Image);
            pbBinarization.Image = pbImage.Image.ToBinarized();
            pbGrayScale.Image = pbImage.Image.ToGrayScale();
            pbSigmaFilter.Image = pbImage.Image.Blur(5);
            tbLightMatrix.Text = pbImage.Image.GetLightMatrix();
        }
    }
}