﻿using System;
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
        private readonly Choice_Christian_AcademyEntities choice_Christian_AcademyEntities;
        public AddEditTeacher()
        {
            InitializeComponent();
            lbl_Title.Text = "Add New Teacher";
            isEditMode = false;
        }
        public AddEditTeacher(Teacher editTeacherData)
        {
            InitializeComponent();
            PopulateFields(editTeacherData);
            lbl_Title.Text = "Edit Teacher Detail";
            isEditMode = true;
            choice_Christian_AcademyEntities = new Choice_Christian_AcademyEntities();
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
                var id = int.Parse(lblID.Text);
                var TeacherData = choice_Christian_AcademyEntities.Teachers.FirstOrDefault(q => q.ID == id);
                TeacherData.First_Name = tbFName.Text;
                TeacherData.Last_Name = tbLName.Text;
                TeacherData.Qualification = tbQualification.Text;
                TeacherData.Grade = tbGrade.Text;

                //Save Changes
                choice_Christian_AcademyEntities.SaveChanges();

                this.Close();
            }
            else
            {
                var newTeacher = new Teacher
                {
                    First_Name = tbFName.Text,
                    Last_Name = tbLName.Text,
                    Grade = tbGrade.Text,
                    Qualification = tbQualification.Text
                };
                choice_Christian_AcademyEntities.Teachers.Add(newTeacher);
                choice_Christian_AcademyEntities.SaveChanges();
                this.Close();
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}