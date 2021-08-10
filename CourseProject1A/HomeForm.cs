using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject1A
{
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();
        }

        private void btn_stuApp_Click(object sender, EventArgs e)
        {
            var RegistrationPage = new RegistrationPage();
            RegistrationPage.MdiParent = this.MdiParent;
            RegistrationPage.Show();
        }
    }
}
