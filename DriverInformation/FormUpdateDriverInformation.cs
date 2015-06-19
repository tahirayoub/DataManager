using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataManager.DriverInformation
{
    public partial class FormUpdateDriverInformation : Form
    {
        public FormUpdateDriverInformation(string driverlicenseNo)
        {
            InitializeComponent();
            LblDriverLicenseInvisible.Text = driverlicenseNo;

        }

        private void FormUpdateDriverInformation_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            TxtFullName.Focus();
            DTPDOB.Format = DateTimePickerFormat.Custom;
            DTPDOB.CustomFormat = "MMM dd, yyyy";

            DTPDriverExperiance.Format = DateTimePickerFormat.Custom;
            DTPDriverExperiance.CustomFormat = "MMM dd, yyyy";

            ClassDriverInformation CDI = new ClassDriverInformation();
            CDI.DriverLicenseNumber = LblDriverLicenseInvisible.Text;

            CDI.ViewDriverInformation();
            TxtFullName.Text = CDI.DriverFullName;

            TxtDriverLicense.Text = LblDriverLicenseInvisible.Text;

            DTPDOB.Text = CDI.DriverDOB; ;

            CBGender.Text = CDI.DriverGender;
            CBType.Text = CDI.DriverLicenseType;

            

            DTPDriverExperiance.Text = CDI.DriverExperiance;
            TxtPhoneNumber.Text = CDI.DriverPhoneNumber;
            TxtMobileNumber.Text = CDI.DriverMobileNumber;

            TxtAddress.Text = CDI.DriverAddress;
            TxtDescription.Text = CDI.DriverDescription;

            TxtDriverAccountNumber.Text = CDI.DriverBankAccountNo;

            
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            DriverInformation.FormSelectUpdateDriverInformation m = new DriverInformation.FormSelectUpdateDriverInformation();
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
            
            try
            {


                if (TxtDriverLicense.Text == null || TxtDriverLicense.Text == "")
                {
                    MessageBox.Show("Please Enter the Driver License Number");
                    TxtDriverLicense.Focus();
                    return;
                }

                if (TxtFullName.Text == null || TxtFullName.Text == "")
                {
                    MessageBox.Show("Please Enter the Driver Full Name");
                    TxtFullName.Focus();
                    return;
                }

                ClassDriverInformation CDI = new ClassDriverInformation();

                CDI.Driver_Ln = LblDriverLicenseInvisible.Text;

                CDI.DriverFullName = TxtFullName.Text;
                CDI.DriverLicenseNumber= TxtDriverLicense.Text;


                CDI.DriverDOB = DTPDOB.Text;

                CDI.DriverGender = CBGender.Text;

                CDI.DriverLicenseType = CBType.Text;

                CDI.DriverExperiance = DTPDriverExperiance.Text;

                CDI.DriverPhoneNumber = TxtPhoneNumber.Text;

                CDI.DriverMobileNumber = TxtMobileNumber.Text;

                CDI.DriverAddress = TxtAddress.Text;

                CDI.DriverDescription = TxtDescription.Text;

                CDI.DriverBankAccountNo = TxtDriverAccountNumber.Text;

                int result = CDI.Updateinfo();

                if (result == 1)
                {
                    MessageBox.Show("Driver Data Updated Successfully");
                }
                else
                {
                    MessageBox.Show("Driver License Number Already Used");
                }
            }
            catch
            { }



        }

        private void DTPDOB_ValueChanged(object sender, EventArgs e)
        {
            LblAge.Visible = true;
            int years = DateTime.Now.Year - DTPDOB.Value.Year;

            if (DTPDOB.Value.AddYears(years) > DateTime.Now) years--;
            LblAge.Text = years.ToString() + " Years"; 
        }

        private void DTPDriverExperiance_ValueChanged(object sender, EventArgs e)
        {
            LblExperiance.Visible = true;
            int years = DateTime.Now.Year - DTPDriverExperiance.Value.Year;

            if (DTPDriverExperiance.Value.AddYears(years) > DateTime.Now) years--;
            LblExperiance.Text = years.ToString() + " Years";
        }
    }
}
