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
            lbl_Welcome.Text = "Welcome" + " User";
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

        private void OptionsForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lbl_Time.Text = DateTime.Now.ToLongTimeString();
            lbl_Date.Text = DateTime.Now.ToLongDateString();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_Time.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
    }
}
