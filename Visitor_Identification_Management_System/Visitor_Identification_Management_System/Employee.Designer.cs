﻿namespace Visitor_Identification_Management_System
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
            btn_close = new Button();
            panel1 = new Panel();
            btn_renewQRCode = new Button();
            btn_register = new Button();
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
            panel2.BackColor = Color.FromArgb(191, 219, 254);
            panel2.Controls.Add(btn_minimize);
            panel2.Controls.Add(btn_close);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1280, 31);
            panel2.TabIndex = 34;
            panel2.MouseDown += panel2_MouseDown;
            // 
            // btn_minimize
            // 
            btn_minimize.Dock = DockStyle.Right;
            btn_minimize.FlatAppearance.BorderSize = 0;
            btn_minimize.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 76, 209);
            btn_minimize.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 96, 228);
            btn_minimize.FlatStyle = FlatStyle.Flat;
            btn_minimize.Image = (Image)resources.GetObject("btn_minimize.Image");
            btn_minimize.Location = new Point(1198, 0);
            btn_minimize.Name = "btn_minimize";
            btn_minimize.Size = new Size(41, 31);
            btn_minimize.TabIndex = 36;
            btn_minimize.UseVisualStyleBackColor = true;
            btn_minimize.Click += btn_minimize_Click;
            // 
            // btn_close
            // 
            btn_close.Dock = DockStyle.Right;
            btn_close.FlatAppearance.BorderSize = 0;
            btn_close.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 76, 209);
            btn_close.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 96, 228);
            btn_close.FlatStyle = FlatStyle.Flat;
            btn_close.Image = (Image)resources.GetObject("btn_close.Image");
            btn_close.Location = new Point(1239, 0);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(41, 31);
            btn_close.TabIndex = 34;
            btn_close.UseVisualStyleBackColor = true;
            btn_close.Click += btn_close_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(147, 197, 253);
            panel1.Controls.Add(btn_renewQRCode);
            panel1.Controls.Add(btn_register);
            panel1.Controls.Add(btn_realTime);
            panel1.Controls.Add(btn_logout);
            panel1.Controls.Add(btn_scan);
            panel1.Controls.Add(btn_blacklist);
            panel1.Controls.Add(btn_info);
            panel1.Controls.Add(btn_logs);
            panel1.Controls.Add(btn_dashboard);
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 689);
            panel1.TabIndex = 35;
            // 
            // btn_renewQRCode
            // 
            btn_renewQRCode.Dock = DockStyle.Top;
            btn_renewQRCode.FlatAppearance.BorderSize = 0;
            btn_renewQRCode.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 76, 209);
            btn_renewQRCode.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 96, 228);
            btn_renewQRCode.FlatStyle = FlatStyle.Flat;
            btn_renewQRCode.Font = new Font("Segoe UI", 9.75F);
            btn_renewQRCode.ForeColor = SystemColors.ControlText;
            btn_renewQRCode.Image = (Image)resources.GetObject("btn_renewQRCode.Image");
            btn_renewQRCode.ImageAlign = ContentAlignment.MiddleLeft;
            btn_renewQRCode.Location = new Point(0, 460);
            btn_renewQRCode.Name = "btn_renewQRCode";
            btn_renewQRCode.Padding = new Padding(12, 0, 0, 0);
            btn_renewQRCode.Size = new Size(200, 55);
            btn_renewQRCode.TabIndex = 23;
            btn_renewQRCode.Text = "   Renew QR Code";
            btn_renewQRCode.TextAlign = ContentAlignment.MiddleLeft;
            btn_renewQRCode.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_renewQRCode.UseVisualStyleBackColor = true;
            btn_renewQRCode.Click += btn_renewQRCode_Click;
            // 
            // btn_register
            // 
            btn_register.Dock = DockStyle.Top;
            btn_register.FlatAppearance.BorderSize = 0;
            btn_register.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 76, 209);
            btn_register.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 96, 228);
            btn_register.FlatStyle = FlatStyle.Flat;
            btn_register.Font = new Font("Segoe UI", 9.75F);
            btn_register.ForeColor = SystemColors.ControlText;
            btn_register.Image = (Image)resources.GetObject("btn_register.Image");
            btn_register.ImageAlign = ContentAlignment.MiddleLeft;
            btn_register.Location = new Point(0, 405);
            btn_register.Name = "btn_register";
            btn_register.Padding = new Padding(12, 0, 0, 0);
            btn_register.Size = new Size(200, 55);
            btn_register.TabIndex = 22;
            btn_register.Text = "   Register Visitor";
            btn_register.TextAlign = ContentAlignment.MiddleLeft;
            btn_register.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_register.UseVisualStyleBackColor = true;
            btn_register.Click += btn_register_Click;
            // 
            // btn_realTime
            // 
            btn_realTime.Dock = DockStyle.Top;
            btn_realTime.FlatAppearance.BorderSize = 0;
            btn_realTime.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 76, 209);
            btn_realTime.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 96, 228);
            btn_realTime.FlatStyle = FlatStyle.Flat;
            btn_realTime.Font = new Font("Segoe UI", 9.75F);
            btn_realTime.ForeColor = SystemColors.ControlText;
            btn_realTime.Image = (Image)resources.GetObject("btn_realTime.Image");
            btn_realTime.ImageAlign = ContentAlignment.MiddleLeft;
            btn_realTime.Location = new Point(0, 350);
            btn_realTime.Name = "btn_realTime";
            btn_realTime.Padding = new Padding(12, 0, 0, 0);
            btn_realTime.Size = new Size(200, 55);
            btn_realTime.TabIndex = 21;
            btn_realTime.Text = "   Real-Time Tracking";
            btn_realTime.TextAlign = ContentAlignment.MiddleLeft;
            btn_realTime.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_realTime.UseVisualStyleBackColor = true;
            btn_realTime.Click += btn_realTime_Click_1;
            // 
            // btn_logout
            // 
            btn_logout.Dock = DockStyle.Bottom;
            btn_logout.FlatAppearance.BorderSize = 0;
            btn_logout.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 76, 209);
            btn_logout.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 96, 228);
            btn_logout.FlatStyle = FlatStyle.Flat;
            btn_logout.Font = new Font("Segoe UI", 9.75F);
            btn_logout.ForeColor = SystemColors.ControlText;
            btn_logout.Image = (Image)resources.GetObject("btn_logout.Image");
            btn_logout.ImageAlign = ContentAlignment.MiddleLeft;
            btn_logout.Location = new Point(0, 634);
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
            btn_scan.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 76, 209);
            btn_scan.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 96, 228);
            btn_scan.FlatStyle = FlatStyle.Flat;
            btn_scan.Font = new Font("Segoe UI", 9.75F);
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
            btn_blacklist.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 76, 209);
            btn_blacklist.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 96, 228);
            btn_blacklist.FlatStyle = FlatStyle.Flat;
            btn_blacklist.Font = new Font("Segoe UI", 9.75F);
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
            btn_info.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 76, 209);
            btn_info.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 96, 228);
            btn_info.FlatStyle = FlatStyle.Flat;
            btn_info.Font = new Font("Segoe UI", 9.75F);
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
            btn_logs.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 76, 209);
            btn_logs.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 96, 228);
            btn_logs.FlatStyle = FlatStyle.Flat;
            btn_logs.Font = new Font("Segoe UI", 9.75F);
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
            btn_dashboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 76, 209);
            btn_dashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 96, 228);
            btn_dashboard.FlatStyle = FlatStyle.Flat;
            btn_dashboard.Font = new Font("Segoe UI", 9.75F);
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
            panel4.BackColor = Color.FromArgb(96, 165, 250);
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
            panel5.BackColor = Color.FromArgb(96, 165, 250);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(panel6);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(200, 31);
            panel5.Name = "panel5";
            panel5.Size = new Size(1080, 47);
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
            panel6.Location = new Point(926, 0);
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
            panelContainer.BackColor = Color.FromArgb(191, 219, 254);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(200, 78);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1080, 642);
            panelContainer.TabIndex = 37;
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
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
        private Button btn_register;
        private Button btn_renewQRCode;
    }
}