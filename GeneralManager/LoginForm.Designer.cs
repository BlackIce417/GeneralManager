namespace GeneralManager
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_loginTitle = new System.Windows.Forms.Label();
            this.label_user = new System.Windows.Forms.Label();
            this.label_passwd = new System.Windows.Forms.Label();
            this.text_user = new System.Windows.Forms.TextBox();
            this.text_passwd = new System.Windows.Forms.TextBox();
            this.button_submit = new System.Windows.Forms.Button();
            this.label_loginAlert = new System.Windows.Forms.Label();
            this.button_signup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_loginTitle
            // 
            this.label_loginTitle.AutoSize = true;
            this.label_loginTitle.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_loginTitle.ForeColor = System.Drawing.Color.Red;
            this.label_loginTitle.Location = new System.Drawing.Point(120, 9);
            this.label_loginTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_loginTitle.Name = "label_loginTitle";
            this.label_loginTitle.Size = new System.Drawing.Size(541, 51);
            this.label_loginTitle.TabIndex = 0;
            this.label_loginTitle.Text = "Welcome to General Manager";
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.Location = new System.Drawing.Point(114, 122);
            this.label_user.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(37, 17);
            this.label_user.TabIndex = 1;
            this.label_user.Text = "User";
            this.label_user.UseMnemonic = false;
            // 
            // label_passwd
            // 
            this.label_passwd.AutoSize = true;
            this.label_passwd.Location = new System.Drawing.Point(117, 161);
            this.label_passwd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_passwd.Name = "label_passwd";
            this.label_passwd.Size = new System.Drawing.Size(66, 17);
            this.label_passwd.TabIndex = 2;
            this.label_passwd.Text = "Password";
            // 
            // text_user
            // 
            this.text_user.Location = new System.Drawing.Point(222, 122);
            this.text_user.Margin = new System.Windows.Forms.Padding(4);
            this.text_user.Name = "text_user";
            this.text_user.Size = new System.Drawing.Size(332, 25);
            this.text_user.TabIndex = 3;
            this.text_user.Text = "123";
            // 
            // text_passwd
            // 
            this.text_passwd.Location = new System.Drawing.Point(222, 161);
            this.text_passwd.Margin = new System.Windows.Forms.Padding(4);
            this.text_passwd.Name = "text_passwd";
            this.text_passwd.PasswordChar = '*';
            this.text_passwd.Size = new System.Drawing.Size(332, 25);
            this.text_passwd.TabIndex = 4;
            this.text_passwd.Text = "123";
            // 
            // button_submit
            // 
            this.button_submit.Location = new System.Drawing.Point(222, 238);
            this.button_submit.Margin = new System.Windows.Forms.Padding(4);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(88, 29);
            this.button_submit.TabIndex = 5;
            this.button_submit.Text = "sign in";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // label_loginAlert
            // 
            this.label_loginAlert.AutoSize = true;
            this.label_loginAlert.Location = new System.Drawing.Point(222, 196);
            this.label_loginAlert.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_loginAlert.Name = "label_loginAlert";
            this.label_loginAlert.Size = new System.Drawing.Size(0, 17);
            this.label_loginAlert.TabIndex = 6;
            // 
            // button_signup
            // 
            this.button_signup.Location = new System.Drawing.Point(317, 238);
            this.button_signup.Name = "button_signup";
            this.button_signup.Size = new System.Drawing.Size(85, 29);
            this.button_signup.TabIndex = 7;
            this.button_signup.Text = "sign up";
            this.button_signup.UseVisualStyleBackColor = true;
            this.button_signup.Click += new System.EventHandler(this.button_signup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(222, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Forget Your Password ?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 460);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_signup);
            this.Controls.Add(this.label_loginAlert);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.text_passwd);
            this.Controls.Add(this.text_user);
            this.Controls.Add(this.label_passwd);
            this.Controls.Add(this.label_user);
            this.Controls.Add(this.label_loginTitle);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_loginTitle;
        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.Label label_passwd;
        private System.Windows.Forms.TextBox text_user;
        private System.Windows.Forms.TextBox text_passwd;
        private System.Windows.Forms.Button button_submit;
        private System.Windows.Forms.Label label_loginAlert;
        private System.Windows.Forms.Button button_signup;
        private System.Windows.Forms.Label label1;
    }
}

