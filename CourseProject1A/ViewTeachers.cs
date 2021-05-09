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
    public partial class ViewTeachers : Form
    {
        private readonly Choice_Christian_AcademyEntities choice_Christian_AcademyEntities;
        public ViewTeachers()
        {
            InitializeComponent();
            choice_Christian_AcademyEntities = new Choice_Christian_AcademyEntities();
        }

        private void ViewTeachers_Load(object sender, EventArgs e)
        {
            var teacherdata = choice_Christian_AcademyEntities.Teachers
              .Select(q => new {
                  First_Name = q.First_Name,
                  Last_Name = q.Last_Name,
                  Grade = q.Grade,
                  Qualification = q.Qualification,
                  q.ID
              }).ToList();
            gvteacherdata.DataSource = teacherdata;
            gvteacherdata.Columns[0].HeaderText = "First Name";
            gvteacherdata.Columns[1].HeaderText = "Last Name";
            gvteacherdata.Columns[2].HeaderText = "Grade";
            gvteacherdata.Columns[3].HeaderText = "Qualification";
            gvteacherdata.Columns[4].Visible = false;
        }

        private void Editbotton_Click(object sender, EventArgs e)
        {
            //Get ID for selected row
            var id = (int)gvteacherdata.SelectedRows[0].Cells["ID"].Value;
            //Query database
            var teacher = choice_Christian_AcademyEntities.Teachers.FirstOrDefault(q => q.ID == id);

            var addEditTeacher = new AddEditTeacher(teacher);
            addEditTeacher.MdiParent = this.MdiParent;
            addEditTeacher.Show();
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            var addEditTeacher = new AddEditTeacher();
            addEditTeacher.MdiParent = this.MdiParent;
            addEditTeacher.Show();
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                //Get ID for selected row
                var id = (int)gvteacherdata.SelectedRows[0].Cells["ID"].Value;
                //Query database
                var teacher = choice_Christian_AcademyEntities.Teachers.FirstOrDefault(q => q.ID == id);

                choice_Christian_AcademyEntities.Teachers.Remove(teacher);
                choice_Christian_AcademyEntities.SaveChanges();
                MessageBox.Show("Information Deleted");
                gvteacherdata.Refresh();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        private void Closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Refreshbutton_Click(object sender, EventArgs e)
        {
            gvteacherdata.Refresh();
           
        }
    }
}
