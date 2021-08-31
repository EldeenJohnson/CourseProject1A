
namespace CourseProject1A
{
    partial class AddUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SaveChanges = new System.Windows.Forms.Button();
            this.tb_UserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Password2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.tb_FullName = new System.Windows.Forms.TextBox();
            this.cb_Roles = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(175, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Re-Enter Password";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.Location = new System.Drawing.Point(307, 22);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(173, 45);
            this.lbl_Title.TabIndex = 30;
            this.lbl_Title.Text = "New User";
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Cancel.ForeColor = System.Drawing.Color.White;
            this.Cancel.Location = new System.Drawing.Point(513, 428);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(109, 30);
            this.Cancel.TabIndex = 31;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(220, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Password";
            // 
            // SaveChanges
            // 
            this.SaveChanges.BackColor = System.Drawing.Color.Green;
            this.SaveChanges.ForeColor = System.Drawing.Color.White;
            this.SaveChanges.Location = new System.Drawing.Point(651, 428);
            this.SaveChanges.Name = "SaveChanges";
            this.SaveChanges.Size = new System.Drawing.Size(109, 30);
            this.SaveChanges.TabIndex = 32;
            this.SaveChanges.Text = "Save Changes";
            this.SaveChanges.UseVisualStyleBackColor = false;
            this.SaveChanges.Click += new System.EventHandler(this.SaveChanges_Click);
            // 
            // tb_UserName
            // 
            this.tb_UserName.Location = new System.Drawing.Point(296, 207);
            this.tb_UserName.Name = "tb_UserName";
            this.tb_UserName.Size = new System.Drawing.Size(199, 20);
            this.tb_UserName.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(218, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Username";
            // 
            // tb_Password2
            // 
            this.tb_Password2.Location = new System.Drawing.Point(296, 286);
            this.tb_Password2.Name = "tb_Password2";
            this.tb_Password2.PasswordChar = '*';
            this.tb_Password2.Size = new System.Drawing.Size(199, 20);
            this.tb_Password2.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(219, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Full Name";
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(296, 247);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(199, 20);
            this.tb_Password.TabIndex = 28;
            // 
            // tb_FullName
            // 
            this.tb_FullName.Location = new System.Drawing.Point(296, 114);
            this.tb_FullName.Name = "tb_FullName";
            this.tb_FullName.Size = new System.Drawing.Size(199, 20);
            this.tb_FullName.TabIndex = 24;
            // 
            // cb_Roles
            // 
            this.cb_Roles.FormattingEnabled = true;
            this.cb_Roles.Location = new System.Drawing.Point(296, 163);
            this.cb_Roles.Name = "cb_Roles";
            this.cb_Roles.Size = new System.Drawing.Size(121, 21);
            this.cb_Roles.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(244, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Role";
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CourseProject1A.Properties.Resources.small_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_Roles);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SaveChanges);
            this.Controls.Add(this.tb_UserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_Password2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_FullName);
            this.MinimizeBox = false;
            this.Name = "AddUser";
            this.Text = "AddUser";
            this.Load += new System.EventHandler(this.AddUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SaveChanges;
        private System.Windows.Forms.TextBox tb_UserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Password2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.TextBox tb_FullName;
        private System.Windows.Forms.ComboBox cb_Roles;
        private System.Windows.Forms.Label label2;
    }
}