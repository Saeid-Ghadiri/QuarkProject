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
    //public partial class UpdateProfileForm : Form
    public partial class UpdateProfileForm : Infrastructure.BaseForm
    {
        #region Load Form
        public UpdateProfileForm()
        {
            InitializeComponent();
        }

        private void UpdateProfileForm_Load(object sender, System.EventArgs e)
        {
            LoadForm();
        }
        #endregion / Load Form

        #region btn_UpdateSave
        private void btn_UpdateSave_Click(object sender, EventArgs e)
        {
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
                    // می توانیم پیغام به کاربر نشان دیم که همچین نام کاربری دیگر وجود ندارد.
                    System.Windows.Forms.Application.Exit();
                }

                oUser.FullName = fullNameTextBox.Text;
                oUser.Description = fullNameTextBox.Text;

                oDatabaseContext.SaveChanges();

                //Infrastructure.Utility.AuthenticatedUser = oUser;
                Infrastructure.Utility.AuthenticatedUser = oUser;

                //System.Windows.Forms.MessageBox
                //    .Show("Your profile was updated successfully...");

                //-------------------------------------------------------------------------
                MessageBox
                    .Show(this,
                    text: "پروفایل کاربری شما با موفقیا بروز رسانی شده است!",
                    caption: "اطلاع رسانی",
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Error,
                    defaultButton: MessageBoxDefaultButton.Button2,
                    options: MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                //-------------------------------------------------------------------------

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

        #endregion / btn_UpdateSave

        #region btn_BackToMainForm
        private void btn_BackToMainForm_Click(object sender, EventArgs e)
        {
            Hide();

            MainForm f =
                new MainForm();

            f.ShowDialog();
        }

        #endregion / btn_BackToMainForm

        #region LoadForm Update Profile
        private void LoadForm()
        {
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

                descriptionTextBox.Text = oUser.FullName;
                descriptionTextBox.Text = oUser.Description;
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
        #endregion / LoadForm Update Profile

        #region 
        #endregion

    }
}
