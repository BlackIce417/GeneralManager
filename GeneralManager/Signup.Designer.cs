namespace GeneralManager
{
    partial class Signup
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
            this.label_user = new System.Windows.Forms.Label();
            this.label_passwd = new System.Windows.Forms.Label();
            this.text_user = new System.Windows.Forms.TextBox();
            this.text_passwd = new System.Windows.Forms.TextBox();
            this.text_rpasswd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_submit = new System.Windows.Forms.Button();
            this.label_checkingMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.Location = new System.Drawing.Point(131, 94);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(59, 12);
            this.label_user.TabIndex = 0;
            this.label_user.Text = "User Name";
            // 
            // label_passwd
            // 
            this.label_passwd.AutoSize = true;
            this.label_passwd.Location = new System.Drawing.Point(131, 145);
            this.label_passwd.Name = "label_passwd";
            this.label_passwd.Size = new System.Drawing.Size(53, 12);
            this.label_passwd.TabIndex = 1;
            this.label_passwd.Text = "Password";
            // 
            // text_user
            // 
            this.text_user.Location = new System.Drawing.Point(253, 94);
            this.text_user.Name = "text_user";
            this.text_user.Size = new System.Drawing.Size(237, 21);
            this.text_user.TabIndex = 2;
            // 
            // text_passwd
            // 
            this.text_passwd.Location = new System.Drawing.Point(253, 145);
            this.text_passwd.Name = "text_passwd";
            this.text_passwd.PasswordChar = '*';
            this.text_passwd.Size = new System.Drawing.Size(237, 21);
            this.text_passwd.TabIndex = 3;
            // 
            // text_rpasswd
            // 
            this.text_rpasswd.Location = new System.Drawing.Point(253, 203);
            this.text_rpasswd.Name = "text_rpasswd";
            this.text_rpasswd.PasswordChar = '*';
            this.text_rpasswd.Size = new System.Drawing.Size(237, 21);
            this.text_rpasswd.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "Repeat Passwd";
            // 
            // button_submit
            // 
            this.button_submit.Location = new System.Drawing.Point(253, 274);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(75, 23);
            this.button_submit.TabIndex = 6;
            this.button_submit.Text = "submit";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // label_checkingMsg
            // 
            this.label_checkingMsg.AutoSize = true;
            this.label_checkingMsg.Location = new System.Drawing.Point(253, 241);
            this.label_checkingMsg.Name = "label_checkingMsg";
            this.label_checkingMsg.Size = new System.Drawing.Size(41, 12);
            this.label_checkingMsg.TabIndex = 7;
            this.label_checkingMsg.Text = "label2";
            this.label_checkingMsg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_checkingMsg.Visible = false;
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_checkingMsg);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_rpasswd);
            this.Controls.Add(this.text_passwd);
            this.Controls.Add(this.text_user);
            this.Controls.Add(this.label_passwd);
            this.Controls.Add(this.label_user);
            this.Name = "Signup";
            this.Text = "Signup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.Label label_passwd;
        private System.Windows.Forms.TextBox text_user;
        private System.Windows.Forms.TextBox text_passwd;
        private System.Windows.Forms.TextBox text_rpasswd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_submit;
        private System.Windows.Forms.Label label_checkingMsg;
    }
}