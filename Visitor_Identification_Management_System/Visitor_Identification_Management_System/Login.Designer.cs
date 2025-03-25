namespace Visitor_Identification_Management_System
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            label3 = new Label();
            rbtn_Admin = new RadioButton();
            cb_Pass = new CheckBox();
            label2 = new Label();
            txt_Password = new TextBox();
            label1 = new Label();
            btn_Login = new Button();
            txt_Email = new TextBox();
            rbtn_Employee = new RadioButton();
            panel2 = new Panel();
            label4 = new Label();
            btn_minimize = new Button();
            btn_close = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(382, 72);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(136, 136);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 32;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(147, 197, 253);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(rbtn_Admin);
            panel1.Controls.Add(cb_Pass);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txt_Password);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_Login);
            panel1.Controls.Add(txt_Email);
            panel1.Controls.Add(rbtn_Employee);
            panel1.Location = new Point(205, 214);
            panel1.Name = "panel1";
            panel1.Size = new Size(491, 315);
            panel1.TabIndex = 31;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(218, 19);
            label3.Name = "label3";
            label3.Size = new Size(76, 30);
            label3.TabIndex = 31;
            label3.Text = "Log In";
            // 
            // rbtn_Admin
            // 
            rbtn_Admin.Anchor = AnchorStyles.None;
            rbtn_Admin.AutoSize = true;
            rbtn_Admin.FlatStyle = FlatStyle.System;
            rbtn_Admin.Font = new Font("Segoe UI", 12F);
            rbtn_Admin.ForeColor = SystemColors.ControlText;
            rbtn_Admin.Location = new Point(279, 52);
            rbtn_Admin.Name = "rbtn_Admin";
            rbtn_Admin.Size = new Size(80, 26);
            rbtn_Admin.TabIndex = 27;
            rbtn_Admin.TabStop = true;
            rbtn_Admin.Text = "Admin";
            rbtn_Admin.UseVisualStyleBackColor = true;
            // 
            // cb_Pass
            // 
            cb_Pass.Anchor = AnchorStyles.None;
            cb_Pass.AutoSize = true;
            cb_Pass.FlatStyle = FlatStyle.System;
            cb_Pass.Font = new Font("Segoe UI", 12F);
            cb_Pass.ForeColor = SystemColors.ControlText;
            cb_Pass.Location = new Point(152, 217);
            cb_Pass.Name = "cb_Pass";
            cb_Pass.Size = new Size(144, 26);
            cb_Pass.TabIndex = 24;
            cb_Pass.Text = "Show Password";
            cb_Pass.UseVisualStyleBackColor = true;
            cb_Pass.CheckedChanged += cb_Pass_CheckedChanged_1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(141, 158);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 29;
            label2.Text = "Password";
            // 
            // txt_Password
            // 
            txt_Password.Anchor = AnchorStyles.None;
            txt_Password.Font = new Font("Segoe UI", 12F);
            txt_Password.Location = new Point(141, 182);
            txt_Password.Name = "txt_Password";
            txt_Password.PasswordChar = '*';
            txt_Password.Size = new Size(232, 29);
            txt_Password.TabIndex = 23;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(141, 88);
            label1.Name = "label1";
            label1.Size = new Size(48, 21);
            label1.TabIndex = 28;
            label1.Text = "Email";
            // 
            // btn_Login
            // 
            btn_Login.Anchor = AnchorStyles.None;
            btn_Login.AutoSize = true;
            btn_Login.BackColor = Color.FromArgb(52, 152, 219);
            btn_Login.FlatAppearance.BorderSize = 0;
            btn_Login.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 76, 209);
            btn_Login.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 96, 228);
            btn_Login.FlatStyle = FlatStyle.Flat;
            btn_Login.Font = new Font("Segoe UI", 12F);
            btn_Login.ForeColor = Color.White;
            btn_Login.Location = new Point(219, 259);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(75, 33);
            btn_Login.TabIndex = 26;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += btn_Login_Click_1;
            // 
            // txt_Email
            // 
            txt_Email.Anchor = AnchorStyles.None;
            txt_Email.Font = new Font("Segoe UI", 12F);
            txt_Email.Location = new Point(141, 112);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(232, 29);
            txt_Email.TabIndex = 22;
            // 
            // rbtn_Employee
            // 
            rbtn_Employee.Anchor = AnchorStyles.None;
            rbtn_Employee.AutoSize = true;
            rbtn_Employee.BackColor = SystemColors.Control;
            rbtn_Employee.FlatStyle = FlatStyle.System;
            rbtn_Employee.Font = new Font("Segoe UI", 12F);
            rbtn_Employee.ForeColor = SystemColors.ControlText;
            rbtn_Employee.ImageAlign = ContentAlignment.MiddleLeft;
            rbtn_Employee.Location = new Point(152, 52);
            rbtn_Employee.Name = "rbtn_Employee";
            rbtn_Employee.Size = new Size(102, 26);
            rbtn_Employee.TabIndex = 25;
            rbtn_Employee.TabStop = true;
            rbtn_Employee.Text = "Employee";
            rbtn_Employee.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(191, 219, 254);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btn_minimize);
            panel2.Controls.Add(btn_close);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(900, 31);
            panel2.TabIndex = 33;
            panel2.MouseDown += panel2_MouseDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 3);
            label4.Name = "label4";
            label4.Size = new Size(373, 21);
            label4.TabIndex = 37;
            label4.Text = "VISITOR IDENTIFICATION MANAGEMENT SYSTEM";
            // 
            // btn_minimize
            // 
            btn_minimize.Dock = DockStyle.Right;
            btn_minimize.FlatAppearance.BorderSize = 0;
            btn_minimize.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 76, 209);
            btn_minimize.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 96, 228);
            btn_minimize.FlatStyle = FlatStyle.Flat;
            btn_minimize.Image = (Image)resources.GetObject("btn_minimize.Image");
            btn_minimize.Location = new Point(818, 0);
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
            btn_close.Location = new Point(859, 0);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(41, 31);
            btn_close.TabIndex = 34;
            btn_close.UseVisualStyleBackColor = true;
            btn_close.Click += btn_close_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(96, 165, 250);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(900, 600);
            Controls.Add(panel2);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label label3;
        private RadioButton rbtn_Admin;
        private CheckBox cb_Pass;
        private Label label2;
        private TextBox txt_Password;
        private Label label1;
        private Button btn_Login;
        private TextBox txt_Email;
        private RadioButton rbtn_Employee;
        private Panel panel2;
        private Button btn_minimize;
        private Button btn_close;
        private Label label4;
    }
}
