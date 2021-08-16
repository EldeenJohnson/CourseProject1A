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
        private readonly Choice_Christian_AcademyEntities2 choice_Christian_AcademyEntities;
        public AddEditStudent(Student_detail editstudentData)
        {
            InitializeComponent();
            PopulateFields(editstudentData);
            choice_Christian_AcademyEntities = new Choice_Christian_AcademyEntities2();
        }

        private void PopulateFields(Student_detail studentdata)
        {
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
            // cb_EdHouse.Text = ()studentdata.House_ID;
            cb_EdGrade.Text = studentdata.Grade;
            cb_EdClass.Text = studentdata.Class;
            rtb_EdstuAddInfo.Text = studentdata.AddInfo;


        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            try { 
                    var id = int.Parse(lblId.Text);
                    var studentdata = choice_Christian_AcademyEntities.Student_detail.FirstOrDefault(q => q.Student_ID == id);
                    studentdata.First_Name = tbFName.Text;
                    studentdata.Mid_Name = tbMInitial.Text;
                    studentdata.Last_Name = tbLName.Text;
                    studentdata.Gender = cb_EditGen.Text;
                    studentdata.Date_of_Birth = tb_EditDOB.Value;
                    studentdata.Address = tbAddress.Text;
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
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
