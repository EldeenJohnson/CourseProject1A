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
        public AddEditStudent(Choice_Christian_AcademyEntities editstudentData)
        {
            InitializeComponent();
            PopulateFields(editstudentData);

        }

        private void PopulateFields(Choice_Christian_AcademyEntities student_detail)
        {
            tbFName.Text = 
        }
    }
}
