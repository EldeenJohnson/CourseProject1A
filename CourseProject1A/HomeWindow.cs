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

        private void OptionsForm_Load(object sender, EventArgs e)
        {
            OptionsForm newMDIChild = new OptionsForm();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        
        private void newApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var RegistrationPage = new RegistrationPage();
            RegistrationPage.MdiParent = this;
            RegistrationPage.Show();
            
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

        private void manageTeachersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var TeacherData = new ViewTeachers();
            TeacherData.MdiParent = this;
            TeacherData.Show();
        }

        private void manageStaffToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var StaffData = new ViewStaff();
            StaffData.MdiParent = this;
            StaffData.Show();
        }

        private void privacyPolicyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var PrivacyPolicy = new PrivacyPolicy();
            PrivacyPolicy.MdiParent = this;
            PrivacyPolicy.Show();

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var LoginPage = new LoginPage();
            LoginPage.Show();
            this.Close();

        }
    }
    
}
