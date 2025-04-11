namespace Visitor_Identification_Management_System
{
    partial class AdminManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminManagement));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btn_refresh = new Button();
            dgv_adminManagement = new DataGridView();
            panel4 = new Panel();
            txt_searchAdmin = new TextBox();
            txt_fullName = new TextBox();
            label6 = new Label();
            btn_clear = new Button();
            txt_adminID = new TextBox();
            label5 = new Label();
            btn_delete = new Button();
            panel1 = new Panel();
            btn_update = new Button();
            btn_add = new Button();
            txt_adminPassword = new TextBox();
            txt_adminEmail = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgv_adminManagement).BeginInit();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btn_refresh
            // 
            btn_refresh.AutoSize = true;
            btn_refresh.BackColor = Color.FromArgb(52, 152, 219);
            btn_refresh.FlatAppearance.BorderSize = 0;
            btn_refresh.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 76, 209);
            btn_refresh.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 96, 228);
            btn_refresh.FlatStyle = FlatStyle.Flat;
            btn_refresh.Font = new Font("Segoe UI", 12F);
            btn_refresh.ForeColor = Color.White;
            btn_refresh.Image = (Image)resources.GetObject("btn_refresh.Image");
            btn_refresh.Location = new Point(227, 29);
            btn_refresh.Name = "btn_refresh";
            btn_refresh.Size = new Size(30, 30);
            btn_refresh.TabIndex = 72;
            btn_refresh.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_refresh.UseVisualStyleBackColor = false;
            btn_refresh.Click += btn_refresh_Click;
            // 
            // dgv_adminManagement
            // 
            dgv_adminManagement.AllowUserToAddRows = false;
            dgv_adminManagement.AllowUserToDeleteRows = false;
            dgv_adminManagement.AllowUserToResizeColumns = false;
            dgv_adminManagement.AllowUserToResizeRows = false;
            dgv_adminManagement.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgv_adminManagement.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_adminManagement.BackgroundColor = SystemColors.Info;
            dgv_adminManagement.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_adminManagement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_adminManagement.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_adminManagement.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_adminManagement.Location = new Point(17, 65);
            dgv_adminManagement.Name = "dgv_adminManagement";
            dgv_adminManagement.RowHeadersVisible = false;
            dgv_adminManagement.Size = new Size(776, 370);
            dgv_adminManagement.TabIndex = 16;
            dgv_adminManagement.CellContentClick += dgv_adminManagement_CellContentClick;
            // 
            // panel4
            // 
            panel4.Controls.Add(btn_refresh);
            panel4.Controls.Add(txt_searchAdmin);
            panel4.Controls.Add(dgv_adminManagement);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 100);
            panel4.Name = "panel4";
            panel4.Size = new Size(799, 542);
            panel4.TabIndex = 29;
            // 
            // txt_searchAdmin
            // 
            txt_searchAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_searchAdmin.Location = new Point(17, 30);
            txt_searchAdmin.Name = "txt_searchAdmin";
            txt_searchAdmin.PlaceholderText = "Search";
            txt_searchAdmin.Size = new Size(204, 29);
            txt_searchAdmin.TabIndex = 19;
            txt_searchAdmin.TextChanged += txt_searchAdmin_TextChanged;
            // 
            // txt_fullName
            // 
            txt_fullName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txt_fullName.Font = new Font("Segoe UI", 12F);
            txt_fullName.Location = new Point(25, 245);
            txt_fullName.Name = "txt_fullName";
            txt_fullName.Size = new Size(232, 29);
            txt_fullName.TabIndex = 88;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(25, 221);
            label6.Name = "label6";
            label6.Size = new Size(81, 21);
            label6.TabIndex = 87;
            label6.Text = "Full Name";
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
            btn_clear.Location = new Point(105, 502);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(77, 33);
            btn_clear.TabIndex = 86;
            btn_clear.Text = "CLEAR";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // txt_adminID
            // 
            txt_adminID.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txt_adminID.Enabled = false;
            txt_adminID.Font = new Font("Segoe UI", 12F);
            txt_adminID.Location = new Point(25, 189);
            txt_adminID.Name = "txt_adminID";
            txt_adminID.Size = new Size(232, 29);
            txt_adminID.TabIndex = 71;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(25, 165);
            label5.Name = "label5";
            label5.Size = new Size(75, 21);
            label5.TabIndex = 70;
            label5.Text = "Admin ID";
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
            btn_delete.Location = new Point(188, 450);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(77, 33);
            btn_delete.TabIndex = 69;
            btn_delete.Text = "DELETE";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // panel1
            // 
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(0, 0);
            panel1.TabIndex = 26;
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
            btn_update.Location = new Point(105, 450);
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
            btn_add.Location = new Point(22, 450);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(77, 33);
            btn_add.TabIndex = 67;
            btn_add.Text = "ADD";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // txt_adminPassword
            // 
            txt_adminPassword.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txt_adminPassword.Font = new Font("Segoe UI", 12F);
            txt_adminPassword.Location = new Point(25, 357);
            txt_adminPassword.Name = "txt_adminPassword";
            txt_adminPassword.Size = new Size(232, 29);
            txt_adminPassword.TabIndex = 62;
            // 
            // txt_adminEmail
            // 
            txt_adminEmail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txt_adminEmail.Font = new Font("Segoe UI", 12F);
            txt_adminEmail.Location = new Point(25, 301);
            txt_adminEmail.Name = "txt_adminEmail";
            txt_adminEmail.Size = new Size(232, 29);
            txt_adminEmail.TabIndex = 61;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(25, 333);
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
            label3.Location = new Point(25, 277);
            label3.Name = "label3";
            label3.Size = new Size(48, 21);
            label3.TabIndex = 58;
            label3.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 15);
            label1.Name = "label1";
            label1.Size = new Size(327, 45);
            label1.TabIndex = 20;
            label1.Text = "Admin Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 60);
            label2.Name = "label2";
            label2.Size = new Size(124, 21);
            label2.TabIndex = 21;
            label2.Text = "Manage | Admin";
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(799, 100);
            panel3.TabIndex = 28;
            // 
            // panel2
            // 
            panel2.Controls.Add(txt_fullName);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(btn_clear);
            panel2.Controls.Add(txt_adminID);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(btn_delete);
            panel2.Controls.Add(btn_update);
            panel2.Controls.Add(btn_add);
            panel2.Controls.Add(txt_adminPassword);
            panel2.Controls.Add(txt_adminEmail);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(799, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(281, 642);
            panel2.TabIndex = 27;
            // 
            // AdminManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "AdminManagement";
            Size = new Size(1080, 642);
            ((System.ComponentModel.ISupportInitialize)dgv_adminManagement).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_refresh;
        private DataGridView dgv_adminManagement;
        private Panel panel4;
        private TextBox txt_searchAdmin;
        private TextBox txt_employeeMiddleName;
        private Label label7;
        private TextBox txt_fullName;
        private Label label6;
        private Button btn_clear;
        private TextBox txt_adminID;
        private Label label5;
        private Button btn_delete;
        private Panel panel1;
        private Button btn_update;
        private Button btn_add;
        private TextBox txt_adminPassword;
        private TextBox txt_adminEmail;
        private TextBox txt_employeeLastName;
        private Label label4;
        private Label label3;
        private Label label8;
        private Label label1;
        private Label label2;
        private Panel panel3;
        private Panel panel2;
    }
}
