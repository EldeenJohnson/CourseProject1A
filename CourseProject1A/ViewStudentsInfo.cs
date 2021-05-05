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
    public partial class ViewStudentsInfo : Form
    {
        private readonly Choice_Christian_AcademyEntities choice_Christian_AcademyEntities;
        public ViewStudentsInfo()
        {
            InitializeComponent();
            choice_Christian_AcademyEntities = new Choice_Christian_AcademyEntities();
        }

        private void ViewStudentsInfo_Load(object sender, EventArgs e)
        {
            var studentdata = choice_Christian_AcademyEntities.Students
                .Select(q=> new{First_Name =q.First_Name, Middle_Name = q.Mid_Name,
                Last_Name =q.Last_Name, Address =q.Address, Date_of_Birth =q.Date_of_Birth, q.ID}).ToList();
            gvstudentlist.DataSource = studentdata;
            gvstudentlist.Columns[0].HeaderText = "First Name";
            gvstudentlist.Columns[1].HeaderText = "Middle Initial";
            gvstudentlist.Columns[2].HeaderText = "Last Name";
            gvstudentlist.Columns[3].HeaderText = "Address";
            gvstudentlist.Columns[4].HeaderText = "Date of Birth";
            gvstudentlist.Columns[5].Visible = false;
        }

        private void EditStudent_Click(object sender, EventArgs e)
        {
            
        }

        private void AddStudent_Click(object sender, EventArgs e)
        {

        }

        private void DeleteStudent_Click(object sender, EventArgs e)
        {

        }
    }
}
