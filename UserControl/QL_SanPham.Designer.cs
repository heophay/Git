﻿namespace GiaoDien
{
    partial class QL_SanPham
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
            this.bt_search = new System.Windows.Forms.Button();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.button_Sua = new System.Windows.Forms.Button();
            this.button_Them = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_NoiSX = new System.Windows.Forms.Label();
            this.cbb_gia = new System.Windows.Forms.ComboBox();
            this.cbb_xuatxu = new System.Windows.Forms.ComboBox();
            this.DGV_QLSP = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_QLSP)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_search
            // 
            this.bt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.bt_search.Location = new System.Drawing.Point(763, 258);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(109, 30);
            this.bt_search.TabIndex = 44;
            this.bt_search.Text = "Tìm Kiếm";
            this.bt_search.UseVisualStyleBackColor = true;
            // 
            // button_Xoa
            // 
            this.button_Xoa.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_Xoa.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_Xoa.FlatAppearance.BorderSize = 0;
            this.button_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Xoa.ForeColor = System.Drawing.Color.White;
            this.button_Xoa.Location = new System.Drawing.Point(839, 691);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(204, 47);
            this.button_Xoa.TabIndex = 41;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.UseVisualStyleBackColor = false;
            // 
            // button_Sua
            // 
            this.button_Sua.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_Sua.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_Sua.FlatAppearance.BorderSize = 0;
            this.button_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Sua.ForeColor = System.Drawing.Color.White;
            this.button_Sua.Location = new System.Drawing.Point(477, 691);
            this.button_Sua.Name = "button_Sua";
            this.button_Sua.Size = new System.Drawing.Size(203, 47);
            this.button_Sua.TabIndex = 42;
            this.button_Sua.Text = "Sửa";
            this.button_Sua.UseVisualStyleBackColor = false;
            // 
            // button_Them
            // 
            this.button_Them.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_Them.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_Them.FlatAppearance.BorderSize = 0;
            this.button_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Them.ForeColor = System.Drawing.Color.White;
            this.button_Them.Location = new System.Drawing.Point(136, 691);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(190, 47);
            this.button_Them.TabIndex = 43;
            this.button_Them.Text = "Thêm";
            this.button_Them.UseVisualStyleBackColor = false;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(237, 263);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(471, 22);
            this.txt_search.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(74, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 61);
            this.label1.TabIndex = 39;
            this.label1.Text = "Quản lí sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(679, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Giá";
            // 
            // label_NoiSX
            // 
            this.label_NoiSX.AutoSize = true;
            this.label_NoiSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NoiSX.Location = new System.Drawing.Point(97, 191);
            this.label_NoiSX.Name = "label_NoiSX";
            this.label_NoiSX.Size = new System.Drawing.Size(114, 20);
            this.label_NoiSX.TabIndex = 35;
            this.label_NoiSX.Text = "Nơi sản xuất";
            // 
            // cbb_gia
            // 
            this.cbb_gia.FormattingEnabled = true;
            this.cbb_gia.Items.AddRange(new object[] {
            "Từ 1-2 Triệu",
            "Từ 2-5 Triệu",
            "Từ 5 -8 Triệu",
            "Trên 8 Triệu"});
            this.cbb_gia.Location = new System.Drawing.Point(763, 187);
            this.cbb_gia.Name = "cbb_gia";
            this.cbb_gia.Size = new System.Drawing.Size(331, 24);
            this.cbb_gia.TabIndex = 36;
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
            this.cbb_xuatxu.Location = new System.Drawing.Point(248, 187);
            this.cbb_xuatxu.Name = "cbb_xuatxu";
            this.cbb_xuatxu.Size = new System.Drawing.Size(281, 24);
            this.cbb_xuatxu.TabIndex = 37;
            // 
            // DGV_QLSP
            // 
            this.DGV_QLSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_QLSP.Location = new System.Drawing.Point(49, 348);
            this.DGV_QLSP.Name = "DGV_QLSP";
            this.DGV_QLSP.RowHeadersWidth = 51;
            this.DGV_QLSP.RowTemplate.Height = 24;
            this.DGV_QLSP.Size = new System.Drawing.Size(1130, 276);
            this.DGV_QLSP.TabIndex = 38;
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bt_search);
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
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(1228, 808);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_QLSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Button button_Sua;
        private System.Windows.Forms.Button button_Them;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_NoiSX;
        private System.Windows.Forms.ComboBox cbb_gia;
        private System.Windows.Forms.ComboBox cbb_xuatxu;
        private System.Windows.Forms.DataGridView DGV_QLSP;
    }
}