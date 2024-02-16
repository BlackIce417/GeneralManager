namespace GeneralManager
{
    partial class AddNewData
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
            this.label_url = new System.Windows.Forms.Label();
            this.label_ID = new System.Windows.Forms.Label();
            this.label_passwd = new System.Windows.Forms.Label();
            this.text_url = new System.Windows.Forms.TextBox();
            this.text_ID = new System.Windows.Forms.TextBox();
            this.text_passwd = new System.Windows.Forms.TextBox();
            this.button_submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_url
            // 
            this.label_url.AutoSize = true;
            this.label_url.Location = new System.Drawing.Point(185, 90);
            this.label_url.Name = "label_url";
            this.label_url.Size = new System.Drawing.Size(23, 12);
            this.label_url.TabIndex = 0;
            this.label_url.Text = "URL";
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(191, 135);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(17, 12);
            this.label_ID.TabIndex = 1;
            this.label_ID.Text = "ID";
            // 
            // label_passwd
            // 
            this.label_passwd.AutoSize = true;
            this.label_passwd.Location = new System.Drawing.Point(179, 187);
            this.label_passwd.Name = "label_passwd";
            this.label_passwd.Size = new System.Drawing.Size(29, 12);
            this.label_passwd.TabIndex = 2;
            this.label_passwd.Text = "Pass";
            // 
            // text_url
            // 
            this.text_url.Location = new System.Drawing.Point(271, 87);
            this.text_url.Name = "text_url";
            this.text_url.Size = new System.Drawing.Size(100, 21);
            this.text_url.TabIndex = 3;
            // 
            // text_ID
            // 
            this.text_ID.Location = new System.Drawing.Point(271, 126);
            this.text_ID.Name = "text_ID";
            this.text_ID.Size = new System.Drawing.Size(100, 21);
            this.text_ID.TabIndex = 4;
            // 
            // text_passwd
            // 
            this.text_passwd.Location = new System.Drawing.Point(271, 184);
            this.text_passwd.Name = "text_passwd";
            this.text_passwd.Size = new System.Drawing.Size(100, 21);
            this.text_passwd.TabIndex = 5;
            // 
            // button_submit
            // 
            this.button_submit.Location = new System.Drawing.Point(271, 253);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(75, 23);
            this.button_submit.TabIndex = 6;
            this.button_submit.Text = "Submit";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // AddNewData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.text_passwd);
            this.Controls.Add(this.text_ID);
            this.Controls.Add(this.text_url);
            this.Controls.Add(this.label_passwd);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.label_url);
            this.Name = "AddNewData";
            this.Text = "AddNewData";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_url;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label label_passwd;
        private System.Windows.Forms.TextBox text_url;
        private System.Windows.Forms.TextBox text_ID;
        private System.Windows.Forms.TextBox text_passwd;
        private System.Windows.Forms.Button button_submit;
    }
}