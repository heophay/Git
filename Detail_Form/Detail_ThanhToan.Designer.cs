namespace GiaoDien.Detail_Form
{
    partial class Detail_ThanhToan
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
            this.lb_ThanhToan = new System.Windows.Forms.Label();
            this.grb_InfoProduct = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_XacNhan = new System.Windows.Forms.Button();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.grb_DonHang = new System.Windows.Forms.GroupBox();
            this.dtp_DateTT = new System.Windows.Forms.DateTimePicker();
            this.dtp_DateTao = new System.Windows.Forms.DateTimePicker();
            this.lb_NgayTT = new System.Windows.Forms.Label();
            this.txt_Tongtien1 = new System.Windows.Forms.TextBox();
            this.txt_maDH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_NgayTao = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbox_TenTK = new System.Windows.Forms.CheckBox();
            this.cbox_DiaChi = new System.Windows.Forms.CheckBox();
            this.cbox_SDT = new System.Windows.Forms.CheckBox();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.lb_DiaChi = new System.Windows.Forms.Label();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.lb_SDT = new System.Windows.Forms.Label();
            this.txt_TenKH = new System.Windows.Forms.TextBox();
            this.lb_TenKH = new System.Windows.Forms.Label();
            this.grb_InfoProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grb_DonHang.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_ThanhToan
            // 
            this.lb_ThanhToan.AutoSize = true;
            this.lb_ThanhToan.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ThanhToan.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lb_ThanhToan.Location = new System.Drawing.Point(369, 21);
            this.lb_ThanhToan.Name = "lb_ThanhToan";
            this.lb_ThanhToan.Size = new System.Drawing.Size(293, 59);
            this.lb_ThanhToan.TabIndex = 0;
            this.lb_ThanhToan.Text = "Thanh toán";
            // 
            // grb_InfoProduct
            // 
            this.grb_InfoProduct.Controls.Add(this.dataGridView1);
            this.grb_InfoProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_InfoProduct.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.grb_InfoProduct.Location = new System.Drawing.Point(20, 395);
            this.grb_InfoProduct.Name = "grb_InfoProduct";
            this.grb_InfoProduct.Size = new System.Drawing.Size(999, 247);
            this.grb_InfoProduct.TabIndex = 1;
            this.grb_InfoProduct.TabStop = false;
            this.grb_InfoProduct.Text = "Danh sách sản phẩm";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(960, 205);
            this.dataGridView1.TabIndex = 4;
            // 
            // bt_XacNhan
            // 
            this.bt_XacNhan.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bt_XacNhan.FlatAppearance.BorderSize = 0;
            this.bt_XacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_XacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bt_XacNhan.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bt_XacNhan.Location = new System.Drawing.Point(238, 670);
            this.bt_XacNhan.Name = "bt_XacNhan";
            this.bt_XacNhan.Size = new System.Drawing.Size(169, 51);
            this.bt_XacNhan.TabIndex = 2;
            this.bt_XacNhan.Text = "Xác nhận";
            this.bt_XacNhan.UseVisualStyleBackColor = false;
            this.bt_XacNhan.Click += new System.EventHandler(this.bt_XacNhan_Click);
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bt_Cancel.Location = new System.Drawing.Point(606, 670);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(162, 51);
            this.bt_Cancel.TabIndex = 2;
            this.bt_Cancel.Text = "Hủy";
            this.bt_Cancel.UseVisualStyleBackColor = true;
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
            // 
            // grb_DonHang
            // 
            this.grb_DonHang.Controls.Add(this.dtp_DateTT);
            this.grb_DonHang.Controls.Add(this.dtp_DateTao);
            this.grb_DonHang.Controls.Add(this.lb_NgayTT);
            this.grb_DonHang.Controls.Add(this.txt_Tongtien1);
            this.grb_DonHang.Controls.Add(this.txt_maDH);
            this.grb_DonHang.Controls.Add(this.label1);
            this.grb_DonHang.Controls.Add(this.label2);
            this.grb_DonHang.Controls.Add(this.lb_NgayTao);
            this.grb_DonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.grb_DonHang.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.grb_DonHang.Location = new System.Drawing.Point(20, 98);
            this.grb_DonHang.Name = "grb_DonHang";
            this.grb_DonHang.Size = new System.Drawing.Size(500, 290);
            this.grb_DonHang.TabIndex = 4;
            this.grb_DonHang.TabStop = false;
            this.grb_DonHang.Text = "Thông tin đơn hàng";
            // 
            // dtp_DateTT
            // 
            this.dtp_DateTT.Location = new System.Drawing.Point(162, 176);
            this.dtp_DateTT.Name = "dtp_DateTT";
            this.dtp_DateTT.Size = new System.Drawing.Size(312, 27);
            this.dtp_DateTT.TabIndex = 2;
            // 
            // dtp_DateTao
            // 
            this.dtp_DateTao.Location = new System.Drawing.Point(162, 109);
            this.dtp_DateTao.Name = "dtp_DateTao";
            this.dtp_DateTao.Size = new System.Drawing.Size(312, 27);
            this.dtp_DateTao.TabIndex = 2;
            // 
            // lb_NgayTT
            // 
            this.lb_NgayTT.AutoSize = true;
            this.lb_NgayTT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_NgayTT.Location = new System.Drawing.Point(11, 176);
            this.lb_NgayTT.Name = "lb_NgayTT";
            this.lb_NgayTT.Size = new System.Drawing.Size(130, 20);
            this.lb_NgayTT.TabIndex = 0;
            this.lb_NgayTT.Text = "Ngày thanh toán";
            // 
            // txt_Tongtien1
            // 
            this.txt_Tongtien1.Location = new System.Drawing.Point(162, 236);
            this.txt_Tongtien1.Name = "txt_Tongtien1";
            this.txt_Tongtien1.Size = new System.Drawing.Size(312, 27);
            this.txt_Tongtien1.TabIndex = 1;
            // 
            // txt_maDH
            // 
            this.txt_maDH.Location = new System.Drawing.Point(162, 47);
            this.txt_maDH.Name = "txt_maDH";
            this.txt_maDH.Size = new System.Drawing.Size(312, 27);
            this.txt_maDH.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(30, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đơn hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(49, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tổng tiền";
            // 
            // lb_NgayTao
            // 
            this.lb_NgayTao.AutoSize = true;
            this.lb_NgayTao.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_NgayTao.Location = new System.Drawing.Point(52, 109);
            this.lb_NgayTao.Name = "lb_NgayTao";
            this.lb_NgayTao.Size = new System.Drawing.Size(75, 20);
            this.lb_NgayTao.TabIndex = 0;
            this.lb_NgayTao.Text = "Ngày tạo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbox_TenTK);
            this.groupBox1.Controls.Add(this.cbox_DiaChi);
            this.groupBox1.Controls.Add(this.cbox_SDT);
            this.groupBox1.Controls.Add(this.txt_DiaChi);
            this.groupBox1.Controls.Add(this.lb_DiaChi);
            this.groupBox1.Controls.Add(this.txt_SDT);
            this.groupBox1.Controls.Add(this.lb_SDT);
            this.groupBox1.Controls.Add(this.txt_TenKH);
            this.groupBox1.Controls.Add(this.lb_TenKH);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(526, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 290);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin vận chuyển";
            // 
            // cbox_TenTK
            // 
            this.cbox_TenTK.AutoSize = true;
            this.cbox_TenTK.Location = new System.Drawing.Point(163, 80);
            this.cbox_TenTK.Name = "cbox_TenTK";
            this.cbox_TenTK.Size = new System.Drawing.Size(240, 24);
            this.cbox_TenTK.TabIndex = 2;
            this.cbox_TenTK.Text = "Sử dụng Tên trong tài khoản";
            this.cbox_TenTK.UseVisualStyleBackColor = true;
            this.cbox_TenTK.CheckedChanged += new System.EventHandler(this.cbox_TenTK_CheckedChanged);
            // 
            // cbox_DiaChi
            // 
            this.cbox_DiaChi.AutoSize = true;
            this.cbox_DiaChi.Location = new System.Drawing.Point(163, 245);
            this.cbox_DiaChi.Name = "cbox_DiaChi";
            this.cbox_DiaChi.Size = new System.Drawing.Size(264, 24);
            this.cbox_DiaChi.TabIndex = 2;
            this.cbox_DiaChi.Text = "Sử dụng Địa chỉ trong tài khoản";
            this.cbox_DiaChi.UseVisualStyleBackColor = true;
            this.cbox_DiaChi.CheckedChanged += new System.EventHandler(this.cbox_DiaChi_CheckedChanged);
            // 
            // cbox_SDT
            // 
            this.cbox_SDT.AutoSize = true;
            this.cbox_SDT.Location = new System.Drawing.Point(163, 165);
            this.cbox_SDT.Name = "cbox_SDT";
            this.cbox_SDT.Size = new System.Drawing.Size(245, 24);
            this.cbox_SDT.TabIndex = 2;
            this.cbox_SDT.Text = "Sử dụng SĐT trong tải khoản";
            this.cbox_SDT.UseVisualStyleBackColor = true;
            this.cbox_SDT.CheckedChanged += new System.EventHandler(this.cbox_SDT_CheckedChanged);
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(163, 206);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(312, 27);
            this.txt_DiaChi.TabIndex = 1;
            this.txt_DiaChi.TextChanged += new System.EventHandler(this.txt_DiaChi_TextChanged_1);
            // 
            // lb_DiaChi
            // 
            this.lb_DiaChi.AutoSize = true;
            this.lb_DiaChi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_DiaChi.Location = new System.Drawing.Point(76, 209);
            this.lb_DiaChi.Name = "lb_DiaChi";
            this.lb_DiaChi.Size = new System.Drawing.Size(61, 20);
            this.lb_DiaChi.TabIndex = 0;
            this.lb_DiaChi.Text = "Địa chỉ";
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(163, 123);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(312, 27);
            this.txt_SDT.TabIndex = 1;
            this.txt_SDT.TextChanged += new System.EventHandler(this.txt_DiaChi_TextChanged);
            // 
            // lb_SDT
            // 
            this.lb_SDT.AutoSize = true;
            this.lb_SDT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_SDT.Location = new System.Drawing.Point(32, 126);
            this.lb_SDT.Name = "lb_SDT";
            this.lb_SDT.Size = new System.Drawing.Size(106, 20);
            this.lb_SDT.TabIndex = 0;
            this.lb_SDT.Text = "Số điện thoại";
            // 
            // txt_TenKH
            // 
            this.txt_TenKH.Location = new System.Drawing.Point(163, 42);
            this.txt_TenKH.Name = "txt_TenKH";
            this.txt_TenKH.Size = new System.Drawing.Size(312, 27);
            this.txt_TenKH.TabIndex = 1;
            this.txt_TenKH.TextChanged += new System.EventHandler(this.txt_TenKH_TextChanged);
            // 
            // lb_TenKH
            // 
            this.lb_TenKH.AutoSize = true;
            this.lb_TenKH.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_TenKH.Location = new System.Drawing.Point(16, 45);
            this.lb_TenKH.Name = "lb_TenKH";
            this.lb_TenKH.Size = new System.Drawing.Size(127, 20);
            this.lb_TenKH.TabIndex = 0;
            this.lb_TenKH.Text = "Tên khách hàng";
            // 
            // Detail_ThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1046, 733);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grb_DonHang);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.bt_XacNhan);
            this.Controls.Add(this.grb_InfoProduct);
            this.Controls.Add(this.lb_ThanhToan);
            this.Name = "Detail_ThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detail_ThanhToan";
            this.grb_InfoProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grb_DonHang.ResumeLayout(false);
            this.grb_DonHang.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_ThanhToan;
        private System.Windows.Forms.GroupBox grb_InfoProduct;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_XacNhan;
        private System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.GroupBox grb_DonHang;
        private System.Windows.Forms.Label lb_NgayTT;
        private System.Windows.Forms.TextBox txt_maDH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_NgayTao;
        private System.Windows.Forms.DateTimePicker dtp_DateTT;
        private System.Windows.Forms.DateTimePicker dtp_DateTao;
        private System.Windows.Forms.TextBox txt_Tongtien1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Label lb_DiaChi;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.Label lb_SDT;
        private System.Windows.Forms.TextBox txt_TenKH;
        private System.Windows.Forms.Label lb_TenKH;
        private System.Windows.Forms.CheckBox cbox_TenTK;
        private System.Windows.Forms.CheckBox cbox_DiaChi;
        private System.Windows.Forms.CheckBox cbox_SDT;
    }
}