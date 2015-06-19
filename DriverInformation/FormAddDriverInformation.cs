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
    public partial class FormAddDriverInformation : Form
    {
        public FormAddDriverInformation()
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

        private void FormAddDriverInformation_Load(object sender, EventArgs e)
        {
            try
            {
                this.TopMost = true;
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                TxtFullName.Focus();
                DTPDOB.Format = DateTimePickerFormat.Custom;
                DTPDOB.CustomFormat = "MMM dd, yyyy";
                
                DTPDriverExperiance.Format = DateTimePickerFormat.Custom;
                DTPDriverExperiance.CustomFormat = "MMM dd, yyyy";
                
                CBGender.SelectedIndex = 0;
                CBType.SelectedIndex = 0;
            }
            catch
            {
            }
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

        private void Login_Click(object sender, EventArgs e)
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

            string dob = DTPDOB.Value.ToShortDateString();
            string experiancedate = DTPDriverExperiance.Value.ToShortDateString();

            ClassDriverInformation CDI = new ClassDriverInformation();
            CDI.info(TxtFullName.Text, TxtDriverLicense.Text, dob, CBGender.Text, CBType.Text, experiancedate, TxtPhoneNumber.Text, TxtMobileNumber.Text, TxtAddress.Text, TxtDescription.Text, TxtDriverAccountNumber.Text);

            int result = CDI.Insert_Driver_Info();

            if (result == 1)
            {
                MessageBox.Show("Driver Information of " + TxtFullName.Text + " Inserted Successfully");
            }
            else
            {
                MessageBox.Show("Driver information of License Number " + TxtDriverLicense.Text + " Already Exist");
            }



        }

        private void FormAddDriverInformation_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtFullName.Text = "";
            TxtDriverLicense.Text = "";
            TxtPhoneNumber.Text = "";
            TxtMobileNumber.Text = "";
            TxtAddress.Text = "";
            TxtDescription.Text = "";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }


    }
}
