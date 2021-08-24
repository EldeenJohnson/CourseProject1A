
namespace CourseProject1A
{
    partial class SelectUser
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
            this.lbl_Title = new System.Windows.Forms.Label();
            this.tb_sFName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.submit_bt = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.lbl_eCon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.Location = new System.Drawing.Point(129, 18);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(282, 45);
            this.lbl_Title.TabIndex = 22;
            this.lbl_Title.Text = "Change Password";
            // 
            // tb_sFName
            // 
            this.tb_sFName.Location = new System.Drawing.Point(197, 126);
            this.tb_sFName.Name = "tb_sFName";
            this.tb_sFName.Size = new System.Drawing.Size(199, 20);
            this.tb_sFName.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(115, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(144, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Please enter Username to change passowrd.";
            // 
            // submit_bt
            // 
            this.submit_bt.BackColor = System.Drawing.Color.Green;
            this.submit_bt.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_bt.ForeColor = System.Drawing.Color.White;
            this.submit_bt.Location = new System.Drawing.Point(147, 190);
            this.submit_bt.Name = "submit_bt";
            this.submit_bt.Size = new System.Drawing.Size(94, 38);
            this.submit_bt.TabIndex = 24;
            this.submit_bt.Text = "Submit";
            this.submit_bt.UseVisualStyleBackColor = false;
            this.submit_bt.Click += new System.EventHandler(this.submit_bt_Click);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Cancel.ForeColor = System.Drawing.Color.White;
            this.Cancel.Location = new System.Drawing.Point(278, 190);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(109, 38);
            this.Cancel.TabIndex = 25;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // lbl_eCon
            // 
            this.lbl_eCon.AutoSize = true;
            this.lbl_eCon.BackColor = System.Drawing.Color.Transparent;
            this.lbl_eCon.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_eCon.Location = new System.Drawing.Point(12, 18);
            this.lbl_eCon.Name = "lbl_eCon";
            this.lbl_eCon.Size = new System.Drawing.Size(0, 13);
            this.lbl_eCon.TabIndex = 37;
            // 
            // SelectUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CourseProject1A.Properties.Resources.small_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(561, 271);
            this.Controls.Add(this.lbl_eCon);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.submit_bt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_sFName);
            this.Name = "SelectUser";
            this.Text = "SelectUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.TextBox tb_sFName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button submit_bt;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label lbl_eCon;
    }
}