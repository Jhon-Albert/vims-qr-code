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
            dgv_blacklist = new DataGridView();
            txt_search_blacklist = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_blacklist).BeginInit();
            SuspendLayout();
            // 
            // dgv_blacklist
            // 
            dgv_blacklist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_blacklist.Location = new Point(8, 130);
            dgv_blacklist.Name = "dgv_blacklist";
            dgv_blacklist.Size = new Size(750, 321);
            dgv_blacklist.TabIndex = 16;
            // 
            // txt_search_blacklist
            // 
            txt_search_blacklist.Location = new Point(8, 101);
            txt_search_blacklist.Name = "txt_search_blacklist";
            txt_search_blacklist.PlaceholderText = "Search";
            txt_search_blacklist.Size = new Size(204, 23);
            txt_search_blacklist.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 60);
            label2.Name = "label2";
            label2.Size = new Size(114, 21);
            label2.TabIndex = 14;
            label2.Text = "Track | Blacklist";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 15);
            label1.Name = "label1";
            label1.Size = new Size(265, 45);
            label1.TabIndex = 13;
            label1.Text = "Blacklist Visitors";
            // 
            // Blacklist
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgv_blacklist);
            Controls.Add(txt_search_blacklist);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Blacklist";
            Size = new Size(766, 464);
            ((System.ComponentModel.ISupportInitialize)dgv_blacklist).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_blacklist;
        private TextBox txt_search_blacklist;
        private Label label2;
        private Label label1;
    }
}
