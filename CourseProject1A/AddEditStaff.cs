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
    public partial class AddEditStaff : Form
    {
        private bool isEditMode;
        private readonly Choice_Christian_AcademyEntities choice_Christian_AcademyEntities;


        public AddEditStaff()
        {
            InitializeComponent();
            lbl_Title.Text = "Add New Staff";
            isEditMode = false;
        }
        public AddEditStaff(Staff editstaffData)
        {
            InitializeComponent();
            PopulateFields(editstaffData);
            lbl_Title.Text = "Edit Staff Detail";
            isEditMode = true;
            choice_Christian_AcademyEntities = new Choice_Christian_AcademyEntities();
        }

        private void PopulateFields(Staff StaffData)
        {
            lblID.Text = StaffData.ID.ToString();
            tbFName.Text = StaffData.First_Name;
            tbLName.Text = StaffData.Last_Name;
            tbAddress.Text = StaffData.Address;
            tbQualification.Text = StaffData.Qualification;
            tbDOE.Value = StaffData.Date_of_Employment;
            tbJob_Title.Text = StaffData.Job_Title;
        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            if (isEditMode)
            {
            var id = int.Parse(lblID.Text);
            var StaffData = choice_Christian_AcademyEntities.Staffs.FirstOrDefault(q => q.ID == id);
            StaffData.First_Name = tbFName.Text;
            StaffData.Last_Name = tbLName.Text;
            StaffData.Address = tbAddress.Text;
            StaffData.Qualification = tbQualification.Text;
            StaffData.Date_of_Employment = tbDOE.Value;
            StaffData.Job_Title = tbJob_Title.Text;


            //Save Changes
            choice_Christian_AcademyEntities.SaveChanges();

            this.Close();
            }
            else
            {
                var newStaff = new Staff
                {
                    First_Name = tbFName.Text,
                    Last_Name = tbLName.Text,
                    Address = tbAddress.Text,
                    Qualification = tbQualification.Text,
                    Date_of_Employment = tbDOE.Value,
                    Job_Title = tbJob_Title.Text
                };
                choice_Christian_AcademyEntities.Staffs.Add(newStaff);
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
