namespace Visitor_Identification_Management_System
{
    partial class VisitorReports
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
            txt_search_logs = new TextBox();
            dgv_logs = new DataGridView();
            button2 = new Button();
            button1 = new Button();
            btn_add = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_logs).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(37, 63);
            label2.Name = "label2";
            label2.Size = new Size(125, 21);
            label2.TabIndex = 21;
            label2.Text = "Manage | Report";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 18);
            label1.Name = "label1";
            label1.Size = new Size(244, 45);
            label1.TabIndex = 20;
            label1.Text = "Visitor Reports";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1053, 100);
            panel1.TabIndex = 22;
            // 
            // panel2
            // 
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btn_add);
            panel2.Controls.Add(dgv_logs);
            panel2.Controls.Add(txt_search_logs);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(1053, 425);
            panel2.TabIndex = 23;
            // 
            // txt_search_logs
            // 
            txt_search_logs.Location = new Point(107, 23);
            txt_search_logs.Name = "txt_search_logs";
            txt_search_logs.PlaceholderText = "Search";
            txt_search_logs.Size = new Size(204, 23);
            txt_search_logs.TabIndex = 14;
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
            dgv_logs.Location = new Point(107, 52);
            dgv_logs.Name = "dgv_logs";
            dgv_logs.RowHeadersVisible = false;
            dgv_logs.Size = new Size(838, 280);
            dgv_logs.TabIndex = 15;
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
            button2.Location = new Point(597, 358);
            button2.Name = "button2";
            button2.Size = new Size(77, 33);
            button2.TabIndex = 72;
            button2.Text = "PRINT";
            button2.UseVisualStyleBackColor = false;
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
            button1.Location = new Point(504, 358);
            button1.Name = "button1";
            button1.Size = new Size(77, 33);
            button1.TabIndex = 71;
            button1.Text = "EXPORT";
            button1.UseVisualStyleBackColor = false;
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
            btn_add.Location = new Point(413, 358);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(84, 33);
            btn_add.TabIndex = 70;
            btn_add.Text = "REFRESH";
            btn_add.UseVisualStyleBackColor = false;
            // 
            // VisitorReports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "VisitorReports";
            Size = new Size(1053, 525);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_logs).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private TextBox txt_search_logs;
        private DataGridView dgv_logs;
        private Button button2;
        private Button button1;
        private Button btn_add;
    }
}
