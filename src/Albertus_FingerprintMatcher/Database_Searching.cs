using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Data;

namespace Albertus_FingerprintMatcher
{
    public class Database_Searching
    {
        public DataTable results;
        public DataTable biodata;
        List<String> path = new List<String>();
        List<String> name = new List<String>();
        List<String> NIK = new List<String>();
        List<String> nama_lengkap = new List<String>();
        List<String> tempat_lahir = new List<String>();
        List<String> tanggal_lahir = new List<String>();
        List<String> jenis_kelamin = new List<String>();
        List<String> golongan_darah = new List<String>();
        List<String> alamat = new List<String>();
        List<String> agama = new List<String>();
        List<String> status_perkawinan = new List<String>();
        List<String> pekerjaan = new List<String>();
        List<String> kewarganegaraan = new List<String>();
        public Database_Searching()
        {
            DatabaseManager db = new DatabaseManager();
            try
            {
                db.Connect();
                results = db.Execute("select * from sidik_jari");
                biodata = db.Execute("select * from biodata");

                foreach (DataRow row in results.Rows)
                {
                    path.Add((String) row[0]);
                    name.Add((String) row[1]);
                    //Console.WriteLine(row[0]);
                }

                foreach (DataRow row in biodata.Rows)
                {
                    NIK.Add((String) row[0]);
                    nama_lengkap.Add((String) row[1]);
                    tempat_lahir.Add((String) row[2]);
                    tanggal_lahir.Add(row[3].ToString().Substring(0, 10));
                    jenis_kelamin.Add((String) row[4]);
                    golongan_darah.Add((String) row[5]);
                    alamat.Add((String) row[6]);
                    agama.Add((String) row[7]);
                    status_perkawinan.Add((String) row[8]);
                    pekerjaan.Add((String) row[9]);
                    kewarganegaraan.Add((String) row[10]);
                }

                db.Disconnect();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public List<String> GetPath()
        {
            return path;
        }
        public List<String> GetName() {
            return name;
        }
        public List<String> GetNIK()
        {
            return NIK;
        }

        public List<String> GetNamaLengkap()
        {
            return nama_lengkap;
        }

        public List<String> GetTempatLahir()
        {
            return tempat_lahir;
        }

        public List<String> GetTanggalLahir()
        {
            return tanggal_lahir;
        }

        public List<String> GetJenisKelamin()
        {
            return jenis_kelamin;
        }

        public List<String> GetGolonganDarah()
        {
            return golongan_darah;
        }

        public List<String> GetAlamat()
        {
            return alamat;
        }

        public List<String> GetAgama()
        {
            return agama;
        }

        public List<String> GetStatusPerkawinan()
        {
            return status_perkawinan;
        }

        public List<String> GetPekerjaan()
        {
            return pekerjaan;
        }

        public List<String> GetKewarganegaraan()
        {
            return kewarganegaraan;
        }
    }

    //public class testing
    //{
    //    public static void Main(string[] args)
    //    {
    //        // Create a test driver for database searching
    //        Database_Searching db = new Database_Searching();
    //        List<String> path = db.GetPath();
    //        foreach (String s in path) { 
    //            Console.WriteLine(s);
    //        }
    //    }
    //}
}
