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
    //public partial class RegisterForm : Form
    public partial class RegisterForm : Infrastructure.BaseForm
    {
        #region Load Form
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, System.EventArgs e)
        {

        }
        #endregion / Load Form

        #region Insert
        private void btn_InsertToDB_Click(object sender, EventArgs e)
        {
            // **************************************************
            if ((string.IsNullOrWhiteSpace(usernameTextBox.Text)) ||
                (string.IsNullOrWhiteSpace(passwordTextBox.Text)))
            {

                usernameTextBox.Text =
                    usernameTextBox.Text.Replace(" ", string.Empty);

                passwordTextBox.Text =
                    passwordTextBox.Text.Replace(" ", string.Empty);

                //System.Windows.Forms.MessageBox.Show("Username and Password is requied!");

                //-------------------------------------------------------------------------
                MessageBox.Show(
                    "کاربر محترم:: لطفا نام کاربری و گذرواژه را وارد نمایید.",
                    "اطلاع رسانی",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
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

            string strErrorMessages = string.Empty;

            if (usernameTextBox.Text.Length < 1)//5
            {
                strErrorMessages =
                    "کاربر محترم:: حداقل تعداد کارکترهای نام کاربری باید 5 حرف باشد.";
            }

            if (passwordTextBox.Text.Length < 1)//6
            {
                if (strErrorMessages != string.Empty)
                {
                    strErrorMessages +=
                        System.Environment.NewLine;
                }

                strErrorMessages +=
                    "کاربر محترم:: حداقل تعداد کارکترهای گذرواژه باید 6 حرف باشد. ";
            }

            // اگر خطایی وجود داشت
            if (strErrorMessages != string.Empty)
            {
                System.Windows.Forms.MessageBox.Show(strErrorMessages);

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

                if (oUser != null)
                {

                    //-------------------------------------------------------------------------
                    MessageBox.Show(
                        "کاربر محترم:: نام کاربری که درج نموده اید در سامانه وجود دارد! لطفا نام دیگری را انتخاب نمایید.",
                        "اطلاع رسانی",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button2,
                        MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                    //-------------------------------------------------------------------------

                    usernameTextBox.Focus();

                    return;
                }

                oUser = new Models.User();


                oUser.FullName = fullNameTextBox.Text;
                oUser.Password = passwordTextBox.Text;
                oUser.Username = usernameTextBox.Text;

                //اگر بخواهیم کاربر جدید که ایجاد میشود فعال نباشد این آیتم باید false باشد.
                oUser.IsActive = true;

                oDatabaseContext.Users.Add(oUser);

                oDatabaseContext.SaveChanges();

                //System.Windows.Forms.MessageBox.Show("Registration Done!");

                //-------------------------------------------------------------------------
                MessageBox
                    .Show(
                    text: "کاربر محترم:: ثبت نام کاربری شما با موفقیت انجام شد.",
                    caption: "اطلاع رسانی",
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Information,
                    defaultButton: MessageBoxDefaultButton.Button2,
                    options: MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                //-------------------------------------------------------------------------

                fullNameTextBox.Text = string.Empty;
                passwordTextBox.Text = string.Empty;
                usernameTextBox.Text = string.Empty;

                usernameTextBox.Focus();
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
        #endregion / Insert

        #region Reset Form
        private void btn_ResetForm_Click(object sender, EventArgs e)
        {
            usernameTextBox.Text = string.Empty;
            passwordTextBox.Text = string.Empty;
            fullNameTextBox.Text = string.Empty;

            usernameTextBox.Focus();
        }
        #endregion /Reset Form

        #region App Exit
        private void btn_ExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion /App Exit

        #region 
        #endregion

    }
}
