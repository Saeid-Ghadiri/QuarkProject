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
    //public partial class ChangePasswordForm : Form
    public partial class ChangePasswordForm : Infrastructure.BaseForm
    {
        #region Load Form
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void ChangePasswordForm_Load(object sender, System.EventArgs e)
        {

        }
        #endregion / Load Form

        #region InsertToDB
        private void btn_InsertToDB_Click(object sender, EventArgs e)
        {
            string strErrorMessages = string.Empty;

            if (string.IsNullOrWhiteSpace(oldPasswordTextBox.Text))
            {
                strErrorMessages =
                    "کاربر محترم:: لطفا گذرواژه فعلی را وارد نمایید.";
            }
            else
            {
                if (oldPasswordTextBox.Text.Length < 8)
                {
                    strErrorMessages =
                        " کاربر محترم:: برای وارد نمودن گذرواژه فعلی حداقل باید 6 حرف داشته باشد.";
                }
            }

            if (string.IsNullOrWhiteSpace(newPasswordTextBox.Text))
            {
                if (strErrorMessages != string.Empty)
                {
                    strErrorMessages += System.Environment.NewLine;
                }

                strErrorMessages +=
                    "کاربر محترم:: لطفا گذرواژه جدید خود را وارد نمایید.";
            }
            else
            {
                if (newPasswordTextBox.Text.Length < 8)
                {
                    if (strErrorMessages != string.Empty)
                    {
                        strErrorMessages += System.Environment.NewLine;
                    }

                    strErrorMessages +=
                        "کاربر محترم:: حداقل تعداد کارکترهای وارد شده برای گذرواژه جدید باید 6 حرف باشد.";
                }
            }

            if (string.IsNullOrWhiteSpace(confirmNewPasswordTextBox.Text))
            {
                if (strErrorMessages != string.Empty)
                {
                    strErrorMessages += System.Environment.NewLine;
                }

                strErrorMessages +=
                    "کاربر محترم:: لطفا گذرواژه جدید را مجدد وارد نمایید";
            }
            else
            {
                if (string.Compare(confirmNewPasswordTextBox.Text, newPasswordTextBox.Text, ignoreCase: false) != 0)
                {
                    if (strErrorMessages != string.Empty)
                    {
                        strErrorMessages += System.Environment.NewLine;
                    }

                    strErrorMessages +=
                        "کاربر محترم:: گذرواژه ای که وارد نموده اید با گذرواژه جدید مطابقت ندارد. لطفا مجدد وارد نمایید.";
                }
            }

            if (strErrorMessages != string.Empty)
            {
                System.Windows.Forms.MessageBox.Show(strErrorMessages);

                return;
            }

            Models.DatabaseContext oDatabaseContext = null;

            try
            {
                oDatabaseContext =
                    new Models.DatabaseContext();

                Models.User oUser =
                    oDatabaseContext.Users
                    .Where(current => current.Id == Infrastructure.Utility.AuthenticatedUser.Id)
                    .FirstOrDefault();

                if (oUser == null)
                {
                    System.Windows.Forms.Application.Exit();
                }

                if (string.Compare(oUser.Password, oldPasswordTextBox.Text, ignoreCase: false) != 0)
                {
                    //System.Windows.Forms.MessageBox.Show("کاربر محترم:: گذرواژه فعلی صحیح نیست.");

                    //-------------------------------------------------------------------------

                    MessageBox
                        .Show(
                        text: "کاربر محترم:: گذرواژه فعلی صحیح نیست!",
                        caption: "خطای ورود داده",
                        buttons: MessageBoxButtons.OK,
                        icon: MessageBoxIcon.Error,
                        defaultButton: MessageBoxDefaultButton.Button2,
                        options: MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);

                    //-------------------------------------------------------------------------

                    oldPasswordTextBox.Focus();

                    return;
                }

                oUser.Password = newPasswordTextBox.Text;

                oDatabaseContext.SaveChanges();

                //System.Windows.Forms.MessageBox.Show("کاربر محترم:: گذرواژه شما با موفقیت تغییر یافت.");

                //-------------------------------------------------------------------------

                MessageBox
                    .Show(
                    text: "کاربر محترم:: گذرواژه شما با موفقیت تغییر یافت.",
                    caption: "اعلان سیستم",
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Information,
                    defaultButton: MessageBoxDefaultButton.Button2,
                    options: MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);

                //-------------------------------------------------------------------------
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
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

        #endregion / InsertToDB

        #region BackToMainForm

        private void btn_BackToMainForm_Click(object sender, EventArgs e)
        {
            Hide();

            MainForm f =
                new MainForm();

            f.ShowDialog();
        }



        #endregion / BackToMainForm

        #region 
        #endregion

        #region 
        #endregion
    }
}
