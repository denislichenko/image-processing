using System.Drawing;

namespace HomeWork_WF.Extension
{
    public static class ImageExtensions
    {
        public static string GetLightMatrix(this Image image)
        {
            var bitmap = new Bitmap(image);
            var result = string.Empty;

            if (bitmap.Width > 100 || bitmap.Height > 100)
            {
                return "Image too big for processing";
            }
            
            for (var i = 0; i < bitmap.Width; i++)
            {
                for (var j = 0; j < bitmap.Height; j++)
                {
                    var pixel = bitmap.GetPixel(i, j);
                    result += $"{pixel.R + pixel.G + pixel.B} ";
                }

                result += "\n";
            }

            return result;
        }
        
        public static Bitmap ToBinarized(this Image image)
        {
            var bitmap = new Bitmap(image);
            for (var i = 0; i < bitmap.Width; i++)
            {
                for (var j = 0; j < bitmap.Height; j++)
                {
                    Color pixel = bitmap.GetPixel(i, j);
                    
                    var isBlackTone = (pixel.R < Color.Black.R + 110)
                                      && (pixel.G < Color.Black.G + 110)
                                      && (pixel.B < Color.Black.B + 110);
                    
                    var isYellowTone = (pixel.R > Color.Yellow.R - 110)
                                       && (pixel.G > Color.Yellow.G - 110)
                                       && (pixel.B < Color.Yellow.B + 110);
                    
                    var isWhiteTone = (pixel.R > Color.White.R - 110)
                                      && (pixel.G > Color.White.G - 110)
                                      && (pixel.B > Color.White.B - 110);

                    if (isBlackTone || isYellowTone || isWhiteTone)
                    {
                        bitmap.SetPixel(i, j, Color.White);
                        continue;
                    }
                    
                    bitmap.SetPixel(i, j, Color.Black);
                }
            }

            return bitmap;
        }

        public static Bitmap ToGrayScale(this Image image)
        {
            var bitmap = new Bitmap(image);
            for (var i = 0; i < bitmap.Width; i++)
            {
                for (var j = 0; j < bitmap.Height; j++)
                {
                    Color pixel = bitmap.GetPixel(i, j);
                    var avg = (pixel.R + pixel.G + pixel.B) / 3;
                    bitmap.SetPixel(i, j, Color.FromArgb(avg, avg, avg));
                }
            }

            return bitmap;
        }
        
        public static Bitmap Blur(this Image image, int blurSize)
        {
            var bitmap = new Bitmap(image);
            return bitmap.Blur(new Rectangle(0, 0, bitmap.Width, bitmap.Height), blurSize);
        }
        
        private static Bitmap Blur(this Bitmap image, Rectangle rectangle, int blurSize)
        {
            Bitmap blurred = new Bitmap(image.Width, image.Height);

            // make an exact copy of the bitmap provided
            using (Graphics graphics = Graphics.FromImage(blurred))
                graphics.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height),
                    new Rectangle(0, 0, image.Width, image.Height), GraphicsUnit.Pixel);

            // look at every pixel in the blur rectangle
            for (int xx = rectangle.X; xx < rectangle.X + rectangle.Width; xx++)
            {
                for (int yy = rectangle.Y; yy < rectangle.Y + rectangle.Height; yy++)
                {
                    int avgR = 0, avgG = 0, avgB = 0;
                    int blurPixelCount = 0;

                    // average the colo red, green and blue for each pixel in the
                    // blur size while making sure you don't go outside the image bounds
                    for (int x = xx; (x < xx + blurSize && x < image.Width); x++)
                    {
                        for (int y = yy; (y < yy + blurSize && y < image.Height); y++)
                        {
                            Color pixel = blurred.GetPixel(x, y);

                            avgR += pixel.R;
                            avgG += pixel.G;
                            avgB += pixel.B;

                            blurPixelCount++;
                        }
                    }

                    avgR = avgR / blurPixelCount;
                    avgG = avgG / blurPixelCount;
                    avgB = avgB / blurPixelCount;

                    // now that we know the average for the blur size, set each pixel to that color
                    for (int x = xx; x < xx + blurSize && x < image.Width && x < rectangle.Width; x++)
                    for (int y = yy; y < yy + blurSize && y < image.Height && y < rectangle.Height; y++)
                        blurred.SetPixel(x, y, Color.FromArgb(avgR, avgG, avgB));
                }
            }

            return blurred;
        }
    }
}