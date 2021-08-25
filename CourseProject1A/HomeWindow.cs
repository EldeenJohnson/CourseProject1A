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
        private LoginPage _login;
        public string _Rolename;
        public char _name;
        public HomeWindow()
        {
            InitializeComponent();
        }
        public HomeWindow(LoginPage login, string roleshortname, char name)
        {
            InitializeComponent();
            _login = login;
            _Rolename = roleshortname;
            _name = name; 

        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {
            OptionsForm newMDIChild = new OptionsForm();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();

            if ( _Rolename != "admin")
            {
                Password_bt.Enabled = false;
                lbl_Welcome.Text = _name.ToString();
            }
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

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var SelectUser = new SelectUser();
            SelectUser.MdiParent = this;
            SelectUser.Show();
        }

        private void HomeWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Close();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var AddUser = new AddUser();
            AddUser.MdiParent = this;
            AddUser.Show();
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OptionsForm newMDIChild = new OptionsForm();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }
    }
    
}
