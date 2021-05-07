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

        private void manageStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var StaffData = new ViewStaff();
            StaffData.MdiParent = this;
            StaffData.Show();
        }

        private void newStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var AddEditStaff = new AddEditStaff();
            AddEditStaff.MdiParent = this.MdiParent;
            AddEditStaff.Show();
        }

        private void manageTeachersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var TeacherData = new ViewTeachers();
            TeacherData.MdiParent = this;
            TeacherData.Show();
        }

        private void newTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var AddEditTeacher = new AddEditTeacher();
            AddEditTeacher.MdiParent = this.MdiParent;
            AddEditTeacher.Show();
        }
    }
}
