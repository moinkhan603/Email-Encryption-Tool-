using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;

namespace ENCTOOL
{
    public partial class Form1 : Form
    {
        string res;
                NetworkCredential login;
        SmtpClient client;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(textBox5.Text, textBox6.Text);
                MailMessage msg = new MailMessage();
                msg.To.Add(textBox1.Text);
                msg.From = new MailAddress(textBox5.Text);
                msg.Subject = textBox3.Text;
                msg.Body = res;
                client.Send(msg);
                MessageBox.Show("sent");
                  

            }
            catch(Exception es)
            {
                MessageBox.Show(es.ToString());
            }


            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string set = textBox4.Text.ToString();

            for (int i = 0; i < set.Length; i++)
            {
                res += "a/8#@" + set[i] +"b0c5"+"^^&&";

            }







            //for (int i = 0; (i < 100 && str[i] != '\0'); i++)
            //{ str[i] = str[i] + 2; }
                //the key for encryption is 3 that is added to ASCII value


        }
        //private static void SendCompletedCallback(object sender,AsyncCompletedEventArgs e)
        //{
        //    if(e.Cancelled)
        //    {
        //        MessageBox.Show(string.Format("{0} send canceled,", e.UserState), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    if(e.Error!=null)
        //    {
        //        MessageBox.Show(string.Format("{0} {1}",e.UserState,e.Error), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    else
        //    {
        //        MessageBox.Show("Message sent", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }

        //}

    }
}
