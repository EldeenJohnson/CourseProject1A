
namespace CourseProject1A
{
    partial class ChangePassword
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
            this.SaveChanges = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_UserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Password2 = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.lbl_eCon = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SaveChanges
            // 
            this.SaveChanges.BackColor = System.Drawing.Color.Green;
            this.SaveChanges.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveChanges.ForeColor = System.Drawing.Color.White;
            this.SaveChanges.Location = new System.Drawing.Point(205, 315);
            this.SaveChanges.Name = "SaveChanges";
            this.SaveChanges.Size = new System.Drawing.Size(94, 38);
            this.SaveChanges.TabIndex = 29;
            this.SaveChanges.Text = "Save Changes";
            this.SaveChanges.UseVisualStyleBackColor = false;
            this.SaveChanges.Click += new System.EventHandler(this.SaveChanges_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(230, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 23);
            this.label2.TabIndex = 28;
            this.label2.Text = "Please enter new passowrd.";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.Location = new System.Drawing.Point(217, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(282, 45);
            this.lbl_Title.TabIndex = 27;
            this.lbl_Title.Text = "Change Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(202, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Username";
            // 
            // tb_UserName
            // 
            this.tb_UserName.Location = new System.Drawing.Point(284, 89);
            this.tb_UserName.Name = "tb_UserName";
            this.tb_UserName.Size = new System.Drawing.Size(199, 20);
            this.tb_UserName.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(202, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Password";
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(284, 200);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(199, 20);
            this.tb_Password.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(159, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Re-Enter Password";
            // 
            // tb_Password2
            // 
            this.tb_Password2.Location = new System.Drawing.Point(284, 252);
            this.tb_Password2.Name = "tb_Password2";
            this.tb_Password2.PasswordChar = '*';
            this.tb_Password2.Size = new System.Drawing.Size(199, 20);
            this.tb_Password2.TabIndex = 33;
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Cancel.ForeColor = System.Drawing.Color.White;
            this.Cancel.Location = new System.Drawing.Point(333, 315);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(109, 38);
            this.Cancel.TabIndex = 34;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // lbl_eCon
            // 
            this.lbl_eCon.AutoSize = true;
            this.lbl_eCon.BackColor = System.Drawing.Color.Transparent;
            this.lbl_eCon.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_eCon.Location = new System.Drawing.Point(23, 34);
            this.lbl_eCon.Name = "lbl_eCon";
            this.lbl_eCon.Size = new System.Drawing.Size(0, 13);
            this.lbl_eCon.TabIndex = 37;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblID.Location = new System.Drawing.Point(23, 328);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 13);
            this.lblID.TabIndex = 38;
            this.lblID.Visible = false;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CourseProject1A.Properties.Resources.small_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(692, 396);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lbl_eCon);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_Password2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.SaveChanges);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_UserName);
            this.Name = "ChangePassword";
            this.Text = "ChangePassowrd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveChanges;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_UserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Password2;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label lbl_eCon;
        private System.Windows.Forms.Label lblID;
    }
}