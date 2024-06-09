using System;
using System.IO;
using System.Text;
using System.Drawing;
namespace Albertus_FingerprintMatcher { 
    public class imgMethod{
        public static string imgToASCII_30Pxl(string filePath)
        {
            byte[] bytes = File.ReadAllBytes(filePath);
            string binaryString = Encoding.ASCII.GetString(bytes);
            // karena 1 pixel gambar hitam putih membutuhkan 1 byte (8 bit) (alokasi memori) makanya ambil 30 string ditengah
            binaryString = binaryString.Substring(binaryString.Length / 2 - 15, 30);
            return binaryString;
        }
        
        public static string imgToASCII(string filePath)
        {
            byte[] bytes = File.ReadAllBytes(filePath);
            string binaryString = Encoding.ASCII.GetString(bytes);
            return binaryString;
        }
    }

}
