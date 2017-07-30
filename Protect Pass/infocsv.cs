using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHelpers;
using System.Net.Mail;
using System.Windows.Forms;

namespace Protect_Pass
{
    [DelimitedRecord(",")]
    [IgnoreEmptyLines()]
    [IgnoreFirst()]

    public partial class infocsv
    {
        public string email { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string pass { get; set; }
        public void ReadCSVFile()
        {
                //string path = "info.csv";
                var engine = new FileHelperEngine(typeof(infocsv));
                var products = (infocsv[])engine.ReadFile("info.csv");
                Form3 f3 = new Form3();
                
                if (products.Any())
                {
                    foreach (var product in products)
                    {

                        pass = product.pass;
                        email = product.email;
                        id = product.id;
                        name = product.name;
                        Console.WriteLine(product.pass);
                        MailMessage mail = new MailMessage(f3.youremail, email);
                        SmtpClient client = new SmtpClient();
                        client.Port = 587;
                        client.DeliveryMethod = SmtpDeliveryMethod.Network;
                        client.Credentials = new System.Net.NetworkCredential(f3.youremail, "dfefef");
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

