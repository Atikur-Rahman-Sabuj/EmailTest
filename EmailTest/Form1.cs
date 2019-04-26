using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            if (tbxMailAddress.Text == "")
            {
                MessageBox.Show("Enter mail");
            }
            string ToMail = tbxMailAddress.Text;
            string FromMail = "info@dealsdeals.co.uk";
            SmtpClient client = new SmtpClient();
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential("info@dealsdeals.co.uk", "Laxmi2121");
            client.Port = 2525;
            client.Host = "mail.dealsdeals.co.uk";
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.EnableSsl = false;
            MailAddress From = new MailAddress(FromMail, "DealsDeals");
            MailAddress To = new MailAddress(ToMail, "Test");
            MailMessage mailMessage = new MailMessage(From, To);
            mailMessage.Subject = "Test of mail sending";
            mailMessage.Body = "Hello dear, I hope you are fine. This a test of our mail and it succeeded, hurrahh!!!.";
            try
            {
                client.Send(mailMessage);
                MessageBox.Show("Mail send successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not send mail" + "Error: " + ex.Message);
            }
        }
    }
}
