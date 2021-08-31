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
    public partial class ViewStudentGradesheet : Form
    {
        private readonly Choice_Christian_AcademyEntities3 choice_Christian_AcademyEntities;
        public ViewStudentGradesheet(Test_Result TestScore, Student_detail Student)
        {
            InitializeComponent();
            PopulateGrid(TestScore, Student);
            choice_Christian_AcademyEntities = new Choice_Christian_AcademyEntities3();
        }

        public void PopulateGrid(Test_Result TestScore, Student_detail Student)
        {
            var Stu= choice_Christian_AcademyEntities.Test_Result
                .Where(q => q.Student_ID == 1)
                          .Select(q => new
                          {
                              ID = q.Student_ID,
                              Semester = q.Semester,
                              Score = q.Score,
                          }).ToList();
            dgv_Stu.DataSource = Stu;
            dgv_Stu.Columns[0].Visible = false;
            dgv_Stu.Columns[1].HeaderText = "Semester";
            dgv_Stu.Columns[2].HeaderText = "Score";
        }   
      
    }
}
