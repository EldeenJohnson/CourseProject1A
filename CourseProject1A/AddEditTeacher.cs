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
    public partial class AddEditTeacher : Form
    {
        private bool isEditMode;
        private readonly Choice_Christian_AcademyEntities2 choice_Christian_AcademyEntities;
        public AddEditTeacher()
        {
            InitializeComponent();
            lbl_Title.Text = "Add New Teacher";
            isEditMode = false;
            choice_Christian_AcademyEntities = new Choice_Christian_AcademyEntities2();
        }
        public AddEditTeacher(Teacher editTeacherData)
        {
            InitializeComponent();
            PopulateFields(editTeacherData);
            lbl_Title.Text = "Edit Teacher Detail";
            isEditMode = true;
            choice_Christian_AcademyEntities = new Choice_Christian_AcademyEntities2();
        }

        private void PopulateFields(Teacher TeacherData)
        {
            lblID.Text = TeacherData.ID.ToString();
            tbFName.Text = TeacherData.First_Name;
            tbLName.Text = TeacherData.Last_Name;
            tbQualification.Text = TeacherData.Qualification;
            tbGrade.Text = TeacherData.Grade;
        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            if (isEditMode)
            {
                try
                {
                    var id = int.Parse(lblID.Text);
                    var TeacherData = choice_Christian_AcademyEntities.Teachers.FirstOrDefault(q => q.ID == id);
                    TeacherData.First_Name = tbFName.Text;
                    TeacherData.Last_Name = tbLName.Text;
                    TeacherData.Qualification = tbQualification.Text;
                    TeacherData.Grade = tbGrade.Text;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
                //Save Changes
                choice_Christian_AcademyEntities.SaveChanges();
                MessageBox.Show("Information Edited");
                this.Close();
                
            }
            else
            {
                try { 
                var newTeacher = new Teacher
                {
                    First_Name = tbFName.Text,
                    Last_Name = tbLName.Text,
                    Grade = tbGrade.Text,
                    Qualification = tbQualification.Text
                };
                choice_Christian_AcademyEntities.Teachers.Add(newTeacher);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
                choice_Christian_AcademyEntities.SaveChanges();
                MessageBox.Show("Information Submitted");
                this.Close();
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
