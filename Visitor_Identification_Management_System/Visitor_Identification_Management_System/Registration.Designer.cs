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
            panel1 = new Panel();
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
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(btn_register);
            panel1.Controls.Add(cmb_purpose);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txt_lastName);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txt_contactNumber);
            panel1.Controls.Add(txt_address);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txt_firstName);
            panel1.Controls.Add(txt_email);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1088, 508);
            panel1.TabIndex = 0;
            // 
            // btn_register
            // 
            btn_register.Anchor = AnchorStyles.None;
            btn_register.AutoSize = true;
            btn_register.FlatAppearance.BorderSize = 0;
            btn_register.FlatAppearance.MouseDownBackColor = SystemColors.GradientActiveCaption;
            btn_register.FlatAppearance.MouseOverBackColor = SystemColors.GradientActiveCaption;
            btn_register.Font = new Font("Segoe UI", 12F);
            btn_register.Location = new Point(521, 396);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(77, 33);
            btn_register.TabIndex = 54;
            btn_register.Text = "Register";
            btn_register.Click += btn_register_Click;
            // 
            // cmb_purpose
            // 
            cmb_purpose.Anchor = AnchorStyles.None;
            cmb_purpose.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmb_purpose.FormattingEnabled = true;
            cmb_purpose.Location = new Point(604, 183);
            cmb_purpose.Name = "cmb_purpose";
            cmb_purpose.Size = new Size(232, 29);
            cmb_purpose.TabIndex = 53;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(604, 159);
            label6.Name = "label6";
            label6.Size = new Size(119, 21);
            label6.TabIndex = 52;
            label6.Text = "Purpose of Visit";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(604, 89);
            label7.Name = "label7";
            label7.Size = new Size(84, 21);
            label7.TabIndex = 51;
            label7.Text = "Last Name";
            // 
            // txt_lastName
            // 
            txt_lastName.Anchor = AnchorStyles.None;
            txt_lastName.Font = new Font("Segoe UI", 12F);
            txt_lastName.Location = new Point(604, 113);
            txt_lastName.Name = "txt_lastName";
            txt_lastName.Size = new Size(232, 29);
            txt_lastName.TabIndex = 49;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(604, 232);
            label4.Name = "label4";
            label4.Size = new Size(66, 21);
            label4.TabIndex = 48;
            label4.Text = "Address";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(271, 232);
            label5.Name = "label5";
            label5.Size = new Size(125, 21);
            label5.TabIndex = 47;
            label5.Text = "Contact Number";
            // 
            // txt_contactNumber
            // 
            txt_contactNumber.Anchor = AnchorStyles.None;
            txt_contactNumber.Font = new Font("Segoe UI", 12F);
            txt_contactNumber.Location = new Point(271, 256);
            txt_contactNumber.Name = "txt_contactNumber";
            txt_contactNumber.Size = new Size(232, 29);
            txt_contactNumber.TabIndex = 45;
            // 
            // txt_address
            // 
            txt_address.Anchor = AnchorStyles.None;
            txt_address.Font = new Font("Segoe UI", 12F);
            txt_address.Location = new Point(604, 256);
            txt_address.Multiline = true;
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(232, 134);
            txt_address.TabIndex = 46;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(391, 9);
            label3.Name = "label3";
            label3.Size = new Size(335, 45);
            label3.TabIndex = 44;
            label3.Text = "VISIT REGISTRATION";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(271, 159);
            label2.Name = "label2";
            label2.Size = new Size(48, 21);
            label2.TabIndex = 43;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(271, 89);
            label1.Name = "label1";
            label1.Size = new Size(86, 21);
            label1.TabIndex = 42;
            label1.Text = "First Name";
            // 
            // txt_firstName
            // 
            txt_firstName.Anchor = AnchorStyles.None;
            txt_firstName.Font = new Font("Segoe UI", 12F);
            txt_firstName.Location = new Point(271, 113);
            txt_firstName.Name = "txt_firstName";
            txt_firstName.Size = new Size(232, 29);
            txt_firstName.TabIndex = 40;
            // 
            // txt_email
            // 
            txt_email.Anchor = AnchorStyles.None;
            txt_email.Font = new Font("Segoe UI", 12F);
            txt_email.Location = new Point(271, 183);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(232, 29);
            txt_email.TabIndex = 41;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 508);
            Controls.Add(panel1);
            Name = "Registration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration Form";
            Load += Registration_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
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
    }
}