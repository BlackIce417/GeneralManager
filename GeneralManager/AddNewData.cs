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
    public partial class AddNewData : Form
    {
        public AddNewData()
        {
            InitializeComponent();
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            Guid guid = Guid.NewGuid();
            string uuid = guid.ToString();
            try
            {
                using (SqlConnection conn = new SqlConnection(Globals.Instance.strCon))
                {
                    conn.Open();

                    string user_id = Globals.Instance.findUserID();
                    string sql_insert = "insert [info] ([info_id], [user_id], [target], [target_id], [target_passwd]) values (@info_id, @user_id, @target, @target_id, @target_passwd);";
                    using (SqlCommand sqlcmd = new SqlCommand(sql_insert, conn))
                    {
                        sqlcmd.Parameters.AddWithValue("@info_id", uuid);
                        sqlcmd.Parameters.AddWithValue("@user_id", user_id);
                        sqlcmd.Parameters.AddWithValue("@target", text_url.Text);
                        sqlcmd.Parameters.AddWithValue("@target_id", text_ID.Text);
                        sqlcmd.Parameters.AddWithValue("@target_passwd", text_passwd.Text);
                        sqlcmd.ExecuteNonQuery();
                    }
                    conn.Close();
                    DialogResult dr = MessageBox.Show("Success", "", MessageBoxButtons.OK);
                    if (dr == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Option Failure");
            }
        }
    }
}
