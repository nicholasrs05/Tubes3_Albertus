using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Diagnostics;

namespace Albertus_FingerprintMatcher
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        public static Boolean valid = false;

        private void buttonInput_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Bitmap files (*.bmp)|*.bmp";

                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = ofd.FileName;
                    
                    pictureBoxInput.ImageLocation = imageLocation;

                    valid = true;
                }
            } 
            catch (Exception errMsg)
            {
                Console.WriteLine(errMsg.Message);
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (valid)
            {
                String imageLocation = pictureBoxInput.ImageLocation;
                String algorithm = comboBoxAlgorithm.Text.ToString();

                if (!algorithm.Equals(""))
                {
                    Stopwatch timeKeeper = new Stopwatch();
                    timeKeeper.Start();
                    List<String> result = Matcher.FindMatch(imageLocation, algorithm);
                    timeKeeper.Stop();

                    pictureBoxOutput.ImageLocation = "../../../../" + result[0];
                    labelExecTimeOutput.Text = ": " + timeKeeper.ElapsedMilliseconds + " ms";
                    labelSimilarityOutput.Text = ": " + result[2];
                    labelChoosenAlgoOutput.Text = ": " + comboBoxAlgorithm.Text.ToString();

                    List<String> biodata = Matcher.FindBiodata(result[1]);
                    if (biodata.Count > 0)
                    {
                        labelNIKOutput.Text = ": " + biodata[0];
                        labelNamaOutput.Text = ": " + biodata[1];
                        labelTempatLahirOutput.Text = ": " + biodata[2];
                        labelTanggalLahirOutput.Text = ": " + biodata[3];
                        labelJenisKelaminOutput.Text = ": " + biodata[4];
                        labelGolonganDarahOutput.Text = ": " + biodata[5];
                        labelAlamatOutput.Text = ": " + biodata[6];
                        labelAgamaOutput.Text = ": " + biodata[7];
                        labelStatusOutput.Text = ": " + biodata[8];
                        labelPekerjaanOutput.Text = ": " + biodata[9];
                        labelKewarganegaraanOutput.Text = ": " + biodata[10];
                    }

                }
            }
        }
    }
}
