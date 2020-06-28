namespace GiaoDien
{
    partial class GioHangUser
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
            this.button_GiamSoLuong = new System.Windows.Forms.Button();
            this.button_Tangsoluong = new System.Windows.Forms.Button();
            this.button_XoaSP = new System.Windows.Forms.Button();
            this.button_Lapdonhang = new System.Windows.Forms.Button();
            this.DGV_Giohang = new System.Windows.Forms.DataGridView();
            this.label_Giohang = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Giohang)).BeginInit();
            this.SuspendLayout();
            // 
            // button_GiamSoLuong
            // 
            this.button_GiamSoLuong.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_GiamSoLuong.FlatAppearance.BorderSize = 0;
            this.button_GiamSoLuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_GiamSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.button_GiamSoLuong.ForeColor = System.Drawing.Color.White;
            this.button_GiamSoLuong.Location = new System.Drawing.Point(160, 661);
            this.button_GiamSoLuong.Name = "button_GiamSoLuong";
            this.button_GiamSoLuong.Size = new System.Drawing.Size(179, 40);
            this.button_GiamSoLuong.TabIndex = 5;
            this.button_GiamSoLuong.Text = "Giảm số lượng";
            this.button_GiamSoLuong.UseVisualStyleBackColor = false;
            this.button_GiamSoLuong.Click += new System.EventHandler(this.button_GiamSoLuong_Click);
            // 
            // button_Tangsoluong
            // 
            this.button_Tangsoluong.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_Tangsoluong.FlatAppearance.BorderSize = 0;
            this.button_Tangsoluong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Tangsoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.button_Tangsoluong.ForeColor = System.Drawing.Color.White;
            this.button_Tangsoluong.Location = new System.Drawing.Point(160, 613);
            this.button_Tangsoluong.Name = "button_Tangsoluong";
            this.button_Tangsoluong.Size = new System.Drawing.Size(179, 42);
            this.button_Tangsoluong.TabIndex = 6;
            this.button_Tangsoluong.Text = "Tăng số lượng";
            this.button_Tangsoluong.UseVisualStyleBackColor = false;
            this.button_Tangsoluong.Click += new System.EventHandler(this.button_Tangsoluong_Click);
            // 
            // button_XoaSP
            // 
            this.button_XoaSP.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_XoaSP.FlatAppearance.BorderSize = 0;
            this.button_XoaSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_XoaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.button_XoaSP.ForeColor = System.Drawing.Color.White;
            this.button_XoaSP.Location = new System.Drawing.Point(452, 624);
            this.button_XoaSP.Name = "button_XoaSP";
            this.button_XoaSP.Size = new System.Drawing.Size(221, 63);
            this.button_XoaSP.TabIndex = 7;
            this.button_XoaSP.Text = "Xóa sản phẩm";
            this.button_XoaSP.UseVisualStyleBackColor = false;
            // 
            // button_Lapdonhang
            // 
            this.button_Lapdonhang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_Lapdonhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Lapdonhang.ForeColor = System.Drawing.Color.White;
            this.button_Lapdonhang.Location = new System.Drawing.Point(774, 624);
            this.button_Lapdonhang.Name = "button_Lapdonhang";
            this.button_Lapdonhang.Size = new System.Drawing.Size(221, 63);
            this.button_Lapdonhang.TabIndex = 8;
            this.button_Lapdonhang.Text = "Lập đơn hàng";
            this.button_Lapdonhang.UseVisualStyleBackColor = false;
            this.button_Lapdonhang.Click += new System.EventHandler(this.button_Lapdonhang_Click);
            // 
            // DGV_Giohang
            // 
            this.DGV_Giohang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Giohang.Location = new System.Drawing.Point(79, 230);
            this.DGV_Giohang.Name = "DGV_Giohang";
            this.DGV_Giohang.RowHeadersWidth = 51;
            this.DGV_Giohang.RowTemplate.Height = 24;
            this.DGV_Giohang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Giohang.Size = new System.Drawing.Size(1052, 315);
            this.DGV_Giohang.TabIndex = 4;
            // 
            // label_Giohang
            // 
            this.label_Giohang.AutoSize = true;
            this.label_Giohang.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label_Giohang.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Giohang.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label_Giohang.Location = new System.Drawing.Point(88, 84);
            this.label_Giohang.Name = "label_Giohang";
            this.label_Giohang.Size = new System.Drawing.Size(477, 68);
            this.label_Giohang.TabIndex = 3;
            this.label_Giohang.Text = "Giỏ hàng của bạn";
            // 
            // GioHangUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.button_GiamSoLuong);
            this.Controls.Add(this.button_Tangsoluong);
            this.Controls.Add(this.button_XoaSP);
            this.Controls.Add(this.button_Lapdonhang);
            this.Controls.Add(this.DGV_Giohang);
            this.Controls.Add(this.label_Giohang);
            this.Name = "GioHangUser";
            this.Size = new System.Drawing.Size(1227, 808);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Giohang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_GiamSoLuong;
        private System.Windows.Forms.Button button_Tangsoluong;
        private System.Windows.Forms.Button button_XoaSP;
        private System.Windows.Forms.Button button_Lapdonhang;
        private System.Windows.Forms.DataGridView DGV_Giohang;
        private System.Windows.Forms.Label label_Giohang;
    }
}
