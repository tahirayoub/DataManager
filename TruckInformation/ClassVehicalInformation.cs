using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DataManager.TruckInformation
{
    class ClassVehicalInformation : IDisposable
    {




        //SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\" + Environment.UserName + "\\documents\\visual studio 2012\\Projects\\Chicken\\Chicken\\DB_Chicken.mdf;Integrated Security=True");

        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\" + Environment.UserName + "\\Documents\\Visual Studio 2013\\Projects\\DataManager\\DataManager\\DM.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader rdr = null;

     
        /// <summary>
        /// /////////////////////////
        /// Variables for Truck Information
        /// </summary>
            public string VehicleNumber = "";
            public string VehicleChassis = "";
            public string VehicleYear = "";
            public string VehicleClassType = "";
            public string VehicleCapacity = "";
            public string VehicleMake = "";
            public string VehicleMileage = "";
            public string VehicleDescription = "";
            public string V_Number = "";
            public string V_Chassis = "";
        /// <summary>
        /// ///////////
        /// Set Truck Variables 
        /// </summary>

            string CN = ""; // Chassis Number
            string VN = ""; // Vehicle Number

        public void info(string VehicleNumber, string VehicleChassis, string VehicleYear, string VehicleClassType, string VehicleCapacity, string VehicleMake, string VehicleMileage, string VehicleDescription)
        {
            this.VehicleNumber = VehicleNumber;
            this.VehicleChassis = VehicleChassis;
            this.VehicleYear = VehicleYear;
            this.VehicleClassType = VehicleClassType;
            this.VehicleCapacity = VehicleCapacity;
            this.VehicleMake = VehicleMake;
            this.VehicleMileage = VehicleMileage;
            this.VehicleDescription = VehicleDescription;
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



        /// <summary>
        /// ///////////
        /// 
        /// Insert Data for Truck Information and return value 1 if success and 0 for failure
        /// </summary>
        /// <returns></returns>
        public int insertVehicleInfo()
        {
            

            try
            {

                int i = validateVehicleNumber(); // check if chassis number for the same vehicle number exist 

                if (i == 1)
                {
                    cn.Open();

                    cmd = new SqlCommand(
                    "INSERT into VehicleInformation (VehicleNumber, VehicleChassis, VehicleYear, VehicleClassType,VehicleCapacity, VehicleMake,VehicleMileage, VehicleDescription) VALUES (@VehicleNumber, @VehicleChassis, @VehicleYear, @VehicleClassType, @VehicleCapacity, @VehicleMake, @VehicleMileage, @VehicleDescription) ", cn);
                    cmd.Parameters.Add("@VehicleNumber", VehicleNumber);
                    cmd.Parameters.Add("@VehicleChassis", VehicleChassis);
                    cmd.Parameters.Add("@VehicleYear", VehicleYear);
                    cmd.Parameters.Add("@VehicleClassType", VehicleClassType);
                    cmd.Parameters.Add("@VehicleCapacity", VehicleCapacity);
                    cmd.Parameters.Add("@VehicleMake", VehicleMake);
                    cmd.Parameters.Add("@VehicleMileage", VehicleMileage);
                    cmd.Parameters.Add("@VehicleDescription", VehicleDescription);

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



        /// <summary>
        /// ///////////
        /// Validate if the Truck Info is unique and return value to InsertVehicleInfo()
        /// </summary>
        /// <returns></returns>
        int validateVehicleNumber()
        {
            try
            {
               
                    cn.Close();
                    cn.Open();



                    string sql = "SELECT VehicleNumber,VehicleChassis FROM VehicleInformation where VehicleNumber=@VehicleNumber";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("VehicleNumber", VehicleNumber);


                    rdr = cmd.ExecuteReader();
                    if (rdr.HasRows)
                    {
                        while (rdr.Read())
                        {

                            VN = rdr["VehicleNumber"].ToString();
                            CN = rdr["VehicleChassis"].ToString();

                        }
                    }
                    rdr.Close();
                    cn.Close();

                  if (VN == null || VN == "")
                    {
                        return 1;
                    }
                    else if (VehicleNumber == VN)
                    {
                        if (VehicleChassis == CN)
                        {
                            return 1;
                        }
                        else
                            return 0;
                    }
                    return 0;
                  
                
              
            }
            catch
            {
                return 0;
            }
            
        
        }

        int validatechassisNumber()
        {
            try
            {
                 int i = validateVehicleNumber();

                 if (i == 1)
                 {
                     cn.Close();
                     cn.Open();



                     string sql = "SELECT VehicleChassis FROM VehicleInformation where VehicleChassis=@VehicleChassis";
                     SqlCommand cmd = new SqlCommand();
                     cmd.Connection = cn;
                     cmd.CommandType = CommandType.Text;
                     cmd.CommandText = sql;
                     cmd.Parameters.AddWithValue("VehicleChassis", VehicleChassis);


                     rdr = cmd.ExecuteReader();
                     if (rdr.HasRows)
                     {
                         while (rdr.Read())
                         {

                             CN = rdr["VehicleChassis"].ToString();

                         }
                     }
                     rdr.Close();
                     cn.Close();

                     if (VehicleChassis == CN)
                     {
                         return 0;
                     }
                     else
                     {

                         return 1;
                     }
                 }
                 else
                     return 0;
            }
            catch
            {
                return 0;
            }


        }
    
       public void ViewInfo()
        {
            try
            {
                cn.Open();

              
                string sql = "SELECT * FROM VehicleInformation where VehicleNumber=@VehicleNumber and  VehicleChassis=@VehicleChassis  ";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("VehicleNumber", VehicleNumber);
                cmd.Parameters.AddWithValue("VehicleChassis", VehicleChassis);

                
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {

                        VehicleNumber       =  rdr["VehicleNumber"].ToString();                 
                        VehicleChassis      =  rdr["VehicleChassis"].ToString();
                        VehicleYear         =  rdr["VehicleYear"].ToString();
                        VehicleClassType    =  rdr["VehicleClassType"].ToString();
                        VehicleCapacity     =  rdr["VehicleCapacity"].ToString();
                        VehicleMake         =  rdr["VehicleMake"].ToString();
                        VehicleMileage      =  rdr["VehicleMileage"].ToString();
                        VehicleDescription  =  rdr["VehicleDescription"].ToString();
                    }
                }

             
                rdr.Close();
                cn.Close();
               

              
            }
            catch
            {
               
            }


        }

       public int Updateinfo()
       {
           try
           {


               int a = validateVehicleNumber();

               
               if (a==1)
               {
                
                       string UpdateSql = "UPDATE VehicleInformation SET VehicleNumber=@VehicleNumber, VehicleChassis = @VehicleChassis, VehicleYear=@VehicleYear, VehicleClassType = @VehicleClassType, VehicleCapacity = @VehicleCapacity, VehicleMake = @VehicleMake, VehicleMileage = @VehicleMileage, VehicleDescription = @VehicleDescription  where VehicleNumber = @VNumber and VehicleChassis = @VChassis";

                       SqlCommand cmd2 = new SqlCommand();
                       cmd2.Connection = cn;
                       cmd2.CommandType = CommandType.Text;
                       cmd2.CommandText = UpdateSql;

                       cmd2.Parameters.AddWithValue("VehicleNumber", VehicleNumber);
                       cmd2.Parameters.AddWithValue("VehicleChassis", VehicleChassis);
                       cmd2.Parameters.AddWithValue("VehicleYear", VehicleYear);
                       cmd2.Parameters.AddWithValue("VehicleClassType", VehicleClassType);
                       cmd2.Parameters.AddWithValue("VehicleCapacity", VehicleCapacity);
                       cmd2.Parameters.AddWithValue("VehicleMake", VehicleMake);
                       cmd2.Parameters.AddWithValue("VehicleMileage", VehicleMileage);
                       cmd2.Parameters.AddWithValue("VehicleDescription", VehicleDescription);

                       cmd2.Parameters.AddWithValue("VNumber", V_Number);
                       cmd2.Parameters.AddWithValue("VChassis", V_Chassis);

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
        public int DeleteTruckInfo()
        {
            try
            {
                string DeleteSql = "DELETE FROM VehicleInformation WHERE VehicleChassis=@VehicleChassis";

                SqlCommand cmd2 = new SqlCommand();
                cmd2.Connection = cn;
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = DeleteSql;

                cmd2.Parameters.AddWithValue("VehicleChassis", VehicleChassis);

                cn.Open();
                cmd2.ExecuteNonQuery();

                cmd2.Clone();
                cn.Close();
                return 1;
            }
            catch
            { return 0; }
            
        }
    }
}
