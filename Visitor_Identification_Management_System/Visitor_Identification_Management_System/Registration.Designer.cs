namespace Visitor_Identification_Management_System
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            btn_register = new Button();
            cmb_purpose = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            txt_lastName = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txt_contactNumber = new TextBox();
            txt_address = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txt_firstName = new TextBox();
            txt_email = new TextBox();
            panel2 = new Panel();
            btn_minimize = new Button();
            btn_close = new Button();
            panel3 = new Panel();
            btn_upload = new Button();
            pb_uploadProfile = new PictureBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_uploadProfile).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_register
            // 
            btn_register.AutoSize = true;
            btn_register.BackColor = Color.FromArgb(52, 152, 219);
            btn_register.FlatAppearance.BorderSize = 0;
            btn_register.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 76, 209);
            btn_register.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 96, 228);
            btn_register.FlatStyle = FlatStyle.Flat;
            btn_register.Font = new Font("Segoe UI", 12F);
            btn_register.ForeColor = Color.White;
            btn_register.Location = new Point(281, 457);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(77, 33);
            btn_register.TabIndex = 54;
            btn_register.Text = "Register";
            btn_register.UseVisualStyleBackColor = false;
            btn_register.Click += btn_register_Click;
            // 
            // cmb_purpose
            // 
            cmb_purpose.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmb_purpose.FormattingEnabled = true;
            cmb_purpose.Location = new Point(337, 188);
            cmb_purpose.Name = "cmb_purpose";
            cmb_purpose.Size = new Size(232, 29);
            cmb_purpose.TabIndex = 53;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(337, 164);
            label6.Name = "label6";
            label6.Size = new Size(119, 21);
            label6.TabIndex = 52;
            label6.Text = "Purpose of Visit";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(337, 94);
            label7.Name = "label7";
            label7.Size = new Size(84, 21);
            label7.TabIndex = 51;
            label7.Text = "Last Name";
            // 
            // txt_lastName
            // 
            txt_lastName.Font = new Font("Segoe UI", 12F);
            txt_lastName.Location = new Point(337, 118);
            txt_lastName.Name = "txt_lastName";
            txt_lastName.Size = new Size(232, 29);
            txt_lastName.TabIndex = 49;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(76, 293);
            label4.Name = "label4";
            label4.Size = new Size(66, 21);
            label4.TabIndex = 48;
            label4.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(76, 237);
            label5.Name = "label5";
            label5.Size = new Size(125, 21);
            label5.TabIndex = 47;
            label5.Text = "Contact Number";
            // 
            // txt_contactNumber
            // 
            txt_contactNumber.Font = new Font("Segoe UI", 12F);
            txt_contactNumber.Location = new Point(76, 261);
            txt_contactNumber.Name = "txt_contactNumber";
            txt_contactNumber.Size = new Size(232, 29);
            txt_contactNumber.TabIndex = 45;
            // 
            // txt_address
            // 
            txt_address.Font = new Font("Segoe UI", 12F);
            txt_address.Location = new Point(76, 317);
            txt_address.Multiline = true;
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(232, 134);
            txt_address.TabIndex = 46;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(136, 26);
            label3.Name = "label3";
            label3.Size = new Size(379, 45);
            label3.TabIndex = 44;
            label3.Text = "VISITOR REGISTRATION";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(76, 164);
            label2.Name = "label2";
            label2.Size = new Size(48, 21);
            label2.TabIndex = 43;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(76, 94);
            label1.Name = "label1";
            label1.Size = new Size(86, 21);
            label1.TabIndex = 42;
            label1.Text = "First Name";
            // 
            // txt_firstName
            // 
            txt_firstName.Font = new Font("Segoe UI", 12F);
            txt_firstName.Location = new Point(76, 118);
            txt_firstName.Name = "txt_firstName";
            txt_firstName.Size = new Size(232, 29);
            txt_firstName.TabIndex = 40;
            // 
            // txt_email
            // 
            txt_email.Font = new Font("Segoe UI", 12F);
            txt_email.Location = new Point(76, 188);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(232, 29);
            txt_email.TabIndex = 41;
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
            panel2.TabIndex = 55;
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
            // panel3
            // 
            panel3.Controls.Add(btn_upload);
            panel3.Controls.Add(pb_uploadProfile);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(txt_contactNumber);
            panel3.Controls.Add(txt_address);
            panel3.Controls.Add(btn_register);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(cmb_purpose);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(txt_email);
            panel3.Controls.Add(txt_lastName);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(txt_firstName);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(371, 31);
            panel3.Name = "panel3";
            panel3.Size = new Size(589, 509);
            panel3.TabIndex = 57;
            // 
            // btn_upload
            // 
            btn_upload.Location = new Point(426, 379);
            btn_upload.Name = "btn_upload";
            btn_upload.Size = new Size(75, 23);
            btn_upload.TabIndex = 56;
            btn_upload.Text = "Upload";
            btn_upload.UseVisualStyleBackColor = true;
            btn_upload.Click += btn_upload_Click;
            // 
            // pb_uploadProfile
            // 
            pb_uploadProfile.BorderStyle = BorderStyle.FixedSingle;
            pb_uploadProfile.Location = new Point(389, 223);
            pb_uploadProfile.Name = "pb_uploadProfile";
            pb_uploadProfile.Size = new Size(150, 150);
            pb_uploadProfile.SizeMode = PictureBoxSizeMode.Zoom;
            pb_uploadProfile.TabIndex = 55;
            pb_uploadProfile.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(371, 509);
            panel1.TabIndex = 58;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(371, 509);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(147, 197, 253);
            ClientSize = new Size(960, 540);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Registration";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Registration Form";
            Load += Registration_Load;
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_uploadProfile).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox cmb_purpose;
        private Label label6;
        private Label label7;
        private TextBox txt_lastName;
        private Label label4;
        private Label label5;
        private TextBox txt_contactNumber;
        private TextBox txt_address;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_firstName;
        private TextBox txt_email;
        private Button btn_register;
        private Panel panel2;
        private Button btn_minimize;
        private Button btn_close;
        private Panel panel3;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pb_uploadProfile;
        private Button btn_upload;
    }
}