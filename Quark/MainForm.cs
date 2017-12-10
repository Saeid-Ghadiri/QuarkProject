using System.Linq;
using System.Data.Entity;

namespace Quark
{
    //public partial class MainForm : Form
    public partial class MainForm : Infrastructure.BaseForm
    {

        #region Form Load
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, System.EventArgs e)
        {
            //**********************************
            PersianCal();
            //**********************************

            //**********************************
            UserActivity();
            //**********************************

            //**********************************
            CenterForm();
            //**********************************
        }
        private void MainForm_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        protected override void OnShown(System.EventArgs e)
        {
            base.OnShown(e);

            this.WindowState =
                System.Windows.Forms.FormWindowState.Maximized;
        }

        private void CenterForm()
        {
            System.Drawing.Point center = new System.Drawing.Point();
            center.X = (System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width - Width) / 2;
            center.Y = (System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height - Height) / 2;

            Location = center;
        }
        #endregion / Form Load

        #region Status Bar

        #region Persian DateTime
        private void PersianCal()
        {

            //lblTodayPersian.Text = FarsiLibrary.Utils.PersianDateConverter.ToPersianDate(System.DateTime.Now).ToString();
            //lblTodayPersianDate.Text = FarsiLibrary.Utils.PersianDate.Now.ToWritten();
            lblDateTimePersianCal.Text = new FarsiLibrary.Utils.PersianDate(System.DateTime.Now).ToString("F");

        }
        #endregion / Persian DateTime

        #region User Activity
        private void UserActivity()
        {
            //lbl_UsernameLoginStatusLable.Text = string.Format("خوش آمدید {0}!", Infrastructure.Utility.AuthenticatedUser.Username);

            lbl_UsernameLoginStatusLable.Text = string.Format(Infrastructure.Utility.AuthenticatedUser.FullName, "خوش آمدید {0}!");
        }
        #endregion / User Activity

        #endregion / Status Bar

        #region 
        #endregion

        #region 
        #endregion

        #region Menu

        private void menuBaseSettingToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Forms.BaseSettingForm f = new Forms.BaseSettingForm();

            f.ShowDialog();
        }

        private void menuAppExitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ToolSet.AppMessageBox msgbox = 
                new ToolSet.AppMessageBox();

            msgbox.ApplicationExit();
        }

        private void menuPhonebookToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Forms.PhonebookForm f = new Forms.PhonebookForm();

            f.ShowDialog();
        }

        private void UserListToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Administrator.UserListForm f = new Administrator.UserListForm();

            f.ShowDialog();
        }

        private void UpdateUserListToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Administrator.UpdateUserProfileForm f = new Administrator.UpdateUserProfileForm();

            f.ShowDialog();
        }

        private void vScrollBar1_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
        {

        }

        private void countriesToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Forms.CountryForm f = new Forms.CountryForm();

            f.ShowDialog();
        }

        private void backandrestoreDatabaseToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Forms.BackupAndRestoreDatabaseForm f = new Forms.BackupAndRestoreDatabaseForm();

            f.ShowDialog();
        }

        private void changepassuserMenutoolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Forms.ChangePasswordForm f = new Forms.ChangePasswordForm();

            f.ShowDialog();
        }
        #endregion / Menu

    }
}
