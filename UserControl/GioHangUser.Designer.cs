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
            this.button_XoaSP = new System.Windows.Forms.Button();
            this.button_Lapdonhang = new System.Windows.Forms.Button();
            this.DGV_Giohang = new System.Windows.Forms.DataGridView();
            this.label_Giohang = new System.Windows.Forms.Label();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ThayDoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Giohang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_XoaSP
            // 
            this.button_XoaSP.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_XoaSP.FlatAppearance.BorderSize = 0;
            this.button_XoaSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_XoaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.button_XoaSP.ForeColor = System.Drawing.Color.White;
            this.button_XoaSP.Location = new System.Drawing.Point(477, 604);
            this.button_XoaSP.Name = "button_XoaSP";
            this.button_XoaSP.Size = new System.Drawing.Size(190, 50);
            this.button_XoaSP.TabIndex = 7;
            this.button_XoaSP.Text = "Xóa sản phẩm";
            this.button_XoaSP.UseVisualStyleBackColor = false;
            this.button_XoaSP.Click += new System.EventHandler(this.button_XoaSP_Click);
            // 
            // button_Lapdonhang
            // 
            this.button_Lapdonhang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_Lapdonhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Lapdonhang.ForeColor = System.Drawing.Color.White;
            this.button_Lapdonhang.Location = new System.Drawing.Point(843, 604);
            this.button_Lapdonhang.Name = "button_Lapdonhang";
            this.button_Lapdonhang.Size = new System.Drawing.Size(209, 55);
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
            this.DGV_Giohang.ReadOnly = true;
            this.DGV_Giohang.RowHeadersWidth = 51;
            this.DGV_Giohang.RowTemplate.Height = 24;
            this.DGV_Giohang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Giohang.Size = new System.Drawing.Size(1052, 315);
            this.DGV_Giohang.TabIndex = 4;
            this.DGV_Giohang.Click += new System.EventHandler(this.DGV_Giohang_Click);
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
            // domainUpDown1
            // 
            this.domainUpDown1.Location = new System.Drawing.Point(160, 42);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(54, 22);
            this.domainUpDown1.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.domainUpDown1);
            this.groupBox1.Controls.Add(this.btn_ThayDoi);
            this.groupBox1.Location = new System.Drawing.Point(117, 570);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 89);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thay đổi số lượng";
            // 
            // btn_ThayDoi
            // 
            this.btn_ThayDoi.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_ThayDoi.FlatAppearance.BorderSize = 0;
            this.btn_ThayDoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThayDoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_ThayDoi.ForeColor = System.Drawing.Color.White;
            this.btn_ThayDoi.Location = new System.Drawing.Point(23, 34);
            this.btn_ThayDoi.Name = "btn_ThayDoi";
            this.btn_ThayDoi.Size = new System.Drawing.Size(119, 35);
            this.btn_ThayDoi.TabIndex = 7;
            this.btn_ThayDoi.Text = "Thay đổi";
            this.btn_ThayDoi.UseVisualStyleBackColor = false;
            this.btn_ThayDoi.Click += new System.EventHandler(this.btn_ThayDoi_Click);
            // 
            // GioHangUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_XoaSP);
            this.Controls.Add(this.button_Lapdonhang);
            this.Controls.Add(this.DGV_Giohang);
            this.Controls.Add(this.label_Giohang);
            this.Name = "GioHangUser";
            this.Size = new System.Drawing.Size(1227, 808);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Giohang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_XoaSP;
        private System.Windows.Forms.Button button_Lapdonhang;
        private System.Windows.Forms.DataGridView DGV_Giohang;
        private System.Windows.Forms.Label label_Giohang;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ThayDoi;
    }
}