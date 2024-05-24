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

                    
                    try
                    {
                        DatabaseManager db = new DatabaseManager();
                        db.Connect();
                        DataTable results = db.Execute("SELECT * FROM sidik_jari LIMIT 5;");
                        
                        pictureBoxOutput.ImageLocation = "../../../../" + results.Rows[4][0].ToString();
                        labelNamaOutput.Text = ": " + results.Rows[4][1].ToString();
                        db.Disconnect();
                    }
                    catch (Exception errMsg)
                    {
                        Console.WriteLine(errMsg);
                    }
                    
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

            }
        }
    }
}
