namespace GiaoDien
{
    partial class Don_Hang
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
            this.button_Xemdonhang = new System.Windows.Forms.Button();
            this.DGV_Donhang = new System.Windows.Forms.DataGridView();
            this.label_Donhang = new System.Windows.Forms.Label();
            this.button_XoaDonHang = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Donhang)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Xemdonhang
            // 
            this.button_Xemdonhang.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_Xemdonhang.FlatAppearance.BorderSize = 0;
            this.button_Xemdonhang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Xemdonhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.button_Xemdonhang.ForeColor = System.Drawing.Color.White;
            this.button_Xemdonhang.Location = new System.Drawing.Point(192, 606);
            this.button_Xemdonhang.Name = "button_Xemdonhang";
            this.button_Xemdonhang.Size = new System.Drawing.Size(219, 44);
            this.button_Xemdonhang.TabIndex = 6;
            this.button_Xemdonhang.Text = "Xem đơn hàng";
            this.button_Xemdonhang.UseVisualStyleBackColor = false;
            this.button_Xemdonhang.Click += new System.EventHandler(this.button_Xemdonhang_Click);
            // 
            // DGV_Donhang
            // 
            this.DGV_Donhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Donhang.Location = new System.Drawing.Point(79, 230);
            this.DGV_Donhang.Name = "DGV_Donhang";
            this.DGV_Donhang.RowHeadersWidth = 51;
            this.DGV_Donhang.RowTemplate.Height = 24;
            this.DGV_Donhang.Size = new System.Drawing.Size(1052, 315);
            this.DGV_Donhang.TabIndex = 5;
            // 
            // label_Donhang
            // 
            this.label_Donhang.AutoSize = true;
            this.label_Donhang.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold);
            this.label_Donhang.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label_Donhang.Location = new System.Drawing.Point(88, 84);
            this.label_Donhang.Name = "label_Donhang";
            this.label_Donhang.Size = new System.Drawing.Size(551, 68);
            this.label_Donhang.TabIndex = 4;
            this.label_Donhang.Text = "Danh sách đơn hàng";
            // 
            // button_XoaDonHang
            // 
            this.button_XoaDonHang.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_XoaDonHang.FlatAppearance.BorderSize = 0;
            this.button_XoaDonHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_XoaDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.button_XoaDonHang.ForeColor = System.Drawing.Color.White;
            this.button_XoaDonHang.Location = new System.Drawing.Point(749, 606);
            this.button_XoaDonHang.Name = "button_XoaDonHang";
            this.button_XoaDonHang.Size = new System.Drawing.Size(224, 44);
            this.button_XoaDonHang.TabIndex = 6;
            this.button_XoaDonHang.Text = "Xóa đơn hàng";
            this.button_XoaDonHang.UseVisualStyleBackColor = false;
            this.button_XoaDonHang.Click += new System.EventHandler(this.button_XoaDonHang_Click);
            // 
            // DonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_XoaDonHang);
            this.Controls.Add(this.button_Xemdonhang);
            this.Controls.Add(this.DGV_Donhang);
            this.Controls.Add(this.label_Donhang);
            this.Name = "DonHang";
            this.Size = new System.Drawing.Size(1228, 808);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Donhang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Xemdonhang;
        private System.Windows.Forms.DataGridView DGV_Donhang;
        private System.Windows.Forms.Label label_Donhang;
        private System.Windows.Forms.Button button_XoaDonHang;
    }
}
