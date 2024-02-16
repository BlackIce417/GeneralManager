namespace GeneralManager
{
    partial class GMForm
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
            this.label_helloUser = new System.Windows.Forms.Label();
            this.button_userSearch = new System.Windows.Forms.Button();
            this.dGV_userInfo = new System.Windows.Forms.DataGridView();
            this.userNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDestination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPasswd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Options = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userInfoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_add = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_userInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // label_helloUser
            // 
            this.label_helloUser.AutoSize = true;
            this.label_helloUser.Location = new System.Drawing.Point(47, 16);
            this.label_helloUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_helloUser.Name = "label_helloUser";
            this.label_helloUser.Size = new System.Drawing.Size(0, 15);
            this.label_helloUser.TabIndex = 0;
            // 
            // button_userSearch
            // 
            this.button_userSearch.Location = new System.Drawing.Point(265, 16);
            this.button_userSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_userSearch.Name = "button_userSearch";
            this.button_userSearch.Size = new System.Drawing.Size(100, 29);
            this.button_userSearch.TabIndex = 1;
            this.button_userSearch.Text = "search";
            this.button_userSearch.UseVisualStyleBackColor = true;
            this.button_userSearch.Click += new System.EventHandler(this.button_userSearch_Click);
            // 
            // dGV_userInfo
            // 
            this.dGV_userInfo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dGV_userInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_userInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userNumber,
            this.userDestination,
            this.userID,
            this.userPasswd,
            this.Options,
            this.userInfoID});
            this.dGV_userInfo.Location = new System.Drawing.Point(265, 116);
            this.dGV_userInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dGV_userInfo.Name = "dGV_userInfo";
            this.dGV_userInfo.RowHeadersVisible = false;
            this.dGV_userInfo.RowHeadersWidth = 51;
            this.dGV_userInfo.RowTemplate.Height = 23;
            this.dGV_userInfo.Size = new System.Drawing.Size(631, 365);
            this.dGV_userInfo.TabIndex = 2;
            this.dGV_userInfo.Visible = false;
            this.dGV_userInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_userInfo_CellContentClick);
            // 
            // userNumber
            // 
            this.userNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.userNumber.HeaderText = "No";
            this.userNumber.MinimumWidth = 6;
            this.userNumber.Name = "userNumber";
            this.userNumber.ReadOnly = true;
            this.userNumber.Width = 52;
            // 
            // userDestination
            // 
            this.userDestination.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userDestination.HeaderText = "Destination";
            this.userDestination.MinimumWidth = 6;
            this.userDestination.Name = "userDestination";
            // 
            // userID
            // 
            this.userID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userID.HeaderText = "ID";
            this.userID.MinimumWidth = 6;
            this.userID.Name = "userID";
            // 
            // userPasswd
            // 
            this.userPasswd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userPasswd.HeaderText = "Passwd";
            this.userPasswd.MinimumWidth = 6;
            this.userPasswd.Name = "userPasswd";
            // 
            // Options
            // 
            this.Options.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Options.HeaderText = "Options";
            this.Options.MinimumWidth = 6;
            this.Options.Name = "Options";
            // 
            // userInfoID
            // 
            this.userInfoID.HeaderText = "Info_id";
            this.userInfoID.MinimumWidth = 6;
            this.userInfoID.Name = "userInfoID";
            this.userInfoID.Visible = false;
            this.userInfoID.Width = 125;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(373, 16);
            this.button_add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(100, 29);
            this.button_add.TabIndex = 3;
            this.button_add.Text = "+";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(481, 16);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Edit Profile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GMForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 482);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.dGV_userInfo);
            this.Controls.Add(this.button_userSearch);
            this.Controls.Add(this.label_helloUser);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GMForm";
            this.Text = "General Manager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GMForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_userInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_helloUser;
        private System.Windows.Forms.Button button_userSearch;
        private System.Windows.Forms.DataGridView dGV_userInfo;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDestination;
        private System.Windows.Forms.DataGridViewTextBoxColumn userID;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPasswd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Options;
        private System.Windows.Forms.DataGridViewTextBoxColumn userInfoID;
        private System.Windows.Forms.Button button1;
    }
}