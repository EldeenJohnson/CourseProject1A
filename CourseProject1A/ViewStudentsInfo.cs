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
    public partial class ViewStudentsInfo : Form
    {
        private readonly Choice_Christian_AcademyEntities choice_Christian_AcademyEntities;
        public ViewStudentsInfo()
        {
            InitializeComponent();
            choice_Christian_AcademyEntities = new Choice_Christian_AcademyEntities();
        }

        private void ViewStudentsInfo_Load_1(object sender, EventArgs e)
        {
            var studentdata = choice_Christian_AcademyEntities.Students
               .Select(q => new {
                   First_Name = q.First_Name,
                   Middle_Name = q.Mid_Name,
                   Last_Name = q.Last_Name,
                   Address = q.Address,
                   Date_of_Birth = q.Date_of_Birth,
                   q.ID
               }).ToList();
            gvstudentdata.DataSource = studentdata;
            gvstudentdata.Columns[0].HeaderText = "First Name";
            gvstudentdata.Columns[1].HeaderText = "Middle Initial";
            gvstudentdata.Columns[2].HeaderText = "Last Name";
            gvstudentdata.Columns[3].HeaderText = "Address";
            gvstudentdata.Columns[4].HeaderText = "Date of Birth";
            gvstudentdata.Columns[5].Visible = false;
        }

        private void Editbotton_Click(object sender, EventArgs e)
        {
            //Get ID for selected row
            var id = (int)gvstudentdata.SelectedRows[0].Cells["ID"].Value;
            //Query database
            var student = choice_Christian_AcademyEntities.Students.FirstOrDefault(q => q.ID ==id);

            var addEditStudent = new AddEditStudent(student);
            addEditStudent.MdiParent = this.MdiParent;
            addEditStudent.Show();
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            //Get ID for selected row
            var id = (int)gvstudentdata.SelectedRows[0].Cells["ID"].Value;
            //Query database
            var student = choice_Christian_AcademyEntities.Students.FirstOrDefault(q => q.ID == id);
            //Delete data and save
            choice_Christian_AcademyEntities.Students.Remove(student);
            choice_Christian_AcademyEntities.SaveChanges();

            gvstudentdata.Refresh();
        }

        private void Closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            RegistrationPage registrationPage = new RegistrationPage();
            registrationPage.MdiParent = this.MdiParent;
            registrationPage.Show();
        }

        private void Refreshbutton_Click(object sender, EventArgs e)
        {
            gvstudentdata.Refresh();
        }
    }
}
