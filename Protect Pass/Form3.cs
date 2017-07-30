using FileHelpers;
using Microsoft.VisualBasic.Logging;
using Protect_Pass.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Protect_Pass
{
    [IgnoreEmptyLines]

    public partial class Form3 : Form
    {
        public string youremail;
        public string yourpass;

        public string email { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string pass { get; set; }

        public Form3()
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

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Form3_Click(object sender, EventArgs e)
        {

        }

        private void Form3_MouseHover(object sender, EventArgs e)
        {

        }

        private void exitclickbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitclickbtn_MouseHover(object sender, EventArgs e)
        {
            exitclickbtn.Image = Resources.exit_button;
        }

        private void exitclickbtn_MouseLeave(object sender, EventArgs e)
        {
            exitclickbtn.Image = Resources.exitbtn;
        }

        private void minbtnclick_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void minbtnclick_MouseHover(object sender, EventArgs e)
        {
            minbtnclick.Image = Resources.minimalize_button;
        }

        private void minbtnclick_MouseLeave(object sender, EventArgs e)
        {
            minbtnclick.Image = Resources.minimalize_btn;
        }

        public void browsebtn_Click(object sender, EventArgs e)
        {
            infocsv ic = new infocsv();
            youremail = emailform.Text;
            yourpass = passbaseform.Text;
            System.Threading.Thread.Sleep(1000);
            ReadCSVFile();
            MessageBox.Show(emailform.Text);
        }

        public void directorytofilesform_TextChanged(object sender, EventArgs e)
        {
            infocsv ic = new infocsv();
            yourpass = passbaseform.Text;
        }

        public void emailform_TextChanged(object sender, EventArgs e)
        {
            infocsv ic = new infocsv();
            youremail = emailform.Text;
        }
        public void startsending()
        {
            System.Threading.Thread.Sleep(1000);
            infocsv ic = new infocsv();
            ic.ReadCSVFile();
            MessageBox.Show("Mails have been sent");
            Console.WriteLine(ic.pass);
        }

        public void ReadCSVFile()
        {
            //string path = "info.csv";
            var engine = new FileHelperEngine(typeof(infocsv));
            var products = (infocsv[])engine.ReadFile("info.csv");
            if (products.Any())
            {
                foreach (var product in products)
                {

                    pass = product.pass;
                    email = product.email;
                    id = product.id;
                    name = product.name;
                    Console.WriteLine(product.pass);
                    MailMessage mail = new MailMessage(youremail, email);
                    SmtpClient client = new SmtpClient();
                    client.Port = 587;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.Credentials = new System.Net.NetworkCredential(youremail, yourpass);
                    client.EnableSsl = true;
                    client.Host = "smtp-mail.outlook.com";
                    mail.Subject = name;
                    mail.Body = pass;
                    client.Send(mail);

                }

            }


        }
    }
}
