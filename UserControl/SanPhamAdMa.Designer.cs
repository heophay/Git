namespace GiaoDien
{
    partial class SanPhamAdMa
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
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_NoiSX = new System.Windows.Forms.Label();
            this.cbb_xuatxu = new System.Windows.Forms.ComboBox();
            this.DGV_QLSP = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Them = new System.Windows.Forms.Button();
            this.button_Sua = new System.Windows.Forms.Button();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_gia = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_QLSP)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(408, 256);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(471, 22);
            this.txt_search.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(73, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 61);
            this.label1.TabIndex = 8;
            this.label1.Text = "Quản lí sản phẩm";
            // 
            // label_NoiSX
            // 
            this.label_NoiSX.AutoSize = true;
            this.label_NoiSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NoiSX.Location = new System.Drawing.Point(96, 187);
            this.label_NoiSX.Name = "label_NoiSX";
            this.label_NoiSX.Size = new System.Drawing.Size(114, 20);
            this.label_NoiSX.TabIndex = 5;
            this.label_NoiSX.Text = "Nơi sản xuất";
            // 
            // cbb_xuatxu
            // 
            this.cbb_xuatxu.FormattingEnabled = true;
            this.cbb_xuatxu.Items.AddRange(new object[] {
            "Trung Quốc",
            "Hàn Quốc",
            "Nhật Bản",
            "Mỹ",
            "Việt Nam"});
            this.cbb_xuatxu.Location = new System.Drawing.Point(247, 183);
            this.cbb_xuatxu.Name = "cbb_xuatxu";
            this.cbb_xuatxu.Size = new System.Drawing.Size(281, 24);
            this.cbb_xuatxu.TabIndex = 6;
            // 
            // DGV_QLSP
            // 
            this.DGV_QLSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_QLSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.DGV_QLSP.Location = new System.Drawing.Point(48, 344);
            this.DGV_QLSP.Name = "DGV_QLSP";
            this.DGV_QLSP.RowHeadersWidth = 51;
            this.DGV_QLSP.RowTemplate.Height = 24;
            this.DGV_QLSP.Size = new System.Drawing.Size(1130, 276);
            this.DGV_QLSP.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Masp";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "TenSP";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "HangSX";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "BaoHanh";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ManHinh";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Ram";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "BoNhoTrong";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "HeDieuHanh";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Pin";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "SoSIm";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 125;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Noixuatxu";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.Width = 125;
            // 
            // button_Them
            // 
            this.button_Them.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_Them.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_Them.FlatAppearance.BorderSize = 0;
            this.button_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Them.ForeColor = System.Drawing.Color.White;
            this.button_Them.Location = new System.Drawing.Point(135, 687);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(190, 47);
            this.button_Them.TabIndex = 31;
            this.button_Them.Text = "Thêm";
            this.button_Them.UseVisualStyleBackColor = false;
            this.button_Them.Click += new System.EventHandler(this.button_Them_Click);
            // 
            // button_Sua
            // 
            this.button_Sua.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_Sua.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_Sua.FlatAppearance.BorderSize = 0;
            this.button_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Sua.ForeColor = System.Drawing.Color.White;
            this.button_Sua.Location = new System.Drawing.Point(476, 687);
            this.button_Sua.Name = "button_Sua";
            this.button_Sua.Size = new System.Drawing.Size(203, 47);
            this.button_Sua.TabIndex = 31;
            this.button_Sua.Text = "Sửa";
            this.button_Sua.UseVisualStyleBackColor = false;
            this.button_Sua.Click += new System.EventHandler(this.button_Sua_Click);
            // 
            // button_Xoa
            // 
            this.button_Xoa.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_Xoa.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_Xoa.FlatAppearance.BorderSize = 0;
            this.button_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Xoa.ForeColor = System.Drawing.Color.White;
            this.button_Xoa.Location = new System.Drawing.Point(838, 687);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(204, 47);
            this.button_Xoa.TabIndex = 31;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(292, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Tìm kiếm";
            // 
            // cbb_gia
            // 
            this.cbb_gia.FormattingEnabled = true;
            this.cbb_gia.Items.AddRange(new object[] {
            "Từ 1-2 Triệu",
            "Từ 2-5 Triệu",
            "Từ 5 -8 Triệu",
            "Trên 8 Triệu"});
            this.cbb_gia.Location = new System.Drawing.Point(762, 183);
            this.cbb_gia.Name = "cbb_gia";
            this.cbb_gia.Size = new System.Drawing.Size(331, 24);
            this.cbb_gia.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(678, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Giá";
            // 
            // SanPhamAdMa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Xoa);
            this.Controls.Add(this.button_Sua);
            this.Controls.Add(this.button_Them);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_NoiSX);
            this.Controls.Add(this.cbb_gia);
            this.Controls.Add(this.cbb_xuatxu);
            this.Controls.Add(this.DGV_QLSP);
            this.Name = "SanPhamAdMa";
            this.Size = new System.Drawing.Size(1228, 808);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_QLSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_NoiSX;
        private System.Windows.Forms.ComboBox cbb_xuatxu;
        private System.Windows.Forms.DataGridView DGV_QLSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.Button button_Them;
        private System.Windows.Forms.Button button_Sua;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_gia;
        private System.Windows.Forms.Label label3;
    }
}
