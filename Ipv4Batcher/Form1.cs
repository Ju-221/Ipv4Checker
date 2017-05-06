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

namespace Ipv4Batcher
{
    public partial class Form1 : Form
    {
        private const string dir = @"C:\Ipv4\";
        private const string path = dir + "Ipv4.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Command, lines = "0";

            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

          
            if (Directory.Exists(dir))
            { 





                    Command = "/C ipconfig | findstr /i \"Subnet Mask\" > " + path;
                System.Diagnostics.Process.Start("cmd.exe", Command);



                try
                {

                    lines = File.ReadAllText(path);
                }
                catch (Exception except1)
                {
                   
                    MessageBox.Show(except1.Message);
                }

                lines.Trim();
                txt_Box.Text += lines;

            }


            
           


        }
    }
}
