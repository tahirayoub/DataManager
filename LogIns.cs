using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;



namespace DataManager
{
   
    class LogIns:IDisposable 
    {




        //SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\" + Environment.UserName + "\\documents\\visual studio 2012\\Projects\\Chicken\\Chicken\\DB_Chicken.mdf;Integrated Security=True");
       
       
      SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\" + Environment.UserName + "\\Documents\\Visual Studio 2013\\Projects\\DataManager\\DataManager\\DM.mdf;Integrated Security=True");
       
        public string UName, Pass = "";
       

        SqlCommand cmd = new SqlCommand();


        SqlDataReader rdr = null;

        public void setUnamePass(string Name, string Pass)
        {
            this.UName = Name;
            this.Pass = Pass;
            
        }
        public void Dispose()
        {
            if (cn != null) { cn.Dispose(); cn = null; }
            if (cmd != null) { cmd.Dispose(); cmd = null; }
            if (rdr != null) { rdr.Dispose(); rdr = null; }
        }
       public int validates()
        {
            try
            {
                cn.Open();
               // string name = UName.ToLower();
                string n1 = "";
                string p1 = "";
                string sql = "SELECT UserName, Password FROM Login where UserName=@UserName and Password=@Password ";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("UserName", UName);
                cmd.Parameters.AddWithValue("Password", Pass);

                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {

                        n1 = rdr["UserName"].ToString();
                        p1 = rdr["Password"].ToString();
                    }
                }



                rdr.Close();
                cn.Close();


                if (UName == n1 && p1 == Pass)
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
        
    }

  
}
