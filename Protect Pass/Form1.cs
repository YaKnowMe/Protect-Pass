using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Protect_Pass.Properties;
using System.Runtime.InteropServices;
using ReadWriteCsv;
using CsvHelper;
using System.Collections;

namespace Protect_Pass
{
    public partial class Form1 : Form
    {
        string browseDIR;
        public string basePASS;
        public bool passok = false;

        public Form1()
        {
            InitializeComponent();

        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        public TextWriter email { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog fdl = new FolderBrowserDialog();

                if (fdl.ShowDialog() == DialogResult.OK)
                {
                    browseDIR = fdl.SelectedPath;
                    directorytofilesform.Text = browseDIR;
                }

            }
            catch
            {

            }
        }

        private void protectbtn_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(browseDIR) || string.IsNullOrEmpty(basePASS))
            {
                MessageBox.Show("Path or password base is empty.");
            }
            else
            {
                basePASS = rPassForm.Text;
                Random rnpass = new Random();

                    DirectoryInfo d = new DirectoryInfo(browseDIR);
                    FileInfo[] Files = d.GetFiles("*.pdf");
                    string str = "";
                    string nameP;
                    string pathtofile;
                    string pathtozip;
                    int id = 1;
                  //  var csv = new CsvWriter(new StreamWriter("testcsv.csv"));
                    foreach (FileInfo file in Files)
                    {
                        int idpass = rnpass.Next(1, 800);
                        string fullpass = basePASS + idpass;
                        str = str + ", " + file.Name;
                        nameP = file.Name + ".zip";
                        pathtofile = browseDIR + @"\" + file.Name;
                        pathtozip = browseDIR + @"\" + nameP;
                        id++;
                        using (ZipFile zip = new ZipFile())
                        {
                            zip.Password = fullpass;
                            zip.AddFile(pathtofile, "");
                            zip.Save("FILES" + @"\" + id + ".zip");

                        }

                    using
                   (
                        StreamWriter csvf = new StreamWriter("info.csv", true))
                    {
                        csvf.WriteLine(","+","+","+fullpass);
                    }

                }

                Form2 messageform = new Form2();
                messageform.Show();
            }
        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitBTN_MouseHover(object sender, EventArgs e)
        {
            exitBTN.Image = Resources.exit_button;
        }

        private void exitBTN_MouseLeave(object sender, EventArgs e)
        {
            exitBTN.Image = Resources.exitbtn;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            minimalizebtnpic.Image = Resources.minimalize_button;
        }

        private void minimalizebtnpic_MouseLeave(object sender, EventArgs e)
        {
            minimalizebtnpic.Image = Resources.minimalize_btn;
        }

        private void passbaseforminput_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void mailtobtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 emailform = new Form3();
            emailform.FormClosed += (s, args) => this.Close();
            emailform.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rPassForm_TextChanged(object sender, EventArgs e)
        {
            basePASS = rPassForm.Text;
        }
    }

}
