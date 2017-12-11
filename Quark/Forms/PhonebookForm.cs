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
    //public partial class PhonebookForm : Form
    public partial class PhonebookForm : Infrastructure.BaseForm
    {

        #region Load Form
        public PhonebookForm()
        {
            InitializeComponent();

            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new System.Globalization.CultureInfo("FA-IR", false));
        }

        private void PhonebookForm_Load(object sender, System.EventArgs e)
        {

        }
        #endregion / Load Form

        #region Save Data To DB
        private void btn_Save_Click(object sender, System.EventArgs e)
        {
            //// **************************************************

            Models.DatabaseContext oDatabaseContext = null;

            try
            {
                //New DbContext
                oDatabaseContext =
                    new Models.DatabaseContext();

                // Load Data
                Models.Phonebook oPhonebook =
                    oDatabaseContext.Phonebooks
                    .Where(current => string.Compare(current.NationalCode, txt_NationalCode.Text, true) == 0)
                    .FirstOrDefault();

                if (oPhonebook != null)
                {

                    //-------------------------------------------------------------------------
                    MessageBox.Show(
                        "کاربر محترم:: کد ملی ثبت شده اشتباه است!.",
                        "اطلاع رسانی",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button2,
                        MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                    //-------------------------------------------------------------------------

                    txt_NationalCode.Focus();

                    return;
                }

                oPhonebook = new Models.Phonebook();

               




                oDatabaseContext.Phonebooks.Add(oPhonebook);

                oDatabaseContext.SaveChanges();

                //System.Windows.Forms.MessageBox.Show("Registration Done!");

                //-------------------------------------------------------------------------
                MessageBox
                    .Show(
                    text: "کاربر محترم:: ثبت اطلاعات شما با موفقیت انجام شد.",
                    caption: "اطلاع رسانی",
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Information,
                    defaultButton: MessageBoxDefaultButton.Button2,
                    options: MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                //-------------------------------------------------------------------------

               // txt_NationalCode.Focus();

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
        }// end insert btn

        //****************************************************************************************************************
        // Image TO Byte
        private byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
            imageIn.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Gif);
            return memoryStream.ToArray();
        }

        //Byte To Image
        private Image byteArrayToImage(byte[] byteArrayIn)
        {
            System.IO.MemoryStream memoryStream = new System.IO.MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(memoryStream);
            return returnImage;
        }
        //****************************************************************************************************************

        #endregion /  Save Data To DB

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

        #region btn_BrowsePicturePhonebook
        private void btn_BrowsePicturePhonebook_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "انتخاب عکس";
            openFileDialog1.Filter = "JPG FILE|*.jpg|" + "BMP FILE |*.bmp|" + "GIF FILE |*.gif|" + "All File|*.*";
            openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picbox.Image = Image.FromFile(openFileDialog1.FileName);
                picbox.Refresh();
            }
        }

        #endregion / btn_BrowsePicturePhonebook

        #region 
        #endregion


    }
}
