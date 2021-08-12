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
    public partial class RegistrationPage : Form
    {
        private readonly Choice_Christian_AcademyEntities choice_Christian_AcademyEntities;
        public RegistrationPage()
        {
            InitializeComponent();
            choice_Christian_AcademyEntities = new Choice_Christian_AcademyEntities();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime TodaysDate = DateTime.Now;
                bool isValid = true;
                var errorMessage = "\tError!\n\r";

                //Student Information
                string stuFName = tb_stufname.Text;
                string stuLName = tb_stulname.Text;
                string stuMname = tb_stuMname.Text;
                DateTime stuDOB = stu_DOB.Value;
                string stuGender = cb_Gender.Text.ToString();
                var Height_ft = cb_HeightFt.Text.ToString();
                var Height_in = cb_HeightIn.Text.ToString();
                string StuAddress = tb_stuAddress.Text;
                string stuEmail = tb_StuEmail.Text;
                string stuPhone = tb_StuPhone.Text;
                string PrevSchool = tb_stuPreSch.Text;
                var BirthEntryNum = tb_StuBEntry.Text;
                string stuHouse = cb_StuHouse.Text.ToString();
             //   var stuUpload = tb_StuUpload.Text;
                string StuAddInfo = rtb_stuAddInfo.Text;

                //Parent1 Info
                string par1fName = tb_parFname.Text;
                string par1lName = tb_parLname.Text;
                DateTime par1DOB = Par_DOB.Value;
                string par1Address = tb_parAddress.Text;
                string par1Email = tb_ParEmail.Text;
                string parPhone = tb_Parphone.Text;
                string parRelationship = tb_ParRelationship.Text;

                //Parent2 Info
                string par2fName = tb_Par2Fname.Text;
                string par2lName = tb_Par2Lname.Text;
                DateTime par2DOB = Par2_DOB.Value;
                string par2Address = tb_par2Address.Text;
                string par2Email = tb_Par2Email.Text;
                string par2Phone = tb_Par2Phone.Text;
                string par2Relationship = tb_Par2Relationship.Text;

                if (stuDOB >= DateTime.Today || par1DOB >= DateTime.Today || par2DOB >= DateTime.Today)
                {
                    //isValid = false;
                    errorMessage += "Invalid date Selected.\n\r";
                }
                //Data Validation
                if 
                    (string.IsNullOrWhiteSpace(stuFName) || string.IsNullOrWhiteSpace(stuLName)
                    || string.IsNullOrWhiteSpace(stuEmail) || string.IsNullOrWhiteSpace(StuAddress)
                    || string.IsNullOrWhiteSpace(BirthEntryNum) || string.IsNullOrWhiteSpace(stuPhone) 
                    || string.IsNullOrWhiteSpace(Height_ft) || string.IsNullOrWhiteSpace(Height_in)
                    || string.IsNullOrWhiteSpace(StuAddress)|| string.IsNullOrWhiteSpace(stuEmail)
                    || string.IsNullOrWhiteSpace(par1fName) || string.IsNullOrWhiteSpace(par1lName)
                    || string.IsNullOrWhiteSpace(parPhone) || string.IsNullOrWhiteSpace(par1Address)
                    || string.IsNullOrWhiteSpace(parRelationship) || string.IsNullOrWhiteSpace(par1Email)
                    || string.IsNullOrWhiteSpace(par2fName) || string.IsNullOrWhiteSpace(par2lName) 
                    || string.IsNullOrWhiteSpace(par2Relationship) || string.IsNullOrWhiteSpace(par2Email)) 
                {
                    isValid = false;
                    errorMessage += "Please enter missing data.\n\r";
                }

                if (isValid)
                {
                    var studentrecord = new Student();
                    studentrecord.First_Name = tb_stufname.Text;
                    studentrecord.Mid_Name = tb_stuMname.Text;
                    studentrecord.Last_Name = tb_stulname.Text;
                    studentrecord.Gender = cb_Gender.Text;
                    studentrecord.Address = tb_stuAddress.Text;
                    studentrecord.Birth_Entry_Number = tb_StuBEntry.Text;
                    studentrecord.Previous_School = cb_Gender.Text;
                    studentrecord.Date_of_Birth = stu_DOB.Value;

                    var parentrecord = new Parent();
                    parentrecord.First_Name = par1fName;
                    parentrecord.Last_Name = par1lName;
                    parentrecord.Address = par1Address;
                    parentrecord.Contact_Number = parPhone;
                    parentrecord.Email = par1Email;
                    parentrecord.Relationship = parRelationship;

                    var parent2record = new Parent();
                    parent2record.First_Name = par2fName;
                    parent2record.Last_Name = par2lName;
                    parent2record.Address = par2Address;
                    parentrecord.Contact_Number = par2Phone;
                    parent2record.Email = par2Email;
                    parent2record.Relationship = par2Relationship;


                    MessageBox.Show($"\tThank you {stuFName} {stuLName}.\n\r" +
                        $"Your Application was submitted successfully!\n\r" +
                        $"\n\t{TodaysDate}");
                }
                else
                {
                    MessageBox.Show(errorMessage);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

        }

        //Cancel Buttons
        private void btn_StuCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ParCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_RevCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Previous & Next Buttons
        private void studentnext_Click_1(object sender, EventArgs e)
        {
            tabRegistration.SelectTab(1);
        }

        private void btn_ParPrev_Click(object sender, EventArgs e)//Parents Tab previous button
        {
            tabRegistration.SelectTab(0);
        }

        private void btn_ParNext_Click(object sender, EventArgs e)//parents Tab Next button
        {
            tabRegistration.SelectTab(2);

            //Below code will display entered data for review
            rtb_Review.Text = "STUDENT INFORMATION"+
                               "\n\nName: " + tb_stufname.Text + " " + tb_stuMname.Text + " " + tb_stulname.Text +
                               "\nDOB: " + stu_DOB.Value.ToShortDateString() +
                               "\nGender: " + cb_Gender.Text +
                               "\nHeight: " + cb_HeightFt.Text + "ft," + cb_HeightIn.Text + "in"+
                               "\nAddress: "+ tb_stuAddress.Text +
                               "\nEmail: "+ tb_StuEmail.Text +
                               "\nPhone Number: "+ tb_StuPhone.Text +
                               "\nPrevious School: "+ tb_stuPreSch.Text +
                               "\nBirth Entry Number: "+ tb_StuBEntry.Text +
                               "\nHouse: "+ cb_StuHouse.Text +
                            //   "\nPicture: "+ tb_StuUpload.Text +
                               "\nAdditional Info: "+ rtb_stuAddInfo.Text +
                               "\n\n"+

                               //Review Parent 1
                               "PARENT 1 INFORMATION"+
                               "\nFirst Name: "+ tb_parFname.Text +
                               "\nLast Name: "+ tb_parLname.Text +
                               "\nDate Of Birth: "+ Par_DOB.Value +
                               "\nAddress: "+ tb_parAddress.Text +
                               "\nEmail: "+ tb_ParEmail.Text +
                               "\nPhone Number: "+ tb_Parphone.Text +
                               "\nRelationship: "+ tb_ParRelationship.Text +
                               "\n\n" +
                              
                               //Review Parent 2
                               "PARENT 2 INFORMATION" +
                               "\nFirst Name: " + tb_Par2Fname.Text +
                               "\nLast Name:" + tb_Par2Lname.Text +
                               "\nDate Of Birth: " + Par2_DOB.Value +
                               "\nAddress: " + tb_par2Address.Text +
                               "\nEmail: " + tb_Par2Email.Text +
                               "\nPhone Number: " + tb_Par2Phone.Text +
                               "\nRelationship: " + tb_Par2Relationship.Text;

        }

        private void btn_RevPre_Click(object sender, EventArgs e)//review tab previous button
        {
            tabRegistration.SelectTab(1);
        }

        private void RegistrationPage_Load(object sender, EventArgs e)
        {
            var house = choice_Christian_AcademyEntities.Houses.ToList();
            cb_StuHouse.DisplayMember = "Colour";
            cb_StuHouse.ValueMember = "id";
            cb_StuHouse.DataSource = house;
        }

        private void Submitbutton_Click(object sender, EventArgs e)
        {
             try
            {
            var newstudent = new Student
            {
                First_Name = tb_stufname.Text,
                Last_Name = tb_stulname.Text,
                Mid_Name = tb_stuMname.Text,
                Gender = cb_Gender.Text,
                Address = tb_stuAddress.Text,
                Date_of_Birth = stu_DOB.Value,
                Previous_School = tb_stuPreSch.Text,
                Birth_Entry_Number = tb_StuBEntry.Text
            };
            choice_Christian_AcademyEntities.Students.Add(newstudent);
            ////choice_Christian_AcademyEntities.SaveChanges();
            var newparent = new Parent
            {
                First_Name = tb_parLname.Text,
                Last_Name = tb_parLname.Text,
                Address = tb_parAddress.Text,
                Contact_Number = tb_Parphone.Text,
                Relationship = tb_ParRelationship.Text,
                Email = tb_ParEmail.Text
            };
            choice_Christian_AcademyEntities.Parents.Add(newparent);

            ////choice_Christian_AcademyEntities.SaveChanges();
            var secondparent = new Parent
            {
                First_Name = tb_Par2Fname.Text,
                Last_Name = tb_Par2Lname.Text,
                Address = tb_par2Address.Text,
                Contact_Number = tb_Par2Phone.Text,
                Relationship = tb_Par2Relationship.Text,
                Email = tb_Par2Email.Text
            }; 
            choice_Christian_AcademyEntities.Parents.Add(secondparent);

            choice_Christian_AcademyEntities.SaveChanges();
            MessageBox.Show("Information Submitted");
            this.Close();
            }
              catch (Exception ex)
              {
                  MessageBox.Show($"Error: {ex.Message}");
              } 
        }

        private void btn_StuUpload_Click(object sender, EventArgs e)
        {
            ////var image = new Image();
            ////image.MdiParent = this.MdiParent;
            ////image.Show();
        }
    }
}    

