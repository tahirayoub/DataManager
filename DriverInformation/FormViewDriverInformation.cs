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
    public partial class FormViewDriverInformation : Form
    {
        public FormViewDriverInformation(string D_License)
        {
            InitializeComponent();
            LblDriverLicenseInvisible.Text = D_License;
        }

        private void FormViewDriverInformation_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
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
            DriverInformation.FormSelectViewDriverInformation m = new DriverInformation.FormSelectViewDriverInformation();
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
            DriverInformation.FormUpdateDriverInformation m = new DriverInformation.FormUpdateDriverInformation(LblDriverLicenseInvisible.Text);
            m.Show();
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
