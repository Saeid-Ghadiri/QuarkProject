using System.Data.Entity;
using System.Linq;

namespace Quark.Forms
{
    //public partial class CountryForm : Form
    public partial class CountryForm : Infrastructure.BaseForm
    {
        #region Form Load

        public CountryForm()
        {
            InitializeComponent();
        }

        #endregion /Form Load

        #region 
        #endregion

        #region 
        #endregion

        #region 
        #endregion

        #region 
        #endregion

        #region 
        #endregion

        private void btn_BackToMainForm_Click(object sender, System.EventArgs e)
        {
            //Hide();

            //MainForm f =
            //    new MainForm();

            //f.Show();

            this.Close();
        }

        /// <summary>
        /// ایونت کلیک دکمه افزودن کشور جدید
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnAddSomeNewCountries_Click(object sender, System.EventArgs e)
        {
            // databasecontext is null
            Models.DatabaseContext oDatabaseContext = null;

            try
            {
                //ایجاد جدید شی  از دیتا بیس کانتکست
                oDatabaseContext =
                    new Models.DatabaseContext();

                //ایجاد یک شی از کلاس کانتری
                Models.Country oCountry = null;

                //مقدار دهی به پراپرتی و افزودن به کالکشن موجود در دیتا بیس کانتکست
                //#################################################

                oCountry = new Models.Country();
                oCountry.Name = "Iran";
                oDatabaseContext.Countries.Add(oCountry);

                oCountry = new Models.Country();
                oCountry.Name = "Iraq";
                oDatabaseContext.Countries.Add(oCountry);

                oCountry = new Models.Country();
                oCountry.Name = "Italy";
                oDatabaseContext.Countries.Add(oCountry);

                oCountry = new Models.Country();
                oCountry.Name = "France";
                oDatabaseContext.Countries.Add(oCountry);

                oCountry = new Models.Country();
                oCountry.Name = "Germany";
                oDatabaseContext.Countries.Add(oCountry);

                oCountry = new Models.Country();
                oCountry.Name = "China";

                //#################################################

                //ذخیره اطلاعات در بانک اطلاعات
                oDatabaseContext.SaveChanges();
            }
            //در صورت بروز خطا آن را نمایش میدهیم
            catch (System.Exception ex)
            {
                System.Windows.Forms.
                    MessageBox.Show(ex.Message);
            }
            finally
            {
                //در نهایت اگر شی دیتا بیس کانتکست نال نبود آن را نال می کنیم
                if (oDatabaseContext != null)
                {
                    oDatabaseContext.Dispose();
                    oDatabaseContext = null;
                }
            }
        }

        private void btnShowAllCountries_Click(object sender, System.EventArgs e)
        {
            //ایجاد یک شی از کلاس دیتا بیس کانتکست
            Models.DatabaseContext oDatabaseContext = null;

            try
            {
                //نیو کردن شی دیتا بیس کانتکست
                oDatabaseContext =
                    new Models.DatabaseContext();

                //روش های لود نمودن اطلاعات
                //#################################################

                // Note: We should write: using System.Data.Entity;
                //oDatabaseContext.Countries
                //	.Load();


                //لامباد اکسپرشن - اوردربای بر اثاث نام کشور
                //هر متغیری بنویسید اون متغیر میشه انتیتی همون کالکشن
                oDatabaseContext.Countries
                    .OrderBy(current => current.Name)
                    .Load();

                //#################################################

                //تنظیمات مربوط به لیست باکس و نمایش اطلاعات با استفاده از لوکال دیتا سورس
                //#################################################

                lstCountries.ValueMember = "ID";
                //lstCountries.DisplayMember = "Name";
                lstCountries.DisplayMember = "DisplayName";

                lstCountries.DataSource =
                    oDatabaseContext.Countries.Local;

                //#################################################
            }
            //درصورت بروز خطا را نمایش میدهیم
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                //در نهایت اگر شی دیتا بیس کانتکست نال نیود آن را نال میکنیم
                if (oDatabaseContext != null)
                {
                    oDatabaseContext.Dispose();
                    oDatabaseContext = null;
                }
            }
        }

        private void btnDeleteAllCountries_Click(object sender, System.EventArgs e)
        {
            //ایجاد یک شی از کلاس دیتا بیس کانتکست
            Models.DatabaseContext oDatabaseContext = null;

            try
            {
                //نیو کردن شی دیتا بیس کانتکست
                oDatabaseContext =
                    new Models.DatabaseContext();

                //راه حل اول
                //ابتدا همه کشورها لود میشود و در لوکال قرار میگیرد
                oDatabaseContext.Countries
                    .Load();

                //اطلاعات موجود در لوکال را حذف میکنیم
                oDatabaseContext.Countries.Local.Clear();

                //ذخیره اطلاعات در بانک اطلاعات
                oDatabaseContext.SaveChanges();
                //پایان راه حل اول

                // راه حل دوم
                //ایجاد یک کواری بمنظور حذف
                //string strQuery =
                //	"DELETE FROM Countries";

                //اجرای کواری
                //oDatabaseContext.Database.ExecuteSqlCommand(strQuery);
                //پایان راه حل دوم

                // راه حل سوم
                //ایجاد یک کواری برای حذف یک کشور
                //string strQuery =
                //	"DELETE FROM Countries WHERE CountryName = '" + txtCountryName.Text + "'";

                //اجرای کواری
                //oDatabaseContext.Database.ExecuteSqlCommand(strQuery);
                // پایان راه حل سوم

                // راه حل چهارم
                //ایجاد یک کواری برای حذف یک کشور
                //string strQuery =
                //	string.Format("DELETE FROM Countries WHERE CountryName = '{0}'", txtCountryName.Text);

                //اجرای کواری
                //oDatabaseContext.Database.ExecuteSqlCommand(strQuery);
                // پایان راه حل چهارم

                // راه حل پنجم
                //استفاده از پارامتر
                // using System.Data.SqlClient.SqlParameter
                //string strQuery =
                //	"DELETE FROM Countries WHERE CountryName = @CName";

                //System.Data.SqlClient.SqlParameter oSqlParameter =
                //	new System.Data.SqlClient.SqlParameter("CName", txtCountryName.Text);

                //اجرای کو اری
                //oDatabaseContext.Database.ExecuteSqlCommand(strQuery, oSqlParameter);
                // پایان راه حل پنجم
            }
            //درصورت بروز خطا آن را نمایش میدهیم
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            //در نهایت اگر شی دیتا بیس کانتکست نال نبود آن را نال میکنیم
            finally
            {
                if (oDatabaseContext != null)
                {
                    oDatabaseContext.Dispose();
                    oDatabaseContext = null;
                }
            }
        }

        private void btnDeleteACountryByName_Click(object sender, System.EventArgs e)
        {
            //#################################################
            // (راه حل اول) (فاجعه)
            //ابتدا همه کشور ها را لود میکنیم و سپس روی لوکال شرط را اعمال میکنیم
            //#################################################
            //Models.DatabaseContext oDatabaseContext =
            //	new Models.DatabaseContext();
            //#################################################

            //#################################################
            //oDatabaseContext.Countries
            //	.Load()
            //	;
            //#################################################

            //#################################################
            //var varCountry =
            //	oDatabaseContext.Countries
            //	.Local
            //اعمال شرط
            //	.Where(current => current.Name == txtCountryName.Text)
            //	// Note: .First() Returns the first element in the sequence.
            //	// If the sequence contains no elements an exception is thrown. 
            //	.FirstOrDefault()
            //	;

            //if (varCountry == null)
            //{
            //	System.Windows.Forms.MessageBox.Show
            //		("There is no country with this name!");
            //}
            //else
            //{
            //	oDatabaseContext.Countries.Local.Remove(varCountry);

            //	//oDatabaseContext.Countries.Local.RemoveAt(0);

            //	oDatabaseContext.SaveChanges();

            //	System.Windows.Forms.MessageBox.Show
            //		("The country deleted succefully!");
            //}
            //#################################################
            // /پایان فاجعه :)
            //#################################################

            //#################################################
            // راه حل دوم
            //#################################################

            //ایجاد یک شی از کلاس دیتا بیس کانتکست
            Models.DatabaseContext oDatabaseContext =
                new Models.DatabaseContext();

            //#################################################

            //#################################################

            //ابتدا شرط را اعمال میکنیم و سپس کشور ها را لود میکنیم
            oDatabaseContext.Countries
                .Where(current => current.Name == txtCountryName.Text)
                .Load();

            //اگر از بعد از لود کشوری با شرط مورد نظر موجو نبود پیغام مناسب نمایش داده میشود
            if (oDatabaseContext.Countries.Local.Count == 0)
            {
                System.Windows.Forms.MessageBox
                    .Show("There is no country with this name!");
            }
            //در غیر اینصورت
            else
            {
                //#################################################

                //کشور مورد نظر را در لوکال قرار میدهیم
                Models.Country oCountry =
                    oDatabaseContext.Countries.Local[0];

                //#################################################

                //روش های حذف یک کشور

                // زیر راه حل اول
                oDatabaseContext.Countries.Remove(oCountry);
                // پایان زیر راه حل اول

                // زیر راه حل دوم
                //oDatabaseContext.Countries.Local.Remove(oCountry);
                // پایان زیر راه حل دوم

                // زیر راه حل سوم
                //oDatabaseContext.Countries.Local.RemoveAt(0);
                //پایان زیر راه حل سوم

                // زیر راه حل چهارم
                //oDatabaseContext.Countries.Local.Clear();
                // پایان زیر راه حل چهارم

                //ذخیره تغییرات در بانک اطلاعات
                oDatabaseContext.SaveChanges();

                //نمایش پیغام مناسب به کاربر
                System.Windows.Forms.MessageBox
                    .Show("The country deleted succefully!");
            }
            //#################################################
            // پایان راه حل دوم
            //#################################################
        }

        private void btnCheckStates_Click(object sender, System.EventArgs e)
        {
            //#################################################

            //ایجاد یک شی از کلاس دیتا بیس کانتکست
            Models.DatabaseContext oDatabaseContext =
                new Models.DatabaseContext();

            //#################################################

            //#################################################

            //چینش سورت شده بر اساس نام
            oDatabaseContext.Countries
                .OrderBy(current => current.Name)
                .Load();

            //#################################################

            //#################################################

            //جنس لوکال برای ایجاد یک متغیر از آن جنس
            //ایجاد یک شی از لوکال و برای ایجاد نمودن آن باید بدانیم لوکال از چه جنسی است
            //با نگه داشتن موس روی لوکال جنس آن مشخص میشود
            //System.Collections.ObjectModel.ObservableCollection<Models.Country> oLocalCountries =
            //	oDatabaseContext.Countries.Local;

            //#################################################

            //#################################################

            // اگر جنس لوکال را نخواهیم اعمال کنیم(معمول نیست)داخل متغیری از جنس ور قرار میدهیم

            var varLocalCountries =
                oDatabaseContext.Countries.Local;

            //#################################################

            //#################################################

            //تعداد کشور ها را نمایش میدهیم
            System.Windows.Forms.MessageBox
                .Show("(0) Count: " + varLocalCountries.Count);

            //#################################################

            //استیت یک انتیتی یکی از 5 حالت ذیل است
            //ادد - مودیفاید -دلیتد - آن چنجد -دیتچد

            // Delete
            //#################################################

            //از کلاس کانتری یک شی میسازیم و برابر با اولین خانه متغیر ایجاد شده از جنس لوکال قرار میدهیم
            Models.Country oDeletedCountry = varLocalCountries[0];

            //استیت متغیر را بررسی میکنیم-آنچنجد
            System.Windows.Forms.MessageBox.Show
                ("(1) " + oDatabaseContext.Entry(oDeletedCountry).State.ToString());

            //اولین خانه را حذف میکنیم
            varLocalCountries.RemoveAt(0);

            //-استیت متغیر را بررسی میکنیم-دلیتد
            System.Windows.Forms.MessageBox.Show
                ("(2) " + oDatabaseContext.Entry(oDeletedCountry).State.ToString());

            //#################################################

            //#################################################

            //تعداد کشور ها را نمایش میدهیم
            System.Windows.Forms.MessageBox
                .Show("3) Count: " + varLocalCountries.Count);

            //#################################################

            // Add New
            //#################################################

            //یک شی از کانتری رو هوا ایجاد میکنیم یعنی به کالکشن اد نمیکنیم
            Models.Country oNewCountry =
                new Models.Country();

            oNewCountry.Name = "Some Added Country";

            //استیت را بررسی میکنیم - دیتچد
            System.Windows.Forms.MessageBox.Show
                ("(4) " + oDatabaseContext.Entry(oNewCountry).State.ToString());

            //افزودن به کالکشن
            varLocalCountries.Add(oNewCountry);

            //بررسی استیت-ادد
            System.Windows.Forms.MessageBox.Show
                ("(5) " + oDatabaseContext.Entry(oNewCountry).State.ToString());

            //#################################################

            // Edit
            //#################################################

            //ایجاد یک متغیر که خانه صفر متغیر هست
            Models.Country oEditedCountry = varLocalCountries[0];

            //بررسی استیت-آنچنجد
            System.Windows.Forms.MessageBox.Show
                ("(7) " + oDatabaseContext.Entry(oEditedCountry).State.ToString());

            //نام کشور را میخوانیم و در یم متغیر قرار میدهیم و دوباره آن را در نام خودش قرار میدهیم
            string strCurrentValue = oEditedCountry.Name;
            oEditedCountry.Name = strCurrentValue;

            //بررسی استیت - آنچنجد-هوشمندی انتیتی فریم ورک
            System.Windows.Forms.MessageBox.Show
                ("(8) " + oDatabaseContext.Entry(oEditedCountry).State.ToString());

            //ولی اگر نام را عوض کنیم
            oEditedCountry.Name = "Edited Country";

            //بررسی استیت - مادیفاید
            System.Windows.Forms.MessageBox.Show
                ("(9) " + oDatabaseContext.Entry(oEditedCountry).State.ToString());

            //دوباره اگر نام اول را بهش بدیم
            oEditedCountry.Name = strCurrentValue;

            //بررسی استیت - مادیفاید
            System.Windows.Forms.MessageBox.Show
                ("(10) " + oDatabaseContext.Entry(oEditedCountry).State.ToString());

            //#################################################

            //#################################################

            //for (int intIndex = 0; intIndex <= varLocalCountries.Count - 1; intIndex++)
            //{
            //    System.Windows.Forms.MessageBox.Show(intIndex.ToString() + ") - " +
            //        oDatabaseContext.Entry(varLocalCountries[intIndex]).State.ToString());
            //}

            //#################################################
        }

        private void btnAddNewCountry_Click(object sender, System.EventArgs e)
        {
            //ایجاد یک شی از دیتا بیس کانتکست
            Models.DatabaseContext oDatabaseContext = null;

            try
            {
                //New DatabaseContext
                oDatabaseContext =
                    new Models.DatabaseContext();

                // راه حل اول
                //ایجاد یک شی از کلاس کانتری
                Models.Country oCountry =
                    new Models.Country();

                //ایجاد خود کار یک نام کشور
                //oCountry.Name = "New Country";

                //ایجاد نام کشور به واسطه تکست باکس
                oCountry.Name = txtCountryName.Text;

                //افزودن به کالکشن کانتریز در دیتابیس کانتکست
                oDatabaseContext.Countries.Add(oCountry);
                // پایان راه حل اول

                // راه حل دوم
                //Models.Country oCountry =
                //	new Models.Country();

                //oCountry.Name = "New Country";

                //oDatabaseContext.Entry(oCountry).State =
                //	System.Data.EntityState.Added;
                // پایان راه حل دوم

                //افزودن اطلاعات در دیتا بیس
                oDatabaseContext.SaveChanges();
            }
            //درصورت بروز خطا آن را نمایش میدهیم
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            //در نهایت اگر شی دیتا بیس کانتکست نال نیود آن را نال میکنیم
            finally
            {
                if (oDatabaseContext != null)
                {
                    oDatabaseContext.Dispose();
                    oDatabaseContext = null;
                }
            }
        }
    }
}
