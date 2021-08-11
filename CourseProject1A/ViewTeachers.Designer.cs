namespace CourseProject1A
{
    partial class ViewTeachers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewTeachers));
            this.Refreshbutton = new System.Windows.Forms.Button();
            this.Addbutton = new System.Windows.Forms.Button();
            this.Closebutton = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.Editbotton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gvteacherdata = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvteacherdata)).BeginInit();
            this.SuspendLayout();
            // 
            // Refreshbutton
            // 
            this.Refreshbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Refreshbutton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refreshbutton.Location = new System.Drawing.Point(361, 308);
            this.Refreshbutton.Name = "Refreshbutton";
            this.Refreshbutton.Size = new System.Drawing.Size(59, 24);
            this.Refreshbutton.TabIndex = 13;
            this.Refreshbutton.Text = "Refresh";
            this.Refreshbutton.UseVisualStyleBackColor = false;
            this.Refreshbutton.Click += new System.EventHandler(this.Refreshbutton_Click);
            // 
            // Addbutton
            // 
            this.Addbutton.BackColor = System.Drawing.Color.Green;
            this.Addbutton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbutton.Location = new System.Drawing.Point(238, 402);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(94, 38);
            this.Addbutton.TabIndex = 12;
            this.Addbutton.Text = "Add";
            this.Addbutton.UseVisualStyleBackColor = false;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // Closebutton
            // 
            this.Closebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Closebutton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Closebutton.Location = new System.Drawing.Point(639, 402);
            this.Closebutton.Name = "Closebutton";
            this.Closebutton.Size = new System.Drawing.Size(94, 38);
            this.Closebutton.TabIndex = 11;
            this.Closebutton.Text = "Close";
            this.Closebutton.UseVisualStyleBackColor = false;
            this.Closebutton.Click += new System.EventHandler(this.Closebutton_Click);
            // 
            // Deletebutton
            // 
            this.Deletebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Deletebutton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebutton.Location = new System.Drawing.Point(440, 402);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(94, 38);
            this.Deletebutton.TabIndex = 10;
            this.Deletebutton.Text = "Delete";
            this.Deletebutton.UseVisualStyleBackColor = false;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // Editbotton
            // 
            this.Editbotton.BackColor = System.Drawing.Color.Teal;
            this.Editbotton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editbotton.Location = new System.Drawing.Point(56, 402);
            this.Editbotton.Name = "Editbotton";
            this.Editbotton.Size = new System.Drawing.Size(94, 38);
            this.Editbotton.TabIndex = 9;
            this.Editbotton.Text = "Edit";
            this.Editbotton.UseVisualStyleBackColor = false;
            this.Editbotton.Click += new System.EventHandler(this.Editbotton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(268, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 45);
            this.label1.TabIndex = 8;
            this.label1.Text = "Teacher\'s Detail";
            // 
            // gvteacherdata
            // 
            this.gvteacherdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvteacherdata.Location = new System.Drawing.Point(75, 67);
            this.gvteacherdata.Name = "gvteacherdata";
            this.gvteacherdata.Size = new System.Drawing.Size(644, 225);
            this.gvteacherdata.TabIndex = 7;
            // 
            // ViewTeachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::CourseProject1A.Properties.Resources.small_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Refreshbutton);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.Closebutton);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.Editbotton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvteacherdata);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewTeachers";
            this.Text = "Teacher Management";
            this.Load += new System.EventHandler(this.ViewTeachers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvteacherdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Refreshbutton;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Button Closebutton;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Button Editbotton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvteacherdata;
    }
}