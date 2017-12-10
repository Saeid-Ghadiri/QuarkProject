namespace Quark.Forms
{
    partial class BackupAndRestoreDatabaseForm
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
            this.RestoreDB = new System.Windows.Forms.Button();
            this.BackupDB = new System.Windows.Forms.Button();
            this.SaveBackUp = new System.Windows.Forms.SaveFileDialog();
            this.OpenBackUp = new System.Windows.Forms.OpenFileDialog();
            this.btn_BackToMainForm = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_BackToMainForm);
            this.groupBox1.Controls.Add(this.RestoreDB);
            this.groupBox1.Controls.Add(this.BackupDB);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(635, 416);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ذخیره بانک اطلاعاتی و برگردان بانک اطلاعاتی";
            // 
            // RestoreDB
            // 
            this.RestoreDB.Location = new System.Drawing.Point(345, 227);
            this.RestoreDB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RestoreDB.Name = "RestoreDB";
            this.RestoreDB.Size = new System.Drawing.Size(144, 50);
            this.RestoreDB.TabIndex = 0;
            this.RestoreDB.Text = "Restore Database";
            this.RestoreDB.UseVisualStyleBackColor = true;
            this.RestoreDB.Click += new System.EventHandler(this.RestoreDB_Click);
            // 
            // BackupDB
            // 
            this.BackupDB.Location = new System.Drawing.Point(345, 143);
            this.BackupDB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BackupDB.Name = "BackupDB";
            this.BackupDB.Size = new System.Drawing.Size(144, 50);
            this.BackupDB.TabIndex = 0;
            this.BackupDB.Text = "Backup Database";
            this.BackupDB.UseVisualStyleBackColor = true;
            this.BackupDB.Click += new System.EventHandler(this.BackupDB_Click);
            // 
            // OpenBackUp
            // 
            this.OpenBackUp.FileName = "OpenBackUp";
            // 
            // btn_BackToMainForm
            // 
            this.btn_BackToMainForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_BackToMainForm.Image = global::Quark.Properties.Resources.previous1;
            this.btn_BackToMainForm.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_BackToMainForm.Location = new System.Drawing.Point(5, 362);
            this.btn_BackToMainForm.Name = "btn_BackToMainForm";
            this.btn_BackToMainForm.Size = new System.Drawing.Size(147, 49);
            this.btn_BackToMainForm.TabIndex = 9;
            this.btn_BackToMainForm.Text = "برگشت به فرم اصلی";
            this.btn_BackToMainForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BackToMainForm.UseVisualStyleBackColor = true;
            this.btn_BackToMainForm.Click += new System.EventHandler(this.btn_BackToMainForm_Click);
            // 
            // BackupAndRestoreDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 416);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Name = "BackupAndRestoreDatabaseForm";
            this.Text = "BackupAndRestoreDatabaseForm";
            this.Load += new System.EventHandler(this.BackupAndRestoreDatabaseForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button RestoreDB;
        private System.Windows.Forms.Button BackupDB;
        private System.Windows.Forms.SaveFileDialog SaveBackUp;
        private System.Windows.Forms.OpenFileDialog OpenBackUp;
        private System.Windows.Forms.Button btn_BackToMainForm;
    }
}