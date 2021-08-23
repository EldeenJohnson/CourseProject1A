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
        private readonly Choice_Christian_AcademyEntities2 choice_Christian_AcademyEntities;
        public ViewStudentsInfo()
        {
            InitializeComponent();
            choice_Christian_AcademyEntities = new Choice_Christian_AcademyEntities2();
        }

        private void ViewStudentsInfo_Load_1(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        private void Editbotton_Click(object sender, EventArgs e)
        {
            try
            {
                //Get ID for selected row
                var id = (int)gvstudentdata.SelectedRows[0].Cells["Student_ID"].Value;
                //Query database
                var student = choice_Christian_AcademyEntities.Student_detail.FirstOrDefault(q => q.Student_ID == id);
                var parent = choice_Christian_AcademyEntities.Parents.FirstOrDefault(q => q.Student_ID == id);
                var parent2 = choice_Christian_AcademyEntities.Parents.FirstOrDefault(q => q.ID > parent.ID && q.Student_ID == id);

                //var addEditStudent = new RegistrationPage();
                var addEditStudent = new AddEditStudent(student, parent, parent2);
                addEditStudent.MdiParent = this.MdiParent;
                addEditStudent.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}"+"\n\nPlease Click the first cell for desired row.") ;
            }
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            try { 
            //Get ID for selected row
            var id = (int)gvstudentdata.SelectedRows[0].Cells["Student_ID"].Value;

            //Query database
            var student = choice_Christian_AcademyEntities.Student_detail.FirstOrDefault(q => q.Student_ID == id);
                var parent = choice_Christian_AcademyEntities.Parents.FirstOrDefault(q => q.Student_ID == id);
                    var parent2 = choice_Christian_AcademyEntities.Parents.FirstOrDefault(q => q.ID == parent.ID + 1 && q.Student_ID == id);
                        var tResults = choice_Christian_AcademyEntities.Test_Result.FirstOrDefault(q => q.Student_ID == id);
            var tReg = choice_Christian_AcademyEntities.Registrations.FirstOrDefault(q => q.Student_ID == id);
            //Delete data and save
            choice_Christian_AcademyEntities.Student_detail.Remove(student);
                choice_Christian_AcademyEntities.Parents.Remove(parent);

                if (parent2 != null )
                {
                    choice_Christian_AcademyEntities.Parents.Remove(parent2);
                }
                if(tResults != null)
                {
                choice_Christian_AcademyEntities.Test_Result.Remove(tResults);
                }
                if (tReg != null)
                {
                    choice_Christian_AcademyEntities.Registrations.Remove(tReg);
                }

            choice_Christian_AcademyEntities.SaveChanges();
            MessageBox.Show("Information Deleted");
            PopulateGrid();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}"+"\n\nPlease Click the first cell for desired row." );
            }
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
            this.Close();
        }

        private void Refreshbutton_Click(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        public void PopulateGrid()
        {
            var studentdata = choice_Christian_AcademyEntities.Student_detail
               .Select(q => new {
                   First_Name = q.First_Name,
                   Middle_Name = q.Mid_Name,
                   Last_Name = q.Last_Name,
                   Address = q.Address,
                   Date_of_Birth = q.Date_of_Birth,
                   gender = q.Gender,
                   q.Student_ID
               }).ToList();
            gvstudentdata.DataSource = studentdata;
            gvstudentdata.Columns[0].HeaderText = "First Name";
            gvstudentdata.Columns[1].HeaderText = "Middle Initial";
            gvstudentdata.Columns[2].HeaderText = "Last Name";
            gvstudentdata.Columns[3].HeaderText = "Address";
            gvstudentdata.Columns[4].HeaderText = "Date of Birth";
            gvstudentdata.Columns[5].HeaderText = "Gender";
            gvstudentdata.Columns[6].Visible = false;
        }
    }
}
