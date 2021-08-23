using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            SqlConnection connection = new SqlConnection(@"Data Source=mysms-db.database.windows.net;Initial Catalog=Choice_Christian_Academy;Persist Security Info=True;User ID=Kratos;Password=@maz1nggrac3");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count (*) From Creds Where User='" + tb_username.Text + "' and Pword='" + tb_Password.Text + "'", connection);
            // SqlDataAdapter sda = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            sda.Fill(data);
            if (data.Rows[0][0].ToString() == "1")
            {
                newHome.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password");
            }
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }
    }
}
