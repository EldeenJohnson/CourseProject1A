﻿namespace CourseProject1A
{
    partial class ViewStudentsInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewStudentsInfo));
            this.gvstudentdata = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Editbotton = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.Closebutton = new System.Windows.Forms.Button();
            this.Addbutton = new System.Windows.Forms.Button();
            this.Refreshbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvstudentdata)).BeginInit();
            this.SuspendLayout();
            // 
            // gvstudentdata
            // 
            this.gvstudentdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvstudentdata.Location = new System.Drawing.Point(28, 65);
            this.gvstudentdata.Name = "gvstudentdata";
            this.gvstudentdata.Size = new System.Drawing.Size(748, 291);
            this.gvstudentdata.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(279, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Detail";
            // 
            // Editbotton
            // 
            this.Editbotton.Location = new System.Drawing.Point(58, 416);
            this.Editbotton.Name = "Editbotton";
            this.Editbotton.Size = new System.Drawing.Size(94, 38);
            this.Editbotton.TabIndex = 2;
            this.Editbotton.Text = "Edit";
            this.Editbotton.UseVisualStyleBackColor = true;
            this.Editbotton.Click += new System.EventHandler(this.Editbotton_Click);
            // 
            // Deletebutton
            // 
            this.Deletebutton.Location = new System.Drawing.Point(442, 416);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(94, 38);
            this.Deletebutton.TabIndex = 3;
            this.Deletebutton.Text = "Delete";
            this.Deletebutton.UseVisualStyleBackColor = true;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // Closebutton
            // 
            this.Closebutton.Location = new System.Drawing.Point(641, 416);
            this.Closebutton.Name = "Closebutton";
            this.Closebutton.Size = new System.Drawing.Size(94, 38);
            this.Closebutton.TabIndex = 4;
            this.Closebutton.Text = "Close";
            this.Closebutton.UseVisualStyleBackColor = true;
            this.Closebutton.Click += new System.EventHandler(this.Closebutton_Click);
            // 
            // Addbutton
            // 
            this.Addbutton.Location = new System.Drawing.Point(240, 416);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(94, 38);
            this.Addbutton.TabIndex = 5;
            this.Addbutton.Text = "Add";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // Refreshbutton
            // 
            this.Refreshbutton.Location = new System.Drawing.Point(359, 362);
            this.Refreshbutton.Name = "Refreshbutton";
            this.Refreshbutton.Size = new System.Drawing.Size(59, 24);
            this.Refreshbutton.TabIndex = 6;
            this.Refreshbutton.Text = "Refresh";
            this.Refreshbutton.UseVisualStyleBackColor = true;
            this.Refreshbutton.Click += new System.EventHandler(this.Refreshbutton_Click);
            // 
            // ViewStudentsInfo
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(797, 500);
            this.Controls.Add(this.Refreshbutton);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.Closebutton);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.Editbotton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvstudentdata);
            this.Name = "ViewStudentsInfo";
            this.Load += new System.EventHandler(this.ViewStudentsInfo_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.gvstudentdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_RegForm;
        private System.Windows.Forms.DataGridView gvstudentlist;
        private System.Windows.Forms.Button EditStudent;
        private System.Windows.Forms.Button AddStudent;
        private System.Windows.Forms.Button DeleteStudent;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView gvstudentdata;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Editbotton;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Button Closebutton;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Button Refreshbutton;
    }
}