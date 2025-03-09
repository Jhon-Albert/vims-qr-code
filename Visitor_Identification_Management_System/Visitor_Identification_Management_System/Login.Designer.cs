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
            txt_Email = new TextBox();
            rbtn_Employee = new RadioButton();
            btn_Login = new Button();
            rbtn_Admin = new RadioButton();
            txt_Password = new TextBox();
            cb_Pass = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txt_Email
            // 
            txt_Email.Anchor = AnchorStyles.None;
            txt_Email.Font = new Font("Segoe UI", 12F);
            txt_Email.Location = new Point(418, 188);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(232, 29);
            txt_Email.TabIndex = 11;
            // 
            // rbtn_Employee
            // 
            rbtn_Employee.Anchor = AnchorStyles.None;
            rbtn_Employee.AutoSize = true;
            rbtn_Employee.BackColor = SystemColors.Control;
            rbtn_Employee.FlatStyle = FlatStyle.System;
            rbtn_Employee.Font = new Font("Segoe UI", 12F);
            rbtn_Employee.ImageAlign = ContentAlignment.MiddleLeft;
            rbtn_Employee.Location = new Point(429, 128);
            rbtn_Employee.Name = "rbtn_Employee";
            rbtn_Employee.Size = new Size(102, 26);
            rbtn_Employee.TabIndex = 15;
            rbtn_Employee.TabStop = true;
            rbtn_Employee.Text = "Employee";
            rbtn_Employee.UseVisualStyleBackColor = false;
            // 
            // btn_Login
            // 
            btn_Login.Anchor = AnchorStyles.None;
            btn_Login.AutoSize = true;
            btn_Login.FlatAppearance.BorderSize = 0;
            btn_Login.FlatAppearance.MouseDownBackColor = SystemColors.GradientActiveCaption;
            btn_Login.FlatAppearance.MouseOverBackColor = SystemColors.GradientActiveCaption;
            btn_Login.Font = new Font("Segoe UI", 12F);
            btn_Login.Location = new Point(496, 335);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(75, 33);
            btn_Login.TabIndex = 16;
            btn_Login.Text = "Login";
            btn_Login.Click += btn_Login_Click;
            // 
            // rbtn_Admin
            // 
            rbtn_Admin.Anchor = AnchorStyles.None;
            rbtn_Admin.AutoSize = true;
            rbtn_Admin.FlatStyle = FlatStyle.System;
            rbtn_Admin.Font = new Font("Segoe UI", 12F);
            rbtn_Admin.Location = new Point(556, 128);
            rbtn_Admin.Name = "rbtn_Admin";
            rbtn_Admin.Size = new Size(80, 26);
            rbtn_Admin.TabIndex = 16;
            rbtn_Admin.TabStop = true;
            rbtn_Admin.Text = "Admin";
            rbtn_Admin.UseVisualStyleBackColor = true;
            // 
            // txt_Password
            // 
            txt_Password.Anchor = AnchorStyles.None;
            txt_Password.Font = new Font("Segoe UI", 12F);
            txt_Password.Location = new Point(418, 258);
            txt_Password.Name = "txt_Password";
            txt_Password.PasswordChar = '*';
            txt_Password.Size = new Size(232, 29);
            txt_Password.TabIndex = 12;
            // 
            // cb_Pass
            // 
            cb_Pass.Anchor = AnchorStyles.None;
            cb_Pass.AutoSize = true;
            cb_Pass.Font = new Font("Segoe UI", 12F);
            cb_Pass.Location = new Point(429, 293);
            cb_Pass.Name = "cb_Pass";
            cb_Pass.Size = new Size(138, 25);
            cb_Pass.TabIndex = 14;
            cb_Pass.Text = "Show Password";
            cb_Pass.UseVisualStyleBackColor = true;
            cb_Pass.CheckedChanged += cb_Pass_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(418, 164);
            label1.Name = "label1";
            label1.Size = new Size(48, 21);
            label1.TabIndex = 17;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(418, 234);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 18;
            label2.Text = "Password";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 508);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_Email);
            Controls.Add(rbtn_Employee);
            Controls.Add(btn_Login);
            Controls.Add(rbtn_Admin);
            Controls.Add(txt_Password);
            Controls.Add(cb_Pass);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Email;
        private RadioButton rbtn_Employee;
        private Button btn_Login;
        private RadioButton rbtn_Admin;
        private TextBox txt_Password;
        private CheckBox cb_Pass;
        private Label label1;
        private Label label2;
    }
}
