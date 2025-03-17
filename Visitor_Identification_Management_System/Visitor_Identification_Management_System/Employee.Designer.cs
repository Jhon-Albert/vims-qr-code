namespace Visitor_Identification_Management_System
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            panel2 = new Panel();
            btn_minimize = new Button();
            btn_maximize = new Button();
            btn_close = new Button();
            panel1 = new Panel();
            btn_realTime = new Button();
            btn_logout = new Button();
            btn_scan = new Button();
            btn_blacklist = new Button();
            btn_info = new Button();
            btn_logs = new Button();
            btn_dashboard = new Button();
            panel4 = new Panel();
            pictureBox2 = new PictureBox();
            panel5 = new Panel();
            label2 = new Label();
            panel6 = new Panel();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panelContainer = new Panel();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(33, 150, 243);
            panel2.Controls.Add(btn_minimize);
            panel2.Controls.Add(btn_maximize);
            panel2.Controls.Add(btn_close);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1253, 41);
            panel2.TabIndex = 34;
            panel2.MouseDown += panel2_MouseDown;
            // 
            // btn_minimize
            // 
            btn_minimize.Dock = DockStyle.Right;
            btn_minimize.FlatAppearance.BorderSize = 0;
            btn_minimize.FlatStyle = FlatStyle.Flat;
            btn_minimize.Image = (Image)resources.GetObject("btn_minimize.Image");
            btn_minimize.Location = new Point(1130, 0);
            btn_minimize.Name = "btn_minimize";
            btn_minimize.Size = new Size(41, 41);
            btn_minimize.TabIndex = 36;
            btn_minimize.UseVisualStyleBackColor = true;
            btn_minimize.Click += btn_minimize_Click;
            // 
            // btn_maximize
            // 
            btn_maximize.Dock = DockStyle.Right;
            btn_maximize.FlatAppearance.BorderSize = 0;
            btn_maximize.FlatStyle = FlatStyle.Flat;
            btn_maximize.ForeColor = SystemColors.ControlText;
            btn_maximize.Image = (Image)resources.GetObject("btn_maximize.Image");
            btn_maximize.Location = new Point(1171, 0);
            btn_maximize.Name = "btn_maximize";
            btn_maximize.Size = new Size(41, 41);
            btn_maximize.TabIndex = 35;
            btn_maximize.UseVisualStyleBackColor = true;
            btn_maximize.Click += btn_maximize_Click;
            // 
            // btn_close
            // 
            btn_close.Dock = DockStyle.Right;
            btn_close.FlatAppearance.BorderSize = 0;
            btn_close.FlatStyle = FlatStyle.Flat;
            btn_close.Image = (Image)resources.GetObject("btn_close.Image");
            btn_close.Location = new Point(1212, 0);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(41, 41);
            btn_close.TabIndex = 34;
            btn_close.UseVisualStyleBackColor = true;
            btn_close.Click += btn_close_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(btn_realTime);
            panel1.Controls.Add(btn_logout);
            panel1.Controls.Add(btn_scan);
            panel1.Controls.Add(btn_blacklist);
            panel1.Controls.Add(btn_info);
            panel1.Controls.Add(btn_logs);
            panel1.Controls.Add(btn_dashboard);
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 574);
            panel1.TabIndex = 35;
            // 
            // btn_realTime
            // 
            btn_realTime.Dock = DockStyle.Top;
            btn_realTime.FlatAppearance.BorderSize = 0;
            btn_realTime.FlatAppearance.MouseDownBackColor = SystemColors.GradientActiveCaption;
            btn_realTime.FlatAppearance.MouseOverBackColor = SystemColors.GradientActiveCaption;
            btn_realTime.FlatStyle = FlatStyle.Flat;
            btn_realTime.Font = new Font("Segoe UI", 9F);
            btn_realTime.ForeColor = SystemColors.ControlText;
            btn_realTime.Image = (Image)resources.GetObject("btn_realTime.Image");
            btn_realTime.ImageAlign = ContentAlignment.MiddleLeft;
            btn_realTime.Location = new Point(0, 350);
            btn_realTime.Name = "btn_realTime";
            btn_realTime.Padding = new Padding(12, 0, 0, 0);
            btn_realTime.Size = new Size(200, 55);
            btn_realTime.TabIndex = 21;
            btn_realTime.Text = "  Real-Time Tracking";
            btn_realTime.TextAlign = ContentAlignment.MiddleLeft;
            btn_realTime.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_realTime.UseVisualStyleBackColor = true;
            btn_realTime.Click += btn_realTime_Click_1;
            // 
            // btn_logout
            // 
            btn_logout.Dock = DockStyle.Bottom;
            btn_logout.FlatAppearance.BorderSize = 0;
            btn_logout.FlatAppearance.MouseDownBackColor = SystemColors.GradientActiveCaption;
            btn_logout.FlatAppearance.MouseOverBackColor = SystemColors.GradientActiveCaption;
            btn_logout.FlatStyle = FlatStyle.Flat;
            btn_logout.Font = new Font("Segoe UI", 9F);
            btn_logout.ForeColor = SystemColors.ControlText;
            btn_logout.Image = (Image)resources.GetObject("btn_logout.Image");
            btn_logout.ImageAlign = ContentAlignment.MiddleLeft;
            btn_logout.Location = new Point(0, 519);
            btn_logout.Name = "btn_logout";
            btn_logout.Padding = new Padding(12, 0, 0, 0);
            btn_logout.Size = new Size(200, 55);
            btn_logout.TabIndex = 20;
            btn_logout.Text = "   Log Out";
            btn_logout.TextAlign = ContentAlignment.MiddleLeft;
            btn_logout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_logout.UseVisualStyleBackColor = true;
            btn_logout.Click += btn_logout_Click_1;
            // 
            // btn_scan
            // 
            btn_scan.Dock = DockStyle.Top;
            btn_scan.FlatAppearance.BorderSize = 0;
            btn_scan.FlatAppearance.MouseDownBackColor = SystemColors.GradientActiveCaption;
            btn_scan.FlatAppearance.MouseOverBackColor = SystemColors.GradientActiveCaption;
            btn_scan.FlatStyle = FlatStyle.Flat;
            btn_scan.Font = new Font("Segoe UI", 9F);
            btn_scan.ForeColor = SystemColors.ControlText;
            btn_scan.Image = (Image)resources.GetObject("btn_scan.Image");
            btn_scan.ImageAlign = ContentAlignment.MiddleLeft;
            btn_scan.Location = new Point(0, 295);
            btn_scan.Name = "btn_scan";
            btn_scan.Padding = new Padding(12, 0, 0, 0);
            btn_scan.Size = new Size(200, 55);
            btn_scan.TabIndex = 19;
            btn_scan.Text = "   Scan QR";
            btn_scan.TextAlign = ContentAlignment.MiddleLeft;
            btn_scan.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_scan.UseVisualStyleBackColor = true;
            btn_scan.Click += btn_scan_Click_1;
            // 
            // btn_blacklist
            // 
            btn_blacklist.Dock = DockStyle.Top;
            btn_blacklist.FlatAppearance.BorderSize = 0;
            btn_blacklist.FlatAppearance.MouseDownBackColor = SystemColors.GradientActiveCaption;
            btn_blacklist.FlatAppearance.MouseOverBackColor = SystemColors.GradientActiveCaption;
            btn_blacklist.FlatStyle = FlatStyle.Flat;
            btn_blacklist.Font = new Font("Segoe UI", 9F);
            btn_blacklist.ForeColor = SystemColors.ControlText;
            btn_blacklist.Image = (Image)resources.GetObject("btn_blacklist.Image");
            btn_blacklist.ImageAlign = ContentAlignment.MiddleLeft;
            btn_blacklist.Location = new Point(0, 240);
            btn_blacklist.Name = "btn_blacklist";
            btn_blacklist.Padding = new Padding(12, 0, 0, 0);
            btn_blacklist.Size = new Size(200, 55);
            btn_blacklist.TabIndex = 18;
            btn_blacklist.Text = "   Blacklist Visitors";
            btn_blacklist.TextAlign = ContentAlignment.MiddleLeft;
            btn_blacklist.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_blacklist.UseVisualStyleBackColor = true;
            btn_blacklist.Click += btn_blacklist_Click_1;
            // 
            // btn_info
            // 
            btn_info.Dock = DockStyle.Top;
            btn_info.FlatAppearance.BorderSize = 0;
            btn_info.FlatAppearance.MouseDownBackColor = SystemColors.GradientActiveCaption;
            btn_info.FlatAppearance.MouseOverBackColor = SystemColors.GradientActiveCaption;
            btn_info.FlatStyle = FlatStyle.Flat;
            btn_info.Font = new Font("Segoe UI", 9F);
            btn_info.ForeColor = SystemColors.ControlText;
            btn_info.Image = (Image)resources.GetObject("btn_info.Image");
            btn_info.ImageAlign = ContentAlignment.MiddleLeft;
            btn_info.Location = new Point(0, 185);
            btn_info.Name = "btn_info";
            btn_info.Padding = new Padding(12, 0, 0, 0);
            btn_info.Size = new Size(200, 55);
            btn_info.TabIndex = 17;
            btn_info.Text = "   Visitor Info";
            btn_info.TextAlign = ContentAlignment.MiddleLeft;
            btn_info.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_info.UseVisualStyleBackColor = true;
            btn_info.Click += btn_info_Click_1;
            // 
            // btn_logs
            // 
            btn_logs.Dock = DockStyle.Top;
            btn_logs.FlatAppearance.BorderSize = 0;
            btn_logs.FlatAppearance.MouseDownBackColor = SystemColors.GradientActiveCaption;
            btn_logs.FlatAppearance.MouseOverBackColor = SystemColors.GradientActiveCaption;
            btn_logs.FlatStyle = FlatStyle.Flat;
            btn_logs.Font = new Font("Segoe UI", 9F);
            btn_logs.ForeColor = SystemColors.ControlText;
            btn_logs.Image = (Image)resources.GetObject("btn_logs.Image");
            btn_logs.ImageAlign = ContentAlignment.MiddleLeft;
            btn_logs.Location = new Point(0, 130);
            btn_logs.Name = "btn_logs";
            btn_logs.Padding = new Padding(12, 0, 0, 0);
            btn_logs.Size = new Size(200, 55);
            btn_logs.TabIndex = 16;
            btn_logs.Text = "   Visitor Logs";
            btn_logs.TextAlign = ContentAlignment.MiddleLeft;
            btn_logs.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_logs.UseVisualStyleBackColor = true;
            btn_logs.Click += btn_logs_Click_1;
            // 
            // btn_dashboard
            // 
            btn_dashboard.Dock = DockStyle.Top;
            btn_dashboard.FlatAppearance.BorderSize = 0;
            btn_dashboard.FlatAppearance.MouseDownBackColor = SystemColors.GradientActiveCaption;
            btn_dashboard.FlatAppearance.MouseOverBackColor = SystemColors.GradientActiveCaption;
            btn_dashboard.FlatStyle = FlatStyle.Flat;
            btn_dashboard.Font = new Font("Segoe UI", 9F);
            btn_dashboard.ForeColor = SystemColors.ControlText;
            btn_dashboard.Image = (Image)resources.GetObject("btn_dashboard.Image");
            btn_dashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btn_dashboard.Location = new Point(0, 75);
            btn_dashboard.Name = "btn_dashboard";
            btn_dashboard.Padding = new Padding(12, 0, 0, 0);
            btn_dashboard.Size = new Size(200, 55);
            btn_dashboard.TabIndex = 15;
            btn_dashboard.Text = "   Dashboard";
            btn_dashboard.TextAlign = ContentAlignment.MiddleLeft;
            btn_dashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_dashboard.UseVisualStyleBackColor = true;
            btn_dashboard.Click += btn_dashboard_Click;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Controls.Add(pictureBox2);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 75);
            panel4.TabIndex = 14;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(61, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(73, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaption;
            panel5.Controls.Add(label2);
            panel5.Controls.Add(panel6);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(200, 41);
            panel5.Name = "panel5";
            panel5.Size = new Size(1053, 47);
            panel5.TabIndex = 36;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(340, 13);
            label2.Name = "label2";
            label2.Size = new Size(373, 21);
            label2.TabIndex = 10;
            label2.Text = "VISITOR IDENTIFICATION MANAGEMENT SYSTEM";
            // 
            // panel6
            // 
            panel6.Controls.Add(label3);
            panel6.Controls.Add(pictureBox1);
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(899, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(154, 47);
            panel6.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(67, 17);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 6;
            label3.Text = "Employee";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(19, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // panelContainer
            // 
            panelContainer.BackColor = SystemColors.GradientInactiveCaption;
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(200, 88);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1053, 527);
            panelContainer.TabIndex = 37;
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1253, 615);
            Controls.Add(panelContainer);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Employee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee";
            Load += Employee_Load;
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Button btn_minimize;
        private Button btn_maximize;
        private Button btn_close;
        private Panel panel1;
        private Button btn_realTime;
        private Button btn_logout;
        private Button btn_scan;
        private Button btn_blacklist;
        private Button btn_info;
        private Button btn_logs;
        private Button btn_dashboard;
        private Panel panel4;
        private PictureBox pictureBox2;
        private Panel panel5;
        private Label label2;
        private Panel panel6;
        private Label label3;
        private PictureBox pictureBox1;
        private Panel panelContainer;
    }
}