using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneralManager
{
    public partial class ChangePasswd : Form
    {
        public ChangePasswd()
        {
            InitializeComponent();
        }

        private bool UpdateUserPasswd(string passwd)
        {
            string current_user = Globals.Instance.user;
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.Open();
                    string sql = "update [user] set [user_passwd] = @passwd where [user_name] = " + Globals.Instance.user;
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@passwd", passwd);
                        int ret_code = cmd.ExecuteNonQuery();
                        if (ret_code != 0)
                        {
                            return true;
                        }
                        return false;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("DB error: " + ex.ErrorCode);
                return false;
            }
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            string passwd = label_newpasswd.Text;
            //UpdateUserPasswd(string passwd);
            MessageBox.Show(Globals.Instance.user);
        }
    }
}
