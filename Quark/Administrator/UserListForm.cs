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
    //public partial class UserListForm : Form
    public partial class UserListForm : Infrastructure.BaseForm
    {
        #region Load Form
        public UserListForm()
        {
            InitializeComponent();
        }

        private Models.DatabaseContext _myDatabaseContext;
        private void UserListForm_Load(object sender, System.EventArgs e)
        {
            _myDatabaseContext =
                new Models.DatabaseContext();
        }
        #endregion / Load Form

        #region btn Search
        private void btn_SearchUserList_Click(object sender, EventArgs e)
        {
            System.Collections.Generic.List<Models.User> oUsers = null;

            fullNameTextBox.Text =
                fullNameTextBox.Text.Trim();

            if (fullNameTextBox.Text == string.Empty)
            {
                oUsers =
                    _myDatabaseContext.Users
                    .OrderBy(current => current.FullName)
                    .ToList()
                    ;
            }
            else
            {
                oUsers =
                    _myDatabaseContext.Users
                    .Where(current => current.FullName.Contains(fullNameTextBox.Text))
                    .OrderBy(current => current.FullName)
                    .ToList()
                    ;
            }

            // Binding
            usersListBox.ValueMember = "Id";
            usersListBox.DisplayMember = "FullName";
            usersListBox.DataSource = oUsers;

            //dgv_info.ValueMember = "Id";
            //dgv_info.DisplayMember = "FullName";
            dgv_info.DataSource = oUsers;

            if (oUsers.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show("کاربر محترم:: کاربری وجود ندارد!");
            }
        }
        #endregion / btn Search

        #region Set Open and Close DBContext
        private void UserListForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_myDatabaseContext != null)
            {
                _myDatabaseContext.Dispose();
                _myDatabaseContext = null;
            }
        }

        private void usersListBox_DoubleClick(object sender, EventArgs e)
        {
            Models.User oSelectedUser =
                usersListBox.SelectedItem as Models.User;

            if (oSelectedUser != null)
            {
                Administrator.UpdateUserProfileForm updateUserForm = new Administrator.UpdateUserProfileForm();

                updateUserForm.UserId = oSelectedUser.Id;

                updateUserForm.ShowDialog();
            }
        }
        #endregion / Set Open and Close DBContext

        #region BackToMainForm
        private void btn_BackToMainForm_Click(object sender, EventArgs e)
        {
            this.Close();

            //Hide();

            //MainForm f =
            //    new MainForm();

            //f.Show();
        }
        #endregion / BackToMainForm

        #region 
        #endregion
    }
}
