namespace Visitor_Identification_Management_System
{
    partial class ScanQR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScanQR));
            btn_back = new Button();
            cmb_camera = new ComboBox();
            btn_camera = new Button();
            pb_scan = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            gb_visitor_information = new GroupBox();
            pb_profilePic = new PictureBox();
            btn_clear = new Button();
            btn_checkOut = new Button();
            btn_confirm = new Button();
            txt_lastName = new TextBox();
            label4 = new Label();
            txt_purpose = new TextBox();
            txt_address = new TextBox();
            txt_contactNumber = new TextBox();
            txt_email = new TextBox();
            txt_firstName = new TextBox();
            txt_visitorID = new TextBox();
            label9 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label5 = new Label();
            label3 = new Label();
            lbl_date = new Label();
            lbl_time = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            btn_refreshCamera = new Button();
            panel2 = new Panel();
            btn_minimize = new Button();
            btn_close = new Button();
            ((System.ComponentModel.ISupportInitialize)pb_scan).BeginInit();
            gb_visitor_information.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_profilePic).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btn_back
            // 
            btn_back.AutoSize = true;
            btn_back.BackColor = Color.FromArgb(52, 152, 219);
            btn_back.FlatAppearance.BorderSize = 0;
            btn_back.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 76, 209);
            btn_back.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 96, 228);
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_back.ForeColor = SystemColors.Control;
            btn_back.Location = new Point(86, 426);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(89, 33);
            btn_back.TabIndex = 48;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // cmb_camera
            // 
            cmb_camera.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmb_camera.FormattingEnabled = true;
            cmb_camera.Location = new Point(21, 122);
            cmb_camera.Name = "cmb_camera";
            cmb_camera.Size = new Size(232, 29);
            cmb_camera.TabIndex = 35;
            // 
            // btn_camera
            // 
            btn_camera.AutoSize = true;
            btn_camera.BackColor = Color.FromArgb(52, 152, 219);
            btn_camera.FlatAppearance.BorderSize = 0;
            btn_camera.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 76, 209);
            btn_camera.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 96, 228);
            btn_camera.FlatStyle = FlatStyle.Flat;
            btn_camera.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_camera.ForeColor = SystemColors.Control;
            btn_camera.Location = new Point(71, 388);
            btn_camera.Name = "btn_camera";
            btn_camera.Size = new Size(118, 33);
            btn_camera.TabIndex = 33;
            btn_camera.Text = "Open Camera";
            btn_camera.UseVisualStyleBackColor = false;
            btn_camera.Click += btn_camera_Click;
            // 
            // pb_scan
            // 
            pb_scan.BorderStyle = BorderStyle.FixedSingle;
            pb_scan.Location = new Point(21, 192);
            pb_scan.Name = "pb_scan";
            pb_scan.Size = new Size(232, 190);
            pb_scan.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_scan.TabIndex = 32;
            pb_scan.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 79);
            label2.Name = "label2";
            label2.Size = new Size(134, 21);
            label2.TabIndex = 31;
            label2.Text = "Manage | Scanner";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 34);
            label1.Name = "label1";
            label1.Size = new Size(229, 45);
            label1.TabIndex = 30;
            label1.Text = "Scan QR Code";
            // 
            // gb_visitor_information
            // 
            gb_visitor_information.Controls.Add(pb_profilePic);
            gb_visitor_information.Controls.Add(btn_clear);
            gb_visitor_information.Controls.Add(btn_checkOut);
            gb_visitor_information.Controls.Add(btn_confirm);
            gb_visitor_information.Controls.Add(txt_lastName);
            gb_visitor_information.Controls.Add(label4);
            gb_visitor_information.Controls.Add(txt_purpose);
            gb_visitor_information.Controls.Add(txt_address);
            gb_visitor_information.Controls.Add(txt_contactNumber);
            gb_visitor_information.Controls.Add(txt_email);
            gb_visitor_information.Controls.Add(txt_firstName);
            gb_visitor_information.Controls.Add(txt_visitorID);
            gb_visitor_information.Controls.Add(label9);
            gb_visitor_information.Controls.Add(label6);
            gb_visitor_information.Controls.Add(label7);
            gb_visitor_information.Controls.Add(label8);
            gb_visitor_information.Controls.Add(label5);
            gb_visitor_information.Controls.Add(label3);
            gb_visitor_information.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gb_visitor_information.Location = new Point(279, 92);
            gb_visitor_information.Name = "gb_visitor_information";
            gb_visitor_information.Size = new Size(565, 365);
            gb_visitor_information.TabIndex = 49;
            gb_visitor_information.TabStop = false;
            gb_visitor_information.Text = "VISITOR INFORMATION";
            // 
            // pb_profilePic
            // 
            pb_profilePic.BorderStyle = BorderStyle.FixedSingle;
            pb_profilePic.Image = (Image)resources.GetObject("pb_profilePic.Image");
            pb_profilePic.Location = new Point(359, 34);
            pb_profilePic.Name = "pb_profilePic";
            pb_profilePic.Size = new Size(200, 200);
            pb_profilePic.SizeMode = PictureBoxSizeMode.Zoom;
            pb_profilePic.TabIndex = 87;
            pb_profilePic.TabStop = false;
            // 
            // btn_clear
            // 
            btn_clear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_clear.AutoSize = true;
            btn_clear.BackColor = Color.FromArgb(52, 152, 219);
            btn_clear.FlatAppearance.BorderSize = 0;
            btn_clear.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 76, 209);
            btn_clear.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 96, 228);
            btn_clear.FlatStyle = FlatStyle.Flat;
            btn_clear.Font = new Font("Segoe UI", 12F);
            btn_clear.ForeColor = Color.White;
            btn_clear.Location = new Point(403, 318);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(103, 33);
            btn_clear.TabIndex = 86;
            btn_clear.Text = "CLEAR";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_checkOut
            // 
            btn_checkOut.AutoSize = true;
            btn_checkOut.BackColor = Color.FromArgb(52, 152, 219);
            btn_checkOut.FlatAppearance.BorderSize = 0;
            btn_checkOut.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 76, 209);
            btn_checkOut.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 96, 228);
            btn_checkOut.FlatStyle = FlatStyle.Flat;
            btn_checkOut.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_checkOut.ForeColor = SystemColors.Control;
            btn_checkOut.Location = new Point(403, 279);
            btn_checkOut.Name = "btn_checkOut";
            btn_checkOut.Size = new Size(103, 33);
            btn_checkOut.TabIndex = 71;
            btn_checkOut.Text = "CHECK OUT";
            btn_checkOut.UseVisualStyleBackColor = false;
            btn_checkOut.Click += btn_checkOut_Click;
            // 
            // btn_confirm
            // 
            btn_confirm.AutoSize = true;
            btn_confirm.BackColor = Color.FromArgb(52, 152, 219);
            btn_confirm.FlatAppearance.BorderSize = 0;
            btn_confirm.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 76, 209);
            btn_confirm.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 96, 228);
            btn_confirm.FlatStyle = FlatStyle.Flat;
            btn_confirm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_confirm.ForeColor = SystemColors.Control;
            btn_confirm.Location = new Point(403, 240);
            btn_confirm.Name = "btn_confirm";
            btn_confirm.Size = new Size(103, 33);
            btn_confirm.TabIndex = 70;
            btn_confirm.Text = "CHECK IN";
            btn_confirm.UseVisualStyleBackColor = false;
            btn_confirm.Click += btn_confirm_Click;
            // 
            // txt_lastName
            // 
            txt_lastName.Font = new Font("Segoe UI", 12F);
            txt_lastName.Location = new Point(133, 112);
            txt_lastName.Name = "txt_lastName";
            txt_lastName.Size = new Size(218, 29);
            txt_lastName.TabIndex = 69;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(45, 116);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 68;
            label4.Text = "Last Name:";
            // 
            // txt_purpose
            // 
            txt_purpose.Font = new Font("Segoe UI", 12F);
            txt_purpose.Location = new Point(133, 322);
            txt_purpose.Name = "txt_purpose";
            txt_purpose.Size = new Size(218, 29);
            txt_purpose.TabIndex = 67;
            // 
            // txt_address
            // 
            txt_address.Font = new Font("Segoe UI", 12F);
            txt_address.Location = new Point(133, 217);
            txt_address.Multiline = true;
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(218, 99);
            txt_address.TabIndex = 66;
            // 
            // txt_contactNumber
            // 
            txt_contactNumber.Font = new Font("Segoe UI", 12F);
            txt_contactNumber.Location = new Point(133, 182);
            txt_contactNumber.Name = "txt_contactNumber";
            txt_contactNumber.Size = new Size(218, 29);
            txt_contactNumber.TabIndex = 65;
            // 
            // txt_email
            // 
            txt_email.Font = new Font("Segoe UI", 12F);
            txt_email.Location = new Point(133, 147);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(218, 29);
            txt_email.TabIndex = 64;
            // 
            // txt_firstName
            // 
            txt_firstName.Font = new Font("Segoe UI", 12F);
            txt_firstName.Location = new Point(133, 78);
            txt_firstName.Name = "txt_firstName";
            txt_firstName.Size = new Size(218, 29);
            txt_firstName.TabIndex = 62;
            // 
            // txt_visitorID
            // 
            txt_visitorID.Font = new Font("Segoe UI", 12F);
            txt_visitorID.Location = new Point(133, 43);
            txt_visitorID.Name = "txt_visitorID";
            txt_visitorID.Size = new Size(218, 29);
            txt_visitorID.TabIndex = 61;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(54, 47);
            label9.Name = "label9";
            label9.Size = new Size(73, 20);
            label9.TabIndex = 60;
            label9.Text = "Visitor ID:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 326);
            label6.Name = "label6";
            label6.Size = new Size(115, 20);
            label6.TabIndex = 58;
            label6.Text = "Purpose of Visit:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(6, 186);
            label7.Name = "label7";
            label7.Size = new Size(121, 20);
            label7.TabIndex = 56;
            label7.Text = "Contact Number:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(62, 221);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 54;
            label8.Text = "Address:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(78, 151);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 52;
            label5.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(44, 82);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 48;
            label3.Text = "First Name:";
            // 
            // lbl_date
            // 
            lbl_date.AutoSize = true;
            lbl_date.Font = new Font("Segoe UI", 12F);
            lbl_date.Location = new Point(565, 53);
            lbl_date.Name = "lbl_date";
            lbl_date.Size = new Size(46, 21);
            lbl_date.TabIndex = 50;
            lbl_date.Text = "DATE";
            // 
            // lbl_time
            // 
            lbl_time.AutoSize = true;
            lbl_time.Font = new Font("Segoe UI", 12F);
            lbl_time.Location = new Point(655, 79);
            lbl_time.Name = "lbl_time";
            lbl_time.Size = new Size(44, 21);
            lbl_time.TabIndex = 51;
            lbl_time.Text = "TIME";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // btn_refreshCamera
            // 
            btn_refreshCamera.AutoSize = true;
            btn_refreshCamera.BackColor = Color.FromArgb(52, 152, 219);
            btn_refreshCamera.FlatAppearance.BorderSize = 0;
            btn_refreshCamera.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 76, 209);
            btn_refreshCamera.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 96, 228);
            btn_refreshCamera.FlatStyle = FlatStyle.Flat;
            btn_refreshCamera.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_refreshCamera.ForeColor = SystemColors.Control;
            btn_refreshCamera.Location = new Point(71, 153);
            btn_refreshCamera.Name = "btn_refreshCamera";
            btn_refreshCamera.Size = new Size(131, 33);
            btn_refreshCamera.TabIndex = 52;
            btn_refreshCamera.Text = "Refresh Camera";
            btn_refreshCamera.UseVisualStyleBackColor = false;
            btn_refreshCamera.Click += btn_refreshCamera_Click;
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
            panel2.TabIndex = 53;
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
            // ScanQR
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(147, 197, 253);
            ClientSize = new Size(960, 540);
            Controls.Add(panel2);
            Controls.Add(btn_refreshCamera);
            Controls.Add(lbl_time);
            Controls.Add(lbl_date);
            Controls.Add(gb_visitor_information);
            Controls.Add(btn_back);
            Controls.Add(cmb_camera);
            Controls.Add(btn_camera);
            Controls.Add(pb_scan);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ScanQR";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ScanQR";
            FormClosing += ScanQR_FormClosing;
            Load += ScanQR_Load;
            ((System.ComponentModel.ISupportInitialize)pb_scan).EndInit();
            gb_visitor_information.ResumeLayout(false);
            gb_visitor_information.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_profilePic).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_back;
        private ComboBox cmb_camera;
        private Button btn_camera;
        private PictureBox pb_scan;
        private Label label2;
        private Label label1;
        private GroupBox gb_visitor_information;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label5;
        private Label label3;
        private Label lbl_date;
        private Label lbl_time;
        private System.Windows.Forms.Timer timer1;
        private TextBox txt_visitorID;
        private Label label9;
        private TextBox txt_purpose;
        private TextBox txt_address;
        private TextBox txt_contactNumber;
        private TextBox txt_email;
        private TextBox txt_firstName;
        private TextBox txt_lastName;
        private Label label4;
        private Button btn_confirm;
        private Button btn_checkOut;
        private Button btn_refreshCamera;
        private Panel panel2;
        private Button btn_minimize;
        private Button btn_close;
        private Button btn_clear;
        private PictureBox pb_profilePic;
    }
}