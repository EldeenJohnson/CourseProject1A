
namespace CourseProject1A
{
    partial class OptionsForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Teach = new System.Windows.Forms.Button();
            this.btn_Staff = new System.Windows.Forms.Button();
            this.btn_stuApp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Welcome = new System.Windows.Forms.Label();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_SubmitScore = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(278, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 66);
            this.label1.TabIndex = 12;
            this.label1.Text = "Choice Christian Academy \r\nSchool Managment System";
            // 
            // btn_Teach
            // 
            this.btn_Teach.BackColor = System.Drawing.Color.Transparent;
            this.btn_Teach.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Teach.BackgroundImage")));
            this.btn_Teach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Teach.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.btn_Teach.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Teach.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Teach.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Teach.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Teach.Location = new System.Drawing.Point(591, 261);
            this.btn_Teach.Name = "btn_Teach";
            this.btn_Teach.Size = new System.Drawing.Size(180, 120);
            this.btn_Teach.TabIndex = 9;
            this.btn_Teach.Text = "Teacher Management";
            this.btn_Teach.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_Teach.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Teach.UseVisualStyleBackColor = false;
            this.btn_Teach.Click += new System.EventHandler(this.btn_Teach_Click);
            // 
            // btn_Staff
            // 
            this.btn_Staff.BackColor = System.Drawing.Color.Transparent;
            this.btn_Staff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Staff.BackgroundImage")));
            this.btn_Staff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btn_Staff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Staff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Staff.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Staff.ForeColor = System.Drawing.Color.Crimson;
            this.btn_Staff.Location = new System.Drawing.Point(341, 261);
            this.btn_Staff.Name = "btn_Staff";
            this.btn_Staff.Size = new System.Drawing.Size(180, 120);
            this.btn_Staff.TabIndex = 10;
            this.btn_Staff.Text = "Staff Management";
            this.btn_Staff.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Staff.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Staff.UseVisualStyleBackColor = false;
            this.btn_Staff.Click += new System.EventHandler(this.btn_Staff_Click);
            // 
            // btn_stuApp
            // 
            this.btn_stuApp.BackColor = System.Drawing.Color.Transparent;
            this.btn_stuApp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_stuApp.BackgroundImage")));
            this.btn_stuApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_stuApp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btn_stuApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_stuApp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_stuApp.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stuApp.ForeColor = System.Drawing.Color.Aqua;
            this.btn_stuApp.Location = new System.Drawing.Point(91, 261);
            this.btn_stuApp.Name = "btn_stuApp";
            this.btn_stuApp.Size = new System.Drawing.Size(180, 120);
            this.btn_stuApp.TabIndex = 11;
            this.btn_stuApp.Text = "Student \r\nApplication";
            this.btn_stuApp.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_stuApp.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_stuApp.UseVisualStyleBackColor = false;
            this.btn_stuApp.Click += new System.EventHandler(this.btn_stuApp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(367, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Welcome
            // 
            this.lbl_Welcome.AutoSize = true;
            this.lbl_Welcome.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Welcome.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Welcome.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl_Welcome.Location = new System.Drawing.Point(644, 33);
            this.lbl_Welcome.Name = "lbl_Welcome";
            this.lbl_Welcome.Size = new System.Drawing.Size(139, 26);
            this.lbl_Welcome.TabIndex = 14;
            this.lbl_Welcome.Text = "Welcome User";
            // 
            // lbl_Time
            // 
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Time.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Time.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_Time.Location = new System.Drawing.Point(678, 64);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(82, 18);
            this.lbl_Time.TabIndex = 15;
            this.lbl_Time.Text = "12:00:00 am";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Date.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_Date.Location = new System.Drawing.Point(639, 87);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(160, 18);
            this.lbl_Date.TabIndex = 15;
            this.lbl_Date.Text = "Tuesday, 10 August 2021";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_SubmitScore
            // 
            this.btn_SubmitScore.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_SubmitScore.ForeColor = System.Drawing.Color.GhostWhite;
            this.btn_SubmitScore.Location = new System.Drawing.Point(89, 425);
            this.btn_SubmitScore.Name = "btn_SubmitScore";
            this.btn_SubmitScore.Size = new System.Drawing.Size(182, 40);
            this.btn_SubmitScore.TabIndex = 16;
            this.btn_SubmitScore.Text = "Submit Grades";
            this.btn_SubmitScore.UseVisualStyleBackColor = false;
            this.btn_SubmitScore.Click += new System.EventHandler(this.btn_SubmitScore_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.ForeColor = System.Drawing.Color.GhostWhite;
            this.button2.Location = new System.Drawing.Point(341, 425);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 40);
            this.button2.TabIndex = 16;
            this.button2.Text = "Student Register";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.button3.ForeColor = System.Drawing.Color.GhostWhite;
            this.button3.Location = new System.Drawing.Point(591, 425);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 40);
            this.button3.TabIndex = 16;
            this.button3.Text = "Staff Register";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::CourseProject1A.Properties.Resources.small_bg;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(669, 7);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 23);
            this.button5.TabIndex = 18;
            this.button5.Text = "Add New User";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CourseProject1A.Properties.Resources.small_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(864, 521);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_SubmitScore);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.lbl_Time);
            this.Controls.Add(this.lbl_Welcome);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Teach);
            this.Controls.Add(this.btn_Staff);
            this.Controls.Add(this.btn_stuApp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Teach;
        private System.Windows.Forms.Button btn_Staff;
        private System.Windows.Forms.Button btn_stuApp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Welcome;
        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_SubmitScore;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
    }
}