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
    public partial class AddEditStudent : Form
    {
        private readonly Choice_Christian_AcademyEntities3 choice_Christian_AcademyEntities;
        public AddEditStudent(Student_detail editstudentData, Parent EditInfo,Parent Parent2)
        {
            InitializeComponent();
            PopulateFields(editstudentData, EditInfo, Parent2);
            ///PopulateFields(EditInfo);
            choice_Christian_AcademyEntities = new Choice_Christian_AcademyEntities3();            
        }
        

        private void PopulateFields(Student_detail studentdata, Parent ParentData, Parent Parent2)
        {   //Retreive Student Data

            lblId.Text = studentdata.Student_ID.ToString();
            tbFName.Text = studentdata.First_Name;
            tbMInitial.Text = studentdata.Mid_Name;
            tbLName.Text = studentdata.Last_Name;
            cb_EditGen.Text = studentdata.Gender;
            tb_EditDOB.Value = (DateTime)studentdata.Date_of_Birth;
            tbAddress.Text = studentdata.Address;
            cb_Editheigthft.Text = studentdata.Height_ft;
            cb_EditheightIn.Text = studentdata.Height_in;
            tb_EdStuEmail.Text = studentdata.Email;
            tb_EdStuPhone.Text = studentdata.Phone_Num;
            tb_EditPrSch.Text = studentdata.Previous_School;
            cb_EdHouse.SelectedValue = studentdata.House_ID;
            cb_EdGrade.SelectedValue = studentdata.Grade_ID;
            cb_EdClass.SelectedValue = studentdata.Class_ID;
            rtb_EdstuAddInfo.Text = studentdata.AddInfo;


            //Retrive parent 1 Data if it exist                
            if (ParentData.Student_ID == studentdata.Student_ID && ParentData != null)
            {
                lblpar1.Text = ParentData.ID.ToString();
                tb_EdparFname.Text = ParentData.First_Name;
                tb_EdparLname.Text = ParentData.Last_Name;
                Par_EdDOB.Value = (DateTime)ParentData.Date_of_Birth;
                tb_EdparAddress.Text = ParentData.Address;
                tb_EdParphone.Text = ParentData.Contact_Number;
                tb_EdParEmail.Text = ParentData.Email;
                tb_EdParRelationship.Text = ParentData.Relationship;
            }

            else
            {
                lblpar1.Text = null;
                 tb_edPar2Fname.Enabled = false;
                 tb_EdPar2Lname.Enabled = false;
                 dp_EdPar2DOB.Enabled = false;
                 tb_EdPar2Add.Enabled = false;
                 tb_EdPar2Phone.Enabled = false;
                 tb_edPar2Email.Enabled = false;
                 tb_EditPar2Rel.Enabled = false;
            }



            //Retrive parent 2 Data  if it exists
            if (ParentData.Student_ID == studentdata.Student_ID && Parent2 != null)
                {
                    lblPar2.Text = Parent2.ID.ToString();
                    tb_edPar2Fname.Text = Parent2.First_Name;
                    tb_EdPar2Lname.Text = Parent2.Last_Name;
                    dp_EdPar2DOB.Value = (DateTime)Parent2.Date_of_Birth;
                    tb_EdPar2Add.Text = Parent2.Address;
                    tb_EdPar2Phone.Text = Parent2.Contact_Number;
                    tb_edPar2Email.Text = Parent2.Email;
                    tb_EditPar2Rel.Text = Parent2.Relationship;                    
                }
                else
                {
                    lblPar2.Text = null;
                    tb_edPar2Fname.Enabled = false;
                    tb_EdPar2Lname.Enabled = false;
                    dp_EdPar2DOB.Enabled = false;
                    tb_EdPar2Add.Enabled = false;
                    tb_EdPar2Phone.Enabled = false;
                    tb_edPar2Email.Enabled = false;
                    tb_EditPar2Rel.Enabled = false;                   
                }

        }
        
       
        private void SaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                var id = int.Parse(lblId.Text);
                var studentdata = choice_Christian_AcademyEntities.Student_detail.FirstOrDefault(q => q.Student_ID == id);
                studentdata.First_Name = tbFName.Text;
                studentdata.Mid_Name = tbMInitial.Text;
                studentdata.Last_Name = tbLName.Text;
                studentdata.Gender = cb_EditGen.Text;
                studentdata.Date_of_Birth = (DateTime)tb_EditDOB.Value;
                studentdata.Address = tbAddress.Text;
                studentdata.Height_ft = cb_Editheigthft.Text;
                studentdata.Height_in = cb_EditheightIn.Text;
                studentdata.Email = tb_EdStuEmail.Text;
                studentdata.Phone_Num = tb_EdStuPhone.Text;
                studentdata.Previous_School = tb_EditPrSch.Text;
                studentdata.House_ID = (int)cb_EdHouse.SelectedValue;
                studentdata.Grade_ID = (int)cb_EdGrade.SelectedValue;
                studentdata.Class_ID = (int)cb_EdClass.SelectedValue;
                studentdata.AddInfo = rtb_EdstuAddInfo.Text;

                var pid1 = int.Parse(lblpar1.Text);
                var ParentData = choice_Christian_AcademyEntities.Parents.FirstOrDefault(q => q.ID == pid1);
                ParentData.First_Name = tb_EdparFname.Text;
                ParentData.Last_Name = tb_EdparLname.Text;
                ParentData.Date_of_Birth = (DateTime)Par_EdDOB.Value;
                ParentData.Address = tb_EdparAddress.Text;
                ParentData.Contact_Number = tb_EdParphone.Text;
                ParentData.Email = tb_EdParEmail.Text;
                ParentData.Relationship = tb_EdParRelationship.Text;

                if (ParentData == null && studentdata != null)
                {
                    var newParentData = new Parent 
                    {
                        First_Name = tb_EdparFname.Text,
                        Last_Name = tb_EdparLname.Text,
                        Date_of_Birth = Par_EdDOB.Value,
                        Address = tb_EdparAddress.Text,
                        Contact_Number = tb_EdParphone.Text,
                        Email = tb_EdParEmail.Text,
                        Relationship = tb_EdParRelationship.Text,
                        Student_ID = studentdata.Student_ID 
                                            };
                    choice_Christian_AcademyEntities.Parents.Add(newParentData);
                }
           if (lblPar2.Text != null)
            {
                //var pid2 = int.Parse(lblPar2.Text);
                var Parent2 = choice_Christian_AcademyEntities.Parents.FirstOrDefault(q => q.ID > pid1 && q.Student_ID == studentdata.Student_ID);
                if (Parent2 != null)
                {
                    Parent2.First_Name = tb_edPar2Fname.Text;
                    Parent2.Last_Name = tb_EdPar2Lname.Text;
                    Parent2.Date_of_Birth = (DateTime)dp_EdPar2DOB.Value;
                    Parent2.Address = tb_EdPar2Add.Text;
                    Parent2.Contact_Number = tb_EdPar2Phone.Text;
                    Parent2.Email = tb_edPar2Email.Text;
                    Parent2.Relationship = tb_EditPar2Rel.Text;
                }
            }

            if (lblPar2.Text == "enable")          
            {
                    chk_Enable.Enabled = false;
                    var newParent2 = new Parent
                {
                    First_Name = tb_edPar2Fname.Text,
                    Last_Name = tb_EdPar2Lname.Text,
                    Date_of_Birth = dp_EdPar2DOB.Value,
                    Address = tb_EdPar2Add.Text,
                    Contact_Number = tb_EdPar2Phone.Text,
                    Email = tb_edPar2Email.Text,
                    Relationship = tb_EditPar2Rel.Text,
                    Student_ID = studentdata.Student_ID
                };
                choice_Christian_AcademyEntities.Parents.Add(newParent2);
            }
                
                     //Save Changes
                    choice_Christian_AcademyEntities.SaveChanges();
                    MessageBox.Show("Information Edited");
                    this.Close();                             
            }
           
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }              
                      

        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddEditStudent_Load(object sender, EventArgs e)
        {
            var House = choice_Christian_AcademyEntities.Houses.ToList();
            cb_EdHouse.DisplayMember = "Colour";
            cb_EdHouse.ValueMember = "id";
            cb_EdHouse.DataSource = House;

            var Grade = choice_Christian_AcademyEntities.Grades.ToList();
            cb_EdGrade.DisplayMember = "Grade1";
            cb_EdGrade.ValueMember = "id";
            cb_EdGrade.DataSource = Grade;

            var Class = choice_Christian_AcademyEntities.Classes.ToList();
            cb_EdClass.DisplayMember = "Class1";
            cb_EdClass.ValueMember = "id";
            cb_EdClass.DataSource = Class;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            lblPar2.Text = "enable";
            tb_edPar2Fname.Enabled = true;
            tb_EdPar2Lname.Enabled = true;
            dp_EdPar2DOB.Enabled = true;
            tb_EdPar2Add.Enabled = true;
            tb_EdPar2Phone.Enabled = true;
            tb_edPar2Email.Enabled = true;
            tb_EditPar2Rel.Enabled = true;
        }
    }

}
