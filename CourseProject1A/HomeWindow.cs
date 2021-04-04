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
    public partial class HomeWindow : Form
    {
        public HomeWindow()
        {
            InitializeComponent();
        }

        private void newApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var RegistrationPage = new RegistrationPage();
            RegistrationPage.MdiParent = this;
            RegistrationPage.Show();
        }
    }
}
