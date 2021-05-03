namespace CourseProject1A
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
            this.lbl_RegForm = new System.Windows.Forms.Label();
            this.gvstudentlist = new System.Windows.Forms.DataGridView();
            this.Editstudent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvstudentlist)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_RegForm
            // 
            this.lbl_RegForm.AutoSize = true;
            this.lbl_RegForm.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RegForm.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_RegForm.Location = new System.Drawing.Point(283, 24);
            this.lbl_RegForm.Name = "lbl_RegForm";
            this.lbl_RegForm.Size = new System.Drawing.Size(264, 42);
            this.lbl_RegForm.TabIndex = 10;
            this.lbl_RegForm.Text = "Student Details";
            // 
            // gvstudentlist
            // 
            this.gvstudentlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvstudentlist.Location = new System.Drawing.Point(46, 82);
            this.gvstudentlist.Name = "gvstudentlist";
            this.gvstudentlist.Size = new System.Drawing.Size(711, 295);
            this.gvstudentlist.TabIndex = 11;
            // 
            // Editstudent
            // 
            this.Editstudent.Location = new System.Drawing.Point(325, 402);
            this.Editstudent.Name = "Editstudent";
            this.Editstudent.Size = new System.Drawing.Size(118, 36);
            this.Editstudent.TabIndex = 12;
            this.Editstudent.Text = "Edit";
            this.Editstudent.UseVisualStyleBackColor = true;
            this.Editstudent.Click += new System.EventHandler(this.Editstudent_Click);
            // 
            // ViewStudentsInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Editstudent);
            this.Controls.Add(this.gvstudentlist);
            this.Controls.Add(this.lbl_RegForm);
            this.Name = "ViewStudentsInfo";
            this.Text = "ViewStudentsInfo";
            this.Load += new System.EventHandler(this.ViewStudentsInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvstudentlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_RegForm;
        private System.Windows.Forms.DataGridView gvstudentlist;
        private System.Windows.Forms.Button Editstudent;
    }
}