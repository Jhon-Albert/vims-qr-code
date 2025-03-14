namespace Visitor_Identification_Management_System
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            panelTabs = new Panel();
            btn_logout = new Button();
            btn_blacklistManagement = new Button();
            btn_visitorReports = new Button();
            btn_employeeManagement = new Button();
            btn_visitorManagement = new Button();
            btn_admin_dashboard = new Button();
            panelLogo = new Panel();
            panelTitle = new Panel();
            Title = new Label();
            panel3 = new Panel();
            lbl_name = new Label();
            pbClose = new PictureBox();
            panelContainer = new Panel();
            panelTabs.SuspendLayout();
            panelTitle.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbClose).BeginInit();
            SuspendLayout();
            // 
            // panelTabs
            // 
            panelTabs.BackColor = Color.Beige;
            panelTabs.Controls.Add(btn_logout);
            panelTabs.Controls.Add(btn_blacklistManagement);
            panelTabs.Controls.Add(btn_visitorReports);
            panelTabs.Controls.Add(btn_employeeManagement);
            panelTabs.Controls.Add(btn_visitorManagement);
            panelTabs.Controls.Add(btn_admin_dashboard);
            panelTabs.Controls.Add(panelLogo);
            panelTabs.Dock = DockStyle.Left;
            panelTabs.Location = new Point(0, 0);
            panelTabs.Name = "panelTabs";
            panelTabs.Size = new Size(200, 572);
            panelTabs.TabIndex = 1;
            // 
            // btn_logout
            // 
            btn_logout.Dock = DockStyle.Bottom;
            btn_logout.FlatAppearance.BorderSize = 0;
            btn_logout.FlatAppearance.MouseDownBackColor = Color.Yellow;
            btn_logout.FlatAppearance.MouseOverBackColor = Color.Yellow;
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
            // btn_blacklistManagement
            // 
            btn_blacklistManagement.Dock = DockStyle.Top;
            btn_blacklistManagement.FlatAppearance.BorderSize = 0;
            btn_blacklistManagement.FlatAppearance.MouseDownBackColor = Color.Yellow;
            btn_blacklistManagement.FlatAppearance.MouseOverBackColor = Color.Yellow;
            btn_blacklistManagement.FlatStyle = FlatStyle.Flat;
            btn_blacklistManagement.Font = new Font("Segoe UI", 9F);
            btn_blacklistManagement.ForeColor = SystemColors.ControlText;
            btn_blacklistManagement.Image = (Image)resources.GetObject("btn_blacklistManagement.Image");
            btn_blacklistManagement.ImageAlign = ContentAlignment.MiddleLeft;
            btn_blacklistManagement.Location = new Point(0, 295);
            btn_blacklistManagement.Name = "btn_blacklistManagement";
            btn_blacklistManagement.Padding = new Padding(12, 0, 0, 0);
            btn_blacklistManagement.Size = new Size(200, 55);
            btn_blacklistManagement.TabIndex = 10;
            btn_blacklistManagement.Text = "   Blacklist Management";
            btn_blacklistManagement.TextAlign = ContentAlignment.MiddleLeft;
            btn_blacklistManagement.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_blacklistManagement.UseVisualStyleBackColor = true;
            btn_blacklistManagement.Click += btn_blacklistManagement_Click;
            // 
            // btn_visitorReports
            // 
            btn_visitorReports.Dock = DockStyle.Top;
            btn_visitorReports.FlatAppearance.BorderSize = 0;
            btn_visitorReports.FlatAppearance.MouseDownBackColor = Color.Yellow;
            btn_visitorReports.FlatAppearance.MouseOverBackColor = Color.Yellow;
            btn_visitorReports.FlatStyle = FlatStyle.Flat;
            btn_visitorReports.Font = new Font("Segoe UI", 9F);
            btn_visitorReports.ForeColor = SystemColors.ControlText;
            btn_visitorReports.Image = (Image)resources.GetObject("btn_visitorReports.Image");
            btn_visitorReports.ImageAlign = ContentAlignment.MiddleLeft;
            btn_visitorReports.Location = new Point(0, 240);
            btn_visitorReports.Name = "btn_visitorReports";
            btn_visitorReports.Padding = new Padding(12, 0, 0, 0);
            btn_visitorReports.Size = new Size(200, 55);
            btn_visitorReports.TabIndex = 9;
            btn_visitorReports.Text = "   Visitor Reports";
            btn_visitorReports.TextAlign = ContentAlignment.MiddleLeft;
            btn_visitorReports.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_visitorReports.UseVisualStyleBackColor = true;
            btn_visitorReports.Click += btn_visitorReports_Click;
            // 
            // btn_employeeManagement
            // 
            btn_employeeManagement.Dock = DockStyle.Top;
            btn_employeeManagement.FlatAppearance.BorderSize = 0;
            btn_employeeManagement.FlatAppearance.MouseDownBackColor = Color.Yellow;
            btn_employeeManagement.FlatAppearance.MouseOverBackColor = Color.Yellow;
            btn_employeeManagement.FlatStyle = FlatStyle.Flat;
            btn_employeeManagement.Font = new Font("Segoe UI", 9F);
            btn_employeeManagement.ForeColor = SystemColors.ControlText;
            btn_employeeManagement.Image = (Image)resources.GetObject("btn_employeeManagement.Image");
            btn_employeeManagement.ImageAlign = ContentAlignment.MiddleLeft;
            btn_employeeManagement.Location = new Point(0, 185);
            btn_employeeManagement.Name = "btn_employeeManagement";
            btn_employeeManagement.Padding = new Padding(12, 0, 0, 0);
            btn_employeeManagement.Size = new Size(200, 55);
            btn_employeeManagement.TabIndex = 8;
            btn_employeeManagement.Text = "   Employee Management";
            btn_employeeManagement.TextAlign = ContentAlignment.MiddleLeft;
            btn_employeeManagement.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_employeeManagement.UseVisualStyleBackColor = true;
            btn_employeeManagement.Click += btn_employeeManagement_Click;
            // 
            // btn_visitorManagement
            // 
            btn_visitorManagement.Dock = DockStyle.Top;
            btn_visitorManagement.FlatAppearance.BorderSize = 0;
            btn_visitorManagement.FlatAppearance.MouseDownBackColor = Color.Yellow;
            btn_visitorManagement.FlatAppearance.MouseOverBackColor = Color.Yellow;
            btn_visitorManagement.FlatStyle = FlatStyle.Flat;
            btn_visitorManagement.Font = new Font("Segoe UI", 9F);
            btn_visitorManagement.ForeColor = SystemColors.ControlText;
            btn_visitorManagement.Image = (Image)resources.GetObject("btn_visitorManagement.Image");
            btn_visitorManagement.ImageAlign = ContentAlignment.MiddleLeft;
            btn_visitorManagement.Location = new Point(0, 130);
            btn_visitorManagement.Name = "btn_visitorManagement";
            btn_visitorManagement.Padding = new Padding(12, 0, 0, 0);
            btn_visitorManagement.Size = new Size(200, 55);
            btn_visitorManagement.TabIndex = 7;
            btn_visitorManagement.Text = "   Visitor Management";
            btn_visitorManagement.TextAlign = ContentAlignment.MiddleLeft;
            btn_visitorManagement.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_visitorManagement.UseVisualStyleBackColor = true;
            btn_visitorManagement.Click += btn_visitorManagement_Click;
            // 
            // btn_admin_dashboard
            // 
            btn_admin_dashboard.Dock = DockStyle.Top;
            btn_admin_dashboard.FlatAppearance.BorderSize = 0;
            btn_admin_dashboard.FlatAppearance.MouseDownBackColor = Color.Yellow;
            btn_admin_dashboard.FlatAppearance.MouseOverBackColor = Color.Yellow;
            btn_admin_dashboard.FlatStyle = FlatStyle.Flat;
            btn_admin_dashboard.Font = new Font("Segoe UI", 9F);
            btn_admin_dashboard.ForeColor = SystemColors.ControlText;
            btn_admin_dashboard.Image = (Image)resources.GetObject("btn_admin_dashboard.Image");
            btn_admin_dashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btn_admin_dashboard.Location = new Point(0, 75);
            btn_admin_dashboard.Name = "btn_admin_dashboard";
            btn_admin_dashboard.Padding = new Padding(12, 0, 0, 0);
            btn_admin_dashboard.Size = new Size(200, 55);
            btn_admin_dashboard.TabIndex = 1;
            btn_admin_dashboard.Text = "   Dashboard";
            btn_admin_dashboard.TextAlign = ContentAlignment.MiddleLeft;
            btn_admin_dashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_admin_dashboard.UseVisualStyleBackColor = true;
            btn_admin_dashboard.Click += btn_admin_dashboard_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.LightGoldenrodYellow;
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(200, 75);
            panelLogo.TabIndex = 0;
            // 
            // panelTitle
            // 
            panelTitle.BackColor = Color.LemonChiffon;
            panelTitle.Controls.Add(Title);
            panelTitle.Controls.Add(panel3);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Location = new Point(200, 0);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(1053, 47);
            panelTitle.TabIndex = 2;
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(6, 16);
            Title.Name = "Title";
            Title.Size = new Size(373, 21);
            Title.TabIndex = 7;
            Title.Text = "VISITOR IDENTIFICATION MANAGEMENT SYSTEM";
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
            lbl_name.Size = new Size(53, 20);
            lbl_name.TabIndex = 6;
            lbl_name.Text = "Admin";
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
            panelContainer.TabIndex = 3;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1253, 572);
            Controls.Add(panelContainer);
            Controls.Add(panelTitle);
            Controls.Add(panelTabs);
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            panelTabs.ResumeLayout(false);
            panelTitle.ResumeLayout(false);
            panelTitle.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbClose).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTabs;
        private Button btn_logout;
        private Button btn_blacklistManagement;
        private Button btn_visitorReports;
        private Button btn_employeeManagement;
        private Button btn_visitorManagement;
        private Button btn_admin_dashboard;
        private Panel panelLogo;
        private Panel panelTitle;
        private Label Title;
        private Panel panel3;
        private Label lbl_name;
        private PictureBox pbClose;
        private Panel panelContainer;
    }
}