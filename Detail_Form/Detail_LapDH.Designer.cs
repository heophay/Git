namespace GiaoDien.Detail_Form
{
    partial class Detail_LapDH
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_ThanhToan = new System.Windows.Forms.Button();
            this.bt_LuuDH = new System.Windows.Forms.Button();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_LapDH = new System.Windows.Forms.Label();
            this.grb_ListSP = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grb_ListSP.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_ThanhToan
            // 
            this.bt_ThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_ThanhToan.FlatAppearance.BorderSize = 0;
            this.bt_ThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bt_ThanhToan.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bt_ThanhToan.Location = new System.Drawing.Point(29, 557);
            this.bt_ThanhToan.Name = "bt_ThanhToan";
            this.bt_ThanhToan.Size = new System.Drawing.Size(155, 50);
            this.bt_ThanhToan.TabIndex = 0;
            this.bt_ThanhToan.Text = "Thanh toán";
            this.bt_ThanhToan.UseVisualStyleBackColor = false;
            this.bt_ThanhToan.Click += new System.EventHandler(this.bt_ThanhToan_Click);
            // 
            // bt_LuuDH
            // 
            this.bt_LuuDH.BackColor = System.Drawing.SystemColors.Highlight;
            this.bt_LuuDH.FlatAppearance.BorderSize = 0;
            this.bt_LuuDH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_LuuDH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bt_LuuDH.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_LuuDH.Location = new System.Drawing.Point(264, 557);
            this.bt_LuuDH.Name = "bt_LuuDH";
            this.bt_LuuDH.Size = new System.Drawing.Size(154, 50);
            this.bt_LuuDH.TabIndex = 0;
            this.bt_LuuDH.Text = "Lưu ";
            this.bt_LuuDH.UseVisualStyleBackColor = false;
            this.bt_LuuDH.Click += new System.EventHandler(this.bt_LuuDH_Click);
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.BackColor = System.Drawing.SystemColors.Control;
            this.bt_Cancel.FlatAppearance.BorderSize = 0;
            this.bt_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.bt_Cancel.Location = new System.Drawing.Point(499, 557);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(136, 49);
            this.bt_Cancel.TabIndex = 0;
            this.bt_Cancel.Text = "Hủy";
            this.bt_Cancel.UseVisualStyleBackColor = false;
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(3, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(730, 338);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tên SP";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Số lượng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Giá";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Thành tiền";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // lb_LapDH
            // 
            this.lb_LapDH.AutoSize = true;
            this.lb_LapDH.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold);
            this.lb_LapDH.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lb_LapDH.Location = new System.Drawing.Point(181, 44);
            this.lb_LapDH.Name = "lb_LapDH";
            this.lb_LapDH.Size = new System.Drawing.Size(299, 49);
            this.lb_LapDH.TabIndex = 2;
            this.lb_LapDH.Text = "Lập đơn hàng";
            // 
            // grb_ListSP
            // 
            this.grb_ListSP.Controls.Add(this.dataGridView1);
            this.grb_ListSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_ListSP.Location = new System.Drawing.Point(12, 137);
            this.grb_ListSP.Name = "grb_ListSP";
            this.grb_ListSP.Size = new System.Drawing.Size(736, 380);
            this.grb_ListSP.TabIndex = 3;
            this.grb_ListSP.TabStop = false;
            this.grb_ListSP.Text = "Danh sách sản phẩm";
            // 
            // Detail_LapDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 648);
            this.Controls.Add(this.grb_ListSP);
            this.Controls.Add(this.lb_LapDH);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.bt_LuuDH);
            this.Controls.Add(this.bt_ThanhToan);
            this.Name = "Detail_LapDH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detail_LapDH";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grb_ListSP.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_ThanhToan;
        private System.Windows.Forms.Button bt_LuuDH;
        private System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lb_LapDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.GroupBox grb_ListSP;
    }
}