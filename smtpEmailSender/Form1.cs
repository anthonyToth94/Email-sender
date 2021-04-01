using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;    //1.
using System.Net.Mail;  //2

namespace smtpEmailSender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MailMessage email = new MailMessage();
            SmtpClient smtpszerver = new SmtpClient("smtp.gmail.com");
            Attachment csatolmany;    //ha kell csatolmany

            email.From = new MailAddress(textBox1.Text);  //kitől
            email.To.Add(textBox3.Text);   //kinek
            email.Subject = textBox5.Text;   //tárgy
            email.Body = textBox4.Text;   //test

            //csatolmany = new Attachment(@"C:\User\Desktop\162866.jpg");

            smtpszerver.Port = 587;
            smtpszerver.Credentials = new NetworkCredential(textBox1.Text, textBox2.Text);  //felhasznalo / jelszo
            smtpszerver.EnableSsl = true; //titkosítva
            smtpszerver.Send(email);
            MessageBox.Show("Elküldve!");
        }
    }
}
