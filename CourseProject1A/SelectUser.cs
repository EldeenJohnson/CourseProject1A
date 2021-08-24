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
    public partial class SelectUser : Form
    {
        private readonly Choice_Christian_AcademyEntities2 choice_Christian_AcademyEntities;
        public SelectUser()
        {

            InitializeComponent();
            choice_Christian_AcademyEntities = new Choice_Christian_AcademyEntities2();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submit_bt_Click(object sender, EventArgs e)
        {
             var id = (int).SelectedRows[0].Cells["ID"].Value;

            //Query database
                 var Cred  = choice_Christian_AcademyEntities.Creds.FirstOrDefault(q => q.ID == id);

            var ChangePassword = new ChangePassword(Cred);
            ChangePassword.MdiParent = this.MdiParent;
            ChangePassword.Show();
        }
    }
}
