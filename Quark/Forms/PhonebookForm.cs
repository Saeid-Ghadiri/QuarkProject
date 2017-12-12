using System.Linq;

namespace Quark.Forms
{
    //public partial class PhonebookForm : Form
    public partial class PhonebookForm : Infrastructure.BaseForm
    {

        #region Load Form
        public PhonebookForm()
        {
            InitializeComponent();

            System.Windows.Forms
                .InputLanguage.CurrentInputLanguage = System.Windows.Forms.InputLanguage
                .FromCulture(new System.Globalization.CultureInfo("FA-IR", false));
        }

        private void PhonebookForm_Load(object sender, System.EventArgs e)
        {

        }
        #endregion / Load Form

        #region Insert
        private void insertButton_Click(object sender, System.EventArgs e)
        {
            //// **************************************************

            Models.DatabaseContext oDatabaseContext = null;

            try
            {
                //New DbContext
                oDatabaseContext =
                    new Models.DatabaseContext();

                // Load Data
                Models.Phonebook phonebook =
                    oDatabaseContext.Phonebooks
                    .Where(current => string.Compare(current.NationalCode, nationalCodeTextBox.Text, true) == 0)
                    .FirstOrDefault();

                if (phonebook != null)
                {

                    //-------------------------------------------------------------------------
                    System.Windows.Forms.
                        MessageBox.Show(
                        text: "کاربر محترم:: کد ملی خود را صحیح وارد نمایید!",
                        caption: "اطلاع رسانی",
                        buttons: System.Windows.Forms.MessageBoxButtons.OK,
                        icon: System.Windows.Forms.MessageBoxIcon.Error,
                        defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button2,
                        options: System.Windows.Forms.MessageBoxOptions.RightAlign | System.Windows.Forms.MessageBoxOptions.RtlReading);
                    //-------------------------------------------------------------------------

                    nationalCodeTextBox.Focus();

                    return;
                }

                phonebook = new Models.Phonebook();

                // Add field 
                phonebook.NationalCode = nationalCodeTextBox.Text;




                oDatabaseContext.Phonebooks.Add(phonebook);

                oDatabaseContext.SaveChanges();

                //System.Windows.Forms.MessageBox.Show("Registration Done!");

                //-------------------------------------------------------------------------
                System.Windows.Forms.MessageBox
                    .Show(
                    text: "کاربر محترم:: ثبت اطلاعات شما با موفقیت انجام شد.",
                    caption: "اطلاع رسانی",
                    buttons: System.Windows.Forms.MessageBoxButtons.OK,
                    icon: System.Windows.Forms.MessageBoxIcon.Information,
                    defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button2,
                    options: System.Windows.Forms.MessageBoxOptions.RightAlign | System.Windows.Forms.MessageBoxOptions.RtlReading);
                //-------------------------------------------------------------------------

                nationalCodeTextBox.Text = string.Empty;

                nationalCodeTextBox.Focus();

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
        }// end insert 

        //****************************************************************************************************************
        // Image TO Byte
        private byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
            imageIn.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Gif);
            return memoryStream.ToArray();
        }

        //Byte To Image
        private System.Drawing.Image byteArrayToImage(byte[] byteArrayIn)
        {
            System.IO.MemoryStream memoryStream = new System.IO.MemoryStream(byteArrayIn);
            System.Drawing.Image returnImage = System.Drawing.Image.FromStream(memoryStream);
            return returnImage;
        }
        //****************************************************************************************************************

        #endregion /  Insert

        #region BackToMainForm
        private void btn_BackToMainForm_Click(object sender, System.EventArgs e)
        {
            //Hide();

            //MainForm f =
            //    new MainForm();

            //f.Show();

            this.Close();


        }

        #endregion / BackToMainForm

        #region Browse Picture
        private void btn_BrowsePicturePhonebook_Click(object sender, System.EventArgs e)
        {
            openFileDialog1.Title = "انتخاب عکس";
            openFileDialog1.Filter = "JPG FILE|*.jpg|" + "BMP FILE |*.bmp|" + "GIF FILE |*.gif|" + "All File|*.*";
            openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox.Image = System.Drawing.Image.FromFile(openFileDialog1.FileName);
                pictureBox.Refresh();
            }
        }


        #endregion / Browse Picture

        #region Edit
        private void editButton_Click(object sender, System.EventArgs e)
        {

        }

        #endregion //Edit

        #region Delete
        private void deleteButton_Click(object sender, System.EventArgs e)
        {

        }

        #endregion / Delete

        #region 


        #endregion

        #region 


        #endregion

        #region tool
        private void persianDateTimePicker1_ValueChanged(object sender, FreeControls.PersianMonthCalendarEventArgs e)
        {
            dateOfBirthDateTimePicker.Value = System.DateTime.Now;
        }

        private void dtSelectorPhonebook_ValueChanged(object sender, System.EventArgs e)
        {
            dateOfBirth1DateTimePicker.Value = System.DateTime.Now;
        }

        #endregion






    }
}
