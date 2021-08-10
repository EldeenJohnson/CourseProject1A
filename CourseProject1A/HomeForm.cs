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

        private void btn_Staff_Click(object sender, EventArgs e)
        {
            var AddEditStaff = new AddEditStaff();
            AddEditStaff.MdiParent = this.MdiParent;
            AddEditStaff.Show();
        }

        private void btn_Teach_Click(object sender, EventArgs e)
        {
            var AddEditTeacher = new AddEditTeacher();
            AddEditTeacher.MdiParent = this.MdiParent;
            AddEditTeacher.Show();
        }
    }
}
