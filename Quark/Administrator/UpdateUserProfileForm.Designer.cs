namespace Quark.Administrator
{
    partial class UpdateUserProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateUserProfileForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_BackToMainForm = new System.Windows.Forms.Button();
            this.btn_UpdateSave = new System.Windows.Forms.Button();
            this.isAdminCheckBox = new System.Windows.Forms.CheckBox();
            this.isActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.descriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSalmon;
            this.groupBox1.Controls.Add(this.btn_BackToMainForm);
            this.groupBox1.Controls.Add(this.btn_UpdateSave);
            this.groupBox1.Controls.Add(this.isAdminCheckBox);
            this.groupBox1.Controls.Add(this.isActiveCheckBox);
            this.groupBox1.Controls.Add(this.descriptionTextBox);
            this.groupBox1.Controls.Add(this.fullNameTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(946, 642);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "  بروز رسانی اطلاعات پروفایل کاربر ";
            // 
            // btn_BackToMainForm
            // 
            this.btn_BackToMainForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_BackToMainForm.Font = new System.Drawing.Font("B Mitra", 13F);
            this.btn_BackToMainForm.Image = ((System.Drawing.Image)(resources.GetObject("btn_BackToMainForm.Image")));
            this.btn_BackToMainForm.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_BackToMainForm.Location = new System.Drawing.Point(19, 553);
            this.btn_BackToMainForm.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_BackToMainForm.Name = "btn_BackToMainForm";
            this.btn_BackToMainForm.Size = new System.Drawing.Size(257, 69);
            this.btn_BackToMainForm.TabIndex = 9;
            this.btn_BackToMainForm.Text = "بازگشت به فرم اصلی";
            this.btn_BackToMainForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BackToMainForm.UseVisualStyleBackColor = true;
            this.btn_BackToMainForm.Click += new System.EventHandler(this.btn_BackToMainForm_Click);
            // 
            // btn_UpdateSave
            // 
            this.btn_UpdateSave.Font = new System.Drawing.Font("B Mitra", 13F);
            this.btn_UpdateSave.Image = global::Quark.Properties.Resources.user3;
            this.btn_UpdateSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_UpdateSave.Location = new System.Drawing.Point(579, 553);
            this.btn_UpdateSave.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_UpdateSave.Name = "btn_UpdateSave";
            this.btn_UpdateSave.Size = new System.Drawing.Size(202, 69);
            this.btn_UpdateSave.TabIndex = 8;
            this.btn_UpdateSave.Text = "ذخیره داده ها";
            this.btn_UpdateSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_UpdateSave.UseVisualStyleBackColor = true;
            this.btn_UpdateSave.Click += new System.EventHandler(this.btn_UpdateSave_Click);
            // 
            // isAdminCheckBox
            // 
            this.isAdminCheckBox.AutoSize = true;
            this.isAdminCheckBox.Location = new System.Drawing.Point(589, 471);
            this.isAdminCheckBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.isAdminCheckBox.Name = "isAdminCheckBox";
            this.isAdminCheckBox.Size = new System.Drawing.Size(192, 37);
            this.isAdminCheckBox.TabIndex = 7;
            this.isAdminCheckBox.Text = "کاربر مدیر سیستم باشد";
            this.isAdminCheckBox.UseVisualStyleBackColor = true;
            // 
            // isActiveCheckBox
            // 
            this.isActiveCheckBox.AutoSize = true;
            this.isActiveCheckBox.Location = new System.Drawing.Point(640, 423);
            this.isActiveCheckBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.isActiveCheckBox.Name = "isActiveCheckBox";
            this.isActiveCheckBox.Size = new System.Drawing.Size(142, 37);
            this.isActiveCheckBox.TabIndex = 7;
            this.isActiveCheckBox.Text = "کاربر فعال باشد";
            this.isActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.descriptionTextBox.Location = new System.Drawing.Point(19, 136);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(763, 265);
            this.descriptionTextBox.TabIndex = 6;
            this.descriptionTextBox.Text = "";
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fullNameTextBox.Location = new System.Drawing.Point(372, 72);
            this.fullNameTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.fullNameTextBox.Multiline = true;
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(410, 54);
            this.fullNameTextBox.TabIndex = 5;
            this.fullNameTextBox.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(793, 136);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "توضیحات";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(793, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "نام و نام خانوادگی:";
            // 
            // UpdateUserProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 642);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.Name = "UpdateUserProfileForm";
            this.Text = "UpdateUserProfileForm";
            this.Load += new System.EventHandler(this.UpdateUserProfileForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_UpdateSave;
        private System.Windows.Forms.CheckBox isAdminCheckBox;
        private System.Windows.Forms.CheckBox isActiveCheckBox;
        private System.Windows.Forms.RichTextBox descriptionTextBox;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_BackToMainForm;
    }
}