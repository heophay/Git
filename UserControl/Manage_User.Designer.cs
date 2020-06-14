namespace GiaoDien
{
    partial class Manage_User
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
            this.button_Xoa = new System.Windows.Forms.Button();
            this.button_Sua = new System.Windows.Forms.Button();
            this.button_Them = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_search = new System.Windows.Forms.ComboBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label_HangSX = new System.Windows.Forms.Label();
            this.DGV_KH = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_KH)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Xoa
            // 
            this.button_Xoa.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_Xoa.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_Xoa.FlatAppearance.BorderSize = 0;
            this.button_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Xoa.ForeColor = System.Drawing.Color.White;
            this.button_Xoa.Location = new System.Drawing.Point(853, 677);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(204, 47);
            this.button_Xoa.TabIndex = 52;
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
            this.button_Sua.Location = new System.Drawing.Point(491, 677);
            this.button_Sua.Name = "button_Sua";
            this.button_Sua.Size = new System.Drawing.Size(203, 47);
            this.button_Sua.TabIndex = 53;
            this.button_Sua.Text = "Sửa";
            this.button_Sua.UseVisualStyleBackColor = false;
            this.button_Sua.Click += new System.EventHandler(this.button_Sua_Click);
            // 
            // button_Them
            // 
            this.button_Them.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_Them.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_Them.FlatAppearance.BorderSize = 0;
            this.button_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Them.ForeColor = System.Drawing.Color.White;
            this.button_Them.Location = new System.Drawing.Point(150, 677);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(190, 47);
            this.button_Them.TabIndex = 54;
            this.button_Them.Text = "Thêm";
            this.button_Them.UseVisualStyleBackColor = false;
            this.button_Them.Click += new System.EventHandler(this.button_Them_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(94, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 61);
            this.label1.TabIndex = 51;
            this.label1.Text = "Quản lý khách hàng";
            // 
            // cbb_search
            // 
            this.cbb_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.cbb_search.FormattingEnabled = true;
            this.cbb_search.Items.AddRange(new object[] {
            "Tên KH",
            "Mã KH"});
            this.cbb_search.Location = new System.Drawing.Point(262, 176);
            this.cbb_search.Name = "cbb_search";
            this.cbb_search.Size = new System.Drawing.Size(178, 28);
            this.cbb_search.TabIndex = 50;
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.txt_search.Location = new System.Drawing.Point(505, 177);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(498, 27);
            this.txt_search.TabIndex = 48;
            // 
            // label_HangSX
            // 
            this.label_HangSX.AutoSize = true;
            this.label_HangSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label_HangSX.Location = new System.Drawing.Point(138, 180);
            this.label_HangSX.Name = "label_HangSX";
            this.label_HangSX.Size = new System.Drawing.Size(85, 20);
            this.label_HangSX.TabIndex = 47;
            this.label_HangSX.Text = "Tìm kiếm";
            // 
            // DGV_KH
            // 
            this.DGV_KH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_KH.Location = new System.Drawing.Point(83, 257);
            this.DGV_KH.Name = "DGV_KH";
            this.DGV_KH.RowHeadersWidth = 51;
            this.DGV_KH.RowTemplate.Height = 24;
            this.DGV_KH.Size = new System.Drawing.Size(1065, 324);
            this.DGV_KH.TabIndex = 49;
            // 
            // Manage_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_Xoa);
            this.Controls.Add(this.button_Sua);
            this.Controls.Add(this.button_Them);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbb_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label_HangSX);
            this.Controls.Add(this.DGV_KH);
            this.Name = "Manage_User";
            this.Size = new System.Drawing.Size(1228, 808);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_KH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Button button_Sua;
        private System.Windows.Forms.Button button_Them;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label_HangSX;
        private System.Windows.Forms.DataGridView DGV_KH;
    }
}
