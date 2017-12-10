namespace Quark.Forms
{
    partial class BaseSettingForm
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
            this.faDatePicker1 = new FarsiLibrary.Win.Controls.FADatePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDirectCast = new System.Windows.Forms.Label();
            this.lblPersianDateCtor = new System.Windows.Forms.Label();
            this.lblTodayPersianDateWithName = new System.Windows.Forms.Label();
            this.lblTodayPersianDate = new System.Windows.Forms.Label();
            this.lblTodayPersian = new System.Windows.Forms.Label();
            this.lblTodayGregorian = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_ConvertNumberToText = new System.Windows.Forms.Button();
            this.txt_Number = new System.Windows.Forms.TextBox();
            this.lblResult_ChangeNumToTxt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeSelector1 = new Atf.UI.DateTimeSelector();
            this.faDatePicker2 = new FarsiLibrary.Win.Controls.FADatePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.faDatePicker1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.lblDirectCast);
            this.groupBox1.Controls.Add(this.lblPersianDateCtor);
            this.groupBox1.Controls.Add(this.lblTodayPersianDateWithName);
            this.groupBox1.Controls.Add(this.lblTodayPersianDate);
            this.groupBox1.Controls.Add(this.lblTodayPersian);
            this.groupBox1.Controls.Add(this.lblTodayGregorian);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(996, 224);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Persian Date Time ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // faDatePicker1
            // 
            this.faDatePicker1.Location = new System.Drawing.Point(563, 20);
            this.faDatePicker1.Name = "faDatePicker1";
            this.faDatePicker1.Size = new System.Drawing.Size(211, 20);
            this.faDatePicker1.TabIndex = 6;
            this.faDatePicker1.Tag = "";
            this.faDatePicker1.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2003;
            this.faDatePicker1.SelectedDateTimeChanged += new System.EventHandler(this.faDatePicker1_SelectedDateTimeChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(216, 20);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 30);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // lblDirectCast
            // 
            this.lblDirectCast.AutoSize = true;
            this.lblDirectCast.Location = new System.Drawing.Point(6, 108);
            this.lblDirectCast.Name = "lblDirectCast";
            this.lblDirectCast.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDirectCast.Size = new System.Drawing.Size(103, 22);
            this.lblDirectCast.TabIndex = 4;
            this.lblDirectCast.Text = "lblDirectCast:";
            // 
            // lblPersianDateCtor
            // 
            this.lblPersianDateCtor.AutoSize = true;
            this.lblPersianDateCtor.Location = new System.Drawing.Point(6, 86);
            this.lblPersianDateCtor.Name = "lblPersianDateCtor";
            this.lblPersianDateCtor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPersianDateCtor.Size = new System.Drawing.Size(146, 22);
            this.lblPersianDateCtor.TabIndex = 3;
            this.lblPersianDateCtor.Text = "lblPersianDateCtor:";
            // 
            // lblTodayPersianDateWithName
            // 
            this.lblTodayPersianDateWithName.AutoSize = true;
            this.lblTodayPersianDateWithName.Location = new System.Drawing.Point(6, 130);
            this.lblTodayPersianDateWithName.Name = "lblTodayPersianDateWithName";
            this.lblTodayPersianDateWithName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTodayPersianDateWithName.Size = new System.Drawing.Size(233, 22);
            this.lblTodayPersianDateWithName.TabIndex = 2;
            this.lblTodayPersianDateWithName.Text = "lblTodayPersianDateWithName:";
            // 
            // lblTodayPersianDate
            // 
            this.lblTodayPersianDate.AutoSize = true;
            this.lblTodayPersianDate.Location = new System.Drawing.Point(6, 64);
            this.lblTodayPersianDate.Name = "lblTodayPersianDate";
            this.lblTodayPersianDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTodayPersianDate.Size = new System.Drawing.Size(159, 22);
            this.lblTodayPersianDate.TabIndex = 2;
            this.lblTodayPersianDate.Text = "lblTodayPersianDate:";
            // 
            // lblTodayPersian
            // 
            this.lblTodayPersian.AutoSize = true;
            this.lblTodayPersian.Location = new System.Drawing.Point(6, 42);
            this.lblTodayPersian.Name = "lblTodayPersian";
            this.lblTodayPersian.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTodayPersian.Size = new System.Drawing.Size(124, 22);
            this.lblTodayPersian.TabIndex = 1;
            this.lblTodayPersian.Text = "lblTodayPersian:";
            // 
            // lblTodayGregorian
            // 
            this.lblTodayGregorian.AutoSize = true;
            this.lblTodayGregorian.Location = new System.Drawing.Point(6, 20);
            this.lblTodayGregorian.Name = "lblTodayGregorian";
            this.lblTodayGregorian.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTodayGregorian.Size = new System.Drawing.Size(142, 22);
            this.lblTodayGregorian.TabIndex = 0;
            this.lblTodayGregorian.Text = "lblTodayGregorian:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_ConvertNumberToText);
            this.groupBox2.Controls.Add(this.txt_Number);
            this.groupBox2.Controls.Add(this.lblResult_ChangeNumToTxt);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(0, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(433, 201);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Number To Text";
            // 
            // btn_ConvertNumberToText
            // 
            this.btn_ConvertNumberToText.Location = new System.Drawing.Point(28, 159);
            this.btn_ConvertNumberToText.Name = "btn_ConvertNumberToText";
            this.btn_ConvertNumberToText.Size = new System.Drawing.Size(93, 36);
            this.btn_ConvertNumberToText.TabIndex = 2;
            this.btn_ConvertNumberToText.Text = "Convert";
            this.btn_ConvertNumberToText.UseVisualStyleBackColor = true;
            this.btn_ConvertNumberToText.Click += new System.EventHandler(this.btn_ConvertNumberToText_Click);
            // 
            // txt_Number
            // 
            this.txt_Number.Location = new System.Drawing.Point(28, 50);
            this.txt_Number.Name = "txt_Number";
            this.txt_Number.Size = new System.Drawing.Size(342, 30);
            this.txt_Number.TabIndex = 1;
            // 
            // lblResult_ChangeNumToTxt
            // 
            this.lblResult_ChangeNumToTxt.AutoSize = true;
            this.lblResult_ChangeNumToTxt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblResult_ChangeNumToTxt.Location = new System.Drawing.Point(183, 98);
            this.lblResult_ChangeNumToTxt.Name = "lblResult_ChangeNumToTxt";
            this.lblResult_ChangeNumToTxt.Size = new System.Drawing.Size(0, 22);
            this.lblResult_ChangeNumToTxt.TabIndex = 0;
            this.lblResult_ChangeNumToTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "نتیجه:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "عدد:";
            // 
            // dateTimeSelector1
            // 
            this.dateTimeSelector1.Location = new System.Drawing.Point(851, 280);
            this.dateTimeSelector1.Name = "dateTimeSelector1";
            this.dateTimeSelector1.Size = new System.Drawing.Size(100, 31);
            this.dateTimeSelector1.TabIndex = 2;
            // 
            // faDatePicker2
            // 
            this.faDatePicker2.FormatInfo = FarsiLibrary.Win.Enums.FormatInfoTypes.FullDateTime;
            this.faDatePicker2.Location = new System.Drawing.Point(536, 318);
            this.faDatePicker2.Name = "faDatePicker2";
            this.faDatePicker2.Size = new System.Drawing.Size(210, 20);
            this.faDatePicker2.TabIndex = 3;
            this.faDatePicker2.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2003;
            // 
            // BaseSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.faDatePicker2);
            this.Controls.Add(this.dateTimeSelector1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 726);
            this.Name = "BaseSettingForm";
            this.Text = "تنظیمات پایه سامانه";
            this.Load += new System.EventHandler(this.BaseSettingForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDirectCast;
        private System.Windows.Forms.Label lblPersianDateCtor;
        private System.Windows.Forms.Label lblTodayPersianDate;
        private System.Windows.Forms.Label lblTodayPersian;
        private System.Windows.Forms.Label lblTodayGregorian;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_ConvertNumberToText;
        private System.Windows.Forms.TextBox txt_Number;
        private System.Windows.Forms.Label lblResult_ChangeNumToTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FarsiLibrary.Win.Controls.FADatePicker faDatePicker1;
        private System.Windows.Forms.Label lblTodayPersianDateWithName;
        private Atf.UI.DateTimeSelector dateTimeSelector1;
        private FarsiLibrary.Win.Controls.FADatePicker faDatePicker2;
    }
}