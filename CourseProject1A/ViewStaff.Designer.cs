namespace CourseProject1A
{
    partial class ViewStaff
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
            CourseProject1A.Choice_Christian_AcademyDataSet choice_Christian_AcademyDataSet1 = new CourseProject1A.Choice_Christian_AcademyDataSet();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewStaff));
            this.gvstaffdata = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Addbutton = new System.Windows.Forms.Button();
            this.Closebutton = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.Editbotton = new System.Windows.Forms.Button();
            this.refreshbttn = new System.Windows.Forms.Button();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gvstaffdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gvstaffdata
            // 
            this.gvstaffdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvstaffdata.Location = new System.Drawing.Point(62, 80);
            this.gvstaffdata.Name = "gvstaffdata";
            this.gvstaffdata.Size = new System.Drawing.Size(690, 221);
            this.gvstaffdata.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(291, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Staff Detail";
            // 
            // Addbutton
            // 
            this.Addbutton.BackColor = System.Drawing.Color.Green;
            this.Addbutton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbutton.ForeColor = System.Drawing.Color.White;
            this.Addbutton.Location = new System.Drawing.Point(244, 390);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(94, 38);
            this.Addbutton.TabIndex = 9;
            this.Addbutton.Text = "Add";
            this.Addbutton.UseVisualStyleBackColor = false;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // Closebutton
            // 
            this.Closebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Closebutton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Closebutton.ForeColor = System.Drawing.Color.White;
            this.Closebutton.Location = new System.Drawing.Point(645, 390);
            this.Closebutton.Name = "Closebutton";
            this.Closebutton.Size = new System.Drawing.Size(94, 38);
            this.Closebutton.TabIndex = 8;
            this.Closebutton.Text = "Close";
            this.Closebutton.UseVisualStyleBackColor = false;
            this.Closebutton.Click += new System.EventHandler(this.Closebutton_Click);
            // 
            // Deletebutton
            // 
            this.Deletebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Deletebutton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebutton.ForeColor = System.Drawing.Color.White;
            this.Deletebutton.Location = new System.Drawing.Point(446, 390);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(94, 38);
            this.Deletebutton.TabIndex = 7;
            this.Deletebutton.Text = "Delete";
            this.Deletebutton.UseVisualStyleBackColor = false;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // Editbotton
            // 
            this.Editbotton.BackColor = System.Drawing.Color.Teal;
            this.Editbotton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editbotton.ForeColor = System.Drawing.Color.White;
            this.Editbotton.Location = new System.Drawing.Point(62, 390);
            this.Editbotton.Name = "Editbotton";
            this.Editbotton.Size = new System.Drawing.Size(94, 38);
            this.Editbotton.TabIndex = 6;
            this.Editbotton.Text = "Edit";
            this.Editbotton.UseVisualStyleBackColor = false;
            this.Editbotton.Click += new System.EventHandler(this.Editbotton_Click);
            // 
            // refreshbttn
            // 
            this.refreshbttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.refreshbttn.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshbttn.ForeColor = System.Drawing.Color.White;
            this.refreshbttn.Location = new System.Drawing.Point(357, 330);
            this.refreshbttn.Name = "refreshbttn";
            this.refreshbttn.Size = new System.Drawing.Size(75, 23);
            this.refreshbttn.TabIndex = 10;
            this.refreshbttn.Text = "Refresh";
            this.refreshbttn.UseVisualStyleBackColor = false;
            this.refreshbttn.Click += new System.EventHandler(this.refreshbttn_Click);
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = choice_Christian_AcademyDataSet1;
            // 
            // ViewStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CourseProject1A.Properties.Resources.small_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.refreshbttn);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.Closebutton);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.Editbotton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvstaffdata);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewStaff";
            this.Text = "Staff Managment";
            this.Load += new System.EventHandler(this.ViewStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvstaffdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvstaffdata;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Button Closebutton;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Button Editbotton;
        private System.Windows.Forms.Button refreshbttn;
        private Choice_Christian_AcademyDataSet choice_Christian_AcademyDataSet;
        private System.Windows.Forms.BindingSource staffBindingSource;
      private Choice_Christian_AcademyDataSetTableAdapters.StaffTableAdapter staffTableAdapter;
    }
}