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
            btn_minimize = new Button();
            btn_close = new Button();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            panel5 = new Panel();
            btn_stopCamera = new Button();
            btn_liveCamera2 = new Button();
            txt_urlCamera2 = new TextBox();
            lbl_time = new Label();
            lbl_date = new Label();
            txt_urlCamera1 = new TextBox();
            btn_liveCamera = new Button();
            panel4 = new Panel();
            pb_camera2 = new PictureBox();
            pb_camera1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_camera2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_camera1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(59, 130, 246);
            panel2.Controls.Add(btn_minimize);
            panel2.Controls.Add(btn_close);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(960, 31);
            panel2.TabIndex = 56;
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
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(960, 100);
            panel1.TabIndex = 57;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 15);
            label1.Name = "label1";
            label1.Size = new Size(307, 45);
            label1.TabIndex = 24;
            label1.Text = "Real-Time Tracking";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 60);
            label2.Name = "label2";
            label2.Size = new Size(136, 21);
            label2.TabIndex = 25;
            label2.Text = "Manage | Tracking";
            // 
            // panel3
            // 
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 131);
            panel3.Name = "panel3";
            panel3.Size = new Size(960, 409);
            panel3.TabIndex = 58;
            // 
            // panel5
            // 
            panel5.Controls.Add(btn_stopCamera);
            panel5.Controls.Add(btn_liveCamera2);
            panel5.Controls.Add(txt_urlCamera2);
            panel5.Controls.Add(lbl_time);
            panel5.Controls.Add(lbl_date);
            panel5.Controls.Add(txt_urlCamera1);
            panel5.Controls.Add(btn_liveCamera);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(668, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(292, 409);
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
            btn_stopCamera.Location = new Point(80, 336);
            btn_stopCamera.Name = "btn_stopCamera";
            btn_stopCamera.Size = new Size(131, 33);
            btn_stopCamera.TabIndex = 71;
            btn_stopCamera.Text = "Stop Camera";
            btn_stopCamera.UseVisualStyleBackColor = false;
            btn_stopCamera.Click += btn_stopCamera_Click;
            // 
            // btn_liveCamera2
            // 
            btn_liveCamera2.AutoSize = true;
            btn_liveCamera2.BackColor = Color.FromArgb(52, 152, 219);
            btn_liveCamera2.FlatAppearance.BorderSize = 0;
            btn_liveCamera2.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 76, 209);
            btn_liveCamera2.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 96, 228);
            btn_liveCamera2.FlatStyle = FlatStyle.Flat;
            btn_liveCamera2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_liveCamera2.ForeColor = Color.White;
            btn_liveCamera2.Location = new Point(80, 279);
            btn_liveCamera2.Name = "btn_liveCamera2";
            btn_liveCamera2.Size = new Size(131, 33);
            btn_liveCamera2.TabIndex = 70;
            btn_liveCamera2.Text = "Open Camera 2";
            btn_liveCamera2.UseVisualStyleBackColor = false;
            btn_liveCamera2.Click += btn_liveCamera2_Click;
            // 
            // txt_urlCamera2
            // 
            txt_urlCamera2.Font = new Font("Segoe UI", 12F);
            txt_urlCamera2.Location = new Point(39, 244);
            txt_urlCamera2.Name = "txt_urlCamera2";
            txt_urlCamera2.PlaceholderText = "RSTP Url Camera 2";
            txt_urlCamera2.Size = new Size(218, 29);
            txt_urlCamera2.TabIndex = 69;
            // 
            // lbl_time
            // 
            lbl_time.AutoSize = true;
            lbl_time.Font = new Font("Segoe UI", 12F);
            lbl_time.Location = new Point(133, 56);
            lbl_time.Name = "lbl_time";
            lbl_time.Size = new Size(44, 21);
            lbl_time.TabIndex = 68;
            lbl_time.Text = "TIME";
            // 
            // lbl_date
            // 
            lbl_date.AutoSize = true;
            lbl_date.Font = new Font("Segoe UI", 12F);
            lbl_date.Location = new Point(39, 24);
            lbl_date.Name = "lbl_date";
            lbl_date.Size = new Size(46, 21);
            lbl_date.TabIndex = 67;
            lbl_date.Text = "DATE";
            // 
            // txt_urlCamera1
            // 
            txt_urlCamera1.Font = new Font("Segoe UI", 12F);
            txt_urlCamera1.Location = new Point(39, 142);
            txt_urlCamera1.Name = "txt_urlCamera1";
            txt_urlCamera1.PlaceholderText = "RSTP Url Camera 1";
            txt_urlCamera1.Size = new Size(218, 29);
            txt_urlCamera1.TabIndex = 66;
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
            btn_liveCamera.Location = new Point(80, 177);
            btn_liveCamera.Name = "btn_liveCamera";
            btn_liveCamera.Size = new Size(131, 33);
            btn_liveCamera.TabIndex = 65;
            btn_liveCamera.Text = "Open Camera 1";
            btn_liveCamera.UseVisualStyleBackColor = false;
            btn_liveCamera.Click += btn_liveCamera_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(pb_camera2);
            panel4.Controls.Add(pb_camera1);
            panel4.Location = new Point(26, 39);
            panel4.Name = "panel4";
            panel4.Size = new Size(636, 330);
            panel4.TabIndex = 0;
            // 
            // pb_camera2
            // 
            pb_camera2.BorderStyle = BorderStyle.FixedSingle;
            pb_camera2.Dock = DockStyle.Right;
            pb_camera2.Location = new Point(336, 0);
            pb_camera2.Name = "pb_camera2";
            pb_camera2.Size = new Size(300, 330);
            pb_camera2.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_camera2.TabIndex = 1;
            pb_camera2.TabStop = false;
            // 
            // pb_camera1
            // 
            pb_camera1.BorderStyle = BorderStyle.FixedSingle;
            pb_camera1.Dock = DockStyle.Left;
            pb_camera1.Location = new Point(0, 0);
            pb_camera1.Name = "pb_camera1";
            pb_camera1.Size = new Size(300, 330);
            pb_camera1.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_camera1.TabIndex = 0;
            pb_camera1.TabStop = false;
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
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RealTimeTracking";
            StartPosition = FormStartPosition.CenterParent;
            Text = "RealTimeTracking";
            Load += RealTimeTracking_Load;
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pb_camera2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_camera1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button btn_minimize;
        private Button btn_close;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Panel panel3;
        private Panel panel4;
        private PictureBox pb_camera1;
        private PictureBox pb_camera2;
        private Panel panel5;
        private Label lbl_time;
        private Label lbl_date;
        private TextBox txt_urlCamera1;
        private Button btn_liveCamera;
        private System.Windows.Forms.Timer timer1;
        private TextBox txt_urlCamera2;
        private Button btn_liveCamera2;
        private Button btn_stopCamera;
    }
}