//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace Quark.Forms
//{
//    class phonebook_t
//    {
//    }


//    #region Save Data To DB
//    private void Btn_Save_Click(object sender, System.EventArgs e)
//    {
//        //// **************************************************
//        //if ((string.IsNullOrWhiteSpace(txt_NationalCode.Text)) ||
//        //    (string.IsNullOrWhiteSpace(txt_FirstName.Text)) ||
//        //    (string.IsNullOrWhiteSpace(txt_LastName.Text)) ||
//        //    (string.IsNullOrWhiteSpace(txt_Telephone.Text)) ||
//        //    (string.IsNullOrWhiteSpace(txt_CellPhone.Text)) ||
//        //    (string.IsNullOrWhiteSpace(txt_Email.Text)))

//        //{
//        //    txt_NationalCode.Text =
//        //        txt_NationalCode.Text.Replace(" ", string.Empty);

//        //    txt_FirstName.Text =
//        //        txt_FirstName.Text.Replace(" ", string.Empty);

//        //    txt_LastName.Text =
//        //        txt_LastName.Text.Replace(" ", string.Empty);

//        //    txt_Telephone.Text =
//        //        txt_Telephone.Text.Replace(" ", string.Empty);

//        //    txt_CellPhone.Text =
//        //        txt_CellPhone.Text.Replace(" ", string.Empty);

//        //    txt_Email.Text =
//        //        txt_Email.Text.Replace(" ", string.Empty);

//        //    //System.Windows.Forms.MessageBox.Show("Username and Password is requied!");

//        //    //-------------------------------------------------------------------------
//        //    MessageBox.Show(
//        //        "کاربر محترم:: لطفا نام فیلدهای درخواستی را تکمیل نمایید.",
//        //        "اطلاع رسانی",
//        //        MessageBoxButtons.OK,
//        //        MessageBoxIcon.Asterisk,
//        //        MessageBoxDefaultButton.Button1,
//        //        MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
//        //    //-------------------------------------------------------------------------

//        //    if (txt_NationalCode.Text == string.Empty)
//        //    {
//        //        txt_NationalCode.Focus();
//        //    }
//        //    else
//        //    {
//        //        txt_FirstName.Focus();
//        //        txt_LastName.Focus();
//        //        txt_Telephone.Focus();
//        //        txt_CellPhone.Focus();
//        //        txt_Email.Focus();
//        //    }

//        //    return;
//        //}

//        //string strErrorMessages = string.Empty;

//        //if (txt_NationalCode.Text.Length < 10)
//        //{
//        //    if (strErrorMessages != string.Empty)
//        //    {
//        //        strErrorMessages +=
//        //            System.Environment.NewLine;
//        //    }

//        //    strErrorMessages =
//        //        "کاربر محترم:: تعداد کارکترهای کد ملی باید 10 عدد باشد.";
//        //}

//        //if (txt_Telephone.Text.Length < 11)
//        //{
//        //    if (strErrorMessages != string.Empty)
//        //    {
//        //        strErrorMessages +=
//        //            System.Environment.NewLine;
//        //    }

//        //    strErrorMessages +=
//        //        "کاربر محترم:: تعداد کارکترهای شماره تلفن ثابت  شما باید 11 عدد باشد. ";
//        //}

//        //if (txt_CellPhone.Text.Length < 11)
//        //{
//        //    if (strErrorMessages != string.Empty)
//        //    {
//        //        strErrorMessages +=
//        //            System.Environment.NewLine;
//        //    }

//        //    strErrorMessages +=
//        //        "کاربر محترم:: تعداد کارکترهای شماره تلفن همراه شما باید 11 عدد باشد. ";
//        //}

//        //// اگر خطایی وجود داشت
//        //if (strErrorMessages != string.Empty)
//        //{
//        //    System.Windows.Forms.MessageBox.Show(strErrorMessages);

//        //    return;
//        //}
//        // **************************************************

//        //Models.DatabaseContext oDatabaseContext = null;

//        //try
//        //{
//        //    oDatabaseContext =
//        //        new Models.DatabaseContext();

//        //    Models.Phonebook oPhonebook =
//        //        oDatabaseContext.Phonebooks
//        //        .Where(current => string.Compare(current.NationalCode, txt_NationalCode.Text, true) == 0)
//        //        .FirstOrDefault();

//        //    if (oPhonebook != null)
//        //    {

//        //        //-------------------------------------------------------------------------
//        //        MessageBox.Show(
//        //            "کاربر محترم:: این کد ملی تکراری است لطفا کد دیگری را وارد نمایید..",
//        //            "اطلاع رسانی",
//        //            MessageBoxButtons.OK,
//        //            MessageBoxIcon.Error,
//        //            MessageBoxDefaultButton.Button1,
//        //            MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
//        //        //-------------------------------------------------------------------------

//        //        txt_NationalCode.Focus();

//        //        return;
//        //    }

//        //    oPhonebook = new Models.Phonebook();

//        //    oPhonebook.NationalCode = txt_NationalCode.Text;

//        //    oPhonebook.FirstName = txt_FirstName.Text;
//        //    oPhonebook.LastName = txt_LastName.Text;
//        //    oPhonebook.Nickname = txt_NickName.Text;
//        //    oPhonebook.MiddleName = txt_middleName.Text;
//        //    oPhonebook.Email = txt_Email.Text;
//        //    oPhonebook.Telephone = txt_Telephone.Text;
//        //    oPhonebook.Fax = txt_Fax.Text;
//        //    oPhonebook.CellPhone = txt_CellPhone.Text;
//        //    oPhonebook.Address = txt_Address.Text;
//        //    oPhonebook.Description = txt_Description.Text;
//        //    //****************************************************************************************************************

//        //    //DateTime date = Convert.ToDateTime(dtSelectorPhonebook.Value);
//        //    //oPhonebook.DateOfBirth = dtSelectorPhonebook.Value;

//        //    //oPhonebook.DateOfBirth = persianDateTimePicker1.Value;
//        //    //******************************************************************************************************************

//        //    //******************************************************************************************************************
//        //    //Bitmap picture = (Bitmap)picbox.Image;
//        //    //System.IO.MemoryStream ms = new System.IO.MemoryStream();
//        //    //picture.Save(ms, picture.RawFormat);
//        //    //byte[] arrpic = ms.GetBuffer();
//        //    //ms.Close();
//        //    //******************************************************************************************************************

//        //    //اگر بخواهیم کاربر جدید که ایجاد میشود فعال نباشد این آیتم باید false باشد.
//        //    //oPhonebook.IsActive = true;

//        //    oDatabaseContext.Phonebooks.Add(oPhonebook);

//        //    oDatabaseContext.SaveChanges();

//        //    //System.Windows.Forms.MessageBox.Show("Registration Done!");

//        //    //-------------------------------------------------------------------------
//        //    MessageBox
//        //        .Show(
//        //        text: "کاربر محترم:: ثبت اطلاعات شما با موفقیت انجام شد.",
//        //        caption: "اطلاع رسانی",
//        //        buttons: MessageBoxButtons.OK,
//        //        icon: MessageBoxIcon.Information,
//        //        defaultButton: MessageBoxDefaultButton.Button2,
//        //        options: MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
//        //    //-------------------------------------------------------------------------

//        //    //txt_NationalCode.Text = string.Empty;
//        //    //txt_FirstName.Text = string.Empty;
//        //    //txt_LastName.Text = string.Empty;
//        //    //txt_NickName.Text = string.Empty;
//        //    //txt_Email.Text = string.Empty;
//        //    //txt_Telephone.Text = string.Empty;
//        //    //txt_Fax.Text = string.Empty;
//        //    //txt_CellPhone.Text = string.Empty;
//        //    //txt_Address.Text = string.Empty;
//        //    //txt_Description.Text = string.Empty;
//        //    //dtSelectorPhonebook.Value = null;


//        //    txt_NationalCode.Focus();
//        //}
//        //catch (System.Exception ex)
//        //{
//        //    System.Windows.Forms.MessageBox.Show("Error: " + ex.Message);
//        //}
//        //finally
//        //{
//        //    if (oDatabaseContext != null)
//        //    {
//        //        oDatabaseContext.Dispose();
//        //        oDatabaseContext = null;
//        //    }
//        //}




//        Models.DatabaseContext oDatabaseContext = null;

//        try
//        {
//            oDatabaseContext =
//                new Models.DatabaseContext();

//            Models.Phonebook oPhonebook =
//                oDatabaseContext.Phonebooks
//                .Where(current => string.Compare(current.NationalCode, txt_NationalCode.Text, true) == 0)
//                .FirstOrDefault();

//            if (oPhonebook != null)
//            {

//                //-------------------------------------------------------------------------
//                MessageBox.Show(
//                    "کاربر محترم:: کد ملی ثبت شده اشتباه است!.",
//                    "اطلاع رسانی",
//                    MessageBoxButtons.OK,
//                    MessageBoxIcon.Error,
//                    MessageBoxDefaultButton.Button2,
//                    MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
//                //-------------------------------------------------------------------------

//                txt_NationalCode.Focus();

//                return;
//            }

//            oPhonebook = new Models.Phonebook();

//            oPhonebook.NationalCode = txt_NationalCode.Text;

//            oPhonebook.FirstName = txt_FirstName.Text;
//            oPhonebook.LastName = txt_LastName.Text;
//            oPhonebook.Nickname = txt_NickName.Text;
//            oPhonebook.MiddleName = txt_middleName.Text;
//            oPhonebook.Email = txt_Email.Text;
//            oPhonebook.Telephone = txt_Telephone.Text;
//            oPhonebook.Fax = txt_Fax.Text;
//            oPhonebook.CellPhone = txt_CellPhone.Text;
//            oPhonebook.Address = txt_Address.Text;
//            oPhonebook.Description = txt_Description.Text;
//            //datetime field
//            //oPhonebook.DateOfBirth = persianDateTimePicker1.Value;  //option 1
//            oPhonebook.DateOfBirth = dtSelectorPhonebook.Value; //option 2



//            oDatabaseContext.Phonebooks.Add(oPhonebook);

//            oDatabaseContext.SaveChanges();

//            //System.Windows.Forms.MessageBox.Show("Registration Done!");

//            //-------------------------------------------------------------------------
//            MessageBox
//                .Show(
//                text: "کاربر محترم:: ثبت اطلاعات شما با موفقیت انجام شد.",
//                caption: "اطلاع رسانی",
//                buttons: MessageBoxButtons.OK,
//                icon: MessageBoxIcon.Information,
//                defaultButton: MessageBoxDefaultButton.Button2,
//                options: MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
//            //-------------------------------------------------------------------------

//            // txt_NationalCode.Focus();

//        }
//        catch (System.Exception ex)
//        {
//            System.Windows.Forms.MessageBox.Show("Error: " + ex.Message);
//        }
//        finally
//        {
//            if (oDatabaseContext != null)
//            {
//                oDatabaseContext.Dispose();
//                oDatabaseContext = null;
//            }
//        }
//    }// end insert btn

//    #endregion
//}
