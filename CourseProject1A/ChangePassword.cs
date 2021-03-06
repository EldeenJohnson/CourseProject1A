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
    public partial class ChangePassword : Form
    {
        private bool isEditMode;
        private readonly Choice_Christian_AcademyEntities3 choice_Christian_AcademyEntities;
        public ChangePassword(Cred ChangePassowrd)
        {
            InitializeComponent();
            PopulateFields(ChangePassowrd);
            isEditMode = true;
            choice_Christian_AcademyEntities = new Choice_Christian_AcademyEntities3();
        }

        private void PopulateFields(Cred UserData)
        {
            lblID.Text = UserData.ID.ToString();
            tb_UserName.Text = UserData.User;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            if (isEditMode)
            {
                if (tb_Password.Text.Trim() == tb_Password2.Text.Trim())
                {
                    try
                    {

                        var id = int.Parse(lblID.Text);
                        var ChangePassword = choice_Christian_AcademyEntities.Creds.FirstOrDefault(q => q.ID == id);
                        ChangePassword.Pword = tb_Password.Text.Trim();

                        //Save Changes
                        choice_Christian_AcademyEntities.SaveChanges();
                        MessageBox.Show("Information Edited");
                        this.Close();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("Password does not match, please try again");
                }
            }
        }
    }
}

