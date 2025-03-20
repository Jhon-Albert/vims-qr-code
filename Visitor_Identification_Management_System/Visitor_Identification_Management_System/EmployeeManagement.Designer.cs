namespace Visitor_Identification_Management_System
{
    partial class EmployeeManagement
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            btn_clear = new Button();
            txt_employeeID = new TextBox();
            label5 = new Label();
            btn_delete = new Button();
            btn_update = new Button();
            btn_add = new Button();
            txt_employeePassword = new TextBox();
            txt_employeeEmail = new TextBox();
            txt_employeeName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label8 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            dgv_employeeManagement = new DataGridView();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_employeeManagement).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 60);
            label2.Name = "label2";
            label2.Size = new Size(146, 21);
            label2.TabIndex = 21;
            label2.Text = "Manage | Employee";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 15);
            label1.Name = "label1";
            label1.Size = new Size(373, 45);
            label1.TabIndex = 20;
            label1.Text = "Employee Management";
            // 
            // panel1
            // 
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(0, 0);
            panel1.TabIndex = 22;
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_clear);
            panel2.Controls.Add(txt_employeeID);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(btn_delete);
            panel2.Controls.Add(btn_update);
            panel2.Controls.Add(btn_add);
            panel2.Controls.Add(txt_employeePassword);
            panel2.Controls.Add(txt_employeeEmail);
            panel2.Controls.Add(txt_employeeName);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label8);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(698, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(355, 525);
            panel2.TabIndex = 23;
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
            btn_clear.Location = new Point(149, 475);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(77, 33);
            btn_clear.TabIndex = 86;
            btn_clear.Text = "CLEAR";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // txt_employeeID
            // 
            txt_employeeID.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txt_employeeID.Enabled = false;
            txt_employeeID.Font = new Font("Segoe UI", 12F);
            txt_employeeID.Location = new Point(69, 124);
            txt_employeeID.Name = "txt_employeeID";
            txt_employeeID.Size = new Size(232, 29);
            txt_employeeID.TabIndex = 71;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(69, 100);
            label5.Name = "label5";
            label5.Size = new Size(97, 21);
            label5.TabIndex = 70;
            label5.Text = "Employee ID";
            label5.Click += label5_Click;
            // 
            // btn_delete
            // 
            btn_delete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_delete.AutoSize = true;
            btn_delete.BackColor = Color.FromArgb(52, 152, 219);
            btn_delete.FlatAppearance.BorderSize = 0;
            btn_delete.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 76, 209);
            btn_delete.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 96, 228);
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.Font = new Font("Segoe UI", 12F);
            btn_delete.ForeColor = Color.White;
            btn_delete.Location = new Point(242, 436);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(77, 33);
            btn_delete.TabIndex = 69;
            btn_delete.Text = "DELETE";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_update
            // 
            btn_update.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_update.AutoSize = true;
            btn_update.BackColor = Color.FromArgb(52, 152, 219);
            btn_update.FlatAppearance.BorderSize = 0;
            btn_update.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 76, 209);
            btn_update.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 96, 228);
            btn_update.FlatStyle = FlatStyle.Flat;
            btn_update.Font = new Font("Segoe UI", 12F);
            btn_update.ForeColor = Color.White;
            btn_update.Location = new Point(149, 436);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(77, 33);
            btn_update.TabIndex = 68;
            btn_update.Text = "UPDATE";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // btn_add
            // 
            btn_add.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_add.AutoSize = true;
            btn_add.BackColor = Color.FromArgb(52, 152, 219);
            btn_add.FlatAppearance.BorderSize = 0;
            btn_add.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 76, 209);
            btn_add.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 96, 228);
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.Font = new Font("Segoe UI", 12F);
            btn_add.ForeColor = Color.White;
            btn_add.Location = new Point(58, 436);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(77, 33);
            btn_add.TabIndex = 67;
            btn_add.Text = "ADD";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // txt_employeePassword
            // 
            txt_employeePassword.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txt_employeePassword.Font = new Font("Segoe UI", 12F);
            txt_employeePassword.Location = new Point(69, 365);
            txt_employeePassword.Name = "txt_employeePassword";
            txt_employeePassword.Size = new Size(232, 29);
            txt_employeePassword.TabIndex = 62;
            // 
            // txt_employeeEmail
            // 
            txt_employeeEmail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txt_employeeEmail.Font = new Font("Segoe UI", 12F);
            txt_employeeEmail.Location = new Point(69, 279);
            txt_employeeEmail.Name = "txt_employeeEmail";
            txt_employeeEmail.Size = new Size(232, 29);
            txt_employeeEmail.TabIndex = 61;
            // 
            // txt_employeeName
            // 
            txt_employeeName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txt_employeeName.Font = new Font("Segoe UI", 12F);
            txt_employeeName.Location = new Point(69, 197);
            txt_employeeName.Name = "txt_employeeName";
            txt_employeeName.Size = new Size(232, 29);
            txt_employeeName.TabIndex = 60;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(69, 341);
            label4.Name = "label4";
            label4.Size = new Size(76, 21);
            label4.TabIndex = 59;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(69, 255);
            label3.Name = "label3";
            label3.Size = new Size(48, 21);
            label3.TabIndex = 58;
            label3.Text = "Email";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(69, 173);
            label8.Name = "label8";
            label8.Size = new Size(81, 21);
            label8.TabIndex = 57;
            label8.Text = "Full Name";
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(698, 100);
            panel3.TabIndex = 24;
            // 
            // panel4
            // 
            panel4.Controls.Add(dgv_employeeManagement);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 100);
            panel4.Name = "panel4";
            panel4.Size = new Size(698, 425);
            panel4.TabIndex = 25;
            // 
            // dgv_employeeManagement
            // 
            dgv_employeeManagement.AllowUserToAddRows = false;
            dgv_employeeManagement.AllowUserToDeleteRows = false;
            dgv_employeeManagement.AllowUserToResizeColumns = false;
            dgv_employeeManagement.AllowUserToResizeRows = false;
            dgv_employeeManagement.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgv_employeeManagement.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_employeeManagement.BackgroundColor = SystemColors.Info;
            dgv_employeeManagement.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_employeeManagement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_employeeManagement.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_employeeManagement.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_employeeManagement.Location = new Point(17, 37);
            dgv_employeeManagement.Name = "dgv_employeeManagement";
            dgv_employeeManagement.RowHeadersVisible = false;
            dgv_employeeManagement.Size = new Size(675, 370);
            dgv_employeeManagement.TabIndex = 16;
            dgv_employeeManagement.CellContentClick += dgv_employeeManagement_CellContentClick;
            // 
            // EmployeeManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "EmployeeManagement";
            Size = new Size(1053, 525);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_employeeManagement).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private DataGridView dgv_employeeManagement;
        private Label label3;
        private Label label8;
        private Label label4;
        private TextBox txt_employeePassword;
        private TextBox txt_employeeEmail;
        private TextBox txt_employeeName;
        private TextBox txt_employeeID;
        private Label label5;
        private Button btn_delete;
        private Button btn_update;
        private Button btn_add;
        private Button btn_clear;
    }
}
