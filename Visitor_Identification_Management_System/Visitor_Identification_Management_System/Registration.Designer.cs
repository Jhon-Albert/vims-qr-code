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
            btn_maximize = new Button();
            btn_close = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_register
            // 
            btn_register.Anchor = AnchorStyles.None;
            btn_register.AutoSize = true;
            btn_register.BackColor = Color.FromArgb(52, 152, 219);
            btn_register.FlatAppearance.BorderSize = 0;
            btn_register.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 76, 209);
            btn_register.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 96, 228);
            btn_register.FlatStyle = FlatStyle.Flat;
            btn_register.Font = new Font("Segoe UI", 12F);
            btn_register.ForeColor = Color.White;
            btn_register.Location = new Point(731, 446);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(77, 33);
            btn_register.TabIndex = 54;
            btn_register.Text = "Register";
            btn_register.UseVisualStyleBackColor = false;
            btn_register.Click += btn_register_Click;
            // 
            // cmb_purpose
            // 
            cmb_purpose.Anchor = AnchorStyles.None;
            cmb_purpose.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmb_purpose.FormattingEnabled = true;
            cmb_purpose.Location = new Point(771, 218);
            cmb_purpose.Name = "cmb_purpose";
            cmb_purpose.Size = new Size(232, 29);
            cmb_purpose.TabIndex = 53;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(771, 194);
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
            label7.Location = new Point(771, 124);
            label7.Name = "label7";
            label7.Size = new Size(84, 21);
            label7.TabIndex = 51;
            label7.Text = "Last Name";
            // 
            // txt_lastName
            // 
            txt_lastName.Anchor = AnchorStyles.None;
            txt_lastName.Font = new Font("Segoe UI", 12F);
            txt_lastName.Location = new Point(771, 148);
            txt_lastName.Name = "txt_lastName";
            txt_lastName.Size = new Size(232, 29);
            txt_lastName.TabIndex = 49;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(771, 267);
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
            label5.Location = new Point(510, 267);
            label5.Name = "label5";
            label5.Size = new Size(125, 21);
            label5.TabIndex = 47;
            label5.Text = "Contact Number";
            // 
            // txt_contactNumber
            // 
            txt_contactNumber.Anchor = AnchorStyles.None;
            txt_contactNumber.Font = new Font("Segoe UI", 12F);
            txt_contactNumber.Location = new Point(510, 291);
            txt_contactNumber.Name = "txt_contactNumber";
            txt_contactNumber.Size = new Size(232, 29);
            txt_contactNumber.TabIndex = 45;
            // 
            // txt_address
            // 
            txt_address.Anchor = AnchorStyles.None;
            txt_address.Font = new Font("Segoe UI", 12F);
            txt_address.Location = new Point(771, 291);
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
            label3.Location = new Point(585, 44);
            label3.Name = "label3";
            label3.Size = new Size(379, 45);
            label3.TabIndex = 44;
            label3.Text = "VISITOR REGISTRATION";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(510, 194);
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
            label1.Location = new Point(510, 124);
            label1.Name = "label1";
            label1.Size = new Size(86, 21);
            label1.TabIndex = 42;
            label1.Text = "First Name";
            // 
            // txt_firstName
            // 
            txt_firstName.Anchor = AnchorStyles.None;
            txt_firstName.Font = new Font("Segoe UI", 12F);
            txt_firstName.Location = new Point(510, 148);
            txt_firstName.Name = "txt_firstName";
            txt_firstName.Size = new Size(232, 29);
            txt_firstName.TabIndex = 40;
            // 
            // txt_email
            // 
            txt_email.Anchor = AnchorStyles.None;
            txt_email.Font = new Font("Segoe UI", 12F);
            txt_email.Location = new Point(510, 218);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(232, 29);
            txt_email.TabIndex = 41;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(191, 219, 254);
            panel2.Controls.Add(btn_minimize);
            panel2.Controls.Add(btn_maximize);
            panel2.Controls.Add(btn_close);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1046, 41);
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
            btn_minimize.Location = new Point(923, 0);
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
            btn_maximize.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 76, 209);
            btn_maximize.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 96, 228);
            btn_maximize.FlatStyle = FlatStyle.Flat;
            btn_maximize.ForeColor = SystemColors.ControlText;
            btn_maximize.Image = (Image)resources.GetObject("btn_maximize.Image");
            btn_maximize.Location = new Point(964, 0);
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
            btn_close.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 76, 209);
            btn_close.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 96, 228);
            btn_close.FlatStyle = FlatStyle.Flat;
            btn_close.Image = (Image)resources.GetObject("btn_close.Image");
            btn_close.Location = new Point(1005, 0);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(41, 41);
            btn_close.TabIndex = 34;
            btn_close.UseVisualStyleBackColor = true;
            btn_close.Click += btn_close_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(467, 460);
            panel1.TabIndex = 56;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(467, 460);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(147, 197, 253);
            ClientSize = new Size(1046, 501);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(btn_register);
            Controls.Add(cmb_purpose);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(txt_email);
            Controls.Add(label7);
            Controls.Add(txt_firstName);
            Controls.Add(txt_lastName);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(txt_address);
            Controls.Add(txt_contactNumber);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Registration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration Form";
            Load += Registration_Load;
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Button btn_maximize;
        private Button btn_close;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}