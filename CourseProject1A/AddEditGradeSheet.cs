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
    public partial class AddEditGradeSheet : Form
    {
        //private bool isEditMode;
        private readonly Choice_Christian_AcademyEntities2 choice_Christian_AcademyEntities;
        public AddEditGradeSheet()
        {
            InitializeComponent();
            choice_Christian_AcademyEntities = new Choice_Christian_AcademyEntities2();
        }

       /* public AddEditGradeSheet()
        {
            InitializeComponent();
            isEditMode = true;
            choice_Christian_AcademyEntities = new Choice_Christian_AcademyEntities2();
        }*/

        private void Student_Grade_Load(object sender, EventArgs e)
        {
            var Grade = choice_Christian_AcademyEntities.Grades.ToList();
            cb_GradeS.DisplayMember = "Grade1";
            cb_GradeS.ValueMember = "id";
            cb_GradeS.DataSource = Grade;

            var Class = choice_Christian_AcademyEntities.Classes.ToList();
            cb_ClassS.DisplayMember = "Class1";
            cb_ClassS.ValueMember = "id";
            cb_ClassS.DataSource = Class;
        }
       
        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                int gID = (int)cb_GradeS.SelectedValue;
                int cID = (int)cb_ClassS.SelectedValue;
                var getStu = choice_Christian_AcademyEntities.Student_detail.FirstOrDefault(q => q.Grade_ID == gID && q.Class_ID == cID);
                var getTeach = choice_Christian_AcademyEntities.Teachers.FirstOrDefault(q => q.Grade_ID == gID && q.Class_ID == cID);

                if (getStu != null || getTeach != null)
                {
                    lbl_Teacher.Text += " " + (string)getTeach.First_Name + " " + (string)getTeach.Last_Name;

                    var Student = choice_Christian_AcademyEntities.Student_detail
                        .Where(q => q.Grade_ID == gID)
                        .Select(q => new
                        {
                            ID = q.Student_ID,
                            First_Name = q.First_Name,
                            Last_Name = q.Last_Name,
                        }).ToList();
                    dgv_Stu.DataSource = Student;
                    dgv_Stu.Columns[0].Visible = false;
                    dgv_Stu.Columns[1].HeaderText = "First Name";
                    dgv_Stu.Columns[2].HeaderText = "Last Name";                    
                }

                else
                {
                    MessageBox.Show("No Records found for the selected Grade and Class.\nPlease try again...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}" + "/n/nNo Records found for the selected /nGrade and Class, try again");
            }
        }
        

        private void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)dgv_Stu.SelectedRows[0].Cells["ID"].Value;            
                
                string[] sub ={tb_Math.Text,tb_English.Text,tb_Sci.Text,tb_Soci.Text,tb_Music.Text,tb_English.Text,
                           tb_Art.Text,tb_Read.Text,tb_Phonics.Text};
                int[] subID = { 1, 2, 3, 4, 5, 7, 9, 11, 12 };
                String[] Comm = { rtb_Com1.Text, rtb_Com2.Text, rtb_Com3.Text, rtb_Com4.Text, rtb_Com5.Text, rtb_Com6.Text,
                                rtb_Com7.Text,rtb_Com8.Text,rtb_Com9.Text};


                for (int i = 0; i < subID.Length; i++)
                {
                    var newGrades = new Test_Result
                    {
                        EntryDate = dp_grade.Value,
                        Score = Convert.ToDouble(sub[i]),
                        Subject_ID = subID[i],
                        Comment = Comm[i],
                        Student_ID = id
                    };
                    choice_Christian_AcademyEntities.Test_Result.Add(newGrades);
                    
                }

                choice_Christian_AcademyEntities.SaveChanges();
                MessageBox.Show("Submited");
                this.Close();
                var AddEditGradeSheet = new AddEditGradeSheet();
                AddEditGradeSheet.MdiParent = this.MdiParent;
                AddEditGradeSheet.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            
            var AddEditGradeSheet = new AddEditGradeSheet();
            AddEditGradeSheet.MdiParent = this.MdiParent;
            AddEditGradeSheet.Show();
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
           // tableLayoutPanel1.Enabled = false;

            var id = (int)dgv_Stu.SelectedRows[0].Cells["ID"].Value;
            var Student = choice_Christian_AcademyEntities.Student_detail.FirstOrDefault(q => q.Student_ID == id);
            var TestScore = choice_Christian_AcademyEntities.Test_Result.FirstOrDefault(q => q.Student_ID == id);

            int tID = TestScore.ID;


            string[] sub ={tb_Math.Text,tb_English.Text,tb_Sci.Text,tb_Soci.Text,tb_Music.Text,tb_English.Text,
                            tb_Art.Text,tb_Read.Text,tb_Phonics.Text};
            int[] subID = { 1, 2, 3, 4, 5, 7, 9, 11, 12 };
            String[] Comm = { rtb_Com1.Text, rtb_Com2.Text, rtb_Com3.Text, rtb_Com4.Text, rtb_Com5.Text, rtb_Com6.Text,
                             rtb_Com7.Text,rtb_Com8.Text,rtb_Com9.Text};
           /* int[] Semester = { (int)cb_1.SelectedValue, (int)cb_2.SelectedValue, (int)cb_3.SelectedValue, 
                                (int)cb_4.SelectedValue, (int)cb_5.SelectedValue, (int)cb_6.SelectedValue, 
                                (int)cb_7.SelectedValue, (int)cb_8.SelectedValue, (int)cb_9.SelectedValue, };*/

            
            for (int i = 0; i < subID.Length; i++)
            {
                    dp_grade.Value = (DateTime)TestScore.EntryDate;
                    sub[i] = Convert.ToString(TestScore.Score);
                    /*  Semester[i] = (int)TestScore.Semester;*/
                    Comm[i] = TestScore.Comment;             
                            
            }

        }
    }
}
