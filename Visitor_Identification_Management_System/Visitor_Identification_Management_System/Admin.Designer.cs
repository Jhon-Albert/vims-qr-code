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
            panel2 = new Panel();
            btn_minimize = new Button();
            btn_maximize = new Button();
            btn_close = new Button();
            panel1 = new Panel();
            btn_logout = new Button();
            btn_blacklistManagement = new Button();
            btn_visitorReports = new Button();
            btn_employeeManagement = new Button();
            btn_visitorManagement = new Button();
            btn_admin_dashboard = new Button();
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            label2 = new Label();
            panel5 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            adminPanelContainer = new Panel();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            panel2.TabIndex = 35;
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
            panel1.BackColor = Color.Cornsilk;
            panel1.Controls.Add(btn_logout);
            panel1.Controls.Add(btn_blacklistManagement);
            panel1.Controls.Add(btn_visitorReports);
            panel1.Controls.Add(btn_employeeManagement);
            panel1.Controls.Add(btn_visitorManagement);
            panel1.Controls.Add(btn_admin_dashboard);
            panel1.Controls.Add(panelLogo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 574);
            panel1.TabIndex = 36;
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
            btn_logout.Location = new Point(0, 519);
            btn_logout.Name = "btn_logout";
            btn_logout.Padding = new Padding(12, 0, 0, 0);
            btn_logout.Size = new Size(200, 55);
            btn_logout.TabIndex = 19;
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
            btn_blacklistManagement.TabIndex = 18;
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
            btn_visitorReports.TabIndex = 17;
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
            btn_employeeManagement.TabIndex = 16;
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
            btn_visitorManagement.TabIndex = 15;
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
            btn_admin_dashboard.TabIndex = 14;
            btn_admin_dashboard.Text = "   Dashboard";
            btn_admin_dashboard.TextAlign = ContentAlignment.MiddleLeft;
            btn_admin_dashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_admin_dashboard.UseVisualStyleBackColor = true;
            btn_admin_dashboard.Click += btn_admin_dashboard_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.LightGoldenrodYellow;
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(200, 75);
            panelLogo.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(62, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LemonChiffon;
            panel4.Controls.Add(label2);
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(200, 41);
            panel4.Name = "panel4";
            panel4.Size = new Size(1053, 47);
            panel4.TabIndex = 37;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(340, 13);
            label2.Name = "label2";
            label2.Size = new Size(373, 21);
            label2.TabIndex = 11;
            label2.Text = "VISITOR IDENTIFICATION MANAGEMENT SYSTEM";
            // 
            // panel5
            // 
            panel5.Controls.Add(label1);
            panel5.Controls.Add(pictureBox2);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(899, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(154, 47);
            panel5.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(67, 17);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 6;
            label1.Text = "Admin";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(19, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // adminPanelContainer
            // 
            adminPanelContainer.BackColor = Color.Beige;
            adminPanelContainer.Dock = DockStyle.Fill;
            adminPanelContainer.Location = new Point(200, 88);
            adminPanelContainer.Name = "adminPanelContainer";
            adminPanelContainer.Size = new Size(1053, 527);
            adminPanelContainer.TabIndex = 38;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1253, 615);
            Controls.Add(adminPanelContainer);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Button btn_minimize;
        private Button btn_maximize;
        private Button btn_close;
        private Panel panel1;
        private Button btn_logout;
        private Button btn_blacklistManagement;
        private Button btn_visitorReports;
        private Button btn_employeeManagement;
        private Button btn_visitorManagement;
        private Button btn_admin_dashboard;
        private Panel panelLogo;
        private PictureBox pictureBox1;
        private Panel panel4;
        private Panel panel5;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label2;
        private Panel adminPanelContainer;
    }
}