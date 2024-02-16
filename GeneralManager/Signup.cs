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
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Security.Cryptography;
using System.Diagnostics.Eventing.Reader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GeneralManager
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private string passwdEncrypt(string password, string salt)
        {
            string plainText = password + salt;
            SHA256Managed sha256 = new SHA256Managed();
            byte[] bcypherText = sha256.ComputeHash(Encoding.UTF8.GetBytes(plainText));
            return BitConverter.ToString(bcypherText).Replace("-", "").ToLower();
        }

        private void regNewUser(string username, string password)
        {
            SqlConnection conn = new SqlConnection(Globals.Instance.strCon);
            DateTime dt = DateTime.Now;
            SHA256Managed sha256 = new SHA256Managed();
            string cypherPasswd = passwdEncrypt(password, dt.ToString());
            byte[] bUsername = sha256.ComputeHash(Encoding.UTF8.GetBytes(username));
            Guid user_uuid = Guid.NewGuid();
            string sql = "insert into [user] (user_id, user_name, user_passwd, " +
                    "user_regDate)" +
                    "values ('" +
                    user_uuid.ToString() + "','" +
                    text_user.Text + "','" +
                    cypherPasswd + "','" +
                    dt.ToString() + "'" +
                    ")";
            SqlCommand sqlcmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                sqlcmd.ExecuteNonQuery();
                conn.Close();

                DialogResult dr = MessageBox.Show("Success! Please Back and Sign in", "", MessageBoxButtons.OK);
                if (dr == DialogResult.OK)
                {
                    this.Close();
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    setCheckingMsg("This name has been registed");
                }
                else
                {
                    MessageBox.Show("Regist Fail");
                }
            }
        }

        private void setCheckingMsg(string msg)
        {
            label_checkingMsg.Text = msg;
            label_checkingMsg.ForeColor = Color.Red;
            label_checkingMsg.Visible = true;
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            label_checkingMsg.Visible = false;
            if (text_passwd.Text != text_rpasswd.Text)
            {
                setCheckingMsg("Password is not same");
            }
            else
            {
                regNewUser(text_user.Text, text_passwd.Text);
            }
        }
    }
}
