using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataManager
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fm = new Form1();
            fm.Show();
          
        }

        private void BtnTruckInformation_Click(object sender, EventArgs e)
        {
            this.Hide();
            TruckInformation.FormAddVehicleInformation m = new TruckInformation.FormAddVehicleInformation();
            m.Show();          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            TruckInformation.FormSelectUpdateVehicleInformation m = new TruckInformation.FormSelectUpdateVehicleInformation();
            m.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            TruckInformation.FormSelectViewVehicleInformation m = new TruckInformation.FormSelectViewVehicleInformation();
            m.Show();
        }

        private void BtnAddDriverInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            DriverInformation.FormAddDriverInformation m = new DriverInformation.FormAddDriverInformation();
            m.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            try
            {
                this.TopMost = true;
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;

            }
            catch
            { }

        }

        private void BtnUpdateDriverInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            DriverInformation.FormSelectUpdateDriverInformation m = new DriverInformation.FormSelectUpdateDriverInformation();
            m.Show();
        }

        private void BtnViewDriverInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            DriverInformation.FormSelectViewDriverInformation m = new DriverInformation.FormSelectViewDriverInformation();
            m.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            SendMail m = new SendMail();
            m.Show();
        }
    }
}
