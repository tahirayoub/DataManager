using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DataManager.DriverInformation
{

    class ClassDriverInformation : IDisposable
    {

        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\" + Environment.UserName + "\\Documents\\Visual Studio 2013\\Projects\\DataManager\\DataManager\\DM.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader rdr = null;

        /// <summary>
        /// //////////Driver Information
        /// </summary>
        public string DriverFullName = "";
        public string DriverLicenseNumber = "";
        public string DriverDOB;
        public string DriverGender = "";
        public string DriverLicenseType = "";
        public string DriverExperiance;
        public string DriverPhoneNumber = "";
        public string DriverMobileNumber = "";
        public string DriverAddress = "";
        public string DriverDescription = "";
        public string DriverBankAccountNo = "";
        /// <summary>
        /// ///////////
        /// Set Truck Variables 
        /// </summary>

       public string DLN = ""; // DLN = DriverLicenseNumber
       public string Driver_Ln = ""; // DLN = DriverLicenseNumber
        

        public void info(string DriverFullName, string DriverLicenseNumber, string DriverDOB, string DriverGender, string DriverLicenseType, string DriverExperiance, string DriverPhoneNumber, string DriverMobileNumber, string DriverAddress, string DriverDescription, string DriverBankAccountNo)
        {
        this.DriverFullName = DriverFullName;
        this.DriverLicenseNumber = DriverLicenseNumber;
        this.DriverDOB = DriverDOB;
        this.DriverGender = DriverGender;
        this.DriverLicenseType = DriverLicenseType;
        this.DriverExperiance = DriverExperiance;
        this.DriverPhoneNumber = DriverPhoneNumber;
        this.DriverMobileNumber = DriverMobileNumber;
        this.DriverAddress = DriverAddress;
        this.DriverDescription = DriverDescription;
        this.DriverBankAccountNo = DriverBankAccountNo;
        }

        /// <summary>
        /// ///////// Sql Varaibles Dispose
        /// </summary>
        public void Dispose()
        {
            if (cn != null) { cn.Dispose(); cn = null; }
            if (cmd != null) { cmd.Dispose(); cmd = null; }
            if (rdr != null) { rdr.Dispose(); rdr = null; }
        }

        public int Insert_Driver_Info()
        {

            try
            {

                int i = validateDriverinformation();        // check if driver License is unqiue

                if (i == 1)
                {
                    cn.Open();

                    cmd = new SqlCommand(
                    "INSERT into DriverInformation (DriverFullName, DriverLicenseNumber, DriverDOB, DriverGender, DriverLicenseType, DriverExperiance, DriverPhoneNumber, DriverMobileNumber, DriverAddress, DriverDescription, DriverBankAccountNo) VALUES (@DriverFullName, @DriverLicenseNumber, @DriverDOB, @DriverGender, @DriverLicenseType, @DriverExperiance, @DriverPhoneNumber, @DriverMobileNumber, @DriverAddress, @DriverDescription,@DriverBankAccountNo) ", cn);
                    cmd.Parameters.Add("@DriverFullName", DriverFullName);
                    cmd.Parameters.Add("@DriverLicenseNumber", DriverLicenseNumber);
                    cmd.Parameters.Add("@DriverDOB", DriverDOB);
                    cmd.Parameters.Add("@DriverGender", DriverGender);
                    cmd.Parameters.Add("@DriverLicenseType", DriverLicenseType);
                    cmd.Parameters.Add("@DriverExperiance", DriverExperiance);
                    cmd.Parameters.Add("@DriverPhoneNumber", DriverPhoneNumber);
                    cmd.Parameters.Add("@DriverMobileNumber", DriverMobileNumber);
                    cmd.Parameters.Add("@DriverAddress", DriverAddress);
                    cmd.Parameters.Add("@DriverDescription", DriverDescription);
                    cmd.Parameters.Add("@DriverBankAccountNo", DriverBankAccountNo);

                    cmd.ExecuteNonQuery();

                    cn.Close();
                    return 1;
                }
                else if (i == 0)
                    return 0;
                return 0;
            }

            catch
            { return 0; }
        }


        int validateDriverinformation()
        {
            try
            {

                cn.Close();
                cn.Open();



                string sql = "SELECT DriverLicenseNumber FROM DriverInformation where DriverLicenseNumber=@DriverLicenseNumber";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("DriverLicenseNumber", DriverLicenseNumber);


                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {

                        DLN = rdr["DriverLicenseNumber"].ToString();
                      

                    }
                }
                rdr.Close();
                cn.Close();

                if (DLN == null || DLN == "")
                {
                    return 1;
                }
                else if (DriverLicenseNumber == DLN)
                {
                    return 1;
                }
                else
                    return 0;



            }
            catch
            {
                return 0;
            }

        
        }
        public void ViewDriverInformation()
        {

            try {

                cn.Open();

                string ViewSql = "Select * from DriverInformation where DriverLicenseNumber = @DriverLicenseNumber";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = ViewSql;
                cmd.Parameters.AddWithValue("@DriverLicenseNumber", DriverLicenseNumber);

                rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {

                        DriverFullName = rdr["DriverFullName"].ToString();
                        DriverLicenseNumber = rdr["DriverLicenseNumber"].ToString();
                        DriverDOB = rdr["DriverDOB"].ToString();
                        DriverGender = rdr["DriverGender"].ToString();
                        DriverLicenseType = rdr["DriverLicenseType"].ToString();
                        DriverExperiance = rdr["DriverExperiance"].ToString();
                        DriverPhoneNumber = rdr["DriverPhoneNumber"].ToString();
                        DriverMobileNumber = rdr["DriverMobileNumber"].ToString();
                        DriverAddress = rdr["DriverAddress"].ToString();
                        DriverDescription = rdr["DriverDescription"].ToString();
                        DriverBankAccountNo = rdr["DriverBankAccountNo"].ToString();

                    
                    }
                }

                rdr.Close();
                cn.Close();

            }
            catch
            { }

        }
        public int Updateinfo()
        {
            try
            {


                int a = validateDriverinformation();


                if (a == 1)
                {

                    string UpdateSql = "UPDATE DriverInformation SET DriverFullName=@DriverFullName, DriverLicenseNumber=@DriverLicenseNumber, DriverDOB=@DriverDOB, DriverGender=@DriverGender, DriverLicenseType=@DriverLicenseType, DriverExperiance=@DriverExperiance, DriverPhoneNumber=@DriverPhoneNumber, DriverMobileNumber=@DriverMobileNumber, DriverAddress=@DriverAddress, DriverDescription=@DriverDescription, DriverBankAccountNo=@DriverBankAccountNo WHERE DriverLicenseNumber=@DriverLicense";

                    SqlCommand cmd2 = new SqlCommand();
                    cmd2.Connection = cn;
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = UpdateSql;

                    cmd2.Parameters.AddWithValue("@DriverFullName", DriverFullName);
                    cmd2.Parameters.AddWithValue("@DriverLicenseNumber", DriverLicenseNumber);
                    cmd2.Parameters.AddWithValue("@DriverDOB", DriverDOB);
                    cmd2.Parameters.AddWithValue("@DriverGender", DriverGender);
                    cmd2.Parameters.AddWithValue("@DriverLicenseType", DriverLicenseType);
                    cmd2.Parameters.AddWithValue("@DriverExperiance", DriverExperiance);
                    cmd2.Parameters.AddWithValue("@DriverPhoneNumber", DriverPhoneNumber);
                    cmd2.Parameters.AddWithValue("@DriverMobileNumber", DriverMobileNumber);
                    cmd2.Parameters.AddWithValue("@DriverAddress", DriverAddress);
                    cmd2.Parameters.AddWithValue("@DriverDescription", DriverDescription);
                    cmd2.Parameters.AddWithValue("@DriverBankAccountNo", DriverBankAccountNo);


                    cmd2.Parameters.AddWithValue("@DriverLicense", Driver_Ln);
                    

                    cn.Open();
                    cmd2.ExecuteNonQuery();

                    cmd2.Clone();
                    cn.Close();

                    return 1;


                }
                else
                {
                    return 0;
                }


            }


            catch
            {

                return 0;
            }


        }
       


    }
}
