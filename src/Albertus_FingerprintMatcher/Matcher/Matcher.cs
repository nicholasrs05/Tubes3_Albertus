﻿using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Albertus_FingerprintMatcher{
    public class Matcher{
        static Database_Searching database = new Database_Searching();

        public static List<String> FindMatch(String input, String algoritma){
            bool find = false;
            List<String> result = new List<String>();
            List<String> path = database.GetPath();
            List<String> name = database.GetName();
            String pattern = imgMethod.imgToASCII_60Pxl(input);
            if (algoritma.Equals("KMP"))
            {
                for (int i = 0; i < path.Count; i++)
                {
                    String currPath = "../../../../" + path[i];
                    String text = imgMethod.imgToASCII(currPath);
                    find = KMP.KMPSearch(text, pattern);
                    if (find)
                    {
                        result.Add(path[i]);
                        result.Add(name[i]);
                        result.Add("100%");
                        result.Add("True");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Masuk BM");
                for (int i = 0; i < path.Count; i++)
                {
                    String currPath = "../../../../" + path[i];
                    String text = imgMethod.imgToASCII(currPath);
                    find = BM.BMMatch(text, pattern);
                    if (find)
                    {
                        result.Add(path[i]);
                        result.Add(name[i]);
                        result.Add("100%");
                        result.Add("True");
                        break;
                    }
                }
            }
            if (!find)
            {
                double percentage = 0;
                int idx = 0;
                Bitmap bitmapPattern = imgMethod.ResizeImage(input, 100, 100);
                String fullPattern = imgMethod.ResizedImgToASCII(bitmapPattern);
                for (int i = 0; i < path.Count; i++)
                {
                    String currPath = "../../../../" + path[i];
                    Bitmap bitmaptext = imgMethod.ResizeImage(currPath, 100, 100);
                    String text = imgMethod.ResizedImgToASCII(bitmaptext);
                    double current = HammingDistance.ComputeHammingDistance(text, fullPattern);
                    if (current > percentage)
                    {
                        percentage = current;
                        idx = i;
                    }
                }
                result.Add(path[idx]);
                result.Add(name[idx]);
                result.Add((percentage * 100).ToString("F2") + "%");
                if (percentage * 100 >= 70)
                {
                    result.Add("True");
                }
                else
                {
                    result.Add("False");
                }
            }
            return result;
        }

        public static List<String> FindBiodata(String namaAsli)
        {
            List<String> result = new List<String>();
            List<String> encryptedNames = database.GetNamaLengkap();
            int idx = -1;
            String regex = RegEx.generateRegEx(namaAsli);

            for (int i = 0; i < encryptedNames.Count; i++)
            {
                if (RegEx.isMatch(encryptedNames[i], regex))
                {
                    idx = i;
                    break;
                }
            }

            if (idx != -1)
            {
                result.Add(database.GetNIK()[idx]);
                result.Add(namaAsli);
                result.Add(database.GetTempatLahir()[idx]);
                result.Add(database.GetTanggalLahir()[idx]);
                result.Add(database.GetJenisKelamin()[idx]);
                result.Add(database.GetGolonganDarah()[idx]);
                result.Add(database.GetAlamat()[idx]);
                result.Add(database.GetAgama()[idx]);
                result.Add(database.GetStatusPerkawinan()[idx]);
                result.Add(database.GetPekerjaan()[idx]);
                result.Add(database.GetKewarganegaraan()[idx]);
            }

            return result;
        }
        
    }
}

