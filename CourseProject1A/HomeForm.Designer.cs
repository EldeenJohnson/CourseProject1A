﻿
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
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            this.btn_Teach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Teach.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.btn_Teach.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Teach.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Teach.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Teach.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_Teach.Location = new System.Drawing.Point(591, 261);
            this.btn_Teach.Name = "btn_Teach";
            this.btn_Teach.Size = new System.Drawing.Size(184, 123);
            this.btn_Teach.TabIndex = 9;
            this.btn_Teach.Text = "Teacher Management";
            this.btn_Teach.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Teach.UseVisualStyleBackColor = false;
            this.btn_Teach.Click += new System.EventHandler(this.btn_Teach_Click);
            // 
            // btn_Staff
            // 
            this.btn_Staff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Staff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btn_Staff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Staff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Staff.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Staff.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Staff.Location = new System.Drawing.Point(341, 261);
            this.btn_Staff.Name = "btn_Staff";
            this.btn_Staff.Size = new System.Drawing.Size(184, 123);
            this.btn_Staff.TabIndex = 10;
            this.btn_Staff.Text = "Aux\r\nStaff \r\nOn-Boarding";
            this.btn_Staff.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Staff.UseVisualStyleBackColor = false;
            this.btn_Staff.Click += new System.EventHandler(this.btn_Staff_Click);
            // 
            // btn_stuApp
            // 
            this.btn_stuApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_stuApp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btn_stuApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_stuApp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_stuApp.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stuApp.ForeColor = System.Drawing.Color.Teal;
            this.btn_stuApp.Location = new System.Drawing.Point(91, 261);
            this.btn_stuApp.Name = "btn_stuApp";
            this.btn_stuApp.Size = new System.Drawing.Size(184, 123);
            this.btn_stuApp.TabIndex = 11;
            this.btn_stuApp.Text = "Student \r\nApplication";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(644, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 26);
            this.label2.TabIndex = 14;
            this.label2.Text = "Welcome Admin";
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
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CourseProject1A.Properties.Resources.small_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(864, 521);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.lbl_Time);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Timer timer1;
    }
}