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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        HomeWindow newHome = new HomeWindow();
        private void btn_login_Click(object sender, EventArgs e)
        {
            string username=tb_username.Text;
            string password=tb_Password.Text;


            if (username != "Admin" || password != "Password")
            {
                MessageBox.Show("Incorrect Username or Password");
            }
            else
            {
                newHome.Show();
                this.Hide();
            }
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }
    }
}
