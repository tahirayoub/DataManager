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
    public partial class FormUpdateVehicleInformation : Form
    {
        public FormUpdateVehicleInformation(string VNo, String CNo) // VNo = VehicleNumber, CNo = Chassis Number
        {
            InitializeComponent();
            LblVehicleNumberInvisible.Text = VNo;
            LblChassisNumberInvisible.Text = CNo;

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSelectUpdateVehicleInformation m = new FormSelectUpdateVehicleInformation();
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

        private void FormUpdateVehicleInformation_Load(object sender, EventArgs e)
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

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
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

                CVI.V_Number = LblVehicleNumberInvisible.Text;
                CVI.V_Chassis = LblChassisNumberInvisible.Text;


                CVI.VehicleNumber = TxtVehicleNo.Text;

                CVI.VehicleChassis = TxtChassisNo.Text;

                CVI.VehicleYear = TxtVehicleYear.Text;

                CVI.VehicleClassType = TxtVehicleClassType.Text;

                CVI.VehicleCapacity = TxtVehicleCapacity.Text;

                CVI.VehicleMake = TxtVehicleMake.Text;

                CVI.VehicleMileage = TxtVehicleMileage.Text;

                CVI.VehicleDescription = TxtVehicleDescription.Text;

                int result = CVI.Updateinfo();


                if (result == 1)
                {
                    MessageBox.Show("Truck Data Updated Successfully");
                }
                else
                {
                    MessageBox.Show("Truck Vehicle Number Already Used");
                }
            }
            catch
            { }



        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            { 
                DialogResult D_Result = MessageBox.Show("Do you want to delete "+ TxtChassisNo.Text +"Information", "Please Click Yes or No",MessageBoxButtons.YesNo);
                if (D_Result == DialogResult.Yes)
                {
                    ClassVehicalInformation CVI = new ClassVehicalInformation();
                    CVI.VehicleChassis = TxtChassisNo.Text;
                    int result = CVI.DeleteTruckInfo();
                    if (result == 1)
                    {
                        MessageBox.Show("Truck Data Deleted Successfully");
                        this.Hide();
                        FormSelectUpdateVehicleInformation m = new FormSelectUpdateVehicleInformation();
                        m.Show();
                    }
                    else
                    {
                        MessageBox.Show("Truck Data Updation Fail");
                    }
                }
                else if (D_Result == DialogResult.No)
                { 
                }
            }
            catch
            { }
        }

        private void FormUpdateVehicleInformation_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
