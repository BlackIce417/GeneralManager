using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneralManager
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            Globals.Instance.loginForm = this;
        }


        private bool checkUser()
        {
            string user = text_user.Text;
            string passwd = text_passwd.Text;

            try
            {
                using (SqlConnection conn = new SqlConnection(Globals.Instance.strCon))
                {
                    conn.Open();
                    string sql = "select [user_passwd], cast([user_regDate] as datetime) as user_regDate from [user] where [user_name] = @user_name;";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@user_name", user);
                        SqlDataReader sqlrdr = cmd.ExecuteReader();
                        if (sqlrdr.Read())
                        {
                            string plain_text = passwd + sqlrdr["user_regDate"];
                            SHA256Managed sha256 = new SHA256Managed();
                            byte[] bcypherText = sha256.ComputeHash(Encoding.UTF8.GetBytes(plain_text));
                            string cypherText = BitConverter.ToString(bcypherText).Replace("-", "").ToLower();
                            return sqlrdr["user_passwd"].ToString() == cypherText;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error!");
            }
            return false;
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            string user = text_user.Text;
            string passwd = text_passwd.Text;

            if (checkUser()) 
            {
                Globals.Instance.user = user;
                GMForm gmForm = new GMForm();
                gmForm.Show();
                Globals.Instance.loginForm.Hide();
            }
            else
            {
                label_loginAlert.Text = "Check User or Password";
                label_loginAlert.ForeColor = Color.Red;
                text_passwd.Text = null;
            }
        }

        private void button_signup_Click(object sender, EventArgs e)
        {
            Signup signupForm = new Signup();
            Globals.Instance.signup = signupForm;
            signupForm.Show();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("you can't do this");
        }
    }
}
