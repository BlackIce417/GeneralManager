using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneralManager
{
    public class SqlActions
    {
        private string sqlConn = "Data Source=127.0.0.1;;Initial Catalog=WinForm-GeneralManager;User ID=sa;Password=123456";
        private SqlConnection getConnection()
        {
            try
            {
                return new SqlConnection(sqlConn);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Cannot connect to DB");
            }
            return null;
        }

        private string GetPK(string tableName)
        {
            string primaryKey;
            switch (tableName)
            {
                case "admin": primaryKey = "admin_id"; break;
                case "user": primaryKey = "user_id"; break;
                case "info": primaryKey = "info_id"; break;
                default:
                    return null;
            }
            return primaryKey;
        }
        public bool Delete(string target_id, string table_name)
        {
            string primary_key = GetPK(table_name);
            try
            {
                using (SqlConnection conn = getConnection())
                {
                    conn.Open();
                    string sql = "delete from [" + table_name +"] where " + primary_key + "= @target_id";
                    using (SqlCommand sqlcmd = new SqlCommand(sql, conn))
                    {
                        sqlcmd.Parameters.AddWithValue("@target_id", target_id);
                        sqlcmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
                return true;
            }
            catch(SqlException ex)
            {
                return false;
            }
        }
    }
}
