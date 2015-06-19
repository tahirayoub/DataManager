using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

namespace DataManager
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtUserName.Text == "")
                {
                    MessageBox.Show("Please Enther User Name");
                    TxtUserName.Focus();
                    return;
                }
                if (TxtPassword.Text == "")
                {
                    MessageBox.Show("Please Enther the Password");
                    TxtPassword.Focus();
                    return;
                }

                LogIns LogInObj = new LogIns();

                LogInObj.setUnamePass(TxtUserName.Text, TxtPassword.Text);

                int result = LogInObj.validates();
             

              

                if (result == 1)
                {
                    this.Hide();


                    Menu form2 = new Menu();
                    form2.Show();
                }
                else
                    MessageBox.Show("The UserName and Password is Incorrect");



               
              
               
            }

            catch
            {
                MessageBox.Show("The UserName and Password is Incorrect");
            }
            finally
            {  }
        }

        private void TxtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxtUserName.Text = "";
            TxtPassword.Text = "";

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            TxtUserName.Focus();
        }
    }
}
