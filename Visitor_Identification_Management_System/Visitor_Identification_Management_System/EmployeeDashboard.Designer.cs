namespace Visitor_Identification_Management_System
{
    partial class EmployeeDashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeDashboard));
            panel4 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel5 = new Panel();
            panel3 = new Panel();
            lbl_current = new Label();
            pictureBox3 = new PictureBox();
            label6 = new Label();
            panel2 = new Panel();
            lbl_today = new Label();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            panel1 = new Panel();
            lbl_total_regis = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(766, 100);
            panel4.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 60);
            label2.Name = "label2";
            label2.Size = new Size(140, 21);
            label2.TabIndex = 14;
            label2.Text = "Home | Dashboard";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 15);
            label1.Name = "label1";
            label1.Size = new Size(184, 45);
            label1.TabIndex = 13;
            label1.Text = "Dashboard";
            // 
            // panel5
            // 
            panel5.Controls.Add(panel3);
            panel5.Controls.Add(panel2);
            panel5.Controls.Add(panel1);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 100);
            panel5.Name = "panel5";
            panel5.Size = new Size(766, 364);
            panel5.TabIndex = 17;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Yellow;
            panel3.Controls.Add(lbl_current);
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(461, 46);
            panel3.Name = "panel3";
            panel3.Size = new Size(175, 100);
            panel3.TabIndex = 18;
            // 
            // lbl_current
            // 
            lbl_current.AutoSize = true;
            lbl_current.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_current.Location = new Point(102, 49);
            lbl_current.Name = "lbl_current";
            lbl_current.Size = new Size(37, 21);
            lbl_current.TabIndex = 8;
            lbl_current.Text = "###";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(19, 34);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(51, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(159, 20);
            label6.TabIndex = 0;
            label6.Text = "Current-Inside Visitor";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Red;
            panel2.Controls.Add(lbl_today);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(280, 46);
            panel2.Name = "panel2";
            panel2.Size = new Size(175, 100);
            panel2.TabIndex = 17;
            // 
            // lbl_today
            // 
            lbl_today.AutoSize = true;
            lbl_today.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_today.Location = new Point(102, 49);
            lbl_today.Name = "lbl_today";
            lbl_today.Size = new Size(37, 21);
            lbl_today.TabIndex = 8;
            lbl_today.Text = "###";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(19, 34);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(51, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(110, 21);
            label5.TabIndex = 0;
            label5.Text = "Today Visitor";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(lbl_total_regis);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(99, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(175, 100);
            panel1.TabIndex = 16;
            // 
            // lbl_total_regis
            // 
            lbl_total_regis.AutoSize = true;
            lbl_total_regis.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_total_regis.Location = new Point(102, 49);
            lbl_total_regis.Name = "lbl_total_regis";
            lbl_total_regis.Size = new Size(37, 21);
            lbl_total_regis.TabIndex = 8;
            lbl_total_regis.Text = "###";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(19, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(173, 20);
            label3.TabIndex = 0;
            label3.Text = "Total Visitor Registered";
            // 
            // EmployeeDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel5);
            Controls.Add(panel4);
            Name = "EmployeeDashboard";
            Size = new Size(766, 464);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private Label label2;
        private Label label1;
        private Panel panel5;
        private Panel panel3;
        private Label lbl_current;
        private PictureBox pictureBox3;
        private Label label6;
        private Panel panel2;
        private Label lbl_today;
        private PictureBox pictureBox2;
        private Label label5;
        private Panel panel1;
        private Label lbl_total_regis;
        private PictureBox pictureBox1;
        private Label label3;
    }
}
