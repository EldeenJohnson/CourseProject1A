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
            var studentdata = choice_Christian_AcademyEntities.Student_Detail.ToList();
            gvstudentlist.DataSource = studentdata;
        }
    }
}
