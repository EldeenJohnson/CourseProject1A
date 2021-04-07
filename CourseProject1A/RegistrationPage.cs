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
        public RegistrationPage()
        {
            InitializeComponent();
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
                var Height_ft = cb_HeightFt.Text;
                var Height_in = cb_HeightIn.Text;
                string StuAddress = tb_stuAddress.Text;
                string stuEmail = tb_StuEmail.Text;
                string stuPhone = tb_StuPhone.Text;
                string PrevSchool = tb_stuPreSch.Text;
                var BirthEntryNum = tb_StuBEntry.Text;
                var stuID = tb_StuID.Text;
                var stuGrade = tb_StuGrade.Text;
                var stuClass = tb_StuClass.Text;
                string stuHouse = cb_StuHouse.Text;
                var stuUpload = tb_StuUpload.Text;
                string StuAddInfo = rtb_stuAddInfo.Text;

                //Parent1 Info
                string par1fName = tb_parFname.Text;
                string par1lName = tb_parLname.Text;
                DateTime par1DOB = Par_DOB.Value;
                string par1Address = tb_parAddress.Text;
                string par1Email = tb_ParEmail.Text;
                string parPhone = tb_Parphone.Text;

                //Parent2 Info
                string par2fName = tb_Par2Fname.Text;
                string par2lName = tb_Par2Lname.Text;
                DateTime par2DOB = Par2_DOB.Value;
                string par2Address = tb_par2Address.Text;
                string par2Email = tb_Par2Email.Text;
                string par2Phone = tb_Parphone.Text;                           

                if (stuDOB >= DateTime.Today || par1DOB >= DateTime.Today || par2DOB >= DateTime.Today)
                {
                    //isValid = false;
                    errorMessage += "Invalid date Selected.\n\r";
                }
                //Data Validation
                if (string.IsNullOrWhiteSpace(stuFName) || String.IsNullOrWhiteSpace(stuLName)
                    || string.IsNullOrWhiteSpace(Height_ft) || string.IsNullOrWhiteSpace(Height_in)
                    || string.IsNullOrWhiteSpace(StuAddress)|| string.IsNullOrWhiteSpace(stuEmail)
                    || string.IsNullOrWhiteSpace(par1fName) || string.IsNullOrWhiteSpace(par1lName)
                    || string.IsNullOrWhiteSpace(parPhone) || string.IsNullOrWhiteSpace(par1Address)
                    || string.IsNullOrWhiteSpace(par1Email)) 
                {
                    isValid = false;
                    errorMessage += "Please enter missing data.\n\r";
                }

                if (isValid)
                {
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
        private void btn_StuNext_Click(object sender, EventArgs e) //Student information tab next button
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
                               "\nID: "+ tb_StuID.Text +
                               "\nGrade: "+ tb_StuGrade.Text +
                               "\nClass: "+ tb_StuClass.Text +
                               "\nHouse: "+ cb_StuHouse.Text +
                               "\nPicture: "+ tb_StuUpload.Text +
                               "\nAdditional Info: "+ rtb_stuAddInfo.Text +
                               "\n\n"+

                               //review Parent 1
                               "PARENT 1 INFORMATION"+
                               "\nFirst Name: "+ tb_parFname.Text +
                               "\nLast Name: "+ tb_parLname.Text +
                               "\nDate Of Birth: "+ Par_DOB.Value +
                               "\nAddress: "+ tb_parAddress.Text +
                               "\nEmail: "+ tb_ParEmail.Text +
                               "\nPhone Number: "+ tb_Parphone.Text +
                               "\n\n" +
                              
                               //Review Parent 2
                               "PARENT 2 INFORMATION" +
                               "\nFirst Name: " + tb_Par2Fname.Text +
                               "\nLast Name:" + tb_Par2Lname.Text +
                               "\nDate Of Birth: " + Par2_DOB.Value +
                               "\nAddress: " + tb_par2Address.Text +
                               "\nEmail: " + tb_Par2Email.Text +
                               "\nPhone Number: " + tb_Parphone.Text;

        }

        private void btn_RevPre_Click(object sender, EventArgs e)//review tab previous button
        {
            tabRegistration.SelectTab(1);
        }

        
    }
    
}
