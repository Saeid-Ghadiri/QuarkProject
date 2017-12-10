namespace Quark.Administrator
{
    partial class UserListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserListForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_info = new System.Windows.Forms.DataGridView();
            this.usersListBox = new System.Windows.Forms.ListBox();
            this.btn_BackToMainForm = new System.Windows.Forms.Button();
            this.btn_SearchUserList = new System.Windows.Forms.Button();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_info)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSalmon;
            this.groupBox1.Controls.Add(this.dgv_info);
            this.groupBox1.Controls.Add(this.usersListBox);
            this.groupBox1.Controls.Add(this.btn_BackToMainForm);
            this.groupBox1.Controls.Add(this.btn_SearchUserList);
            this.groupBox1.Controls.Add(this.fullNameTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(860, 769);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "  بروز رسانی اطلاعات پروفایل کاربر ";
            // 
            // dgv_info
            // 
            this.dgv_info.AllowUserToAddRows = false;
            this.dgv_info.AllowUserToDeleteRows = false;
            this.dgv_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_info.Location = new System.Drawing.Point(19, 379);
            this.dgv_info.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgv_info.Name = "dgv_info";
            this.dgv_info.ReadOnly = true;
            this.dgv_info.Size = new System.Drawing.Size(821, 222);
            this.dgv_info.TabIndex = 6;
            // 
            // usersListBox
            // 
            this.usersListBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.usersListBox.FormattingEnabled = true;
            this.usersListBox.ItemHeight = 33;
            this.usersListBox.Location = new System.Drawing.Point(280, 158);
            this.usersListBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.usersListBox.Name = "usersListBox";
            this.usersListBox.Size = new System.Drawing.Size(410, 202);
            this.usersListBox.TabIndex = 4;
            this.usersListBox.DoubleClick += new System.EventHandler(this.usersListBox_DoubleClick);
            // 
            // btn_BackToMainForm
            // 
            this.btn_BackToMainForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_BackToMainForm.Font = new System.Drawing.Font("B Mitra", 13F);
            this.btn_BackToMainForm.Image = ((System.Drawing.Image)(resources.GetObject("btn_BackToMainForm.Image")));
            this.btn_BackToMainForm.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_BackToMainForm.Location = new System.Drawing.Point(19, 687);
            this.btn_BackToMainForm.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_BackToMainForm.Name = "btn_BackToMainForm";
            this.btn_BackToMainForm.Size = new System.Drawing.Size(257, 69);
            this.btn_BackToMainForm.TabIndex = 5;
            this.btn_BackToMainForm.Text = "بازگشت به فرم اصلی";
            this.btn_BackToMainForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BackToMainForm.UseVisualStyleBackColor = true;
            this.btn_BackToMainForm.Click += new System.EventHandler(this.btn_BackToMainForm_Click);
            // 
            // btn_SearchUserList
            // 
            this.btn_SearchUserList.Font = new System.Drawing.Font("B Mitra", 13F);
            this.btn_SearchUserList.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SearchUserList.Location = new System.Drawing.Point(36, 62);
            this.btn_SearchUserList.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_SearchUserList.Name = "btn_SearchUserList";
            this.btn_SearchUserList.Size = new System.Drawing.Size(202, 69);
            this.btn_SearchUserList.TabIndex = 2;
            this.btn_SearchUserList.Text = "جستجو";
            this.btn_SearchUserList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SearchUserList.UseVisualStyleBackColor = true;
            this.btn_SearchUserList.Click += new System.EventHandler(this.btn_SearchUserList_Click);
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fullNameTextBox.Location = new System.Drawing.Point(280, 75);
            this.fullNameTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.fullNameTextBox.Multiline = true;
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(410, 54);
            this.fullNameTextBox.TabIndex = 1;
            this.fullNameTextBox.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(702, 158);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "لیست کاربران:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(702, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 33);
            this.label3.TabIndex = 0;
            this.label3.Text = "نام و نام خانوادگی:";
            // 
            // UserListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 769);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.Name = "UserListForm";
            this.Text = "UserListForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserListForm_FormClosed);
            this.Load += new System.EventHandler(this.UserListForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_info)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_info;
        private System.Windows.Forms.ListBox usersListBox;
        private System.Windows.Forms.Button btn_BackToMainForm;
        private System.Windows.Forms.Button btn_SearchUserList;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}