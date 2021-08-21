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
        public AddEditTeacher(Teacher editTeacherData, Emergency_contact emergency)
        {
            InitializeComponent();
            PopulateFields(editTeacherData, emergency);
            lbl_Title.Text = "Edit Teacher Detail";
            isEditMode = true;
            choice_Christian_AcademyEntities = new Choice_Christian_AcademyEntities2();
        }

        private void PopulateFields(Teacher TeacherData, Emergency_contact ecData )
        {
            lblID.Text = TeacherData.ID.ToString();
            tb_TFName.Text = TeacherData.First_Name;
            tb_TLName.Text = TeacherData.Last_Name;
            dtp_TDob.Value = (DateTime)TeacherData.DOB;
            tb_TAddress.Text = TeacherData.Address;
            tb_TPhone.Text = TeacherData.Phone;
            tb_TEmail.Text = TeacherData.Email;
            tbQualification.Text = TeacherData.Qualification;
            tb_TprEmp.Text = TeacherData.Prev_Employer;
            dtp_TDateEmp.Value = (DateTime)TeacherData.DateOf_Emp;
            cb_TGrade.SelectedValue = TeacherData.Grade_ID;
            cb_TClass.SelectedValue = TeacherData.Class_ID;
            cb_Faculty.SelectedValue = TeacherData.Faculty_ID;

            if (ecData.Teacher_ID == TeacherData.ID )
            {
                lbl_ecID.Text = ecData.ID.ToString();
                tb_ECFName.Text = ecData.First_Name;
                tb_ECLName.Text = ecData.Last_Name;
                tb_ECAddress.Text = ecData.Address;
                tb_ECEmail.Text = ecData.Email;
                tb_ECPhone.Text = ecData.Phone;
            }


        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            if (isEditMode)
            {
                try
                {
                    var id = int.Parse(lblID.Text);
                    var TeacherData = choice_Christian_AcademyEntities.Teachers.FirstOrDefault(q => q.ID == id);
                    TeacherData.First_Name = tb_TFName.Text;
                    TeacherData.Last_Name = tb_TLName.Text;
                    TeacherData.DOB = dtp_TDob.Value;
                    TeacherData.Address = tb_TAddress.Text;
                    TeacherData.Phone = tb_TPhone.Text;
                    TeacherData.Email = tb_TEmail.Text;
                    TeacherData.Qualification = tbQualification.Text;
                    TeacherData.Prev_Employer = tb_TprEmp.Text;
                    TeacherData.DateOf_Emp = dtp_TDateEmp.Value;
                    TeacherData.Grade_ID = (int)cb_TGrade.SelectedValue;
                    TeacherData.Class_ID = (int)cb_TClass.SelectedValue;
                    TeacherData.Faculty_ID = (int)cb_Faculty.SelectedValue;

                    var ecID = int.Parse(lbl_ecID.Text);
                    var ecData = choice_Christian_AcademyEntities.Emergency_contact.FirstOrDefault(q => q.ID == ecID);
                    ecData.First_Name = tb_ECFName.Text;
                    ecData.Last_Name = tb_ECLName.Text;
                    ecData.Address = tb_ECAddress.Text;
                    ecData.Email = tb_ECEmail.Text;
                    ecData.Phone = tb_ECPhone.Text;
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
                    First_Name = tb_TFName.Text,
                    Last_Name = tb_TLName.Text,
                    DOB = dtp_TDob.Value,
                    Address = tb_TAddress.Text,
                    Phone = tb_TPhone.Text,
                    Email = tb_TEmail.Text,
                    Qualification = tbQualification.Text,
                    Prev_Employer = tb_TprEmp.Text,
                    DateOf_Emp = dtp_TDateEmp.Value,
                    Grade_ID = (int)cb_TGrade.SelectedValue,
                    Class_ID = (int)cb_TClass.SelectedValue,
                    Faculty_ID = (int)cb_Faculty.SelectedValue,
                };
                choice_Christian_AcademyEntities.Teachers.Add(newTeacher);

                var newEcontact = new Emergency_contact
                {
                    First_Name = tb_ECFName.Text,
                    Last_Name = tb_ECLName.Text,
                    Address = tb_ECAddress.Text,
                    Email = tb_ECEmail.Text,
                    Phone = tb_ECPhone.Text,
                };
                    choice_Christian_AcademyEntities.Emergency_contact.Add(newEcontact);
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

        private void AddEditTeacher_Load(object sender, EventArgs e)
        {
            var Faculty = choice_Christian_AcademyEntities.Faculties.ToList();
            cb_Faculty.DisplayMember = "Faculty_Name";
            cb_Faculty.ValueMember = "id";
            cb_Faculty.DataSource = Faculty;

            var Grade = choice_Christian_AcademyEntities.Grades.ToList();
            cb_TGrade.DisplayMember = "Grade1";
            cb_TGrade.ValueMember = "id";
            cb_TGrade.DataSource = Grade;

            var Class = choice_Christian_AcademyEntities.Classes.ToList();
            cb_TClass.DisplayMember = "Class1";
            cb_TClass.ValueMember = "id";
            cb_TClass.DataSource = Class;

            
        }
    }
}
