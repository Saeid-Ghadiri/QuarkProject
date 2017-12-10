using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quark.Forms
{
    //public partial class BackupAndRestoreDatabaseForm : Form
    public partial class BackupAndRestoreDatabaseForm : Infrastructure.BaseForm
    {
        #region form load
        public BackupAndRestoreDatabaseForm()
        {
            InitializeComponent();
        }

        private void BackupAndRestoreDatabaseForm_Load(object sender, EventArgs e)
        {

        }
        #endregion /form load

        #region Backup Database
        private void Backup(string BackupQuarkDB)

        {

            try

            {

                string command = @"Backup DataBase Quark To Disk='" + BackupQuarkDB + "'";

                this.Cursor = Cursors.WaitCursor;

                System.Data.SqlClient.SqlCommand ocommand = null;

                System.Data.SqlClient.SqlConnection oconnection = null;

                oconnection = new System.Data.SqlClient.SqlConnection("Data Source=(local);Initial Catalog=Quark ;user id=sa");

                if (oconnection.State != ConnectionState.Open)

                    oconnection.Open();

                ocommand = new System.Data.SqlClient.SqlCommand(command, oconnection);

                ocommand.ExecuteNonQuery();

                this.Cursor = Cursors.Default;

                MessageBox.Show("تهیه نسخه پشتیبان از اطلا عات با موفقیت انجام شد");

            }

            catch (Exception ex)

            {

                MessageBox.Show("Error : ", ex.Message);

            }

        }

        #endregion /Backup Database
        private void Restore(string BackupQuarkDB)

        {

            try

            {

                string command = @"ALTER DATABASE Quark  SET SINGLE_USER with ROLLBACK IMMEDIATE " + " USE master " + " RESTORE DATABASE Quark FROM DISK= N'" + BackupQuarkDB + "' WITH REPLACE";

                //string command = @"RESTORE DATABASE  DBName FROM DISK ='" + filename + "' ";

                this.Cursor = Cursors.WaitCursor;

                System.Data.SqlClient.SqlCommand ocommand = null;

                System.Data.SqlClient.SqlConnection oconnection = null;

                oconnection = new System.Data.SqlClient.SqlConnection("Data Source=(local);Initial Catalog=DBName ;user id=sa");

                if (oconnection.State != ConnectionState.Open)

                    oconnection.Open();

                ocommand = new System.Data.SqlClient.SqlCommand(command, oconnection);

                ocommand.ExecuteNonQuery();

                this.Cursor = Cursors.Default;

                MessageBox.Show("بازیابی اطلاعات از  نسخه پشتیبان از  با موفقیت انجام شد");

            }

            catch (Exception ex)

            {

                MessageBox.Show("Error : ", ex.Message);

            }

        }


        #region  Resotre Database

        #endregion /Restore Database

        #region 
        #endregion

        #region 
        #endregion

        private void BackupDB_Click(object sender, EventArgs e)
        {
            string filename = string.Empty;

            SaveBackUp.OverwritePrompt = true;

            SaveBackUp.DefaultExt = "";

            SaveBackUp.Filter = @"SQL Backup Files ALL Files (*.*) |*.*| (*.Bak)|*.Bak";

            SaveBackUp.FilterIndex = 1;

            string DateDay = FarsiLibrary.Utils.PersianDate.Now.ToString().Substring(0, 10);//بر اساس تاریخ شمسی ذخیره می کند

            SaveBackUp.FileName = DateDay.Replace("/", "") + "_" + DateTime.Now.Hour.ToString() + "-" + DateTime.Now.Minute.ToString() + "-" + DateTime.Now.Second.ToString();

            SaveBackUp.Title = "Backup SQL File";

            if (SaveBackUp.ShowDialog() == DialogResult.OK)

            {

                filename = SaveBackUp.FileName;

                Backup(filename);

            }

        }

        private void RestoreDB_Click(object sender, EventArgs e)
        {
            string filename = string.Empty;

            OpenBackUp.Filter = @"SQL Backup Files ALL Files (*.*) |*.*| (*.Bak)|*.Bak";

            OpenBackUp.FilterIndex = 1;

            OpenBackUp.Filter = @"SQL Backup Files (*.*)|";



            string DateDay = FarsiLibrary.Utils.PersianDate.Now.ToString().Substring(0, 10);

            OpenBackUp.FileName = DateDay.Replace("/", "") + "_" + DateTime.Now.Hour.ToString() + "-" + DateTime.Now.Minute.ToString() + "-" + DateTime.Now.Second.ToString();

            if (OpenBackUp.ShowDialog() == DialogResult.OK)

            {

                filename = OpenBackUp.FileName;

                Restore(filename);

            }

        }

        private void btn_BackToMainForm_Click(object sender, EventArgs e)
        {
            Hide();

            MainForm f = 
                new MainForm();

            f.Show();
        }
    }
}
