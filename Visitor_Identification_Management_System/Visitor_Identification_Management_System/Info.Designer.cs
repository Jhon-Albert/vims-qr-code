namespace Visitor_Identification_Management_System
{
    partial class Info
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
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            txt_search_info = new TextBox();
            dgv_info = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_info).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1053, 100);
            panel1.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 60);
            label2.Name = "label2";
            label2.Size = new Size(140, 21);
            label2.TabIndex = 8;
            label2.Text = "Track | Information";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 15);
            label1.Name = "label1";
            label1.Size = new Size(307, 45);
            label1.TabIndex = 7;
            label1.Text = "Visitor Information";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgv_info);
            panel2.Controls.Add(txt_search_info);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(1053, 425);
            panel2.TabIndex = 14;
            // 
            // txt_search_info
            // 
            txt_search_info.Location = new Point(107, 23);
            txt_search_info.Name = "txt_search_info";
            txt_search_info.PlaceholderText = "Search";
            txt_search_info.Size = new Size(204, 23);
            txt_search_info.TabIndex = 13;
            txt_search_info.TextChanged += txt_search_info_TextChanged;
            // 
            // dgv_info
            // 
            dgv_info.AllowUserToAddRows = false;
            dgv_info.AllowUserToDeleteRows = false;
            dgv_info.AllowUserToResizeColumns = false;
            dgv_info.AllowUserToResizeRows = false;
            dgv_info.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_info.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv_info.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgv_info.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_info.Location = new Point(107, 52);
            dgv_info.Name = "dgv_info";
            dgv_info.RowHeadersVisible = false;
            dgv_info.Size = new Size(838, 321);
            dgv_info.TabIndex = 15;
            // 
            // Info
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Info";
            Size = new Size(1053, 525);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_info).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private DataGridView dgv_logs;
        private TextBox txt_search_info;
        private DataGridView dgv_info;
    }
}
