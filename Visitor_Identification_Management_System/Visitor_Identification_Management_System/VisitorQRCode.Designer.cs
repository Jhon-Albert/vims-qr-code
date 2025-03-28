namespace Visitor_Identification_Management_System
{
    partial class VisitorQRCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisitorQRCode));
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            btn_downloadQRCode = new Button();
            btn_refresh = new Button();
            txt_searchVisitorQRCode = new TextBox();
            dgv_visitorQRCode = new DataGridView();
            pb_visitorQRCode = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_visitorQRCode).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_visitorQRCode).BeginInit();
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
            panel1.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 18);
            label1.Name = "label1";
            label1.Size = new Size(279, 45);
            label1.TabIndex = 20;
            label1.Text = "Visitor's QR Code";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(37, 63);
            label2.Name = "label2";
            label2.Size = new Size(140, 21);
            label2.TabIndex = 21;
            label2.Text = "Manage | QR Code";
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_downloadQRCode);
            panel2.Controls.Add(btn_refresh);
            panel2.Controls.Add(txt_searchVisitorQRCode);
            panel2.Controls.Add(dgv_visitorQRCode);
            panel2.Controls.Add(pb_visitorQRCode);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(1080, 542);
            panel2.TabIndex = 24;
            // 
            // btn_downloadQRCode
            // 
            btn_downloadQRCode.AutoSize = true;
            btn_downloadQRCode.BackColor = Color.FromArgb(52, 152, 219);
            btn_downloadQRCode.FlatAppearance.BorderSize = 0;
            btn_downloadQRCode.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 76, 209);
            btn_downloadQRCode.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 96, 228);
            btn_downloadQRCode.FlatStyle = FlatStyle.Flat;
            btn_downloadQRCode.Font = new Font("Segoe UI", 12F);
            btn_downloadQRCode.ForeColor = Color.White;
            btn_downloadQRCode.Image = (Image)resources.GetObject("btn_downloadQRCode.Image");
            btn_downloadQRCode.ImageAlign = ContentAlignment.MiddleLeft;
            btn_downloadQRCode.Location = new Point(912, 262);
            btn_downloadQRCode.Name = "btn_downloadQRCode";
            btn_downloadQRCode.Size = new Size(134, 33);
            btn_downloadQRCode.TabIndex = 72;
            btn_downloadQRCode.Text = "DOWNLOAD";
            btn_downloadQRCode.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_downloadQRCode.UseVisualStyleBackColor = false;
            btn_downloadQRCode.Click += btn_downloadQRCode_Click;
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
            btn_refresh.Location = new Point(238, 21);
            btn_refresh.Name = "btn_refresh";
            btn_refresh.Size = new Size(30, 30);
            btn_refresh.TabIndex = 71;
            btn_refresh.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_refresh.UseVisualStyleBackColor = false;
            // 
            // txt_searchVisitorQRCode
            // 
            txt_searchVisitorQRCode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_searchVisitorQRCode.Location = new Point(28, 21);
            txt_searchVisitorQRCode.Name = "txt_searchVisitorQRCode";
            txt_searchVisitorQRCode.PlaceholderText = "Search";
            txt_searchVisitorQRCode.Size = new Size(204, 29);
            txt_searchVisitorQRCode.TabIndex = 15;
            txt_searchVisitorQRCode.TextChanged += txt_searchVisitorQRCode_TextChanged;
            // 
            // dgv_visitorQRCode
            // 
            dgv_visitorQRCode.BackgroundColor = SystemColors.Info;
            dgv_visitorQRCode.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_visitorQRCode.Location = new Point(28, 56);
            dgv_visitorQRCode.Name = "dgv_visitorQRCode";
            dgv_visitorQRCode.Size = new Size(843, 341);
            dgv_visitorQRCode.TabIndex = 1;
            dgv_visitorQRCode.CellClick += dgv_visitorQRCode_CellClick;
            // 
            // pb_visitorQRCode
            // 
            pb_visitorQRCode.Image = (Image)resources.GetObject("pb_visitorQRCode.Image");
            pb_visitorQRCode.Location = new Point(877, 56);
            pb_visitorQRCode.Name = "pb_visitorQRCode";
            pb_visitorQRCode.Size = new Size(200, 200);
            pb_visitorQRCode.SizeMode = PictureBoxSizeMode.Zoom;
            pb_visitorQRCode.TabIndex = 0;
            pb_visitorQRCode.TabStop = false;
            // 
            // VisitorQRCode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "VisitorQRCode";
            Size = new Size(1080, 642);
            Load += VisitorQRCode_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_visitorQRCode).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_visitorQRCode).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private DataGridView dgv_visitorQRCode;
        private PictureBox pb_visitorQRCode;
        private TextBox txt_searchVisitorQRCode;
        private Button btn_refresh;
        private Button btn_downloadQRCode;
    }
}
