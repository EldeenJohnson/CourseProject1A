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
        private readonly Choice_Christian_AcademyEntities2 choice_Christian_AcademyEntities;
        public ChangePassword(Cred ChangePassowrd)
        {
            PopulateFields(ChangePassowrd);
            InitializeComponent();
            choice_Christian_AcademyEntities = new Choice_Christian_AcademyEntities2();
        }

        private void PopulateFields(Cred changePassowrd)
        {
            lblID.Text = changePassowrd.ID.ToString();
            tb_UserName.Text = changePassowrd.User;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            if (isEditMode)
            {
                try
                {
                    var id = int.Parse(lblID.Text);
                    var ChangePassword = choice_Christian_AcademyEntities.Creds.FirstOrDefault(q => q.ID == id);
                    ChangePassword.Pword = tb_Password.Text;

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
        }
    }
}

