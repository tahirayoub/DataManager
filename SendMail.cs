using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;


namespace DataManager
{
    public partial class SendMail : Form
    {
        public SendMail()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
               


                string emailfrom = "bank6260@gmail.com";
                string pwd = "inse6260";
                string sb = textBox_Subject.Text;

                string ee = textBox_To.Text;

                string bd = textBox_Message.Text;

                MailMessage msg = new MailMessage();
                msg.From = new MailAddress(emailfrom);

                msg.To.Add(ee);
                msg.Subject = sb;
                msg.Body = bd;
                if ( textBox_Attachment.Text != "")
                {
                    Attachment data = new Attachment(textBox_Attachment.Text);
                    msg.Attachments.Add(data);
                }
                SmtpClient sc = new SmtpClient("smtp.gmail.com");

                sc.Port = 587;

                sc.Credentials = new NetworkCredential(emailfrom, pwd);
                sc.EnableSsl = true;

                sc.Send(msg);

                MessageBox.Show("Successfully Sent Message.");

                System.Threading.Thread.Sleep(5000);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBox_Attachment.Text = dlg.FileName.ToString();
            }
        }
    }
}
