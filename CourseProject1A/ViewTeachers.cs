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
        private readonly Choice_Christian_AcademyEntities3 choice_Christian_AcademyEntities;
        public ViewTeachers()
        {
            InitializeComponent();
            choice_Christian_AcademyEntities = new Choice_Christian_AcademyEntities3();
        }

        private void ViewTeachers_Load(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        private void Editbotton_Click(object sender, EventArgs e)
        {
            //Get ID for selected row
            try
            {
                var id = (int)gvteacherdata.SelectedRows[0].Cells["ID"].Value;
                //Query database
                var teacher = choice_Christian_AcademyEntities.Teachers.FirstOrDefault(q => q.ID == id);
                var eContact = choice_Christian_AcademyEntities.Emergency_contact.FirstOrDefault(q => q.Teacher_ID == teacher.ID);

                var addEditTeacher = new AddEditTeacher(teacher, eContact);
                addEditTeacher.MdiParent = this.MdiParent;
                addEditTeacher.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}" + "\n\nPlease Click the first cell for desired row.");
            }
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
                var eContact = choice_Christian_AcademyEntities.Emergency_contact.FirstOrDefault(q => q.Teacher_ID == teacher.ID);
                var tResults = choice_Christian_AcademyEntities.Test_Result.FirstOrDefault(q => q.Teacher_ID == id);

                choice_Christian_AcademyEntities.Teachers.Remove(teacher);
                if (eContact != null)
                {
                    choice_Christian_AcademyEntities.Emergency_contact.Remove(eContact);
                }
                if (tResults != null)
                {
                    choice_Christian_AcademyEntities.Test_Result.Remove(tResults);
                }
            choice_Christian_AcademyEntities.SaveChanges();
                MessageBox.Show("Information Deleted");
                PopulateGrid();
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
            PopulateGrid();           
        }

        public void PopulateGrid()
        {
            var teacherdata = choice_Christian_AcademyEntities.Teachers
              .Select(q => new {
                  First_Name = q.First_Name,
                  Last_Name = q.Last_Name,
                  DOB = q.DOB,
                  Address = q.Address,
                  Qualification = q.Qualification,
                  Date_Employed = q.DateOf_Emp,
                  q.ID
              }).ToList();
            gvteacherdata.DataSource = teacherdata;
            gvteacherdata.Columns[0].HeaderText = "First Name";
            gvteacherdata.Columns[1].HeaderText = "Last Name";
            gvteacherdata.Columns[2].HeaderText = "DOB";
            gvteacherdata.Columns[3].HeaderText = "Address";
            gvteacherdata.Columns[4].HeaderText = "Qualification";
            gvteacherdata.Columns[5].HeaderText = "Date Employed";
            gvteacherdata.Columns[6].Visible = false;
        }
    }
}
