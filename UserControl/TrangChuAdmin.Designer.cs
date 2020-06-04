namespace GiaoDien
{
    partial class AdminManager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminManager));
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bt_SP = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bt_TTNV = new System.Windows.Forms.Button();
            this.bt_doanhthu = new System.Windows.Forms.Button();
            this.bt_Gia = new System.Windows.Forms.Button();
            this.button_DanhMuc = new System.Windows.Forms.Button();
            this.danhMucAd2 = new GiaoDien.DanhMucAd();
            this.doanhThuAd1 = new GiaoDien.DoanhThuAd();
            this.nhanVienAdMa1 = new GiaoDien.NhanVienAdMa();
            this.nhapXuatAdMa1 = new GiaoDien.NhapXuatAdMa();
            this.sanPhamAdMa1 = new GiaoDien.SanPhamAdMa();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.danhMucAd2);
            this.panel2.Controls.Add(this.doanhThuAd1);
            this.panel2.Controls.Add(this.nhanVienAdMa1);
            this.panel2.Controls.Add(this.nhapXuatAdMa1);
            this.panel2.Controls.Add(this.sanPhamAdMa1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(273, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1227, 808);
            this.panel2.TabIndex = 9;
            // 
            // bt_SP
            // 
            this.bt_SP.FlatAppearance.BorderSize = 0;
            this.bt_SP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.bt_SP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_SP.Font = new System.Drawing.Font("Century Schoolbook", 13.2F);
            this.bt_SP.ForeColor = System.Drawing.Color.White;
            this.bt_SP.Image = ((System.Drawing.Image)(resources.GetObject("bt_SP.Image")));
            this.bt_SP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_SP.Location = new System.Drawing.Point(8, 171);
            this.bt_SP.Name = "bt_SP";
            this.bt_SP.Size = new System.Drawing.Size(255, 51);
            this.bt_SP.TabIndex = 1;
            this.bt_SP.Text = "Sản phẩm";
            this.toolTip1.SetToolTip(this.bt_SP, "Sản phẩm");
            this.bt_SP.UseVisualStyleBackColor = true;
            this.bt_SP.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(269, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 0);
            this.panel3.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.bt_TTNV);
            this.panel1.Controls.Add(this.bt_doanhthu);
            this.panel1.Controls.Add(this.bt_Gia);
            this.panel1.Controls.Add(this.button_DanhMuc);
            this.panel1.Controls.Add(this.bt_SP);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 808);
            this.panel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Jokerman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(72, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 43);
            this.label2.TabIndex = 8;
            this.label2.Text = "Welcome!!";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 49);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Location = new System.Drawing.Point(0, 64);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(269, 84);
            this.panel4.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Mistral", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(73, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "PHONE STORE";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 84);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // bt_TTNV
            // 
            this.bt_TTNV.FlatAppearance.BorderSize = 0;
            this.bt_TTNV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.bt_TTNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_TTNV.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_TTNV.ForeColor = System.Drawing.Color.White;
            this.bt_TTNV.Image = ((System.Drawing.Image)(resources.GetObject("bt_TTNV.Image")));
            this.bt_TTNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_TTNV.Location = new System.Drawing.Point(5, 399);
            this.bt_TTNV.Name = "bt_TTNV";
            this.bt_TTNV.Size = new System.Drawing.Size(255, 51);
            this.bt_TTNV.TabIndex = 1;
            this.bt_TTNV.Text = "Theo dõi nhân viên";
            this.bt_TTNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.bt_TTNV, "Theo dõi nhân viên");
            this.bt_TTNV.UseVisualStyleBackColor = true;
            this.bt_TTNV.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_doanhthu
            // 
            this.bt_doanhthu.FlatAppearance.BorderSize = 0;
            this.bt_doanhthu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.bt_doanhthu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_doanhthu.Font = new System.Drawing.Font("Century Schoolbook", 13.2F);
            this.bt_doanhthu.ForeColor = System.Drawing.Color.White;
            this.bt_doanhthu.Image = ((System.Drawing.Image)(resources.GetObject("bt_doanhthu.Image")));
            this.bt_doanhthu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_doanhthu.Location = new System.Drawing.Point(5, 342);
            this.bt_doanhthu.Name = "bt_doanhthu";
            this.bt_doanhthu.Size = new System.Drawing.Size(255, 51);
            this.bt_doanhthu.TabIndex = 1;
            this.bt_doanhthu.Text = "Doanh thu";
            this.toolTip1.SetToolTip(this.bt_doanhthu, "Doanh thu");
            this.bt_doanhthu.UseVisualStyleBackColor = true;
            this.bt_doanhthu.Click += new System.EventHandler(this.button4_Click);
            // 
            // bt_Gia
            // 
            this.bt_Gia.FlatAppearance.BorderSize = 0;
            this.bt_Gia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.bt_Gia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Gia.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Gia.ForeColor = System.Drawing.Color.White;
            this.bt_Gia.Image = ((System.Drawing.Image)(resources.GetObject("bt_Gia.Image")));
            this.bt_Gia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Gia.Location = new System.Drawing.Point(5, 285);
            this.bt_Gia.Name = "bt_Gia";
            this.bt_Gia.Size = new System.Drawing.Size(255, 51);
            this.bt_Gia.TabIndex = 1;
            this.bt_Gia.Text = "Kiểm tra giá";
            this.toolTip1.SetToolTip(this.bt_Gia, "Kiểm tra giá");
            this.bt_Gia.UseVisualStyleBackColor = true;
            this.bt_Gia.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_DanhMuc
            // 
            this.button_DanhMuc.FlatAppearance.BorderSize = 0;
            this.button_DanhMuc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.button_DanhMuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DanhMuc.Font = new System.Drawing.Font("Century Schoolbook", 13.2F);
            this.button_DanhMuc.ForeColor = System.Drawing.Color.White;
            this.button_DanhMuc.Image = ((System.Drawing.Image)(resources.GetObject("button_DanhMuc.Image")));
            this.button_DanhMuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_DanhMuc.Location = new System.Drawing.Point(5, 228);
            this.button_DanhMuc.Name = "button_DanhMuc";
            this.button_DanhMuc.Size = new System.Drawing.Size(255, 51);
            this.button_DanhMuc.TabIndex = 1;
            this.button_DanhMuc.Text = "Danh mục";
            this.toolTip1.SetToolTip(this.button_DanhMuc, "Danh mục");
            this.button_DanhMuc.UseVisualStyleBackColor = true;
            this.button_DanhMuc.Click += new System.EventHandler(this.button_DanhMuc_Click);
            // 
            // danhMucAd2
            // 
            this.danhMucAd2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.danhMucAd2.Location = new System.Drawing.Point(0, 0);
            this.danhMucAd2.Name = "danhMucAd2";
            this.danhMucAd2.Size = new System.Drawing.Size(1227, 808);
            this.danhMucAd2.TabIndex = 6;
            // 
            // doanhThuAd1
            // 
            this.doanhThuAd1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.doanhThuAd1.Location = new System.Drawing.Point(0, 0);
            this.doanhThuAd1.Name = "doanhThuAd1";
            this.doanhThuAd1.Size = new System.Drawing.Size(1227, 808);
            this.doanhThuAd1.TabIndex = 5;
            // 
            // nhanVienAdMa1
            // 
            this.nhanVienAdMa1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nhanVienAdMa1.Location = new System.Drawing.Point(0, 0);
            this.nhanVienAdMa1.Name = "nhanVienAdMa1";
            this.nhanVienAdMa1.Size = new System.Drawing.Size(1227, 808);
            this.nhanVienAdMa1.TabIndex = 3;
            // 
            // nhapXuatAdMa1
            // 
            this.nhapXuatAdMa1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nhapXuatAdMa1.Location = new System.Drawing.Point(0, 0);
            this.nhapXuatAdMa1.Name = "nhapXuatAdMa1";
            this.nhapXuatAdMa1.Size = new System.Drawing.Size(1227, 808);
            this.nhapXuatAdMa1.TabIndex = 1;
            // 
            // sanPhamAdMa1
            // 
            this.sanPhamAdMa1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sanPhamAdMa1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sanPhamAdMa1.Location = new System.Drawing.Point(0, 0);
            this.sanPhamAdMa1.Name = "sanPhamAdMa1";
            this.sanPhamAdMa1.Size = new System.Drawing.Size(1227, 808);
            this.sanPhamAdMa1.TabIndex = 0;
            // 
            // AdminManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "AdminManager";
            this.Size = new System.Drawing.Size(1500, 808);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button bt_SP;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bt_TTNV;
        private System.Windows.Forms.Button bt_doanhthu;
        private System.Windows.Forms.Button bt_Gia;
        private System.Windows.Forms.Button button_DanhMuc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private SanPhamAdMa sanPhamAdMa1;
        private NhapXuatAdMa nhapXuatAdMa1;
        private NhanVienAdMa nhanVienAdMa1;
        private DoanhThuAd doanhThuAd1;
        private DanhMucAd danhMucAd2;
    }
}
