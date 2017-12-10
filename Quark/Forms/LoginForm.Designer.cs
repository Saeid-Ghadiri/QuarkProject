namespace Quark.Forms
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
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Register = new System.Windows.Forms.Button();
            this.btn_Accept = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_ExitApplication = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Reset
            // 
            this.btn_Reset.Font = new System.Drawing.Font("B Mitra", 13F);
            this.btn_Reset.Image = global::Quark.Properties.Resources.refresh;
            this.btn_Reset.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Reset.Location = new System.Drawing.Point(280, 424);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(174, 59);
            this.btn_Reset.TabIndex = 17;
            this.btn_Reset.Text = "تکمیل مجدد اطلاعات";
            this.btn_Reset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Register
            // 
            this.btn_Register.Font = new System.Drawing.Font("B Mitra", 13F);
            this.btn_Register.Image = global::Quark.Properties.Resources.user3;
            this.btn_Register.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Register.Location = new System.Drawing.Point(30, 424);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(177, 59);
            this.btn_Register.TabIndex = 18;
            this.btn_Register.Text = "ایجاد کاربر جدید";
            this.btn_Register.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // btn_Accept
            // 
            this.btn_Accept.Font = new System.Drawing.Font("B Mitra", 13F);
            this.btn_Accept.Image = global::Quark.Properties.Resources.success;
            this.btn_Accept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Accept.Location = new System.Drawing.Point(522, 424);
            this.btn_Accept.Name = "btn_Accept";
            this.btn_Accept.Size = new System.Drawing.Size(161, 59);
            this.btn_Accept.TabIndex = 16;
            this.btn_Accept.Text = "ورود به سامانه";
            this.btn_Accept.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Accept.UseVisualStyleBackColor = true;
            this.btn_Accept.Click += new System.EventHandler(this.btn_Accept_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.Font = new System.Drawing.Font("Calibri", 14.5F);
            this.passwordTextBox.Location = new System.Drawing.Point(252, 262);
            this.passwordTextBox.Multiline = true;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(267, 36);
            this.passwordTextBox.TabIndex = 15;
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.usernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTextBox.Font = new System.Drawing.Font("Calibri", 14.5F);
            this.usernameTextBox.Location = new System.Drawing.Point(252, 220);
            this.usernameTextBox.Multiline = true;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(267, 36);
            this.usernameTextBox.TabIndex = 14;
            this.usernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("B Mitra", 18F);
            this.label1.Image = global::Quark.Properties.Resources.man;
            this.label1.Location = new System.Drawing.Point(202, 222);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 33);
            this.label1.TabIndex = 19;
            this.label1.Text = "      ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("B Mitra", 18F);
            this.label2.Image = global::Quark.Properties.Resources.key11;
            this.label2.Location = new System.Drawing.Point(202, 265);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 33);
            this.label2.TabIndex = 19;
            this.label2.Text = "      ";
            // 
            // lbl_ExitApplication
            // 
            this.lbl_ExitApplication.AutoSize = true;
            this.lbl_ExitApplication.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ExitApplication.Font = new System.Drawing.Font("B Mitra", 18F);
            this.lbl_ExitApplication.Image = global::Quark.Properties.Resources.cancel;
            this.lbl_ExitApplication.Location = new System.Drawing.Point(30, 27);
            this.lbl_ExitApplication.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ExitApplication.Name = "lbl_ExitApplication";
            this.lbl_ExitApplication.Size = new System.Drawing.Size(45, 33);
            this.lbl_ExitApplication.TabIndex = 19;
            this.lbl_ExitApplication.Text = "      ";
            this.lbl_ExitApplication.Click += new System.EventHandler(this.lbl_ExitApplication_Click);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btn_Accept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Quark.Properties.Resources.login2;
            this.ClientSize = new System.Drawing.Size(716, 650);
            this.Controls.Add(this.lbl_ExitApplication);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.btn_Accept);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "LoginForm";
            this.RightToLeftLayout = false;
            this.Text = "LoginForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.Click += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Button btn_Accept;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_ExitApplication;
        private System.Windows.Forms.Label label1;
    }
}