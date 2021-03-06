using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject1A
{
    public partial class LoginPage : Form
    {
        private readonly Choice_Christian_AcademyEntities3 choice_Christian_AcademyEntities;
        public LoginPage()
        {
            InitializeComponent();

            choice_Christian_AcademyEntities = new Choice_Christian_AcademyEntities3();
            
        }
        
        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                //Stores Username and Password
                var username = tb_username.Text.Trim();
                var password = tb_Password.Text;

                var user = choice_Christian_AcademyEntities.Creds.FirstOrDefault(q => q.User == username && q.Pword == password);

                
                if (user == null)
                {
                    MessageBox.Show("Incorrect Username or Password");
                }
                else
                {

                    var role = user.UserRoles.FirstOrDefault();
                    var roleshortname = role.Role.Shortname;
;                   var newHome = new HomeWindow(this,roleshortname);
                    newHome.Show();                    
                    Hide();

                }

            }         
            catch (Exception)
            {

                MessageBox.Show("Something went wrong. Please try again");
            }
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please contact your administrator");
        }
    }
}
