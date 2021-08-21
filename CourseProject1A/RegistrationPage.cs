using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace CourseProject1A
{
    public partial class RegistrationPage : Form
    {
        private readonly Choice_Christian_AcademyEntities2 choice_Christian_AcademyEntities;
        public RegistrationPage()
        {
            InitializeComponent();
            choice_Christian_AcademyEntities = new Choice_Christian_AcademyEntities2();
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
                if (Par2_IsChecked != false)
                {
                    string par2fName = tb_Par2Fname.Text;
                    string par2lName = tb_Par2Lname.Text;
                    DateTime par2DOB = Par2_DOB.Value;
                    if (par2DOB >= DateTime.Today)
                    {
                        errorMessage += "Invalid date Selected.\n\r";
                    }
                    string par2Address = tb_par2Address.Text;
                    string par2Email = tb_Par2Email.Text;
                    string par2Phone = tb_Par2Phone.Text;
                    string par2Relationship = tb_Par2Relationship.Text;

                    if (string.IsNullOrWhiteSpace(par2fName) || string.IsNullOrWhiteSpace(par2lName)
                        || string.IsNullOrWhiteSpace(par2Relationship) || string.IsNullOrWhiteSpace(par2Email))
                    {
                        isValid = false;
                        errorMessage += "Please enter missing data.\n\r";
                    }
                }

                if (stuDOB >= DateTime.Today || par1DOB >= DateTime.Today)
                {
                    isValid = false;
                    errorMessage += "Invalid date Selected.\n\r";
                }
                //Data Validation
                if
                    (string.IsNullOrWhiteSpace(stuFName) || string.IsNullOrWhiteSpace(stuLName)
                    || string.IsNullOrWhiteSpace(stuEmail) || string.IsNullOrWhiteSpace(StuAddress)
                    || string.IsNullOrWhiteSpace(BirthEntryNum) || string.IsNullOrWhiteSpace(stuPhone)
                    || string.IsNullOrWhiteSpace(Height_ft) || string.IsNullOrWhiteSpace(Height_in)
                    || string.IsNullOrWhiteSpace(StuAddress) || string.IsNullOrWhiteSpace(stuEmail)
                    || string.IsNullOrWhiteSpace(par1fName) || string.IsNullOrWhiteSpace(par1lName)
                    || string.IsNullOrWhiteSpace(parPhone) || string.IsNullOrWhiteSpace(par1Address)
                    || string.IsNullOrWhiteSpace(parRelationship) || string.IsNullOrWhiteSpace(par1Email))
                {
                    isValid = false;
                    errorMessage += "Please enter missing data.\n\r";
                }

                if (isValid) //Will Add data to the database
                {                    
                        var studentrecord = new Student_detail();
                        studentrecord.First_Name = stuFName;
                        studentrecord.Mid_Name = stuMname;
                        studentrecord.Last_Name = stuLName;
                        studentrecord.Date_of_Birth = stuDOB;
                        studentrecord.Gender = stuGender;
                        studentrecord.Height_ft = Height_ft;
                        studentrecord.Height_in = Height_in;
                        studentrecord.Address = StuAddress;
                        studentrecord.Email = stuEmail;
                        studentrecord.Phone_Num = stuPhone;
                        studentrecord.Birth_Entry_Number = BirthEntryNum;
                        studentrecord.Previous_School = PrevSchool;
                        studentrecord.House_ID = (int)cb_StuHouse.SelectedValue;
                        studentrecord.Grade_ID = (int)cb_Grade.SelectedValue;
                        studentrecord.Class_ID = (int)cb_Class.SelectedValue;
                       // studentrecord.Image_ID = 
                        studentrecord.AddInfo = StuAddInfo;
                    choice_Christian_AcademyEntities.Student_detail.Add(studentrecord);
                   
                    var parentrecord = new Parent();
                    parentrecord.First_Name = par1fName;
                    parentrecord.Last_Name = par1lName;
                    parentrecord.Date_of_Birth = par1DOB;
                    parentrecord.Address = par1Address;
                    parentrecord.Contact_Number = parPhone;
                    parentrecord.Email = par1Email;
                    parentrecord.Relationship = parRelationship;
                    parentrecord.Student_ID = studentrecord.Student_ID;
                    choice_Christian_AcademyEntities.Parents.Add(parentrecord);
                  
                    if (Par2_IsChecked != false)
                    {
                        var parent2record = new Parent();
                        parent2record.First_Name = tb_Par2Fname.Text;
                        parent2record.Last_Name = tb_Par2Lname.Text;
                        parent2record.Date_of_Birth = Par2_DOB.Value;
                        parent2record.Address = tb_par2Address.Text;
                        parent2record.Contact_Number = tb_Par2Phone.Text;
                        parent2record.Email = tb_Par2Email.Text;
                        parent2record.Relationship = tb_Par2Relationship.Text;
                        parent2record.Student_ID = studentrecord.Student_ID;

                        choice_Christian_AcademyEntities.Parents.Add(parent2record);
                        
                    }
                    choice_Christian_AcademyEntities.SaveChanges();



                    MessageBox.Show($"\tThank you {stuFName} {stuLName}.\n\r" +
                        $"Your Application was submitted successfully!\n\r" +
                        $"\n\t{TodaysDate}");
                    this.Close();
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
            rtb_Review.Text = "STUDENT INFORMATION" +
                               "\n\nName: " + tb_stufname.Text + " " + tb_stuMname.Text + " " + tb_stulname.Text +
                               "\nDOB: " + stu_DOB.Value.ToShortDateString() +
                               "\nGender: " + cb_Gender.Text +
                               "\nHeight: " + cb_HeightFt.Text + "ft, " + cb_HeightIn.Text + "in" +
                               "\nAddress: " + tb_stuAddress.Text +
                               "\nEmail: " + tb_StuEmail.Text +
                               "\nPhone Number: " + tb_StuPhone.Text +
                               "\nPrevious School: " + tb_stuPreSch.Text +
                               "\nBirth Entry Number: " + tb_StuBEntry.Text +
                               "\nHouse: " + cb_StuHouse.Text + 
                               "\nHouse: " + cb_Grade.Text + "Class " + cb_Class +
                               "\nPicture: "+ lbImgFile.Text +
                               "\nAdditional Info: " + rtb_stuAddInfo.Text +
                               "\n\n" +

                               //Review Parent 1
                               "PARENT 1 INFORMATION" +
                               "\n\nFirst Name: " + tb_parFname.Text +
                               "\nLast Name: " + tb_parLname.Text +
                               "\nDate Of Birth: " + Par_DOB.Value +
                               "\nAddress: " + tb_parAddress.Text +
                               "\nEmail: " + tb_ParEmail.Text +
                               "\nPhone Number: " + tb_Parphone.Text +
                               "\nRelationship: " + tb_ParRelationship.Text +
                               "\n\n";

                            //Review Parent 2
                            if (Par2_IsChecked != false)
                            {
                                rtb_Review.Text +=
                                "PARENT 2 INFORMATION" +
                                "\n\nFirst Name: " + tb_Par2Fname.Text +
                                "\nLast Name:" + tb_Par2Lname.Text +
                                "\nDate Of Birth: " + Par2_DOB.Value +
                                "\nAddress: " + tb_par2Address.Text +
                                "\nEmail: " + tb_Par2Email.Text +
                                "\nPhone Number: " + tb_Par2Phone.Text +
                                "\nRelationship: " + tb_Par2Relationship.Text;
                            }
        }
        private void btn_RevPre_Click(object sender, EventArgs e)//review tab previous button
        {
            tabRegistration.SelectTab(1);
        }

        private void RegistrationPage_Load(object sender, EventArgs e)
        {
            var House = choice_Christian_AcademyEntities.Houses.ToList();
            cb_StuHouse.DisplayMember = "Colour";
            cb_StuHouse.ValueMember = "id";
            cb_StuHouse.DataSource = House;

            var Grade = choice_Christian_AcademyEntities.Grades.ToList();
            cb_Grade.DisplayMember = "Grade1";
            cb_Grade.ValueMember = "id";
            cb_Grade.DataSource = Grade;

            var Class = choice_Christian_AcademyEntities.Classes.ToList();
            cb_Class.DisplayMember = "Class1";
            cb_Class.ValueMember = "id";
            cb_Class.DataSource = Class;
        }

        private void btn_StuUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.png;*.jpg;*.jpeg;*.gif;*.bmp;)| *.png;*.jpg;*.jpeg;*.gif;*.bmp;";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                lbImgFile.Text = opnfd.FileName;
                //var Img = new Image();
            }

            File.Copy(lbImgFile.Text, Path.Combine(@"C:\Users\andre\source\repos\CourseProject1A\CourseProject1A\Resources\", Path.GetFileName(lbImgFile.Text)), true);
        }

        private void tb_stufname_Click(object sender, EventArgs e)
        {
            if (tb_stufname.Text == "First Name")
            {
                tb_stufname.Text = "";


            }
        }


        private void tb_stufname_Leave_1(object sender, EventArgs e)
        {
            if (tb_stufname.Text == "")
            {
                tb_stufname.Text = "First Name";
                tb_stufname.ForeColor = Color.Black;

            }
        }

        private void tb_stuMname_Click(object sender, EventArgs e)
        {
            if (tb_stuMname.Text == "Middle Name")
            {
                tb_stuMname.Text = "";


            }
        }

        private void tb_stuMname_Leave(object sender, EventArgs e)
        {
            if (tb_stuMname.Text == "")
            {
                tb_stuMname.Text = "Middle Name";
                tb_stuMname.ForeColor = Color.Black;

            }
        }

        private void tb_stulname_Click(object sender, EventArgs e)
        {
            if (tb_stulname.Text == "Last Name")
            {
                tb_stulname.Text = "";


            }
        }

        private void tb_stulname_Leave(object sender, EventArgs e)
        {
            if (tb_stulname.Text == "")
            {
                tb_stulname.Text = "Last Name";

                tb_stulname.ForeColor = Color.Black;
            }
        }

        private void tb_parFname_Click(object sender, EventArgs e)
        {
            if (tb_parFname.Text == "First Name")
            {
                tb_parFname.Text = "";

            }
        }

        private void tb_parFname_Leave(object sender, EventArgs e)
        {
            if (tb_parFname.Text == "")
            {
                tb_parFname.Text = "First Name";
                tb_parFname.ForeColor = Color.Black;
            }
        }

        private void tb_parLname_Click(object sender, EventArgs e)
        {
            if (tb_parLname.Text == "Last Name")
            {
                tb_parLname.Text = "";

            }
        }

        private void tb_parLname_Leave(object sender, EventArgs e)
        {
            if (tb_parLname.Text == "")
            {
                tb_parLname.Text = "Last Name";
                tb_parLname.ForeColor = Color.Black;
            }
        }

        private void tb_Par2Fname_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_Par2Fname_Click(object sender, EventArgs e)
        {
            if (tb_Par2Fname.Text == "First Name")
            {
                tb_Par2Fname.Text = "";

            }
        }

        private void tb_Par2Fname_Leave(object sender, EventArgs e)
        {
            if (tb_Par2Fname.Text == "")
            {
                tb_Par2Fname.Text = "First Name";
                tb_Par2Fname.ForeColor = Color.Black;
            }
        }

        private void tb_Par2Lname_Click(object sender, EventArgs e)
        {
            if (tb_Par2Lname.Text == "Last Name")
            {
                tb_Par2Lname.Text = "";

            }
        }

        private void tb_Par2Lname_Leave(object sender, EventArgs e)
        {
            if (tb_Par2Lname.Text == "")
            {
                tb_Par2Lname.Text = "Last Name";
                tb_Par2Lname.ForeColor = Color.Black;
            }
        }

        bool Par2_IsChecked = false;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Par2_IsChecked = true;
                tb_Par2Fname.Enabled = true;
                tb_Par2Lname.Enabled = true;
                Par2_DOB.Enabled = true;
                tb_par2Address.Enabled = true;
                tb_Par2Email.Enabled = true;
                tb_Par2Phone.Enabled = true;
                tb_Par2Relationship.Enabled = true;
            }
            else
            {
                Par2_IsChecked = false;
                tb_Par2Fname.Enabled = false;
                tb_Par2Lname.Enabled = false;
                Par2_DOB.Enabled = false;
                tb_par2Address.Enabled = false;
                tb_Par2Email.Enabled = false;
                tb_Par2Phone.Enabled = false;
                tb_Par2Relationship.Enabled = false;
            }
        }
    }

   
}

