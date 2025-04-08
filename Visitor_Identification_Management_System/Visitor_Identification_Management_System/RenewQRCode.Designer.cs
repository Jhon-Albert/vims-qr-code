namespace Visitor_Identification_Management_System
{
    partial class RenewQRCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RenewQRCode));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            cmb_visitor = new ComboBox();
            btn_renewQRCode = new Button();
            pb_currentQRCode = new PictureBox();
            dgv_visitorQRCode = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_currentQRCode).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_visitorQRCode).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1080, 100);
            panel1.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 18);
            label1.Name = "label1";
            label1.Size = new Size(366, 45);
            label1.TabIndex = 20;
            label1.Text = "Renew Visitor QR Code";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(37, 63);
            label2.Name = "label2";
            label2.Size = new Size(191, 21);
            label2.TabIndex = 21;
            label2.Text = "Manage | Renew QR Code";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgv_visitorQRCode);
            panel2.Controls.Add(cmb_visitor);
            panel2.Controls.Add(btn_renewQRCode);
            panel2.Controls.Add(pb_currentQRCode);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(1080, 542);
            panel2.TabIndex = 25;
            // 
            // cmb_visitor
            // 
            cmb_visitor.FormattingEnabled = true;
            cmb_visitor.Location = new Point(28, 44);
            cmb_visitor.Name = "cmb_visitor";
            cmb_visitor.Size = new Size(200, 23);
            cmb_visitor.TabIndex = 81;
            cmb_visitor.SelectedIndexChanged += cmb_visitor_SelectedIndexChanged;
            // 
            // btn_renewQRCode
            // 
            btn_renewQRCode.AutoSize = true;
            btn_renewQRCode.BackColor = Color.FromArgb(52, 152, 219);
            btn_renewQRCode.FlatAppearance.BorderSize = 0;
            btn_renewQRCode.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 76, 209);
            btn_renewQRCode.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 96, 228);
            btn_renewQRCode.FlatStyle = FlatStyle.Flat;
            btn_renewQRCode.Font = new Font("Segoe UI", 12F);
            btn_renewQRCode.ForeColor = Color.White;
            btn_renewQRCode.ImageAlign = ContentAlignment.MiddleLeft;
            btn_renewQRCode.Location = new Point(336, 419);
            btn_renewQRCode.Name = "btn_renewQRCode";
            btn_renewQRCode.Size = new Size(133, 33);
            btn_renewQRCode.TabIndex = 78;
            btn_renewQRCode.Text = "Renew QR Code";
            btn_renewQRCode.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_renewQRCode.UseVisualStyleBackColor = false;
            btn_renewQRCode.Click += btn_renewQRCode_Click;
            // 
            // pb_currentQRCode
            // 
            pb_currentQRCode.BorderStyle = BorderStyle.FixedSingle;
            pb_currentQRCode.Image = (Image)resources.GetObject("pb_currentQRCode.Image");
            pb_currentQRCode.Location = new Point(856, 73);
            pb_currentQRCode.Name = "pb_currentQRCode";
            pb_currentQRCode.Size = new Size(200, 200);
            pb_currentQRCode.SizeMode = PictureBoxSizeMode.Zoom;
            pb_currentQRCode.TabIndex = 75;
            pb_currentQRCode.TabStop = false;
            // 
            // dgv_visitorQRCode
            // 
            dgv_visitorQRCode.AllowUserToAddRows = false;
            dgv_visitorQRCode.AllowUserToDeleteRows = false;
            dgv_visitorQRCode.AllowUserToResizeColumns = false;
            dgv_visitorQRCode.AllowUserToResizeRows = false;
            dgv_visitorQRCode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgv_visitorQRCode.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_visitorQRCode.BackgroundColor = SystemColors.GradientActiveCaption;
            dgv_visitorQRCode.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv_visitorQRCode.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgv_visitorQRCode.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgv_visitorQRCode.DefaultCellStyle = dataGridViewCellStyle4;
            dgv_visitorQRCode.Location = new Point(28, 73);
            dgv_visitorQRCode.Name = "dgv_visitorQRCode";
            dgv_visitorQRCode.RowHeadersVisible = false;
            dgv_visitorQRCode.Size = new Size(800, 340);
            dgv_visitorQRCode.TabIndex = 82;
            // 
            // RenewQRCode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "RenewQRCode";
            Size = new Size(1080, 642);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_currentQRCode).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_visitorQRCode).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private PictureBox pb_currentQRCode;
        private Button btn_renewQRCode;
        private ComboBox cmb_visitor;
        private DataGridView dgv_visitorQRCode;
    }
}
