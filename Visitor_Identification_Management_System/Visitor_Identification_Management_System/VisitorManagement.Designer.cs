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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel3 = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel5 = new Panel();
            dgv_logs = new DataGridView();
            label6 = new Label();
            label7 = new Label();
            txt_lastName = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txt_contactNumber = new TextBox();
            txt_address = new TextBox();
            label3 = new Label();
            label8 = new Label();
            txt_firstName = new TextBox();
            txt_email = new TextBox();
            btn_add = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            textBox1 = new TextBox();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_logs).BeginInit();
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
            // panel1
            // 
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(btn_delete);
            panel1.Controls.Add(btn_update);
            panel1.Controls.Add(btn_add);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txt_lastName);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txt_contactNumber);
            panel1.Controls.Add(txt_address);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txt_firstName);
            panel1.Controls.Add(txt_email);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(745, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(308, 525);
            panel1.TabIndex = 0;
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
            // panel5
            // 
            panel5.Controls.Add(dgv_logs);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 100);
            panel5.Name = "panel5";
            panel5.Size = new Size(745, 425);
            panel5.TabIndex = 2;
            // 
            // dgv_logs
            // 
            dgv_logs.AllowUserToAddRows = false;
            dgv_logs.AllowUserToDeleteRows = false;
            dgv_logs.AllowUserToResizeColumns = false;
            dgv_logs.AllowUserToResizeRows = false;
            dgv_logs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_logs.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgv_logs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgv_logs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_logs.Location = new Point(43, 47);
            dgv_logs.Name = "dgv_logs";
            dgv_logs.RowHeadersVisible = false;
            dgv_logs.Size = new Size(602, 321);
            dgv_logs.TabIndex = 15;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(35, 285);
            label6.Name = "label6";
            label6.Size = new Size(119, 21);
            label6.TabIndex = 64;
            label6.Text = "Purpose of Visit";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(37, 86);
            label7.Name = "label7";
            label7.Size = new Size(84, 21);
            label7.TabIndex = 63;
            label7.Text = "Last Name";
            // 
            // txt_lastName
            // 
            txt_lastName.Anchor = AnchorStyles.None;
            txt_lastName.Font = new Font("Segoe UI", 12F);
            txt_lastName.Location = new Point(37, 110);
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
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(35, 159);
            label5.Name = "label5";
            label5.Size = new Size(125, 21);
            label5.TabIndex = 60;
            label5.Text = "Contact Number";
            // 
            // txt_contactNumber
            // 
            txt_contactNumber.Anchor = AnchorStyles.None;
            txt_contactNumber.Font = new Font("Segoe UI", 12F);
            txt_contactNumber.Location = new Point(35, 183);
            txt_contactNumber.Name = "txt_contactNumber";
            txt_contactNumber.Size = new Size(232, 29);
            txt_contactNumber.TabIndex = 58;
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
            label3.Location = new Point(35, 229);
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
            label8.Location = new Point(35, 16);
            label8.Name = "label8";
            label8.Size = new Size(86, 21);
            label8.TabIndex = 56;
            label8.Text = "First Name";
            // 
            // txt_firstName
            // 
            txt_firstName.Anchor = AnchorStyles.None;
            txt_firstName.Font = new Font("Segoe UI", 12F);
            txt_firstName.Location = new Point(35, 40);
            txt_firstName.Name = "txt_firstName";
            txt_firstName.Size = new Size(232, 29);
            txt_firstName.TabIndex = 54;
            // 
            // txt_email
            // 
            txt_email.Anchor = AnchorStyles.None;
            txt_email.Font = new Font("Segoe UI", 12F);
            txt_email.Location = new Point(35, 253);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(232, 29);
            txt_email.TabIndex = 55;
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
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(35, 309);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(232, 29);
            textBox1.TabIndex = 69;
            // 
            // VisitorManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Name = "VisitorManagement";
            Size = new Size(1053, 525);
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_logs).EndInit();
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
        private DataGridView dgv_logs;
        private Label label6;
        private Label label7;
        private TextBox txt_lastName;
        private Label label4;
        private Label label5;
        private TextBox txt_contactNumber;
        private TextBox txt_address;
        private Label label3;
        private Label label8;
        private TextBox txt_firstName;
        private TextBox txt_email;
        private Button btn_delete;
        private Button btn_update;
        private Button btn_add;
        private TextBox textBox1;
    }
}
