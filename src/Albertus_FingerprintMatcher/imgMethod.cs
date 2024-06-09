using System;
using System.IO;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
namespace Albertus_FingerprintMatcher { 
    public class imgMethod{
        public static string imgToASCII_30Pxl(string filePath)
        {
            Bitmap bmp = ConvertFileToBlackAndWhite(filePath);
            byte[] bytes = BitmapToByteArray(bmp);
            string binaryString = Encoding.ASCII.GetString(bytes);
            // karena 1 pixel gambar hitam putih membutuhkan 1 byte (8 bit) (alokasi memori) makanya ambil 30 string ditengah
            binaryString = binaryString.Substring(binaryString.Length / 2 - 60, 120);
            return binaryString;
        }
        
        public static string imgToASCII(string filePath)
        {
            Bitmap bmp = ConvertFileToBlackAndWhite(filePath);
            byte[] bytes = BitmapToByteArray(bmp);
            string binaryString = Encoding.ASCII.GetString(bytes);
            return binaryString;
        }

        public static Bitmap ConvertFileToBlackAndWhite(string inputFilePath)
        {
            // Load the original image
            Bitmap originalImage = new Bitmap(inputFilePath);

            // Create a new bitmap with the same dimensions
            Bitmap blackAndWhiteImage = new Bitmap(originalImage.Width, originalImage.Height);

            // Iterate through the image's pixels to convert them to black and white
            for (int y = 0; y < originalImage.Height; y++)
            {
                for (int x = 0; x < originalImage.Width; x++)
                {
                    // Get the pixel color
                    Color originalColor = originalImage.GetPixel(x, y);

                    // Compute the grayscale value
                    int grayScale = (int)((originalColor.R * 0.3) + (originalColor.G * 0.59) + (originalColor.B * 0.11));

                    // Set the pixel to black or white based on the threshold
                    Color bwColor = grayScale < 128 ? Color.Black : Color.White;
                    blackAndWhiteImage.SetPixel(x, y, bwColor);
                }
            }

            return blackAndWhiteImage;
        }

        private static byte[] BitmapToByteArray(Bitmap bitmap)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                // Save the bitmap to the memory stream
                bitmap.Save(memoryStream, ImageFormat.Bmp);

                // Convert the memory stream to a byte array
                return memoryStream.ToArray();
            }
        }

        public static bool IsBlackAndWhite(Bitmap bitmap)
        {
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    // Get the pixel color
                    Color color = bitmap.GetPixel(x, y);

                    // Check if the color is either black or white
                    if (!(color.R == 0 && color.G == 0 && color.B == 0) && !(color.R == 255 && color.G == 255 && color.B == 255))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool IsGrayscale(string filePath)
        {
            // Load the image
            Bitmap image = new Bitmap(filePath);

            // Variables to store sum of pixel colors
            int totalRed = 0, totalGreen = 0, totalBlue = 0;

            // Iterate through all pixels
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    // Get pixel color
                    Color pixelColor = image.GetPixel(x, y);

                    // Add pixel color components to totals
                    totalRed += pixelColor.R;
                    totalGreen += pixelColor.G;
                    totalBlue += pixelColor.B;
                }
            }

            // Calculate average color components
            int totalPixels = image.Width * image.Height;
            int avgRed = totalRed / totalPixels;
            int avgGreen = totalGreen / totalPixels;
            int avgBlue = totalBlue / totalPixels;

            // If the average values are approximately equal, the image is likely grayscale
            bool isGrayscale = Math.Abs(avgRed - avgGreen) < 10 && Math.Abs(avgRed - avgBlue) < 10;

            return isGrayscale;
        }
    }
}

