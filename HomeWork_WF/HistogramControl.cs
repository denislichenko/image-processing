using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HomeWork_WF
{
    public partial class HistogramControl : UserControl
    {
        private long MaxValue { get; set; }
        private long[] Values { get; set; }
        private bool IsDrawing { get; set; }
        private float YUnit { get; set; }
        private float XUnit { get; set; }
        private Font DiagramFont { get; set; } = new Font("Tahoma", 10);

        [Category("Options")]
        [Description("Distance from the margins for the histogram")]
        private int Offset { get; set; } = 20;
        
        [Category("Options")]
        [Description("Color for control")]
        private Color DisplayColor { get; set; } = Color.Black;
        
        public HistogramControl()
        {
            InitializeComponent();
        }

        private void HistogramControl_Paint(object sender, PaintEventArgs e)
        {
            if(!IsDrawing) 
                return;

            Graphics graphics = e.Graphics;
            var pen = new Pen(new SolidBrush(DisplayColor), XUnit);
            for (var i = 0; i < Values.Length; i++)
            {
                graphics.DrawLine(pen,
                    new PointF(Offset + (i * XUnit), this.Height - Offset),
                    new PointF(Offset + (i * XUnit), this.Height - Offset - Values[i] * YUnit));

                if (Values[i] == MaxValue)
                {
                    SizeF size = graphics.MeasureString(i.ToString(), DiagramFont);
                    graphics.DrawString(i.ToString(), DiagramFont, new SolidBrush(DisplayColor),
                        new PointF(Offset + (i * XUnit) - (Size.Width / 2), Height - Font.Height),
                        StringFormat.GenericDefault);
                    
                }
            }
            
            graphics.DrawString("0", DiagramFont, 
                new SolidBrush(DisplayColor), 
                new PointF(Offset, Height - DiagramFont.Height),
                StringFormat.GenericDefault);
            graphics.DrawString((Values.Length - 1).ToString(), DiagramFont,
                new SolidBrush(DisplayColor),
                new PointF(Offset + (Values.Length * XUnit) - graphics.MeasureString((Values.Length - 1).ToString(), DiagramFont).Width,
                    Height - DiagramFont.Height),
                StringFormat.GenericDefault);
            
            graphics.DrawRectangle(new Pen(new SolidBrush(DisplayColor), 1), 0, 0, Width - 1, Height - 1);
        }

        private void HistogramControl_Resize(object sender, EventArgs e)
        {
            if (!IsDrawing)
                return;

            CalculateXYUnitValues();
            this.Refresh();
        }

        public void DrawHistogram(Image picture)
        {
            Values = GetHistogramValues(new Bitmap(picture));

            IsDrawing = true;
            MaxValue = GetMaxHistogramValue(Values);

            CalculateXYUnitValues();
            this.Refresh();
        }

        private long[] GetHistogramValues(Bitmap picture)
        {
            var histogram = new long[256];
            for (var i = 0; i < picture.Size.Width; i++)
            {
                for (var j = 0; j < picture.Size.Height; j++)
                {
                    var pixelColor = picture.GetPixel(i, j);
                    var index = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    histogram[index]++;
                }
            }

            return histogram;
        }
        
        private long GetMaxHistogramValue(long[] values)
        {
            if (!IsDrawing)
            {
                return 1;
            }

            long max = 0;
            return values.Prepend(max).Max();
        }

        private void CalculateXYUnitValues()
        {
            XUnit = (float) (this.Width - (2 * Offset)) / (Values.Length - 1);
            YUnit = (float) (this.Height - (2 * Offset)) / MaxValue;
        }
    }
}