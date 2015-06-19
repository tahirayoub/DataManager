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
    public partial class FormViewVehicleInformation : Form
    {
        public FormViewVehicleInformation(string VN, string CN) // VN = Vehicale Number and CN == Chassis Number
        {
            InitializeComponent();
            LblVehicleNumberInvisible.Text = VN;
            LblChassisNumberInvisible.Text = CN;

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

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdateVehicleInformation EditodrFrom = new FormUpdateVehicleInformation(LblVehicleNumberInvisible.Text, LblChassisNumberInvisible.Text);
            EditodrFrom.Show();
        }

        private void FormViewVehicleInformation_Load(object sender, EventArgs e)
        {
            try
            {
                this.TopMost = true;
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;

                ClassVehicalInformation CVI = new ClassVehicalInformation();

                CVI.VehicleNumber = LblVehicleNumberInvisible.Text;
                CVI.VehicleChassis = LblChassisNumberInvisible.Text;

                CVI.ViewInfo();

                TxtVehicleNo.Text = LblVehicleNumberInvisible.Text;
                TxtChassisNo.Text = LblChassisNumberInvisible.Text;

                TxtVehicleYear.Text = CVI.VehicleYear;
                TxtVehicleClassType.Text = CVI.VehicleClassType;
                TxtVehicleCapacity.Text = CVI.VehicleCapacity;
                TxtVehicleMake.Text = CVI.VehicleMake;
                TxtVehicleMileage.Text = CVI.VehicleMileage;
                TxtVehicleDescription.Text = CVI.VehicleDescription;
            }
            catch
            { }
            
        }

        private void FormViewVehicleInformation_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
