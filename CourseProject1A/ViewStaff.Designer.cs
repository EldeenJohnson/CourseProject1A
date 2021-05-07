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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewStaff));
            this.gvstaffdata = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Addbutton = new System.Windows.Forms.Button();
            this.Closebutton = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.Editbotton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvstaffdata)).BeginInit();
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(291, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Staff Detail";
            // 
            // Addbutton
            // 
            this.Addbutton.Location = new System.Drawing.Point(244, 390);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(94, 38);
            this.Addbutton.TabIndex = 9;
            this.Addbutton.Text = "Add";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // Closebutton
            // 
            this.Closebutton.Location = new System.Drawing.Point(645, 390);
            this.Closebutton.Name = "Closebutton";
            this.Closebutton.Size = new System.Drawing.Size(94, 38);
            this.Closebutton.TabIndex = 8;
            this.Closebutton.Text = "Close";
            this.Closebutton.UseVisualStyleBackColor = true;
            this.Closebutton.Click += new System.EventHandler(this.Closebutton_Click);
            // 
            // Deletebutton
            // 
            this.Deletebutton.Location = new System.Drawing.Point(446, 390);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(94, 38);
            this.Deletebutton.TabIndex = 7;
            this.Deletebutton.Text = "Delete";
            this.Deletebutton.UseVisualStyleBackColor = true;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // Editbotton
            // 
            this.Editbotton.Location = new System.Drawing.Point(62, 390);
            this.Editbotton.Name = "Editbotton";
            this.Editbotton.Size = new System.Drawing.Size(94, 38);
            this.Editbotton.TabIndex = 6;
            this.Editbotton.Text = "Edit";
            this.Editbotton.UseVisualStyleBackColor = true;
            this.Editbotton.Click += new System.EventHandler(this.Editbotton_Click);
            // 
            // ViewStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.Closebutton);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.Editbotton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvstaffdata);
            this.Name = "ViewStaff";
            this.Text = "ViewStaff";
            this.Load += new System.EventHandler(this.ViewStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvstaffdata)).EndInit();
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
    }
}