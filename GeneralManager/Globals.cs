using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneralManager
{
    public class Globals
    {
        private static Globals _instance = null;

        public static Globals Instance
        {
            get 
            { 
                if (_instance == null)
                    _instance = new Globals();
                return _instance; 
            }
        }

        public LoginForm loginForm = null;
        public string user = null;

        public string strCon = "Data Source=127.0.0.1;;Initial Catalog=WinForm-GeneralManager;User ID=sa;Password=123456";
    
        public Signup signup = null;

        public string findUserID()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.strCon))
                {
                    conn.Open();

                    //string sql = "select [user_id] from [user] where [user_name] = " + "'" + Globals.Instance.user + "'";
                    string sql = "select [user_id] from [user] where [user_name] = @user_name";

                    using (SqlCommand sqlcmd = new SqlCommand(sql, conn))
                    {
                        sqlcmd.Parameters.AddWithValue("@user_name", Globals.Instance.user);
                        using (SqlDataReader sqlReader = sqlcmd.ExecuteReader())
                        {
                            if (sqlReader.Read())
                            {
                                string user_id = sqlReader[0].ToString();
                                conn.Close();
                                return user_id;
                            }
                            return "";
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Unknown user name");
                return "";
            }
        }
    }
}
