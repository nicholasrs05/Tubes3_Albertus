using System;
using System.IO;
using System.Text;

class imgMethod
{
using System;
using System.Drawing;
using System.Text;

public class ImageToAsciiConverter
{
    public string ImgToASCII(string filePath)
    {
        using (Bitmap bitmap = new Bitmap(filePath))
        {
            int width = bitmap.Width;
            int height = bitmap.Height;

            // Menentukan koordinat untuk mengambil 30x30 piksel di tengah gambar
            int startX = (width - 30) / 2;
            int startY = (height - 30) / 2;
            Rectangle cropRect = new Rectangle(startX, startY, 30, 30);

            // Menyimpan piksel yang dipilih ke dalam byte array
            byte[] imgBytes = new byte[30 * 30 * 4]; // 4 bytes per pixel (RGBA)
            int index = 0;

            for (int y = startY; y < startY + 30; y++)
            {
                for (int x = startX; x < startX + 30; x++)
                {
                    Color pixelColor = bitmap.GetPixel(x, y);
                    imgBytes[index++] = pixelColor.R;
                    imgBytes[index++] = pixelColor.G;
                    imgBytes[index++] = pixelColor.B;
                    imgBytes[index++] = pixelColor.A;
                }
            }

            // Mengonversi byte array menjadi string biner menggunakan encoding ASCII
            string binaryString = Encoding.ASCII.GetString(imgBytes);

            return binaryString;
        }
    }
}



    public static void main(string[] args)
    {
        imgMethod imgMethod = new imgMethod();
        string filePath = "testing.jpg";
        string binaryString = imgMethod.imgToASCII(filePath);
        Console.WriteLine(binaryString);
    }

}
