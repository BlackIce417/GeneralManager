using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.AccessControl;

namespace GeneralManager
{
    public partial class GMForm : Form
    {
        public GMForm()
        {
            InitializeComponent();
            setHelloUserText();
        }

        private enum GreetingTime
        {
            morning = 5,
            afternoon = 12,
            evening = 18,
        }

        public void setHelloUserText()
        {
            DateTime dt = DateTime.Now;

            int currentTime = (int)dt.Hour;
            if (currentTime >= (int)GreetingTime.morning && currentTime < (int)GreetingTime.afternoon)
            {
                label_helloUser.Text = "Good Morning  " + Globals.Instance.user;
            }
            else if (currentTime >= (int)GreetingTime.afternoon && currentTime < (int)GreetingTime.evening)
            {
                label_helloUser.Text = "Good afternoon  " + Globals.Instance.user;
            }
            else
            {
                label_helloUser.Text = "Good night  " + Globals.Instance.user;
            }
            label_helloUser.ForeColor = Color.Red;
        }

        private Button setNewButton_edit()
        {
            Button button_opt_edit = new Button();
            button_opt_edit.Text = "Edit";
            this.dGV_userInfo.Controls.Add(button_opt_edit);
            //button_opt_edit.Click += button_edit_Click;
            Rectangle rct = this.dGV_userInfo.GetCellDisplayRectangle(4, dGV_userInfo.Rows.Count - 1, false);
            button_opt_edit.Width = rct.Width / 2;
            button_opt_edit.Height = rct.Height;
            button_opt_edit.Location = new Point(rct.Left, rct.Top - rct.Height);

            return button_opt_edit;
        }

        private Button setNewButton_delete(int num)
        {
            Button button_opt_delete = new Button();
            button_opt_delete.Text = "Delete";
            button_opt_delete.Name = num.ToString();
            dGV_userInfo.Controls.Add(button_opt_delete);
            Rectangle rct = dGV_userInfo.GetCellDisplayRectangle(4, dGV_userInfo.Rows.Count - 1, false);
            button_opt_delete.Width = rct.Width / 2;
            button_opt_delete.Height = rct.Height;
            button_opt_delete.Location = new Point(rct.Left + rct.Width / 2, rct.Top - rct.Height);

            return button_opt_delete;
        }

        private void setButtons(int num)
        {
            Button button_opt_edit = setNewButton_edit();
            Button button_opt_delete = setNewButton_delete(num);
            ActionButtons ab = new ActionButtons(button_opt_edit, button_opt_delete, num);
            ab.button_delete.Click += (s, e) => button_delete_Click(ab);
            lActionButtons.Add(ab);
        }
        private List<ActionButtons> lActionButtons = new List<ActionButtons>();

        private bool SetDGVUserInfo()
        {
            string user_id = Globals.Instance.findUserID();
            try
            {
                using (SqlConnection conn = new SqlConnection(Globals.Instance.strCon))
                {
                    conn.Open();
                    //MessageBox.Show("Success");
                    string sql = "select [target], [target_id], [target_passwd], [info_id] from [info] where [user_id] = '" + user_id + "'";
                    using (SqlCommand sqlcmd = new SqlCommand(sql, conn))
                    {
                        SqlDataReader sdr = sqlcmd.ExecuteReader();
                        dGV_userInfo.Rows.Clear();
                        int index = 0;
                        while (sdr.Read())
                        {
                            dGV_userInfo.Rows.Add();
                            //MessageBox.Show("user: " + sdr[0] + "des" + sdr[1]);
                            //dGV_userInfo.Rows.Add(counter, sdr[0], sdr[1], sdr[2]);
                            dGV_userInfo.Rows[index].Cells["userNumber"].Value = index + 1;
                            dGV_userInfo.Rows[index].Cells["userDestination"].Value = sdr["target"];
                            dGV_userInfo.Rows[index].Cells["userID"].Value = sdr["target_id"];
                            dGV_userInfo.Rows[index].Cells["userPasswd"].Value = sdr["target_passwd"];
                            dGV_userInfo.Rows[index].Cells["userInfoID"].Value = sdr["info_id"];
                            //setNewButton_edit(); 
                            //setNewButton_delete();
                            index++;
                            setButtons(index);
                        }
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        private void button_userSearch_Click(object sender, EventArgs e)
        {
            string user_id = Globals.Instance.findUserID();
            //SqlConnection conn = new SqlConnection(Globals.Instance.strCon);
            dGV_userInfo.Visible = true;
            try
            {
                //conn.Open();
                //MessageBox.Show("Success");
                //string sql = "select [target], [target_id], [target_passwd], [info_id] from [info] where [user_id] = '" + user_id + "'";
                //SqlCommand sqlcmd = new SqlCommand(sql, conn);
                SetDGVUserInfo();
            }
            catch
            {
                MessageBox.Show("Connect to DB Fail");
                Application.Exit();
            }
        }

        private void GMForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            AddNewData addNewData = new AddNewData();
            addNewData.Show();
        }

        private void button_edit_Click(object sender, DataGridViewRowsAddedEventArgs e)
        {
            MessageBox.Show("edit");
        }


        private void button_delete_Click(ActionButtons ab)
        {
            int row = ab.row;
            string info_id = dGV_userInfo.Rows[row - 1].Cells["userInfoID"].Value.ToString();
            //MessageBox.Show(user);
            SqlActions sa = new SqlActions();
            if (sa.Delete(info_id, "info"))
            {
                ab.button_delete.Visible = false;
                ab.button_edit.Visible = false;
                SetDGVUserInfo();
            }
            else
            {
                MessageBox.Show("Fail");
            }

        }

        private void dGV_userInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangePasswd changePasswd = new ChangePasswd();
            changePasswd.Show();
        }
    }

    internal class ActionButtons
    {
        public ActionButtons(Button button_edit, Button button_delete, int num)
        {
            this.button_edit = button_edit;
            this.button_delete = button_delete;
            this.row = num;
        }
        public Button button_edit { get; set; }
        public Button button_delete { get; set; }
        public int row { get; set; }
    }
}
