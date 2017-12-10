using System.Linq;
using System.Data.Entity;

namespace Quark.Forms
{
    public partial class LoginForm : Infrastructure.BaseForm
    {
        public LoginForm() : base()
        {
            InitializeComponent();
        }
        private void LoginForm_Load(object sender, System.EventArgs e)
        {
            //****************
            //Forms.BaseSettingForm();
            //****************

            //****************
            SettingForm();
            //****************
            
            //****************
            //Start Splash Screen

            ThreadSplashScreenForm();
            //****************
        }

        private void btn_Accept_Click(object sender, System.EventArgs e)
        {
            // **************************************************
            if ((string.IsNullOrWhiteSpace(usernameTextBox.Text)) ||
                (string.IsNullOrWhiteSpace(passwordTextBox.Text)))
            {
                //usernameTextBox.Text =
                //	usernameTextBox.Text.Trim();

                //passwordTextBox.Text =
                //	passwordTextBox.Text.Trim();

                usernameTextBox.Text =
                    usernameTextBox.Text.Replace(" ", string.Empty);

                passwordTextBox.Text =
                    passwordTextBox.Text.Replace(" ", string.Empty);

                //System.Windows.Forms.MessageBox.Show("Username and Password is requied!");

                //-------------------------------------------------------------------------

                System.Windows.Forms.
                    MessageBox.Show(
                    text: "کاربر محترم:: نام کاربری و یا گذر واژه اشتباه است!",
                    caption: "خطای ورود به سامانه",
                    buttons: System.Windows.Forms.MessageBoxButtons.OK,
                    icon: System.Windows.Forms.MessageBoxIcon.Error,
                    defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button2,
                    options: System.Windows.Forms.MessageBoxOptions.RightAlign | System.Windows.Forms.MessageBoxOptions.RtlReading);

                //-------------------------------------------------------------------------

                if (usernameTextBox.Text == string.Empty)
                {
                    usernameTextBox.Focus();
                }
                else
                {
                    passwordTextBox.Focus();
                }

                return;
            }
            // **************************************************

            Models.DatabaseContext oDatabaseContext = null;

            try
            {
                oDatabaseContext =
                    new Models.DatabaseContext();

                Models.User oUser =
                    oDatabaseContext.Users
                    .Where(current => string.Compare(current.Username, usernameTextBox.Text, true) == 0)
                    .FirstOrDefault();

                if (oUser == null)
                {
                    //System.Windows.Forms.MessageBox
                    //	.Show("Username is not correct!");

                    //System.Windows.Forms.MessageBox
                    //    .Show("Username and/or Password is not correct!");

                    //-------------------------------------------------------------------------

                    System.Windows.Forms.MessageBox
                        .Show(
                        text: "کاربر محترم:: نام کاربری و یا گذر واژه اشتباه است!",
                        caption: "خطای ورود به سامانه",
                        buttons: System.Windows.Forms.MessageBoxButtons.OK,
                        icon: System.Windows.Forms.MessageBoxIcon.Error,
                        defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button2,
                        options: System.Windows.Forms.MessageBoxOptions.RightAlign | System.Windows.Forms.MessageBoxOptions.RtlReading);

                    //-------------------------------------------------------------------------

                    usernameTextBox.Focus();

                    return;
                }

                if (string.Compare(oUser.Password, passwordTextBox.Text, ignoreCase: false) != 0)
                {
                    //System.Windows.Forms.MessageBox
                    //	.Show("Password is not correct!");

                    //System.Windows.Forms.MessageBox
                    //    .Show("Username and/or Password is not correct!");

                    //-------------------------------------------------------------------------

                    System.Windows.Forms.MessageBox
                        .Show(
                        text: "کاربر محترم:: نام کاربری و یا گذر واژه اشتباه است!",
                        caption: "خطای ورود به سامانه",
                        buttons: System.Windows.Forms.MessageBoxButtons.OK,
                        icon: System.Windows.Forms.MessageBoxIcon.Error,
                        defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button2,
                        options: System.Windows.Forms.MessageBoxOptions.RightAlign | System.Windows.Forms.MessageBoxOptions.RtlReading);

                    //-------------------------------------------------------------------------

                    usernameTextBox.Focus();

                    return;
                }

                if (oUser.IsActive == false)
                {
                    //System.Windows.Forms.MessageBox
                    //    .Show("You can not login to this application! Please contact support.");

                    //-------------------------------------------------------------------------

                    System.Windows.Forms.MessageBox
                        .Show(
                        text: "کاربر محرتم! شما نمی توانید به سامانه وارد شوید لطفا با پشتیبانی تماس حاصل فرمایید!",
                        caption: "خطای ورود به سامانه",
                        buttons: System.Windows.Forms.MessageBoxButtons.OK,
                        icon: System.Windows.Forms.MessageBoxIcon.Error,
                        defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button2,
                        options: System.Windows.Forms.MessageBoxOptions.RightAlign | System.Windows.Forms.MessageBoxOptions.RtlReading);

                    //-------------------------------------------------------------------------

                    usernameTextBox.Focus();

                    return;
                }

                Infrastructure.Utility.AuthenticatedUser = oUser;

                Hide();

                MainForm mainForm = new MainForm();

                mainForm.Show();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (oDatabaseContext != null)
                {
                    oDatabaseContext.Dispose();
                    oDatabaseContext = null;
                }
            }
        }

        private void btn_Reset_Click(object sender, System.EventArgs e)
        {
            passwordTextBox.Text = string.Empty;
            usernameTextBox.Text = string.Empty;

            usernameTextBox.Focus();
        }

        private void btn_Register_Click(object sender, System.EventArgs e)
        {
            Hide();

            RegisterForm registerForm = new RegisterForm();

            registerForm.Show();
        }

        private void passwordTextBox_TextChanged(object sender, System.EventArgs e)
        {
            passwordTextBox.PasswordChar = '\u25CF';
            //passwordTextBox.SelectAll();
        }

        private void lbl_ExitApplication_Click(object sender, System.EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        #region Setting Application
        private void SettingForm()
        {
            this.MinimumSize = new System.Drawing.Size(713, 650);
            this.MaximumSize = new System.Drawing.Size(713, 650);

            Font = new System.Drawing.Font("B Mitra", 12F);

            passwordTextBox.PasswordChar = '\u25CF';

            //.FormBorderStyle = FormBorderStyle.FixedDialog;
            

        }

        public void ThreadSplashScreenForm()
        {
            System.Threading.Thread t =
                new System.Threading.
                Thread(new System.Threading.ThreadStart(StartForm));

            t.Start();

            System.Threading.Thread.Sleep(5000);

            t.Abort();
        }


        public void StartForm()
        {
            // Run Splash Screen Form
            System.Windows.Forms.
                Application.Run(new Forms.SplashScreenLoginForm());
        }
        #endregion / Setting Application
    }
}
