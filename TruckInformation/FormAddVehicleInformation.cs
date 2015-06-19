using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataManager.TruckInformation
{
    public partial class FormAddVehicleInformation : Form
    {
        public FormAddVehicleInformation()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu m = new Menu();
            m.Show();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fm = new Form1();
            fm.Show();
          
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu m = new Menu();
            m.Show();
        }

      

        private void Login_Click(object sender, EventArgs e)
        {

            if (TxtChassisNo.Text == null || TxtChassisNo.Text == "")
            {
                MessageBox.Show("Please Enter the Chasses Number");
                TxtChassisNo.Focus();
                return;
            }
            
            if (TxtVehicleNo.Text == null || TxtVehicleNo.Text == "")
            {
                MessageBox.Show("Please Enter the Vehicle Number");
                TxtChassisNo.Focus();
                return;
            }


            ClassVehicalInformation CVI = new ClassVehicalInformation();
            CVI.info(TxtVehicleNo.Text, TxtChassisNo.Text, TxtVehicleYear.Text, TxtVehicleClassType.Text, TxtVehicleCapacity.Text, TxtVehicleMake.Text, TxtVehicleMileage.Text, TxtVehicleDescription.Text);

            int result = CVI.insertVehicleInfo();

            if (result == 1)
            {
                MessageBox.Show("Truck Data "+TxtVehicleNo.Text+ " Inserted Successfully");
            }
            else
            {
                MessageBox.Show("Truck Data " + TxtVehicleNo.Text + " Vehicle Info Already Exist");
            }



        }

        private void FormAddVehicleInformation_Load(object sender, EventArgs e)
        {
            try
            {
                TxtVehicleNo.Focus();
                TxtVehicleClassType.SelectedIndex = 0;
                this.TopMost = true;
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }
            catch
            { }

        }

        private void FormAddVehicleInformation_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtVehicleNo.Text = "";
            TxtChassisNo.Text = "";
            TxtVehicleYear.Text = "";
            TxtVehicleCapacity.Text = "";
            TxtVehicleMake.Text = "";
            TxtVehicleMileage.Text = "";
            TxtVehicleDescription.Text = "";
        }

    }
}
