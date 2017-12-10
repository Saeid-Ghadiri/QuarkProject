using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quark.Administrator
{
    //public partial class UpdateUserProfileForm : Form
    public partial class UpdateUserProfileForm : Infrastructure.BaseForm
    {
        #region Load Form
        public UpdateUserProfileForm()
        {
            InitializeComponent();
        }

        private void UpdateUserProfileForm_Load(object sender, System.EventArgs e)
        {
            LoadForm();
        }
        #endregion / Load Form

        #region btn_UpdateSave
        public System.Guid UserId { get; set; }
        private void btn_UpdateSave_Click(object sender, EventArgs e)
        {
            Models.DatabaseContext oDatabaseContext = null;

            try
            {
                oDatabaseContext =
                    new Models.DatabaseContext();

                Models.User oUser =
                    oDatabaseContext.Users
                    .Where(current => current.Id == UserId)
                    .FirstOrDefault();

                if (oUser == null)
                {
                    System.Windows.Forms.MessageBox.Show("There is no such a user!");

                    Close();
                }

                oUser.IsAdmin = isAdminCheckBox.Checked;
                oUser.IsActive = isActiveCheckBox.Checked;

                oUser.FullName = fullNameTextBox.Text;
                oUser.Description = descriptionTextBox.Text;

                oDatabaseContext.SaveChanges();

                Close();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

                Close();
            }
            finally
            {
            }
        }

        #endregion / btn_UpdateSave

        #region LoadForm
        private void LoadForm()
        {
            Models.DatabaseContext oDatabaseContext = null;

            try
            {
                oDatabaseContext =
                    new Models.DatabaseContext();

                Models.User oUser =
                    oDatabaseContext.Users
                    .Where(current => current.Id == UserId)
                    .FirstOrDefault();

                if (oUser == null)
                {
                    System.Windows.Forms.MessageBox.Show("کاربر محترم:: چنین نام کاربری وجود ندارد!");

                    Close();
                }

                isAdminCheckBox.Checked = oUser.IsAdmin;
                isActiveCheckBox.Checked = oUser.IsActive;

                fullNameTextBox.Text = oUser.FullName;
                descriptionTextBox.Text = oUser.Description;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

                Close();
            }
            finally
            {
            }
        }



        #endregion / LoadForm

        #region Back To MainForm
        private void btn_BackToMainForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion /Back To MainForm

        #region 

        #endregion
    }
}
