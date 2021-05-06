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
    public partial class ViewStaff : Form
    {
        private readonly Choice_Christian_AcademyEntities choice_Christian_AcademyEntities;
        public ViewStaff()
        {
            InitializeComponent();
            choice_Christian_AcademyEntities = new Choice_Christian_AcademyEntities();
        }

        private void ViewStaff_Load(object sender, EventArgs e)
        {
            var staffdata = choice_Christian_AcademyEntities.Staffs
               .Select(q => new {
                   First_Name = q.First_Name,
                   Last_Name = q.Last_Name,
                   Address = q.Address,
                   Date_of_Employment = q.Date_of_Employment,
                   Qualification = q.Qualification,
                   Job_Title = q.Job_Title,
                   q.ID
               }).ToList();
            gvstaffdata.DataSource = staffdata;
            gvstaffdata.Columns[0].HeaderText = "First Name";
            gvstaffdata.Columns[1].HeaderText = "Last Name";
            gvstaffdata.Columns[2].HeaderText = "Address";
            gvstaffdata.Columns[3].HeaderText = "Date of Employment";
            gvstaffdata.Columns[4].HeaderText = "Qualification";
            gvstaffdata.Columns[5].HeaderText = "Job Title";
            gvstaffdata.Columns[6].Visible = false;
        }

        private void Editbotton_Click(object sender, EventArgs e)
        {
            //Get ID for selected row
            var id = (int)gvstaffdata.SelectedRows[0].Cells["ID"].Value;
            //Query database
            var Staff = choice_Christian_AcademyEntities.Staffs.FirstOrDefault(q => q.ID == id);

            var addEditStaff = new AddEditStaff(Staff);
            addEditStaff.MdiParent = this.MdiParent;
            addEditStaff.Show();
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            //Get ID for selected row
            var id = (int)gvstaffdata.SelectedRows[0].Cells["ID"].Value;
            //Query database
            var Staff = choice_Christian_AcademyEntities.Staffs.FirstOrDefault(q => q.ID == id);

            //Delete data and save
            choice_Christian_AcademyEntities.Staffs.Remove(Staff);
            choice_Christian_AcademyEntities.SaveChanges();

            gvstaffdata.Refresh();
        }

        private void Closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            var AddEditStaff = new AddEditStaff();
            AddEditStaff.MdiParent = this.MdiParent;
            AddEditStaff.Show();
        }
    }
}