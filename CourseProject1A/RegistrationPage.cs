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
                string stuFName = tb_stufname.Text;
                string stuLName = tb_stulname.Text;
                string stuMname = tb_stuMname.Text;
                DateTime stuDOB = stu_DOB.Value;
                string Height = tbHeight.Text.ToString();                
                
                var Address = tbAddress.Text.ToString();
                string School = cbSchool.Text;
                bool isValid = true;
                var errorMessage = "\tError!\n\r";

                if (DOB > DateTime.Today)
                {
                    isValid = false;
                    errorMessage += "Invalid date Selected.\n\r";
                }

                if (string.IsNullOrWhiteSpace(FName) || String.IsNullOrWhiteSpace(LName)
                    || string.IsNullOrWhiteSpace(Height) || string.IsNullOrWhiteSpace(Address)
                    || string.IsNullOrWhiteSpace(School))
                {
                    isValid = false;
                    errorMessage += "Please enter missing data.\n\r";
                }

                if (isValid)
                {
                    MessageBox.Show($"\tThank you {FName} {LName}.\n\r" +
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
    }
    }
}
