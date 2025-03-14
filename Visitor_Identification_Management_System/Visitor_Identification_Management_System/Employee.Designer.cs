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
            panelTabs = new Panel();
            btn_logout = new Button();
            btn_scan = new Button();
            btn_blacklist = new Button();
            btn_info = new Button();
            btn_logs = new Button();
            button1 = new Button();
            panelLogo = new Panel();
            panelTitle = new Panel();
            Title = new Label();
            panel3 = new Panel();
            lbl_name = new Label();
            pbClose = new PictureBox();
            panelContainer = new Panel();
            btn_realTime = new Button();
            panelTabs.SuspendLayout();
            panelTitle.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbClose).BeginInit();
            SuspendLayout();
            // 
            // panelTabs
            // 
            panelTabs.BackColor = SystemColors.GradientInactiveCaption;
            panelTabs.Controls.Add(btn_realTime);
            panelTabs.Controls.Add(btn_logout);
            panelTabs.Controls.Add(btn_scan);
            panelTabs.Controls.Add(btn_blacklist);
            panelTabs.Controls.Add(btn_info);
            panelTabs.Controls.Add(btn_logs);
            panelTabs.Controls.Add(button1);
            panelTabs.Controls.Add(panelLogo);
            panelTabs.Dock = DockStyle.Left;
            panelTabs.Location = new Point(0, 0);
            panelTabs.Name = "panelTabs";
            panelTabs.Size = new Size(200, 572);
            panelTabs.TabIndex = 0;
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
            btn_logout.Location = new Point(0, 517);
            btn_logout.Name = "btn_logout";
            btn_logout.Padding = new Padding(12, 0, 0, 0);
            btn_logout.Size = new Size(200, 55);
            btn_logout.TabIndex = 12;
            btn_logout.Text = "   Log Out";
            btn_logout.TextAlign = ContentAlignment.MiddleLeft;
            btn_logout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_logout.UseVisualStyleBackColor = true;
            btn_logout.Click += btn_logout_Click;
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
            btn_scan.TabIndex = 11;
            btn_scan.Text = "   Scan QR";
            btn_scan.TextAlign = ContentAlignment.MiddleLeft;
            btn_scan.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_scan.UseVisualStyleBackColor = true;
            btn_scan.Click += btn_scan_Click;
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
            btn_blacklist.TabIndex = 10;
            btn_blacklist.Text = "   Blacklist Visitors";
            btn_blacklist.TextAlign = ContentAlignment.MiddleLeft;
            btn_blacklist.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_blacklist.UseVisualStyleBackColor = true;
            btn_blacklist.Click += btn_blacklist_Click;
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
            btn_info.TabIndex = 8;
            btn_info.Text = "   Visitor Info";
            btn_info.TextAlign = ContentAlignment.MiddleLeft;
            btn_info.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_info.UseVisualStyleBackColor = true;
            btn_info.Click += btn_info_Click;
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
            btn_logs.TabIndex = 7;
            btn_logs.Text = "   Visitor Logs";
            btn_logs.TextAlign = ContentAlignment.MiddleLeft;
            btn_logs.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_logs.UseVisualStyleBackColor = true;
            btn_logs.Click += btn_logs_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = SystemColors.GradientActiveCaption;
            button1.FlatAppearance.MouseOverBackColor = SystemColors.GradientActiveCaption;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F);
            button1.ForeColor = SystemColors.ControlText;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 75);
            button1.Name = "button1";
            button1.Padding = new Padding(12, 0, 0, 0);
            button1.Size = new Size(200, 55);
            button1.TabIndex = 1;
            button1.Text = "   Dashboard";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = SystemColors.GradientActiveCaption;
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(200, 75);
            panelLogo.TabIndex = 0;
            // 
            // panelTitle
            // 
            panelTitle.BackColor = SystemColors.ActiveCaption;
            panelTitle.Controls.Add(Title);
            panelTitle.Controls.Add(panel3);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Location = new Point(200, 0);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(1053, 47);
            panelTitle.TabIndex = 1;
            // 
            // Title
            // 
            Title.Location = new Point(0, 0);
            Title.Name = "Title";
            Title.Size = new Size(100, 23);
            Title.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(lbl_name);
            panel3.Controls.Add(pbClose);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(899, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(154, 47);
            panel3.TabIndex = 6;
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_name.Location = new Point(67, 17);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(75, 20);
            lbl_name.TabIndex = 6;
            lbl_name.Text = "Employee";
            lbl_name.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbClose
            // 
            pbClose.Image = (Image)resources.GetObject("pbClose.Image");
            pbClose.Location = new Point(19, 9);
            pbClose.Name = "pbClose";
            pbClose.Size = new Size(33, 32);
            pbClose.SizeMode = PictureBoxSizeMode.Zoom;
            pbClose.TabIndex = 5;
            pbClose.TabStop = false;
            // 
            // panelContainer
            // 
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(200, 47);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1053, 525);
            panelContainer.TabIndex = 2;
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
            btn_realTime.TabIndex = 13;
            btn_realTime.Text = "  Real-Time Tracking";
            btn_realTime.TextAlign = ContentAlignment.MiddleLeft;
            btn_realTime.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_realTime.UseVisualStyleBackColor = true;
            btn_realTime.Click += btn_realTime_Click;
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1253, 572);
            Controls.Add(panelContainer);
            Controls.Add(panelTitle);
            Controls.Add(panelTabs);
            Name = "Employee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee";
            panelTabs.ResumeLayout(false);
            panelTitle.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbClose).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTabs;
        private Panel panelTitle;
        private Panel panel3;
        private Label lbl_name;
        private PictureBox pbClose;
        private Panel panelLogo;
        private Label Title;
        private Button btn_logout;
        private Button btn_scan;
        private Button btn_blacklist;
        private Button btn_info;
        private Button btn_logs;
        private Button button1;
        private Panel panelContainer;
        private Button btn_realTime;
    }
}