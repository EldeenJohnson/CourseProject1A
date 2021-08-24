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
    public partial class AddUser : Form
    {
        private readonly Choice_Christian_AcademyEntities2 choice_Christian_AcademyEntities;
        public AddUser()
        {
            InitializeComponent();
            choice_Christian_AcademyEntities = new Choice_Christian_AcademyEntities2();
        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            DateTime TodaysDate = DateTime.Now;
            string FullName = tb_FullName.Text;
            string UserName = tb_UserName.Text;
            string Password = tb_Password.Text;
            string Password2 = tb_Password2.Text;

            if (Password != Password2)
            {
                MessageBox.Show("Password does not match, Please Try Again");
            }
            else
            {
                try
                {
                    var NewUser = new Cred();
                    NewUser.User = FullName;
                    NewUser.Pword = Password;
                    NewUser.Full_name = FullName;
                    choice_Christian_AcademyEntities.Creds.Add(NewUser);
                    choice_Christian_AcademyEntities.SaveChanges();
                    MessageBox.Show($"New User ({FullName}) added successfully!\n\r" +
                        $"\n\t{TodaysDate}");
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("An Error occured, Please try again");
                }
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}