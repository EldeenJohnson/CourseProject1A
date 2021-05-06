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
        private readonly Choice_Christian_AcademyEntities choice_Christian_AcademyEntities;
        public AddEditStudent(Student editstudentData)
        {
            InitializeComponent();
            PopulateFields(editstudentData);
            choice_Christian_AcademyEntities = new Choice_Christian_AcademyEntities();
        }

        private void PopulateFields(Student studentdata)
        {
            lblId.Text = studentdata.ID.ToString();
            tbFName.Text = studentdata.First_Name;
            tbMInitial.Text = studentdata.Mid_Name;
            tbLName.Text = studentdata.Last_Name;
            tbGender.Text = studentdata.Gender;
            tbDOM.Value = studentdata.Date_of_Birth;
            tbAddress.Text = studentdata.Address;
        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            var id = int.Parse(lblId.Text);
            var studentdata = choice_Christian_AcademyEntities.Students.FirstOrDefault(q => q.ID == id);
            studentdata.First_Name = tbFName.Text;
            studentdata.Mid_Name = tbMInitial.Text;
            studentdata.Last_Name = tbLName.Text;
            studentdata.Gender = tbGender.Text;
            studentdata.Date_of_Birth = tbDOM.Value;
            studentdata.Address = tbAddress.Text;

            //Save Changes
            choice_Christian_AcademyEntities.SaveChanges();

            this.Close();
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
