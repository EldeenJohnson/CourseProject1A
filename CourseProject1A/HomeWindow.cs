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
      
        RegistrationPage regPage = new RegistrationPage();
        private void newApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*var RegistrationPage = new RegistrationPage();
            RegistrationPage.MdiParent = this;
            RegistrationPage.Show();*/

            regPage.MdiParent = this;
            regPage.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var studentdata = new ViewStudentsInfo();
            studentdata.MdiParent = this;
            studentdata.Show();
        }
    }
}
