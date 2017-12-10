namespace Quark.Forms
{
    partial class UpdateProfileForm
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
            this.btn_BackToMainForm = new System.Windows.Forms.Button();
            this.btn_UpdateSave = new System.Windows.Forms.Button();
            this.descriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox1.Controls.Add(this.btn_BackToMainForm);
            this.groupBox1.Controls.Add(this.btn_UpdateSave);
            this.groupBox1.Controls.Add(this.descriptionTextBox);
            this.groupBox1.Controls.Add(this.fullNameTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 470);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بروز رسانی پروفایل کاربر";
            // 
            // btn_BackToMainForm
            // 
            this.btn_BackToMainForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_BackToMainForm.Font = new System.Drawing.Font("B Mitra", 13F);
            this.btn_BackToMainForm.Image = global::Quark.Properties.Resources.previous1;
            this.btn_BackToMainForm.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_BackToMainForm.Location = new System.Drawing.Point(6, 419);
            this.btn_BackToMainForm.Name = "btn_BackToMainForm";
            this.btn_BackToMainForm.Size = new System.Drawing.Size(160, 45);
            this.btn_BackToMainForm.TabIndex = 5;
            this.btn_BackToMainForm.Text = "بازگشت به فرم اصلی";
            this.btn_BackToMainForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BackToMainForm.UseVisualStyleBackColor = true;
            this.btn_BackToMainForm.Click += new System.EventHandler(this.btn_BackToMainForm_Click);
            // 
            // btn_UpdateSave
            // 
            this.btn_UpdateSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_UpdateSave.Font = new System.Drawing.Font("B Mitra", 13F);
            this.btn_UpdateSave.Image = global::Quark.Properties.Resources._checked;
            this.btn_UpdateSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_UpdateSave.Location = new System.Drawing.Point(480, 419);
            this.btn_UpdateSave.Name = "btn_UpdateSave";
            this.btn_UpdateSave.Size = new System.Drawing.Size(130, 45);
            this.btn_UpdateSave.TabIndex = 4;
            this.btn_UpdateSave.Text = "ذخیره داده ها";
            this.btn_UpdateSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_UpdateSave.UseVisualStyleBackColor = true;
            this.btn_UpdateSave.Click += new System.EventHandler(this.btn_UpdateSave_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.descriptionTextBox.Location = new System.Drawing.Point(12, 85);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(492, 265);
            this.descriptionTextBox.TabIndex = 3;
            this.descriptionTextBox.Text = "";
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fullNameTextBox.Location = new System.Drawing.Point(239, 39);
            this.fullNameTextBox.Multiline = true;
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(265, 34);
            this.fullNameTextBox.TabIndex = 1;
            this.fullNameTextBox.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(510, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "توضیحات:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(510, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "نام و نام خانوادگی:";
            // 
            // UpdateProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 470);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "UpdateProfileForm";
            this.Load += new System.EventHandler(this.UpdateProfileForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_BackToMainForm;
        private System.Windows.Forms.Button btn_UpdateSave;
        private System.Windows.Forms.RichTextBox descriptionTextBox;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}