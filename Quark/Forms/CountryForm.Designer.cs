namespace Quark.Forms
{
    partial class CountryForm
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
            this.btnAddNewCountry = new System.Windows.Forms.Button();
            this.btnCheckStates = new System.Windows.Forms.Button();
            this.txtCountryName = new System.Windows.Forms.TextBox();
            this.btnDeleteACountryByName = new System.Windows.Forms.Button();
            this.lstCountries = new System.Windows.Forms.ListBox();
            this.btnShowAllCountries = new System.Windows.Forms.Button();
            this.btnAddSomeNewCountries = new System.Windows.Forms.Button();
            this.btnDeleteAllCountries = new System.Windows.Forms.Button();
            this.btn_BackToMainForm = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddNewCountry);
            this.groupBox1.Controls.Add(this.btnCheckStates);
            this.groupBox1.Controls.Add(this.txtCountryName);
            this.groupBox1.Controls.Add(this.btnDeleteACountryByName);
            this.groupBox1.Controls.Add(this.lstCountries);
            this.groupBox1.Controls.Add(this.btnShowAllCountries);
            this.groupBox1.Controls.Add(this.btnAddSomeNewCountries);
            this.groupBox1.Controls.Add(this.btnDeleteAllCountries);
            this.groupBox1.Controls.Add(this.btn_BackToMainForm);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(768, 485);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "فرم اطلاعات کشورها";
            // 
            // btnAddNewCountry
            // 
            this.btnAddNewCountry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewCountry.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewCountry.Location = new System.Drawing.Point(355, 382);
            this.btnAddNewCountry.Name = "btnAddNewCountry";
            this.btnAddNewCountry.Size = new System.Drawing.Size(373, 37);
            this.btnAddNewCountry.TabIndex = 23;
            this.btnAddNewCountry.Text = "Add New Country";
            this.btnAddNewCountry.UseVisualStyleBackColor = true;
            this.btnAddNewCountry.Click += new System.EventHandler(this.btnAddNewCountry_Click);
            // 
            // btnCheckStates
            // 
            this.btnCheckStates.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckStates.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckStates.Location = new System.Drawing.Point(355, 339);
            this.btnCheckStates.Name = "btnCheckStates";
            this.btnCheckStates.Size = new System.Drawing.Size(373, 37);
            this.btnCheckStates.TabIndex = 22;
            this.btnCheckStates.Text = "Check States (First Delete All Countries & Then Add Some New Countries)";
            this.btnCheckStates.UseVisualStyleBackColor = true;
            this.btnCheckStates.Click += new System.EventHandler(this.btnCheckStates_Click);
            // 
            // txtCountryName
            // 
            this.txtCountryName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCountryName.Location = new System.Drawing.Point(355, 305);
            this.txtCountryName.Name = "txtCountryName";
            this.txtCountryName.Size = new System.Drawing.Size(373, 30);
            this.txtCountryName.TabIndex = 21;
            // 
            // btnDeleteACountryByName
            // 
            this.btnDeleteACountryByName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteACountryByName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteACountryByName.Location = new System.Drawing.Point(355, 265);
            this.btnDeleteACountryByName.Name = "btnDeleteACountryByName";
            this.btnDeleteACountryByName.Size = new System.Drawing.Size(373, 37);
            this.btnDeleteACountryByName.TabIndex = 20;
            this.btnDeleteACountryByName.Text = "Delete A Country By Name";
            this.btnDeleteACountryByName.UseVisualStyleBackColor = true;
            this.btnDeleteACountryByName.Click += new System.EventHandler(this.btnDeleteACountryByName_Click);
            // 
            // lstCountries
            // 
            this.lstCountries.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstCountries.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCountries.FormattingEnabled = true;
            this.lstCountries.ItemHeight = 14;
            this.lstCountries.Location = new System.Drawing.Point(355, 123);
            this.lstCountries.Name = "lstCountries";
            this.lstCountries.Size = new System.Drawing.Size(373, 74);
            this.lstCountries.TabIndex = 18;
            // 
            // btnShowAllCountries
            // 
            this.btnShowAllCountries.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowAllCountries.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllCountries.Location = new System.Drawing.Point(355, 76);
            this.btnShowAllCountries.Name = "btnShowAllCountries";
            this.btnShowAllCountries.Size = new System.Drawing.Size(373, 37);
            this.btnShowAllCountries.TabIndex = 17;
            this.btnShowAllCountries.Text = "Show All Countries";
            this.btnShowAllCountries.UseVisualStyleBackColor = true;
            this.btnShowAllCountries.Click += new System.EventHandler(this.btnShowAllCountries_Click);
            // 
            // btnAddSomeNewCountries
            // 
            this.btnAddSomeNewCountries.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddSomeNewCountries.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSomeNewCountries.Location = new System.Drawing.Point(355, 33);
            this.btnAddSomeNewCountries.Name = "btnAddSomeNewCountries";
            this.btnAddSomeNewCountries.Size = new System.Drawing.Size(373, 37);
            this.btnAddSomeNewCountries.TabIndex = 16;
            this.btnAddSomeNewCountries.Text = "Add Some New Countries";
            this.btnAddSomeNewCountries.UseVisualStyleBackColor = true;
            this.btnAddSomeNewCountries.Click += new System.EventHandler(this.btnAddSomeNewCountries_Click);
            // 
            // btnDeleteAllCountries
            // 
            this.btnDeleteAllCountries.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteAllCountries.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAllCountries.Location = new System.Drawing.Point(355, 223);
            this.btnDeleteAllCountries.Name = "btnDeleteAllCountries";
            this.btnDeleteAllCountries.Size = new System.Drawing.Size(373, 37);
            this.btnDeleteAllCountries.TabIndex = 19;
            this.btnDeleteAllCountries.Text = "Delete All Countries";
            this.btnDeleteAllCountries.UseVisualStyleBackColor = true;
            this.btnDeleteAllCountries.Click += new System.EventHandler(this.btnDeleteAllCountries_Click);
            // 
            // btn_BackToMainForm
            // 
            this.btn_BackToMainForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_BackToMainForm.Image = global::Quark.Properties.Resources.previous1;
            this.btn_BackToMainForm.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_BackToMainForm.Location = new System.Drawing.Point(9, 427);
            this.btn_BackToMainForm.Name = "btn_BackToMainForm";
            this.btn_BackToMainForm.Size = new System.Drawing.Size(147, 49);
            this.btn_BackToMainForm.TabIndex = 8;
            this.btn_BackToMainForm.Text = "برگشت به فرم اصلی";
            this.btn_BackToMainForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BackToMainForm.UseVisualStyleBackColor = true;
            this.btn_BackToMainForm.Click += new System.EventHandler(this.btn_BackToMainForm_Click);
            // 
            // CountryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 485);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "CountryForm";
            this.Text = "CountryForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_BackToMainForm;
        private System.Windows.Forms.Button btnAddNewCountry;
        private System.Windows.Forms.Button btnCheckStates;
        private System.Windows.Forms.TextBox txtCountryName;
        private System.Windows.Forms.Button btnDeleteACountryByName;
        private System.Windows.Forms.ListBox lstCountries;
        private System.Windows.Forms.Button btnShowAllCountries;
        private System.Windows.Forms.Button btnAddSomeNewCountries;
        private System.Windows.Forms.Button btnDeleteAllCountries;
    }
}