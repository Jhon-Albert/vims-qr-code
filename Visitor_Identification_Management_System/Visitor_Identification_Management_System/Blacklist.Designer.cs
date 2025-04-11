namespace Visitor_Identification_Management_System
{
    partial class Blacklist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Blacklist));
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            dgv_blacklist = new DataGridView();
            txt_search_blacklist = new TextBox();
            btn_refresh = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_blacklist).BeginInit();
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
            panel1.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 60);
            label2.Name = "label2";
            label2.Size = new Size(114, 21);
            label2.TabIndex = 16;
            label2.Text = "Track | Blacklist";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 15);
            label1.Name = "label1";
            label1.Size = new Size(265, 45);
            label1.TabIndex = 15;
            label1.Text = "Blacklist Visitors";
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_refresh);
            panel2.Controls.Add(dgv_blacklist);
            panel2.Controls.Add(txt_search_blacklist);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(1053, 425);
            panel2.TabIndex = 18;
            // 
            // dgv_blacklist
            // 
            dgv_blacklist.AllowUserToAddRows = false;
            dgv_blacklist.AllowUserToDeleteRows = false;
            dgv_blacklist.AllowUserToResizeColumns = false;
            dgv_blacklist.AllowUserToResizeRows = false;
            dgv_blacklist.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgv_blacklist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_blacklist.BackgroundColor = SystemColors.GradientActiveCaption;
            dgv_blacklist.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            dgv_blacklist.Location = new Point(107, 52);
            dgv_blacklist.Name = "dgv_blacklist";
            dgv_blacklist.RowHeadersVisible = false;
            dgv_blacklist.Size = new Size(838, 321);
            dgv_blacklist.TabIndex = 18;
            // 
            // txt_search_blacklist
            // 
            txt_search_blacklist.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_search_blacklist.Location = new Point(107, 17);
            txt_search_blacklist.Name = "txt_search_blacklist";
            txt_search_blacklist.PlaceholderText = "Search";
            txt_search_blacklist.Size = new Size(204, 29);
            txt_search_blacklist.TabIndex = 17;
            txt_search_blacklist.TextChanged += txt_search_blacklist_TextChanged;
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
            btn_refresh.Location = new Point(317, 16);
            btn_refresh.Name = "btn_refresh";
            btn_refresh.Size = new Size(30, 30);
            btn_refresh.TabIndex = 72;
            btn_refresh.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_refresh.UseVisualStyleBackColor = false;
            btn_refresh.Click += btn_refresh_Click;
            // 
            // Blacklist
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Blacklist";
            Size = new Size(1053, 525);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_blacklist).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private TextBox txt_search_blacklist;
        private DataGridView dgv_blacklist;
        private Button btn_refresh;
    }
}
