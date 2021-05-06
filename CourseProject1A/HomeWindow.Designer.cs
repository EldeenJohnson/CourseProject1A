
namespace CourseProject1A
{
    partial class HomeWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.studentApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTeacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageTeachersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentApplicationToolStripMenuItem,
            this.staffToolStripMenuItem,
            this.teacherToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(830, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // studentApplicationToolStripMenuItem
            // 
            this.studentApplicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newApplicationToolStripMenuItem,
            this.editApplicationToolStripMenuItem});
            this.studentApplicationToolStripMenuItem.Name = "studentApplicationToolStripMenuItem";
            this.studentApplicationToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.studentApplicationToolStripMenuItem.Text = "Student Application";
            // 
            // newApplicationToolStripMenuItem
            // 
            this.newApplicationToolStripMenuItem.Name = "newApplicationToolStripMenuItem";
            this.newApplicationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newApplicationToolStripMenuItem.Text = "New Student";
            this.newApplicationToolStripMenuItem.Click += new System.EventHandler(this.newApplicationToolStripMenuItem_Click);
            // 
            // editApplicationToolStripMenuItem
            // 
            this.editApplicationToolStripMenuItem.Name = "editApplicationToolStripMenuItem";
            this.editApplicationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editApplicationToolStripMenuItem.Text = "Manage Student";
            this.editApplicationToolStripMenuItem.Click += new System.EventHandler(this.editApplicationToolStripMenuItem_Click);
            // 
            // staffToolStripMenuItem
            // 
            this.staffToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newStaffToolStripMenuItem,
            this.manageStaffToolStripMenuItem});
            this.staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            this.staffToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.staffToolStripMenuItem.Text = "Staff";
            // 
            // newStaffToolStripMenuItem
            // 
            this.newStaffToolStripMenuItem.Name = "newStaffToolStripMenuItem";
            this.newStaffToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newStaffToolStripMenuItem.Text = "New Staff";
            this.newStaffToolStripMenuItem.Click += new System.EventHandler(this.newStaffToolStripMenuItem_Click);
            // 
            // manageStaffToolStripMenuItem
            // 
            this.manageStaffToolStripMenuItem.Name = "manageStaffToolStripMenuItem";
            this.manageStaffToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.manageStaffToolStripMenuItem.Text = "Manage Staff";
            this.manageStaffToolStripMenuItem.Click += new System.EventHandler(this.manageStaffToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // teacherToolStripMenuItem
            // 
            this.teacherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTeacherToolStripMenuItem,
            this.manageTeachersToolStripMenuItem});
            this.teacherToolStripMenuItem.Name = "teacherToolStripMenuItem";
            this.teacherToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.teacherToolStripMenuItem.Text = "Teacher";
            // 
            // newTeacherToolStripMenuItem
            // 
            this.newTeacherToolStripMenuItem.Name = "newTeacherToolStripMenuItem";
            this.newTeacherToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newTeacherToolStripMenuItem.Text = "New Teacher";
            this.newTeacherToolStripMenuItem.Click += new System.EventHandler(this.newTeacherToolStripMenuItem_Click);
            // 
            // manageTeachersToolStripMenuItem
            // 
            this.manageTeachersToolStripMenuItem.Name = "manageTeachersToolStripMenuItem";
            this.manageTeachersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.manageTeachersToolStripMenuItem.Text = "Manage Teachers";
            this.manageTeachersToolStripMenuItem.Click += new System.EventHandler(this.manageTeachersToolStripMenuItem_Click);
            // 
            // HomeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(830, 749);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomeWindow";
            this.Text = "Home Window";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem studentApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newTeacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageTeachersToolStripMenuItem;
    }
}