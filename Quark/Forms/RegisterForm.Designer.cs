namespace Quark.Forms
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.btn_ResetForm = new System.Windows.Forms.Button();
            this.btn_ExitApplication = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_InsertToDB = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSalmon;
            this.groupBox1.Controls.Add(this.fullNameTextBox);
            this.groupBox1.Controls.Add(this.passwordTextBox);
            this.groupBox1.Controls.Add(this.usernameTextBox);
            this.groupBox1.Controls.Add(this.btn_ResetForm);
            this.groupBox1.Controls.Add(this.btn_ExitApplication);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_InsertToDB);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.MaximumSize = new System.Drawing.Size(663, 431);
            this.groupBox1.MinimumSize = new System.Drawing.Size(663, 431);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(663, 431);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "کاربر جدید";
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fullNameTextBox.Location = new System.Drawing.Point(157, 217);
            this.fullNameTextBox.Multiline = true;
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(265, 37);
            this.fullNameTextBox.TabIndex = 5;
            this.fullNameTextBox.WordWrap = false;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.passwordTextBox.Location = new System.Drawing.Point(157, 174);
            this.passwordTextBox.Multiline = true;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(265, 37);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.passwordTextBox.WordWrap = false;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.usernameTextBox.Location = new System.Drawing.Point(157, 131);
            this.usernameTextBox.Multiline = true;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(265, 37);
            this.usernameTextBox.TabIndex = 1;
            this.usernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.usernameTextBox.WordWrap = false;
            // 
            // btn_ResetForm
            // 
            this.btn_ResetForm.Image = global::Quark.Properties.Resources.refresh;
            this.btn_ResetForm.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ResetForm.Location = new System.Drawing.Point(399, 375);
            this.btn_ResetForm.Name = "btn_ResetForm";
            this.btn_ResetForm.Size = new System.Drawing.Size(126, 50);
            this.btn_ResetForm.TabIndex = 7;
            this.btn_ResetForm.Text = "تکمیل مجدد";
            this.btn_ResetForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ResetForm.UseVisualStyleBackColor = true;
            this.btn_ResetForm.Click += new System.EventHandler(this.btn_ResetForm_Click);
            // 
            // btn_ExitApplication
            // 
            this.btn_ExitApplication.Image = global::Quark.Properties.Resources.power;
            this.btn_ExitApplication.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ExitApplication.Location = new System.Drawing.Point(6, 375);
            this.btn_ExitApplication.Name = "btn_ExitApplication";
            this.btn_ExitApplication.Size = new System.Drawing.Size(126, 50);
            this.btn_ExitApplication.TabIndex = 8;
            this.btn_ExitApplication.Text = "خروج از سامانه";
            this.btn_ExitApplication.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ExitApplication.UseVisualStyleBackColor = true;
            this.btn_ExitApplication.Click += new System.EventHandler(this.btn_ExitApplication_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(428, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "نام کاربری:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "نام و نام خانوادگی:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(428, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "گذرواژه:";
            // 
            // btn_InsertToDB
            // 
            this.btn_InsertToDB.Image = ((System.Drawing.Image)(resources.GetObject("btn_InsertToDB.Image")));
            this.btn_InsertToDB.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_InsertToDB.Location = new System.Drawing.Point(531, 375);
            this.btn_InsertToDB.Name = "btn_InsertToDB";
            this.btn_InsertToDB.Size = new System.Drawing.Size(126, 50);
            this.btn_InsertToDB.TabIndex = 6;
            this.btn_InsertToDB.Text = "ثبت داده ها";
            this.btn_InsertToDB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_InsertToDB.UseVisualStyleBackColor = true;
            this.btn_InsertToDB.Click += new System.EventHandler(this.btn_InsertToDB_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 431);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "RegisterForm";
            this.Text = "فرم ثبت نام کاربر مدیریت سیستم و کاربر برای کاربری سیستم";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Button btn_ResetForm;
        private System.Windows.Forms.Button btn_ExitApplication;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_InsertToDB;
    }
}