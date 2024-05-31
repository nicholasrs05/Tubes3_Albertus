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
                    List<String> result = Matcher.FindMatch(imageLocation, algorithm);
                    Console.WriteLine(imageLocation);
                    Console.WriteLine(result[0]);

                    pictureBoxOutput.ImageLocation = "../../../../" + result[0];
                }
            }
        }
    }
}
