namespace Quark.Forms
{
    partial class ChangePasswordForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.oldPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_InsertToDB = new System.Windows.Forms.Button();
            this.newPasswordTextBox = new System.Windows.Forms.TextBox();
            this.confirmNewPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_BackToMainForm = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btn_BackToMainForm);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("B Mitra", 13F);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(1089, 705);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " تغییر گذرواژه کاربر ";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(19, 88);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox3.Size = new System.Drawing.Size(494, 488);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "تولید رمز عبور جدید";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.oldPasswordTextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btn_InsertToDB);
            this.groupBox2.Controls.Add(this.newPasswordTextBox);
            this.groupBox2.Controls.Add(this.confirmNewPasswordTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(523, 88);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox2.Size = new System.Drawing.Size(553, 488);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "  تغییر رمز عبور  ";
            // 
            // oldPasswordTextBox
            // 
            this.oldPasswordTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.oldPasswordTextBox.Location = new System.Drawing.Point(25, 117);
            this.oldPasswordTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.oldPasswordTextBox.Multiline = true;
            this.oldPasswordTextBox.Name = "oldPasswordTextBox";
            this.oldPasswordTextBox.Size = new System.Drawing.Size(349, 54);
            this.oldPasswordTextBox.TabIndex = 1;
            this.oldPasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.oldPasswordTextBox.UseSystemPasswordChar = true;
            this.oldPasswordTextBox.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "گذرواژه فعلی:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(384, 199);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "گذرواژه جدید:";
            // 
            // btn_InsertToDB
            // 
            this.btn_InsertToDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_InsertToDB.Image = global::Quark.Properties.Resources.success;
            this.btn_InsertToDB.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_InsertToDB.Location = new System.Drawing.Point(347, 406);
            this.btn_InsertToDB.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_InsertToDB.Name = "btn_InsertToDB";
            this.btn_InsertToDB.Size = new System.Drawing.Size(196, 74);
            this.btn_InsertToDB.TabIndex = 6;
            this.btn_InsertToDB.Text = "ذخیره داده";
            this.btn_InsertToDB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_InsertToDB.UseVisualStyleBackColor = true;
            this.btn_InsertToDB.Click += new System.EventHandler(this.btn_InsertToDB_Click);
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.newPasswordTextBox.Location = new System.Drawing.Point(25, 181);
            this.newPasswordTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.newPasswordTextBox.Multiline = true;
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.Size = new System.Drawing.Size(349, 54);
            this.newPasswordTextBox.TabIndex = 3;
            this.newPasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.newPasswordTextBox.UseSystemPasswordChar = true;
            this.newPasswordTextBox.WordWrap = false;
            // 
            // confirmNewPasswordTextBox
            // 
            this.confirmNewPasswordTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.confirmNewPasswordTextBox.Location = new System.Drawing.Point(25, 246);
            this.confirmNewPasswordTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.confirmNewPasswordTextBox.Multiline = true;
            this.confirmNewPasswordTextBox.Name = "confirmNewPasswordTextBox";
            this.confirmNewPasswordTextBox.Size = new System.Drawing.Size(349, 54);
            this.confirmNewPasswordTextBox.TabIndex = 5;
            this.confirmNewPasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.confirmNewPasswordTextBox.UseSystemPasswordChar = true;
            this.confirmNewPasswordTextBox.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 264);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "تکرار گذرواژه جدید:";
            // 
            // btn_BackToMainForm
            // 
            this.btn_BackToMainForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_BackToMainForm.Image = global::Quark.Properties.Resources.previous1;
            this.btn_BackToMainForm.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_BackToMainForm.Location = new System.Drawing.Point(19, 618);
            this.btn_BackToMainForm.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_BackToMainForm.Name = "btn_BackToMainForm";
            this.btn_BackToMainForm.Size = new System.Drawing.Size(243, 74);
            this.btn_BackToMainForm.TabIndex = 7;
            this.btn_BackToMainForm.Text = "برگشت به فرم اصلی";
            this.btn_BackToMainForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BackToMainForm.UseVisualStyleBackColor = true;
            this.btn_BackToMainForm.Click += new System.EventHandler(this.btn_BackToMainForm_Click);
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 705);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.Name = "ChangePasswordForm";
            this.Load += new System.EventHandler(this.ChangePasswordForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox oldPasswordTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_InsertToDB;
        private System.Windows.Forms.TextBox newPasswordTextBox;
        private System.Windows.Forms.TextBox confirmNewPasswordTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_BackToMainForm;
    }
}