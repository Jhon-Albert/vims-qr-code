namespace Visitor_Identification_Management_System
{
    partial class RealTimeTracking
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RealTimeTracking));
            panel2 = new Panel();
            label1 = new Label();
            btn_minimize = new Button();
            btn_close = new Button();
            panel3 = new Panel();
            panel5 = new Panel();
            btn_stopCamera = new Button();
            lbl_time = new Label();
            lbl_date = new Label();
            txt_urlCamera1 = new TextBox();
            btn_liveCamera = new Button();
            panel4 = new Panel();
            panel1 = new Panel();
            lbl_visitorTime = new Label();
            panel6 = new Panel();
            lbl_visitorName = new Label();
            lbl_visitorStatus = new Label();
            pb_visitorProfilePicture = new PictureBox();
            pb_camera1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            settingToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            rSTPUrlToolStripMenuItem = new ToolStripMenuItem();
            toolStripTextBox1_urlCamera1 = new ToolStripTextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_visitorProfilePicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_camera1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(59, 130, 246);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btn_minimize);
            panel2.Controls.Add(btn_close);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(960, 31);
            panel2.TabIndex = 56;
            panel2.MouseDown += panel2_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 3);
            label1.Name = "label1";
            label1.Size = new Size(142, 21);
            label1.TabIndex = 24;
            label1.Text = "Real-Time Tracking";
            // 
            // btn_minimize
            // 
            btn_minimize.Dock = DockStyle.Right;
            btn_minimize.FlatAppearance.BorderSize = 0;
            btn_minimize.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 76, 209);
            btn_minimize.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 96, 228);
            btn_minimize.FlatStyle = FlatStyle.Flat;
            btn_minimize.Image = (Image)resources.GetObject("btn_minimize.Image");
            btn_minimize.Location = new Point(878, 0);
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
            btn_close.Location = new Point(919, 0);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(41, 31);
            btn_close.TabIndex = 34;
            btn_close.UseVisualStyleBackColor = true;
            btn_close.Click += btn_close_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(menuStrip1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 31);
            panel3.Name = "panel3";
            panel3.Size = new Size(960, 509);
            panel3.TabIndex = 58;
            // 
            // panel5
            // 
            panel5.Controls.Add(btn_stopCamera);
            panel5.Controls.Add(lbl_time);
            panel5.Controls.Add(lbl_date);
            panel5.Controls.Add(txt_urlCamera1);
            panel5.Controls.Add(btn_liveCamera);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(707, 24);
            panel5.Name = "panel5";
            panel5.Size = new Size(253, 485);
            panel5.TabIndex = 1;
            // 
            // btn_stopCamera
            // 
            btn_stopCamera.AutoSize = true;
            btn_stopCamera.BackColor = Color.FromArgb(52, 152, 219);
            btn_stopCamera.FlatAppearance.BorderSize = 0;
            btn_stopCamera.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 76, 209);
            btn_stopCamera.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 96, 228);
            btn_stopCamera.FlatStyle = FlatStyle.Flat;
            btn_stopCamera.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_stopCamera.ForeColor = Color.White;
            btn_stopCamera.Location = new Point(77, 151);
            btn_stopCamera.Name = "btn_stopCamera";
            btn_stopCamera.Size = new Size(131, 33);
            btn_stopCamera.TabIndex = 71;
            btn_stopCamera.Text = "Stop Camera";
            btn_stopCamera.UseVisualStyleBackColor = false;
            btn_stopCamera.Click += btn_stopCamera_Click;
            // 
            // lbl_time
            // 
            lbl_time.AutoSize = true;
            lbl_time.Font = new Font("Segoe UI", 12F);
            lbl_time.Location = new Point(3, 36);
            lbl_time.Name = "lbl_time";
            lbl_time.Size = new Size(44, 21);
            lbl_time.TabIndex = 68;
            lbl_time.Text = "TIME";
            // 
            // lbl_date
            // 
            lbl_date.AutoSize = true;
            lbl_date.Font = new Font("Segoe UI", 12F);
            lbl_date.Location = new Point(3, 15);
            lbl_date.Name = "lbl_date";
            lbl_date.Size = new Size(46, 21);
            lbl_date.TabIndex = 67;
            lbl_date.Text = "DATE";
            // 
            // txt_urlCamera1
            // 
            txt_urlCamera1.Font = new Font("Segoe UI", 12F);
            txt_urlCamera1.Location = new Point(3, 60);
            txt_urlCamera1.Name = "txt_urlCamera1";
            txt_urlCamera1.PlaceholderText = "RSTP Url Camera 1";
            txt_urlCamera1.Size = new Size(205, 29);
            txt_urlCamera1.TabIndex = 66;
            txt_urlCamera1.Visible = false;
            // 
            // btn_liveCamera
            // 
            btn_liveCamera.AutoSize = true;
            btn_liveCamera.BackColor = Color.FromArgb(52, 152, 219);
            btn_liveCamera.FlatAppearance.BorderSize = 0;
            btn_liveCamera.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 76, 209);
            btn_liveCamera.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 96, 228);
            btn_liveCamera.FlatStyle = FlatStyle.Flat;
            btn_liveCamera.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_liveCamera.ForeColor = Color.White;
            btn_liveCamera.Location = new Point(77, 95);
            btn_liveCamera.Name = "btn_liveCamera";
            btn_liveCamera.Size = new Size(131, 33);
            btn_liveCamera.TabIndex = 65;
            btn_liveCamera.Text = "Open Camera 1";
            btn_liveCamera.UseVisualStyleBackColor = false;
            btn_liveCamera.Click += btn_liveCamera_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(pb_visitorProfilePicture);
            panel4.Controls.Add(pb_camera1);
            panel4.Location = new Point(12, 60);
            panel4.Name = "panel4";
            panel4.Size = new Size(689, 330);
            panel4.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(2, 132, 199);
            panel1.Controls.Add(lbl_visitorTime);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(lbl_visitorStatus);
            panel1.Location = new Point(361, 396);
            panel1.Name = "panel1";
            panel1.Size = new Size(340, 101);
            panel1.TabIndex = 3;
            // 
            // lbl_visitorTime
            // 
            lbl_visitorTime.AutoSize = true;
            lbl_visitorTime.FlatStyle = FlatStyle.Flat;
            lbl_visitorTime.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            lbl_visitorTime.ForeColor = Color.FromArgb(23, 37, 84);
            lbl_visitorTime.Location = new Point(193, 73);
            lbl_visitorTime.Name = "lbl_visitorTime";
            lbl_visitorTime.Size = new Size(48, 21);
            lbl_visitorTime.TabIndex = 5;
            lbl_visitorTime.Text = "TIME";
            lbl_visitorTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(186, 230, 253);
            panel6.Controls.Add(lbl_visitorName);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(340, 70);
            panel6.TabIndex = 0;
            // 
            // lbl_visitorName
            // 
            lbl_visitorName.AutoSize = true;
            lbl_visitorName.FlatStyle = FlatStyle.Flat;
            lbl_visitorName.Font = new Font("Nirmala UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_visitorName.ForeColor = Color.FromArgb(23, 37, 84);
            lbl_visitorName.Location = new Point(67, 21);
            lbl_visitorName.Name = "lbl_visitorName";
            lbl_visitorName.Size = new Size(205, 32);
            lbl_visitorName.TabIndex = 4;
            lbl_visitorName.Text = "VISITOR'S NAME";
            lbl_visitorName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_visitorStatus
            // 
            lbl_visitorStatus.AutoSize = true;
            lbl_visitorStatus.FlatStyle = FlatStyle.Flat;
            lbl_visitorStatus.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            lbl_visitorStatus.ForeColor = Color.FromArgb(23, 37, 84);
            lbl_visitorStatus.Location = new Point(3, 73);
            lbl_visitorStatus.Name = "lbl_visitorStatus";
            lbl_visitorStatus.Size = new Size(67, 21);
            lbl_visitorStatus.TabIndex = 3;
            lbl_visitorStatus.Text = "STATUS";
            // 
            // pb_visitorProfilePicture
            // 
            pb_visitorProfilePicture.BorderStyle = BorderStyle.FixedSingle;
            pb_visitorProfilePicture.Dock = DockStyle.Right;
            pb_visitorProfilePicture.Image = (Image)resources.GetObject("pb_visitorProfilePicture.Image");
            pb_visitorProfilePicture.Location = new Point(349, 0);
            pb_visitorProfilePicture.Name = "pb_visitorProfilePicture";
            pb_visitorProfilePicture.Size = new Size(340, 330);
            pb_visitorProfilePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_visitorProfilePicture.TabIndex = 1;
            pb_visitorProfilePicture.TabStop = false;
            // 
            // pb_camera1
            // 
            pb_camera1.BorderStyle = BorderStyle.FixedSingle;
            pb_camera1.Dock = DockStyle.Left;
            pb_camera1.Image = (Image)resources.GetObject("pb_camera1.Image");
            pb_camera1.Location = new Point(0, 0);
            pb_camera1.Name = "pb_camera1";
            pb_camera1.Size = new Size(340, 330);
            pb_camera1.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_camera1.TabIndex = 0;
            pb_camera1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, settingToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(960, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(92, 22);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // settingToolStripMenuItem
            // 
            settingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            settingToolStripMenuItem.Size = new Size(61, 20);
            settingToolStripMenuItem.Text = "Settings";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { rSTPUrlToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(124, 22);
            toolStripMenuItem1.Text = "Camera 1";
            // 
            // rSTPUrlToolStripMenuItem
            // 
            rSTPUrlToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripTextBox1_urlCamera1 });
            rSTPUrlToolStripMenuItem.Name = "rSTPUrlToolStripMenuItem";
            rSTPUrlToolStripMenuItem.Size = new Size(119, 22);
            rSTPUrlToolStripMenuItem.Text = "RSTP Url";
            // 
            // toolStripTextBox1_urlCamera1
            // 
            toolStripTextBox1_urlCamera1.Name = "toolStripTextBox1_urlCamera1";
            toolStripTextBox1_urlCamera1.Size = new Size(100, 23);
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // RealTimeTracking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(147, 197, 253);
            ClientSize = new Size(960, 540);
            Controls.Add(panel3);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "RealTimeTracking";
            StartPosition = FormStartPosition.CenterParent;
            Text = "RealTimeTracking";
            Load += RealTimeTracking_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_visitorProfilePicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_camera1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button btn_minimize;
        private Button btn_close;
        private Label label1;
        private Panel panel3;
        private Panel panel4;
        private PictureBox pb_camera1;
        private PictureBox pb_visitorProfilePicture;
        private Panel panel5;
        private Label lbl_time;
        private Label lbl_date;
        private TextBox txt_urlCamera1;
        private Button btn_liveCamera;
        private System.Windows.Forms.Timer timer1;
        private Button btn_stopCamera;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem settingToolStripMenuItem;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem rSTPUrlToolStripMenuItem;
        private ToolStripTextBox toolStripTextBox1_urlCamera1;
        private Panel panel1;
        private Label lbl_visitorTime;
        private Label lbl_visitorStatus;
        private Label lbl_visitorName;
        private Panel panel6;
    }
}