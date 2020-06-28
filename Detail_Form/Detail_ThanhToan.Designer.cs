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
            this.txt_Tongtien = new System.Windows.Forms.TextBox();
            this.label_TongTien = new System.Windows.Forms.Label();
            this.bt_XacNhan = new System.Windows.Forms.Button();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.grb_DonHang = new System.Windows.Forms.GroupBox();
            this.lb_NgayTT = new System.Windows.Forms.Label();
            this.txt_maDH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_NgayTao = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grb_InfoProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grb_DonHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_ThanhToan
            // 
            this.lb_ThanhToan.AutoSize = true;
            this.lb_ThanhToan.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ThanhToan.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lb_ThanhToan.Location = new System.Drawing.Point(245, 20);
            this.lb_ThanhToan.Name = "lb_ThanhToan";
            this.lb_ThanhToan.Size = new System.Drawing.Size(282, 56);
            this.lb_ThanhToan.TabIndex = 0;
            this.lb_ThanhToan.Text = "Thanh toán";
            // 
            // grb_InfoProduct
            // 
            this.grb_InfoProduct.Controls.Add(this.dataGridView1);
            this.grb_InfoProduct.Controls.Add(this.txt_Tongtien);
            this.grb_InfoProduct.Controls.Add(this.label_TongTien);
            this.grb_InfoProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_InfoProduct.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.grb_InfoProduct.Location = new System.Drawing.Point(12, 91);
            this.grb_InfoProduct.Name = "grb_InfoProduct";
            this.grb_InfoProduct.Size = new System.Drawing.Size(779, 255);
            this.grb_InfoProduct.TabIndex = 1;
            this.grb_InfoProduct.TabStop = false;
            this.grb_InfoProduct.Text = "Thông tin sản phẩm";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(749, 166);
            this.dataGridView1.TabIndex = 4;
            // 
            // txt_Tongtien
            // 
            this.txt_Tongtien.Location = new System.Drawing.Point(563, 213);
            this.txt_Tongtien.Name = "txt_Tongtien";
            this.txt_Tongtien.Size = new System.Drawing.Size(170, 27);
            this.txt_Tongtien.TabIndex = 3;
            // 
            // label_TongTien
            // 
            this.label_TongTien.AutoSize = true;
            this.label_TongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TongTien.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_TongTien.Location = new System.Drawing.Point(404, 206);
            this.label_TongTien.Name = "label_TongTien";
            this.label_TongTien.Size = new System.Drawing.Size(140, 36);
            this.label_TongTien.TabIndex = 0;
            this.label_TongTien.Text = "Tổng tiền";
            // 
            // bt_XacNhan
            // 
            this.bt_XacNhan.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bt_XacNhan.FlatAppearance.BorderSize = 0;
            this.bt_XacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_XacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bt_XacNhan.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bt_XacNhan.Location = new System.Drawing.Point(127, 617);
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
            this.bt_Cancel.Location = new System.Drawing.Point(487, 620);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(147, 44);
            this.bt_Cancel.TabIndex = 2;
            this.bt_Cancel.Text = "Hủy";
            this.bt_Cancel.UseVisualStyleBackColor = true;
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
            // 
            // grb_DonHang
            // 
            this.grb_DonHang.Controls.Add(this.dateTimePicker2);
            this.grb_DonHang.Controls.Add(this.dateTimePicker1);
            this.grb_DonHang.Controls.Add(this.lb_NgayTT);
            this.grb_DonHang.Controls.Add(this.textBox1);
            this.grb_DonHang.Controls.Add(this.txt_maDH);
            this.grb_DonHang.Controls.Add(this.label1);
            this.grb_DonHang.Controls.Add(this.label2);
            this.grb_DonHang.Controls.Add(this.lb_NgayTao);
            this.grb_DonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.grb_DonHang.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.grb_DonHang.Location = new System.Drawing.Point(12, 367);
            this.grb_DonHang.Name = "grb_DonHang";
            this.grb_DonHang.Size = new System.Drawing.Size(779, 226);
            this.grb_DonHang.TabIndex = 4;
            this.grb_DonHang.TabStop = false;
            this.grb_DonHang.Text = "Thông tin đơn hàng";
            // 
            // lb_NgayTT
            // 
            this.lb_NgayTT.AutoSize = true;
            this.lb_NgayTT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_NgayTT.Location = new System.Drawing.Point(348, 152);
            this.lb_NgayTT.Name = "lb_NgayTT";
            this.lb_NgayTT.Size = new System.Drawing.Size(130, 20);
            this.lb_NgayTT.TabIndex = 0;
            this.lb_NgayTT.Text = "Ngày thanh toán";
            // 
            // txt_maDH
            // 
            this.txt_maDH.Location = new System.Drawing.Point(118, 56);
            this.txt_maDH.Name = "txt_maDH";
            this.txt_maDH.Size = new System.Drawing.Size(199, 27);
            this.txt_maDH.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(7, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đơn hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(7, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tổng tiền";
            // 
            // lb_NgayTao
            // 
            this.lb_NgayTao.AutoSize = true;
            this.lb_NgayTao.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_NgayTao.Location = new System.Drawing.Point(393, 59);
            this.lb_NgayTao.Name = "lb_NgayTao";
            this.lb_NgayTao.Size = new System.Drawing.Size(75, 20);
            this.lb_NgayTao.TabIndex = 0;
            this.lb_NgayTao.Text = "Ngày tạo";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(484, 56);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(276, 27);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(484, 149);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(276, 27);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 149);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 27);
            this.textBox1.TabIndex = 1;
            // 
            // Detail_ThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(810, 687);
            this.Controls.Add(this.grb_DonHang);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.bt_XacNhan);
            this.Controls.Add(this.grb_InfoProduct);
            this.Controls.Add(this.lb_ThanhToan);
            this.Name = "Detail_ThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detail_ThanhToan";
            this.grb_InfoProduct.ResumeLayout(false);
            this.grb_InfoProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grb_DonHang.ResumeLayout(false);
            this.grb_DonHang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_ThanhToan;
        private System.Windows.Forms.GroupBox grb_InfoProduct;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_Tongtien;
        private System.Windows.Forms.Label label_TongTien;
        private System.Windows.Forms.Button bt_XacNhan;
        private System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.GroupBox grb_DonHang;
        private System.Windows.Forms.Label lb_NgayTT;
        private System.Windows.Forms.TextBox txt_maDH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_NgayTao;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
    }
}