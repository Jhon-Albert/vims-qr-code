namespace Visitor_Identification_Management_System
{
    partial class RealTime
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            lbl_time = new Label();
            lbl_date = new Label();
            txt_urlCamera = new TextBox();
            btn_liveCamera = new Button();
            panel3 = new Panel();
            pb_camera2 = new PictureBox();
            pb_camera1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_camera2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_camera1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1053, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 17);
            label1.Name = "label1";
            label1.Size = new Size(307, 45);
            label1.TabIndex = 22;
            label1.Text = "Real-Time Tracking";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(46, 62);
            label2.Name = "label2";
            label2.Size = new Size(136, 21);
            label2.TabIndex = 23;
            label2.Text = "Manage | Tracking";
            // 
            // panel2
            // 
            panel2.Controls.Add(lbl_time);
            panel2.Controls.Add(lbl_date);
            panel2.Controls.Add(txt_urlCamera);
            panel2.Controls.Add(btn_liveCamera);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(1053, 425);
            panel2.TabIndex = 1;
            // 
            // lbl_time
            // 
            lbl_time.AutoSize = true;
            lbl_time.Font = new Font("Segoe UI", 12F);
            lbl_time.Location = new Point(909, 59);
            lbl_time.Name = "lbl_time";
            lbl_time.Size = new Size(44, 21);
            lbl_time.TabIndex = 64;
            lbl_time.Text = "TIME";
            // 
            // lbl_date
            // 
            lbl_date.AutoSize = true;
            lbl_date.Font = new Font("Segoe UI", 12F);
            lbl_date.Location = new Point(815, 27);
            lbl_date.Name = "lbl_date";
            lbl_date.Size = new Size(46, 21);
            lbl_date.TabIndex = 63;
            lbl_date.Text = "DATE";
            // 
            // txt_urlCamera
            // 
            txt_urlCamera.Font = new Font("Segoe UI", 12F);
            txt_urlCamera.Location = new Point(815, 145);
            txt_urlCamera.Name = "txt_urlCamera";
            txt_urlCamera.PlaceholderText = "RSTP Url";
            txt_urlCamera.Size = new Size(218, 29);
            txt_urlCamera.TabIndex = 62;
            // 
            // btn_liveCamera
            // 
            btn_liveCamera.AutoSize = true;
            btn_liveCamera.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_liveCamera.Location = new Point(863, 205);
            btn_liveCamera.Name = "btn_liveCamera";
            btn_liveCamera.Size = new Size(116, 31);
            btn_liveCamera.TabIndex = 34;
            btn_liveCamera.Text = "Open Camera";
            btn_liveCamera.UseVisualStyleBackColor = true;
            btn_liveCamera.Click += btn_liveCamera_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(pb_camera2);
            panel3.Controls.Add(pb_camera1);
            panel3.Location = new Point(46, 27);
            panel3.Name = "panel3";
            panel3.Size = new Size(739, 345);
            panel3.TabIndex = 1;
            // 
            // pb_camera2
            // 
            pb_camera2.BorderStyle = BorderStyle.FixedSingle;
            pb_camera2.Dock = DockStyle.Right;
            pb_camera2.Location = new Point(372, 0);
            pb_camera2.Name = "pb_camera2";
            pb_camera2.Size = new Size(367, 345);
            pb_camera2.TabIndex = 1;
            pb_camera2.TabStop = false;
            // 
            // pb_camera1
            // 
            pb_camera1.BorderStyle = BorderStyle.FixedSingle;
            pb_camera1.Dock = DockStyle.Left;
            pb_camera1.Location = new Point(0, 0);
            pb_camera1.Name = "pb_camera1";
            pb_camera1.Size = new Size(373, 345);
            pb_camera1.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_camera1.TabIndex = 0;
            pb_camera1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // RealTime
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "RealTime";
            Size = new Size(1053, 525);
            Load += RealTime_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pb_camera2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_camera1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pb_camera2;
        private PictureBox pb_camera1;
        private Button btn_liveCamera;
        private TextBox txt_urlCamera;
        private Label lbl_date;
        private Label lbl_time;
        private System.Windows.Forms.Timer timer1;
    }
}
