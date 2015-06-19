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

namespace DataManager.DriverInformation
{
    public partial class FormSelectUpdateDriverInformation : Form
    {

        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\" + Environment.UserName + "\\Documents\\Visual Studio 2013\\Projects\\DataManager\\DataManager\\DM.mdf;Integrated Security=True");

        SqlCommand cmd = new SqlCommand();

        string r1, r2, r3, r4, r5 = "";
        public FormSelectUpdateDriverInformation()
        {
            InitializeComponent();
        }

        private void FormSelectUpdateDriverInformation_Load(object sender, EventArgs e)
        {
            try
            {
                this.TopMost = true;
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                cmd.Connection = cn;
                dataGridView1.Visible = true;
                cn.Open();
                string strSQL = "Select DriverFullName AS [Driver Full Name], DriverLicenseNumber AS [License], DriverExperiance FROm DriverInformation";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(strSQL, cn);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                // Populate a new data table and bind it to the BindingSource.
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                dbBindSource.DataSource = table;

                // Resize the DataGridView columns to fit the newly loaded content.
                //  dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                // you can make it grid readonly.
                dataGridView1.ReadOnly = true;

                // finally bind the data to the grid
                dataGridView1.DataSource = dbBindSource;
                dataGridView1.Visible = true;
                cmd.Connection = cn;

           



            }

            catch
            {

            }
            finally
            {
                cn.Close();

            }
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {

                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                    r1 = row.Cells["Driver Full Name"].Value.ToString();
                    r2 = row.Cells["License"].Value.ToString();
                    r3 = row.Cells["DriverExperiance"].Value.ToString();
                    

                    this.Hide();
                    FormUpdateDriverInformation EditodrFrom = new FormUpdateDriverInformation(r2);
                    EditodrFrom.Show();
                }
            }

            catch
            { }
        }
    }
}
