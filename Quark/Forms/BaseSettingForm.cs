namespace Quark.Forms
{
    //public partial class BaseSettingForm : Form
    public partial class BaseSettingForm : Infrastructure.BaseForm
    {
        public BaseSettingForm()
        {
            InitializeComponent();
        }

        private void BaseSettingForm_Load(object sender, System.EventArgs e)
        {
            PersianCal();

            DateTimepicker1();
        }

        private void PersianCal()
        {
            lblTodayGregorian.Text = System.DateTime.Now.ToString("d");
            lblTodayPersian.Text = FarsiLibrary.Utils.PersianDateConverter.ToPersianDate(System.DateTime.Now).ToString();
            lblTodayPersianDate.Text = FarsiLibrary.Utils.PersianDate.Now.ToWritten();
            lblPersianDateCtor.Text = new FarsiLibrary.Utils.PersianDate(System.DateTime.Now).ToString("G");
            lblDirectCast.Text = ((FarsiLibrary.Utils.PersianDate)System.DateTime.Now).ToWritten();
            lblTodayPersianDateWithName.Text = new FarsiLibrary.Utils.PersianDate(System.DateTime.Now).ToString("F");
        }


        //FarsiLibrary.Win.FAThemeManager.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2003;
        private void btn_ConvertNumberToText_Click(object sender, System.EventArgs e)
        {
            try
            {
                long num = long.Parse(txt_Number.Text);
                lblResult_ChangeNumToTxt.Text = FarsiLibrary.Utils.ToWords.ToString(num);
            }
            catch (System.ArgumentOutOfRangeException)
            {
                lblResult_ChangeNumToTxt.Text = "لطفا عدد کوچکتری را وارد کنید";
            }
            catch (System.FormatException)
            {
                lblResult_ChangeNumToTxt.Text = string.Empty;
            }
        }

        private void DateTimepicker1()
        {
            FarsiLibrary.Win.FAThemeManager.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2003;
            FarsiLibrary.Resources.FALocalizeManager.CustomCulture = FarsiLibrary.Resources.FALocalizeManager.FarsiCulture;

        }

        private void faDatePicker1_SelectedDateTimeChanged(object sender, System.EventArgs e)
        {
            //FarsiLibrary.Resources.FALocalizeManager.CustomCulture = FarsiLibrary.Resources.FALocalizeManager.FarsiCulture;
        }

        private void groupBox1_Enter(object sender, System.EventArgs e)
        {

        }
    }
}
