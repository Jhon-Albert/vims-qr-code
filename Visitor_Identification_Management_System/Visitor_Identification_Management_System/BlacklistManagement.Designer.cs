namespace Visitor_Identification_Management_System
{
    partial class BlacklistManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlacklistManagement));
            label2 = new Label();
            label1 = new Label();
            btn_clear = new Button();
            txt_dateAdded = new TextBox();
            btn_delete = new Button();
            btn_update = new Button();
            btn_add = new Button();
            label6 = new Label();
            label7 = new Label();
            txt_blacklistFirstname = new TextBox();
            label5 = new Label();
            txt_blacklistLastname = new TextBox();
            label3 = new Label();
            label8 = new Label();
            txt_blacklistID = new TextBox();
            txt_reason = new TextBox();
            txt_search_blacklist = new TextBox();
            dgv_blacklist = new DataGridView();
            panel1 = new Panel();
            panel2 = new Panel();
            txt_blacklistMiddleName = new TextBox();
            label4 = new Label();
            panel3 = new Panel();
            btn_refresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_blacklist).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 60);
            label2.Name = "label2";
            label2.Size = new Size(134, 21);
            label2.TabIndex = 23;
            label2.Text = "Manage | Blacklist";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 15);
            label1.Name = "label1";
            label1.Size = new Size(351, 45);
            label1.TabIndex = 22;
            label1.Text = "Blacklist Management";
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
            btn_clear.Location = new Point(102, 478);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(77, 33);
            btn_clear.TabIndex = 85;
            btn_clear.Text = "CLEAR";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // txt_dateAdded
            // 
            txt_dateAdded.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txt_dateAdded.Enabled = false;
            txt_dateAdded.Font = new Font("Segoe UI", 12F);
            txt_dateAdded.Location = new Point(30, 391);
            txt_dateAdded.Name = "txt_dateAdded";
            txt_dateAdded.Size = new Size(232, 29);
            txt_dateAdded.TabIndex = 84;
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
            btn_delete.Location = new Point(185, 439);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(77, 33);
            btn_delete.TabIndex = 83;
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
            btn_update.Location = new Point(102, 439);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(77, 33);
            btn_update.TabIndex = 82;
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
            btn_add.Location = new Point(19, 439);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(77, 33);
            btn_add.TabIndex = 81;
            btn_add.Text = "ADD";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(31, 367);
            label6.Name = "label6";
            label6.Size = new Size(91, 21);
            label6.TabIndex = 80;
            label6.Text = "Date Added";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(31, 86);
            label7.Name = "label7";
            label7.Size = new Size(86, 21);
            label7.TabIndex = 79;
            label7.Text = "First Name";
            // 
            // txt_blacklistFirstname
            // 
            txt_blacklistFirstname.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txt_blacklistFirstname.Font = new Font("Segoe UI", 12F);
            txt_blacklistFirstname.Location = new Point(30, 110);
            txt_blacklistFirstname.Name = "txt_blacklistFirstname";
            txt_blacklistFirstname.Size = new Size(232, 29);
            txt_blacklistFirstname.TabIndex = 78;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(31, 198);
            label5.Name = "label5";
            label5.Size = new Size(84, 21);
            label5.TabIndex = 76;
            label5.Text = "Last Name";
            // 
            // txt_blacklistLastname
            // 
            txt_blacklistLastname.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txt_blacklistLastname.Font = new Font("Segoe UI", 12F);
            txt_blacklistLastname.Location = new Point(30, 222);
            txt_blacklistLastname.Name = "txt_blacklistLastname";
            txt_blacklistLastname.Size = new Size(232, 29);
            txt_blacklistLastname.TabIndex = 74;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 254);
            label3.Name = "label3";
            label3.Size = new Size(61, 21);
            label3.TabIndex = 73;
            label3.Text = "Reason";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(31, 30);
            label8.Name = "label8";
            label8.Size = new Size(85, 21);
            label8.TabIndex = 72;
            label8.Text = "Blacklist ID";
            // 
            // txt_blacklistID
            // 
            txt_blacklistID.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txt_blacklistID.Enabled = false;
            txt_blacklistID.Font = new Font("Segoe UI", 12F);
            txt_blacklistID.Location = new Point(30, 54);
            txt_blacklistID.Name = "txt_blacklistID";
            txt_blacklistID.Size = new Size(232, 29);
            txt_blacklistID.TabIndex = 70;
            // 
            // txt_reason
            // 
            txt_reason.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txt_reason.Font = new Font("Segoe UI", 12F);
            txt_reason.Location = new Point(30, 278);
            txt_reason.Multiline = true;
            txt_reason.Name = "txt_reason";
            txt_reason.Size = new Size(232, 86);
            txt_reason.TabIndex = 71;
            // 
            // txt_search_blacklist
            // 
            txt_search_blacklist.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_search_blacklist.Location = new Point(17, 30);
            txt_search_blacklist.Name = "txt_search_blacklist";
            txt_search_blacklist.PlaceholderText = "Search";
            txt_search_blacklist.Size = new Size(204, 29);
            txt_search_blacklist.TabIndex = 18;
            txt_search_blacklist.TextChanged += txt_search_blacklist_TextChanged;
            // 
            // dgv_blacklist
            // 
            dgv_blacklist.AllowUserToAddRows = false;
            dgv_blacklist.AllowUserToDeleteRows = false;
            dgv_blacklist.AllowUserToResizeColumns = false;
            dgv_blacklist.AllowUserToResizeRows = false;
            dgv_blacklist.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgv_blacklist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_blacklist.BackgroundColor = SystemColors.Info;
            dgv_blacklist.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_blacklist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_blacklist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_blacklist.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_blacklist.Location = new Point(17, 65);
            dgv_blacklist.Name = "dgv_blacklist";
            dgv_blacklist.RowHeadersVisible = false;
            dgv_blacklist.Size = new Size(778, 359);
            dgv_blacklist.TabIndex = 17;
            dgv_blacklist.CellContentClick += dgv_blacklist_CellContentClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1080, 100);
            panel1.TabIndex = 86;
            // 
            // panel2
            // 
            panel2.Controls.Add(txt_blacklistMiddleName);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txt_blacklistID);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txt_blacklistFirstname);
            panel2.Controls.Add(txt_blacklistLastname);
            panel2.Controls.Add(btn_clear);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txt_dateAdded);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btn_delete);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(btn_update);
            panel2.Controls.Add(btn_add);
            panel2.Controls.Add(txt_reason);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(801, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(279, 542);
            panel2.TabIndex = 87;
            // 
            // txt_blacklistMiddleName
            // 
            txt_blacklistMiddleName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txt_blacklistMiddleName.Font = new Font("Segoe UI", 12F);
            txt_blacklistMiddleName.Location = new Point(30, 166);
            txt_blacklistMiddleName.Name = "txt_blacklistMiddleName";
            txt_blacklistMiddleName.Size = new Size(232, 29);
            txt_blacklistMiddleName.TabIndex = 86;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(31, 142);
            label4.Name = "label4";
            label4.Size = new Size(104, 21);
            label4.TabIndex = 87;
            label4.Text = "Middle Name";
            // 
            // panel3
            // 
            panel3.Controls.Add(btn_refresh);
            panel3.Controls.Add(dgv_blacklist);
            panel3.Controls.Add(txt_search_blacklist);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 100);
            panel3.Name = "panel3";
            panel3.Size = new Size(801, 542);
            panel3.TabIndex = 88;
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
            // BlacklistManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "BlacklistManagement";
            Size = new Size(1080, 642);
            ((System.ComponentModel.ISupportInitialize)dgv_blacklist).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox txt_dateAdded;
        private Button btn_delete;
        private Button btn_update;
        private Button btn_add;
        private Label label6;
        private Label label7;
        private TextBox txt_blacklistFirstname;
        private Label label5;
        private TextBox txt_blacklistLastname;
        private Label label3;
        private Label label8;
        private TextBox txt_blacklistID;
        private TextBox txt_reason;
        private DataGridView dgv_blacklist;
        private TextBox txt_search_blacklist;
        private Button btn_clear;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private TextBox txt_blacklistMiddleName;
        private Label label4;
        private Button btn_refresh;
    }
}
