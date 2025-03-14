namespace Visitor_Identification_Management_System
{
    partial class VisitorManagement
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel3 = new Panel();
            panel5 = new Panel();
            dgv_visitorManagement = new DataGridView();
            panel2 = new Panel();
            panel4 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            txt_purpose = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txt_contactNumber = new TextBox();
            txt_firstName = new TextBox();
            label9 = new Label();
            txt_visitorID = new TextBox();
            btn_delete = new Button();
            btn_update = new Button();
            btn_add = new Button();
            label7 = new Label();
            txt_lastName = new TextBox();
            label4 = new Label();
            txt_address = new TextBox();
            label3 = new Label();
            label8 = new Label();
            txt_email = new TextBox();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_visitorManagement).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(panel1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1053, 525);
            panel3.TabIndex = 24;
            // 
            // panel5
            // 
            panel5.Controls.Add(dgv_visitorManagement);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 100);
            panel5.Name = "panel5";
            panel5.Size = new Size(745, 425);
            panel5.TabIndex = 2;
            // 
            // dgv_visitorManagement
            // 
            dgv_visitorManagement.AllowUserToAddRows = false;
            dgv_visitorManagement.AllowUserToDeleteRows = false;
            dgv_visitorManagement.AllowUserToResizeColumns = false;
            dgv_visitorManagement.AllowUserToResizeRows = false;
            dgv_visitorManagement.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_visitorManagement.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_visitorManagement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_visitorManagement.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_visitorManagement.Location = new Point(43, 47);
            dgv_visitorManagement.Name = "dgv_visitorManagement";
            dgv_visitorManagement.RowHeadersVisible = false;
            dgv_visitorManagement.Size = new Size(602, 321);
            dgv_visitorManagement.TabIndex = 15;
            dgv_visitorManagement.CellContentClick += dgv_visitorManagement_CellContentClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(745, 100);
            panel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(745, 100);
            panel4.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 60);
            label2.Name = "label2";
            label2.Size = new Size(123, 21);
            label2.TabIndex = 21;
            label2.Text = "Manage | Visitor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 15);
            label1.Name = "label1";
            label1.Size = new Size(325, 45);
            label1.TabIndex = 20;
            label1.Text = "Visitor Management";
            // 
            // panel1
            // 
            panel1.Controls.Add(txt_purpose);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txt_contactNumber);
            panel1.Controls.Add(txt_firstName);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txt_visitorID);
            panel1.Controls.Add(btn_delete);
            panel1.Controls.Add(btn_update);
            panel1.Controls.Add(btn_add);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txt_lastName);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txt_address);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txt_email);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(745, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(308, 525);
            panel1.TabIndex = 0;
            // 
            // txt_purpose
            // 
            txt_purpose.Anchor = AnchorStyles.None;
            txt_purpose.Font = new Font("Segoe UI", 12F);
            txt_purpose.Location = new Point(35, 326);
            txt_purpose.Name = "txt_purpose";
            txt_purpose.Size = new Size(232, 29);
            txt_purpose.TabIndex = 76;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(35, 302);
            label6.Name = "label6";
            label6.Size = new Size(119, 21);
            label6.TabIndex = 75;
            label6.Text = "Purpose of Visit";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(37, 246);
            label5.Name = "label5";
            label5.Size = new Size(125, 21);
            label5.TabIndex = 74;
            label5.Text = "Contact Number";
            // 
            // txt_contactNumber
            // 
            txt_contactNumber.Anchor = AnchorStyles.None;
            txt_contactNumber.Font = new Font("Segoe UI", 12F);
            txt_contactNumber.Location = new Point(37, 270);
            txt_contactNumber.Name = "txt_contactNumber";
            txt_contactNumber.Size = new Size(232, 29);
            txt_contactNumber.TabIndex = 73;
            // 
            // txt_firstName
            // 
            txt_firstName.Anchor = AnchorStyles.None;
            txt_firstName.Font = new Font("Segoe UI", 12F);
            txt_firstName.Location = new Point(35, 102);
            txt_firstName.Name = "txt_firstName";
            txt_firstName.Size = new Size(232, 29);
            txt_firstName.TabIndex = 72;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(35, 22);
            label9.Name = "label9";
            label9.Size = new Size(74, 21);
            label9.TabIndex = 71;
            label9.Text = "Visitor ID";
            // 
            // txt_visitorID
            // 
            txt_visitorID.Anchor = AnchorStyles.None;
            txt_visitorID.Font = new Font("Segoe UI", 12F);
            txt_visitorID.Location = new Point(35, 46);
            txt_visitorID.Name = "txt_visitorID";
            txt_visitorID.Size = new Size(232, 29);
            txt_visitorID.TabIndex = 70;
            // 
            // btn_delete
            // 
            btn_delete.Anchor = AnchorStyles.None;
            btn_delete.AutoSize = true;
            btn_delete.BackColor = Color.FromArgb(52, 152, 219);
            btn_delete.FlatAppearance.BorderSize = 0;
            btn_delete.FlatAppearance.MouseDownBackColor = SystemColors.GradientActiveCaption;
            btn_delete.FlatAppearance.MouseOverBackColor = SystemColors.GradientActiveCaption;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.Font = new Font("Segoe UI", 12F);
            btn_delete.ForeColor = Color.White;
            btn_delete.Location = new Point(210, 476);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(77, 33);
            btn_delete.TabIndex = 68;
            btn_delete.Text = "DELETE";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_update
            // 
            btn_update.Anchor = AnchorStyles.None;
            btn_update.AutoSize = true;
            btn_update.BackColor = Color.FromArgb(52, 152, 219);
            btn_update.FlatAppearance.BorderSize = 0;
            btn_update.FlatAppearance.MouseDownBackColor = SystemColors.GradientActiveCaption;
            btn_update.FlatAppearance.MouseOverBackColor = SystemColors.GradientActiveCaption;
            btn_update.FlatStyle = FlatStyle.Flat;
            btn_update.Font = new Font("Segoe UI", 12F);
            btn_update.ForeColor = Color.White;
            btn_update.Location = new Point(117, 476);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(77, 33);
            btn_update.TabIndex = 67;
            btn_update.Text = "UPDATE";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // btn_add
            // 
            btn_add.Anchor = AnchorStyles.None;
            btn_add.AutoSize = true;
            btn_add.BackColor = Color.FromArgb(52, 152, 219);
            btn_add.FlatAppearance.BorderSize = 0;
            btn_add.FlatAppearance.MouseDownBackColor = SystemColors.GradientActiveCaption;
            btn_add.FlatAppearance.MouseOverBackColor = SystemColors.GradientActiveCaption;
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.Font = new Font("Segoe UI", 12F);
            btn_add.ForeColor = Color.White;
            btn_add.Location = new Point(15, 476);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(77, 33);
            btn_add.TabIndex = 66;
            btn_add.Text = "ADD";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(37, 134);
            label7.Name = "label7";
            label7.Size = new Size(84, 21);
            label7.TabIndex = 63;
            label7.Text = "Last Name";
            // 
            // txt_lastName
            // 
            txt_lastName.Anchor = AnchorStyles.None;
            txt_lastName.Font = new Font("Segoe UI", 12F);
            txt_lastName.Location = new Point(37, 158);
            txt_lastName.Name = "txt_lastName";
            txt_lastName.Size = new Size(232, 29);
            txt_lastName.TabIndex = 62;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(35, 358);
            label4.Name = "label4";
            label4.Size = new Size(66, 21);
            label4.TabIndex = 61;
            label4.Text = "Address";
            // 
            // txt_address
            // 
            txt_address.Anchor = AnchorStyles.None;
            txt_address.Font = new Font("Segoe UI", 12F);
            txt_address.Location = new Point(35, 382);
            txt_address.Multiline = true;
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(232, 75);
            txt_address.TabIndex = 59;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(37, 190);
            label3.Name = "label3";
            label3.Size = new Size(48, 21);
            label3.TabIndex = 57;
            label3.Text = "Email";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(37, 78);
            label8.Name = "label8";
            label8.Size = new Size(86, 21);
            label8.TabIndex = 56;
            label8.Text = "First Name";
            label8.Click += label8_Click;
            // 
            // txt_email
            // 
            txt_email.Anchor = AnchorStyles.None;
            txt_email.Font = new Font("Segoe UI", 12F);
            txt_email.Location = new Point(37, 214);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(232, 29);
            txt_email.TabIndex = 55;
            // 
            // VisitorManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Name = "VisitorManagement";
            Size = new Size(1053, 525);
            Load += VisitorManagement_Load;
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_visitorManagement).EndInit();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private Panel panel2;
        private Panel panel4;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Panel panel5;
        private DataGridView dgv_visitorManagement;
        private Label label7;
        private TextBox txt_lastName;
        private Label label4;
        private TextBox txt_address;
        private Label label3;
        private Label label8;
        private TextBox txt_email;
        private Button btn_delete;
        private Button btn_update;
        private Button btn_add;
        private Label label9;
        private TextBox txt_visitorID;
        private TextBox txt_purpose;
        private Label label6;
        private Label label5;
        private TextBox txt_contactNumber;
        private TextBox txt_firstName;
    }
}
