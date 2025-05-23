﻿namespace Visitor_Identification_Management_System
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisitorReports));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            btn_import = new Button();
            btn_print = new Button();
            btn_export = new Button();
            btn_refresh = new Button();
            dgv_reports = new DataGridView();
            txt_search_reports = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_reports).BeginInit();
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
            panel1.Size = new Size(1080, 100);
            panel1.TabIndex = 22;
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_import);
            panel2.Controls.Add(btn_print);
            panel2.Controls.Add(btn_export);
            panel2.Controls.Add(btn_refresh);
            panel2.Controls.Add(dgv_reports);
            panel2.Controls.Add(txt_search_reports);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(1080, 542);
            panel2.TabIndex = 23;
            // 
            // btn_import
            // 
            btn_import.Anchor = AnchorStyles.None;
            btn_import.AutoSize = true;
            btn_import.BackColor = Color.FromArgb(52, 152, 219);
            btn_import.FlatAppearance.BorderSize = 0;
            btn_import.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 76, 209);
            btn_import.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 96, 228);
            btn_import.FlatStyle = FlatStyle.Flat;
            btn_import.Font = new Font("Segoe UI", 12F);
            btn_import.ForeColor = Color.White;
            btn_import.Image = (Image)resources.GetObject("btn_import.Image");
            btn_import.ImageAlign = ContentAlignment.MiddleLeft;
            btn_import.Location = new Point(630, 383);
            btn_import.Name = "btn_import";
            btn_import.Size = new Size(100, 33);
            btn_import.TabIndex = 73;
            btn_import.Text = "IMPORT";
            btn_import.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_import.UseVisualStyleBackColor = false;
            btn_import.Click += btn_import_Click;
            // 
            // btn_print
            // 
            btn_print.Anchor = AnchorStyles.None;
            btn_print.AutoSize = true;
            btn_print.BackColor = Color.FromArgb(52, 152, 219);
            btn_print.FlatAppearance.BorderSize = 0;
            btn_print.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 76, 209);
            btn_print.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 96, 228);
            btn_print.FlatStyle = FlatStyle.Flat;
            btn_print.Font = new Font("Segoe UI", 12F);
            btn_print.ForeColor = Color.White;
            btn_print.Image = (Image)resources.GetObject("btn_print.Image");
            btn_print.ImageAlign = ContentAlignment.MiddleLeft;
            btn_print.Location = new Point(509, 383);
            btn_print.Name = "btn_print";
            btn_print.Size = new Size(87, 33);
            btn_print.TabIndex = 72;
            btn_print.Text = "PRINT";
            btn_print.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_print.UseVisualStyleBackColor = false;
            btn_print.Click += btn_print_Click;
            // 
            // btn_export
            // 
            btn_export.Anchor = AnchorStyles.None;
            btn_export.AutoSize = true;
            btn_export.BackColor = Color.FromArgb(52, 152, 219);
            btn_export.FlatAppearance.BorderSize = 0;
            btn_export.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 76, 209);
            btn_export.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 96, 228);
            btn_export.FlatStyle = FlatStyle.Flat;
            btn_export.Font = new Font("Segoe UI", 12F);
            btn_export.ForeColor = Color.White;
            btn_export.Image = (Image)resources.GetObject("btn_export.Image");
            btn_export.ImageAlign = ContentAlignment.MiddleLeft;
            btn_export.Location = new Point(374, 383);
            btn_export.Name = "btn_export";
            btn_export.Size = new Size(99, 33);
            btn_export.TabIndex = 71;
            btn_export.Text = "EXPORT";
            btn_export.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_export.UseVisualStyleBackColor = false;
            btn_export.Click += btn_export_Click;
            // 
            // btn_refresh
            // 
            btn_refresh.Anchor = AnchorStyles.None;
            btn_refresh.AutoSize = true;
            btn_refresh.BackColor = Color.FromArgb(52, 152, 219);
            btn_refresh.FlatAppearance.BorderSize = 0;
            btn_refresh.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 76, 209);
            btn_refresh.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 96, 228);
            btn_refresh.FlatStyle = FlatStyle.Flat;
            btn_refresh.Font = new Font("Segoe UI", 12F);
            btn_refresh.ForeColor = Color.White;
            btn_refresh.Image = (Image)resources.GetObject("btn_refresh.Image");
            btn_refresh.Location = new Point(247, 17);
            btn_refresh.Name = "btn_refresh";
            btn_refresh.Size = new Size(30, 30);
            btn_refresh.TabIndex = 70;
            btn_refresh.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_refresh.UseVisualStyleBackColor = false;
            btn_refresh.Click += btn_refresh_Click;
            // 
            // dgv_reports
            // 
            dgv_reports.AllowUserToAddRows = false;
            dgv_reports.AllowUserToDeleteRows = false;
            dgv_reports.AllowUserToResizeColumns = false;
            dgv_reports.AllowUserToResizeRows = false;
            dgv_reports.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgv_reports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_reports.BackgroundColor = SystemColors.Info;
            dgv_reports.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_reports.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_reports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_reports.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_reports.Location = new Point(37, 52);
            dgv_reports.Name = "dgv_reports";
            dgv_reports.RowHeadersVisible = false;
            dgv_reports.Size = new Size(1007, 300);
            dgv_reports.TabIndex = 15;
            // 
            // txt_search_reports
            // 
            txt_search_reports.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_search_reports.Location = new Point(37, 17);
            txt_search_reports.Name = "txt_search_reports";
            txt_search_reports.PlaceholderText = "Search";
            txt_search_reports.Size = new Size(204, 29);
            txt_search_reports.TabIndex = 14;
            txt_search_reports.TextChanged += txt_search_reports_TextChanged;
            // 
            // VisitorReports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "VisitorReports";
            Size = new Size(1080, 642);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_reports).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private TextBox txt_search_reports;
        private DataGridView dgv_reports;
        private Button btn_print;
        private Button btn_export;
        private Button btn_refresh;
        private Button btn_import;
    }
}
