using System;
using System.IO;
using System.Text;
using System.Drawing;

    class imgMethod{
    public class ImageToAsciiConverter
    {
        public string imgToASCII_30Pxl(string filePath)
        {
            byte[] bytes = File.ReadAllBytes(filePath);
            string binaryString = Encoding.ASCII.GetString(bytes);
            // karena 1 pixel gambar hitam putih membutuhkan 1 byte (8 bit) (alokasi memori) makanya ambil 30 string ditengah
            binaryString = binaryString.Substring(binaryString.Length / 2 - 15, 30);
            return binaryString;
        }
        
        public string imgToASCII(string filePath)
        {
            using (Bitmap bitmap = new Bitmap(filePath))
            {
                byte[] bytes = File.ReadAllBytes(filePath);
                string binaryString = Encoding.ASCII.GetString(bytes);
                return binaryString;
            }
        }
    }




}
