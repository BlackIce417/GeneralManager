namespace GeneralManager
{
    partial class ChangePasswd
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
            this.label_currentpasswd = new System.Windows.Forms.Label();
            this.label_newpasswd = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label_reptpasswd = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button_submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_currentpasswd
            // 
            this.label_currentpasswd.AutoSize = true;
            this.label_currentpasswd.Location = new System.Drawing.Point(20, 38);
            this.label_currentpasswd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_currentpasswd.Name = "label_currentpasswd";
            this.label_currentpasswd.Size = new System.Drawing.Size(101, 12);
            this.label_currentpasswd.TabIndex = 0;
            this.label_currentpasswd.Text = "Current Password";
            // 
            // label_newpasswd
            // 
            this.label_newpasswd.AutoSize = true;
            this.label_newpasswd.Location = new System.Drawing.Point(20, 84);
            this.label_newpasswd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_newpasswd.Name = "label_newpasswd";
            this.label_newpasswd.Size = new System.Drawing.Size(77, 12);
            this.label_newpasswd.TabIndex = 1;
            this.label_newpasswd.Text = "New Password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(145, 36);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 21);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(145, 82);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(143, 21);
            this.textBox2.TabIndex = 3;
            // 
            // label_reptpasswd
            // 
            this.label_reptpasswd.AutoSize = true;
            this.label_reptpasswd.Location = new System.Drawing.Point(20, 131);
            this.label_reptpasswd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_reptpasswd.Name = "label_reptpasswd";
            this.label_reptpasswd.Size = new System.Drawing.Size(95, 12);
            this.label_reptpasswd.TabIndex = 4;
            this.label_reptpasswd.Text = "Repeat Password";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(145, 129);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(143, 21);
            this.textBox3.TabIndex = 5;
            // 
            // button_submit
            // 
            this.button_submit.Location = new System.Drawing.Point(145, 171);
            this.button_submit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(56, 18);
            this.button_submit.TabIndex = 6;
            this.button_submit.Text = "submit";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // ChangePasswd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 216);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label_reptpasswd);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_newpasswd);
            this.Controls.Add(this.label_currentpasswd);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ChangePasswd";
            this.Text = "ChangePasswd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_currentpasswd;
        private System.Windows.Forms.Label label_newpasswd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label_reptpasswd;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button_submit;
    }
}