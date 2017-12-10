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
    //public partial class SplashScreenLoginForm : Form
    public partial class SplashScreenLoginForm : Infrastructure.BaseForm
    {
        public SplashScreenLoginForm()
        {
            InitializeComponent();
        }

        private void SplashScreenLoginForm_Load(object sender, EventArgs e)
        {

        }

        private void SettingForm()
        {
            this.MinimumSize = new System.Drawing.Size(530, 190);
            this.MaximumSize = new System.Drawing.Size(530, 190);

            Font = new System.Drawing.Font("B Mitra", 12F);

            

            //.FormBorderStyle = FormBorderStyle.FixedDialog;
            //form1.MaximizeBox = false;
        }
    }
}
