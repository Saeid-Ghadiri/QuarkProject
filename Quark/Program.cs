using System.Linq;

namespace Quark
{
    static class Program
    {
        [System.STAThread]
        static void Main()
        {
            // **************************************************
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            // **************************************************

            // **************************************************
            #region Create Default User Administrator

            Models.DatabaseContext oDatabaseContext = null;

            try
            {
                oDatabaseContext =
                    new Models.DatabaseContext();

                int intAdminCount =
                    oDatabaseContext.Users
                    .Where(current => current.IsAdmin)
                    .Count();

                if (intAdminCount == 0)
                {
                    Models.User oAdminUser = new Models.User();

                    oAdminUser.IsAdmin = true;
                    oAdminUser.IsActive = true;

                    oAdminUser.Username = "administrator";
                    oAdminUser.Password = "123456789";
                    oAdminUser.FullName = "مدیر سیستم";

                    oDatabaseContext.Users.Add(oAdminUser);

                    oDatabaseContext.SaveChanges();
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.
                    MessageBox.Show(ex.Message);

                return;
            }
            finally
            {
                if (oDatabaseContext != null)
                {
                    oDatabaseContext.Dispose();
                    oDatabaseContext = null;
                }
            }

            #endregion / Create Default User Administrator
            // **************************************************

            // **************************************************
            #region Runing Startup Form and then Disposing!

            Forms.LoginForm startupForm =
                new Forms.LoginForm();

            //Forms.X startupForm = new Forms.X();

            System.Windows.Forms.Application.Run(startupForm);

            if (startupForm != null)
            {
                if (startupForm.IsDisposed == false)
                {
                    startupForm.Dispose();
                }

                startupForm = null;
            }
            #endregion /Runing Startup Form and then Disposing!
            // **************************************************
        }
    }
}
