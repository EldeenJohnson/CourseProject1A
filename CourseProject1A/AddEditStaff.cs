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
        private readonly Choice_Christian_AcademyEntities2 choice_Christian_AcademyEntities;


        public AddEditStaff()
        {
            InitializeComponent();
            lbl_Title.Text = "Add New Staff";
            isEditMode = false;
            choice_Christian_AcademyEntities = new Choice_Christian_AcademyEntities2();
        }
        public AddEditStaff(Staff editstaffData, Emergency_contact editContact)
        {
            InitializeComponent();
            PopulateFields(editstaffData, editContact);
            lbl_Title.Text = "Edit Staff Detail";
            isEditMode = true;
            choice_Christian_AcademyEntities = new Choice_Christian_AcademyEntities2();
        }

        private void PopulateFields(Staff StaffData, Emergency_contact eContactData)
        {
            lblID.Text = StaffData.ID.ToString();
            tb_sFName.Text = StaffData.First_Name;
            tb_sLName.Text = StaffData.Last_Name;
            dp_sDOB.Value = (DateTime)StaffData.DOB;
            tb_sAddress.Text = StaffData.Address;
            tb_sPhone.Text = StaffData.Phone;
            tb_sEmail.Text = StaffData.Email;
            tb_sQualification.Text = StaffData.Qualification;
            tb_sDOE.Value = (DateTime)StaffData.Date_of_Employment;
            tbJob_Title.Text = StaffData.Job_Title;
            cb_sDept.SelectedValue = StaffData.Department;
          
                lbl_eCon.Text = eContactData.ID.ToString();
                tb_sECFName.Text = eContactData.First_Name;
                tb_sECLName.Text = eContactData.Last_Name;
                tb_sECAddress.Text = eContactData.Address;
                tb_sECEmail.Text = eContactData.Email;
                tb_sECPhone.Text = eContactData.Phone;
        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            if (isEditMode)
            {
                try { 
                        var id = int.Parse(lblID.Text);
                        var StaffData = choice_Christian_AcademyEntities.Staffs.FirstOrDefault(q => q.ID == id);
                            StaffData.First_Name = tb_sFName.Text;
                            StaffData.Last_Name = tb_sLName.Text;
                            StaffData.DOB = dp_sDOB.Value;
                            StaffData.Address = tb_sAddress.Text;
                            StaffData.Phone = tb_sPhone.Text;
                            StaffData.Email = tb_sPhone.Text;                          
                            StaffData.Qualification = tb_sQualification.Text;
                            StaffData.Date_of_Employment = tb_sDOE.Value;
                            StaffData.Job_Title = tbJob_Title.Text;
                            StaffData.Dept_ID = (int)cb_sDept.SelectedValue;

                         var ecID = int.Parse(lbl_eCon.Text);
                         var eContactData = choice_Christian_AcademyEntities.Emergency_contact.FirstOrDefault(q => q.ID == ecID);
                            eContactData.First_Name = tb_sECFName.Text;
                            eContactData.Last_Name = tb_sECLName.Text;
                            eContactData.Email = tb_sECEmail.Text;
                            eContactData.Phone = tb_sECPhone.Text;
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
                           var StaffData = new Staff
                        {
                            First_Name = tb_sFName.Text,
                            Last_Name = tb_sLName.Text,
                            Address = tb_sAddress.Text,
                            DOB = dp_sDOB.Value,
                            Phone = tb_sPhone.Text,
                            Email = tb_sEmail.Text,
                            Qualification = tb_sQualification.Text,
                            Date_of_Employment = tb_sDOE.Value,
                            Job_Title = tbJob_Title.Text,
                            Dept_ID = (int)cb_sDept.SelectedValue
                        };
                    choice_Christian_AcademyEntities.Staffs.Add(StaffData);

                    var eContactData = new Emergency_contact
                    {
                        First_Name = tb_sECFName.Text,
                        Last_Name = tb_sECLName.Text,
                        Address = tb_sECAddress.Text,
                        Email = tb_sECEmail.Text,
                        Phone = tb_sECPhone.Text,
                        Staff_ID = StaffData.ID
                    };
                   choice_Christian_AcademyEntities.Emergency_contact.Add(eContactData);

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

        private void AddEditStaff_Load(object sender, EventArgs e)
        {
            var Department = choice_Christian_AcademyEntities.Departments.ToList();
            cb_sDept.DisplayMember = "Dept_Name";
            cb_sDept.ValueMember = "id";
            cb_sDept.DataSource = Department;
        }
    }
}
