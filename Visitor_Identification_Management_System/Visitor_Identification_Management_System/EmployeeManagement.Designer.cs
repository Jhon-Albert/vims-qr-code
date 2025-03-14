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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            dgv_logs = new DataGridView();
            label8 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_firstName = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btn_add = new Button();
            button1 = new Button();
            button2 = new Button();
            textBox3 = new TextBox();
            label5 = new Label();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_logs).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 63);
            label2.Name = "label2";
            label2.Size = new Size(146, 21);
            label2.TabIndex = 21;
            label2.Text = "Manage | Employee";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 18);
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
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btn_add);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(txt_firstName);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label8);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(732, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(321, 525);
            panel2.TabIndex = 23;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(732, 100);
            panel3.TabIndex = 24;
            // 
            // panel4
            // 
            panel4.Controls.Add(dgv_logs);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 100);
            panel4.Name = "panel4";
            panel4.Size = new Size(732, 425);
            panel4.TabIndex = 25;
            // 
            // dgv_logs
            // 
            dgv_logs.AllowUserToAddRows = false;
            dgv_logs.AllowUserToDeleteRows = false;
            dgv_logs.AllowUserToResizeColumns = false;
            dgv_logs.AllowUserToResizeRows = false;
            dgv_logs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_logs.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv_logs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgv_logs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_logs.Location = new Point(56, 48);
            dgv_logs.Name = "dgv_logs";
            dgv_logs.RowHeadersVisible = false;
            dgv_logs.Size = new Size(602, 321);
            dgv_logs.TabIndex = 16;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(39, 162);
            label8.Name = "label8";
            label8.Size = new Size(81, 21);
            label8.TabIndex = 57;
            label8.Text = "Full Name";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(39, 244);
            label3.Name = "label3";
            label3.Size = new Size(48, 21);
            label3.TabIndex = 58;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(39, 330);
            label4.Name = "label4";
            label4.Size = new Size(76, 21);
            label4.TabIndex = 59;
            label4.Text = "Password";
            // 
            // txt_firstName
            // 
            txt_firstName.Anchor = AnchorStyles.None;
            txt_firstName.Font = new Font("Segoe UI", 12F);
            txt_firstName.Location = new Point(39, 186);
            txt_firstName.Name = "txt_firstName";
            txt_firstName.Size = new Size(232, 29);
            txt_firstName.TabIndex = 60;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(39, 268);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(232, 29);
            textBox1.TabIndex = 61;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(39, 354);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(232, 29);
            textBox2.TabIndex = 62;
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
            btn_add.Location = new Point(24, 436);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(77, 33);
            btn_add.TabIndex = 67;
            btn_add.Text = "ADD";
            btn_add.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.AutoSize = true;
            button1.BackColor = Color.FromArgb(52, 152, 219);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = SystemColors.GradientActiveCaption;
            button1.FlatAppearance.MouseOverBackColor = SystemColors.GradientActiveCaption;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(115, 436);
            button1.Name = "button1";
            button1.Size = new Size(77, 33);
            button1.TabIndex = 68;
            button1.Text = "UPDATE";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.AutoSize = true;
            button2.BackColor = Color.FromArgb(52, 152, 219);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = SystemColors.GradientActiveCaption;
            button2.FlatAppearance.MouseOverBackColor = SystemColors.GradientActiveCaption;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(208, 436);
            button2.Name = "button2";
            button2.Size = new Size(77, 33);
            button2.TabIndex = 69;
            button2.Text = "DELETE";
            button2.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.Font = new Font("Segoe UI", 12F);
            textBox3.Location = new Point(39, 113);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(232, 29);
            textBox3.TabIndex = 71;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(39, 89);
            label5.Name = "label5";
            label5.Size = new Size(97, 21);
            label5.TabIndex = 70;
            label5.Text = "Employee ID";
            label5.Click += label5_Click;
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
            ((System.ComponentModel.ISupportInitialize)dgv_logs).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private DataGridView dgv_logs;
        private Label label3;
        private Label label8;
        private Label label4;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox txt_firstName;
        private TextBox textBox3;
        private Label label5;
        private Button button2;
        private Button button1;
        private Button btn_add;
    }
}
