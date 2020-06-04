namespace GiaoDien
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.panel_Function = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button_DangKi = new System.Windows.Forms.Button();
            this.button_DngNhap = new System.Windows.Forms.Button();
            this.label_Greeting = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel_Interface = new System.Windows.Forms.Panel();
            this.donHang1 = new GiaoDien.DonHang();
            this.gioHangUser1 = new GiaoDien.GioHangUser();
            this.taiKhoanUser1 = new GiaoDien.TaiKhoanUser();
            this.trangChuUser1 = new GiaoDien.TrangChuUser();
            this.pictureBox_Profile = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button_DonHang = new System.Windows.Forms.Button();
            this.button_GioHang = new System.Windows.Forms.Button();
            this.button_TaiKhoan = new System.Windows.Forms.Button();
            this.button_TrangChu = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pic_selection = new System.Windows.Forms.PictureBox();
            this.panel_Function.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel_Interface.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Profile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_selection)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Function
            // 
            this.panel_Function.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel_Function.Controls.Add(this.pic_selection);
            this.panel_Function.Controls.Add(this.label2);
            this.panel_Function.Controls.Add(this.button_DangKi);
            this.panel_Function.Controls.Add(this.button_DngNhap);
            this.panel_Function.Controls.Add(this.label_Greeting);
            this.panel_Function.Controls.Add(this.pictureBox_Profile);
            this.panel_Function.Controls.Add(this.pictureBox3);
            this.panel_Function.Controls.Add(this.button_DonHang);
            this.panel_Function.Controls.Add(this.button_GioHang);
            this.panel_Function.Controls.Add(this.button_TaiKhoan);
            this.panel_Function.Controls.Add(this.button_TrangChu);
            this.panel_Function.Controls.Add(this.panel4);
            this.panel_Function.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Function.Location = new System.Drawing.Point(0, 0);
            this.panel_Function.Name = "panel_Function";
            this.panel_Function.Size = new System.Drawing.Size(273, 808);
            this.panel_Function.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Jokerman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(72, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 43);
            this.label2.TabIndex = 5;
            this.label2.Text = "Welcome!!";
            // 
            // button_DangKi
            // 
            this.button_DangKi.BackColor = System.Drawing.Color.White;
            this.button_DangKi.FlatAppearance.BorderSize = 0;
            this.button_DangKi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DangKi.Location = new System.Drawing.Point(54, 703);
            this.button_DangKi.Name = "button_DangKi";
            this.button_DangKi.Size = new System.Drawing.Size(166, 37);
            this.button_DangKi.TabIndex = 4;
            this.button_DangKi.Text = "Đăng kí";
            this.button_DangKi.UseVisualStyleBackColor = false;
            this.button_DangKi.Click += new System.EventHandler(this.button_DangKi_Click);
            // 
            // button_DngNhap
            // 
            this.button_DngNhap.BackColor = System.Drawing.Color.White;
            this.button_DngNhap.FlatAppearance.BorderSize = 0;
            this.button_DngNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DngNhap.Location = new System.Drawing.Point(54, 660);
            this.button_DngNhap.Name = "button_DngNhap";
            this.button_DngNhap.Size = new System.Drawing.Size(166, 37);
            this.button_DngNhap.TabIndex = 4;
            this.button_DngNhap.Text = "Đăng nhập";
            this.button_DngNhap.UseVisualStyleBackColor = false;
            this.button_DngNhap.Click += new System.EventHandler(this.button_DngNhap_Click);
            // 
            // label_Greeting
            // 
            this.label_Greeting.AutoSize = true;
            this.label_Greeting.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Greeting.ForeColor = System.Drawing.Color.White;
            this.label_Greeting.Location = new System.Drawing.Point(63, 727);
            this.label_Greeting.Name = "label_Greeting";
            this.label_Greeting.Size = new System.Drawing.Size(136, 27);
            this.label_Greeting.TabIndex = 3;
            this.label_Greeting.Text = "Hi! Customer";
            this.label_Greeting.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Location = new System.Drawing.Point(0, 64);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(269, 84);
            this.panel4.TabIndex = 0;
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
            // panel_Interface
            // 
            this.panel_Interface.Controls.Add(this.donHang1);
            this.panel_Interface.Controls.Add(this.gioHangUser1);
            this.panel_Interface.Controls.Add(this.taiKhoanUser1);
            this.panel_Interface.Controls.Add(this.trangChuUser1);
            this.panel_Interface.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Interface.Location = new System.Drawing.Point(273, 0);
            this.panel_Interface.Name = "panel_Interface";
            this.panel_Interface.Size = new System.Drawing.Size(1227, 808);
            this.panel_Interface.TabIndex = 4;
            // 
            // donHang1
            // 
            this.donHang1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.donHang1.Location = new System.Drawing.Point(0, 0);
            this.donHang1.Name = "donHang1";
            this.donHang1.Size = new System.Drawing.Size(1227, 808);
            this.donHang1.TabIndex = 3;
            // 
            // gioHangUser1
            // 
            this.gioHangUser1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gioHangUser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gioHangUser1.Location = new System.Drawing.Point(0, 0);
            this.gioHangUser1.Name = "gioHangUser1";
            this.gioHangUser1.Size = new System.Drawing.Size(1227, 808);
            this.gioHangUser1.TabIndex = 2;
            // 
            // taiKhoanUser1
            // 
            this.taiKhoanUser1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.taiKhoanUser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taiKhoanUser1.Location = new System.Drawing.Point(0, 0);
            this.taiKhoanUser1.Name = "taiKhoanUser1";
            this.taiKhoanUser1.Size = new System.Drawing.Size(1227, 808);
            this.taiKhoanUser1.TabIndex = 1;
            // 
            // trangChuUser1
            // 
            this.trangChuUser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trangChuUser1.Location = new System.Drawing.Point(0, 0);
            this.trangChuUser1.Name = "trangChuUser1";
            this.trangChuUser1.Size = new System.Drawing.Size(1227, 808);
            this.trangChuUser1.TabIndex = 0;
            // 
            // pictureBox_Profile
            // 
            this.pictureBox_Profile.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Profile.Image")));
            this.pictureBox_Profile.Location = new System.Drawing.Point(68, 587);
            this.pictureBox_Profile.Name = "pictureBox_Profile";
            this.pictureBox_Profile.Size = new System.Drawing.Size(131, 137);
            this.pictureBox_Profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Profile.TabIndex = 2;
            this.pictureBox_Profile.TabStop = false;
            this.pictureBox_Profile.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 49);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // button_DonHang
            // 
            this.button_DonHang.FlatAppearance.BorderSize = 0;
            this.button_DonHang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.button_DonHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DonHang.Font = new System.Drawing.Font("Century Schoolbook", 13.2F);
            this.button_DonHang.ForeColor = System.Drawing.Color.White;
            this.button_DonHang.Image = ((System.Drawing.Image)(resources.GetObject("button_DonHang.Image")));
            this.button_DonHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_DonHang.Location = new System.Drawing.Point(3, 342);
            this.button_DonHang.Name = "button_DonHang";
            this.button_DonHang.Size = new System.Drawing.Size(257, 51);
            this.button_DonHang.TabIndex = 1;
            this.button_DonHang.Text = "Đơn hàng";
            this.toolTip1.SetToolTip(this.button_DonHang, "Đơn hàng");
            this.button_DonHang.UseVisualStyleBackColor = true;
            this.button_DonHang.Click += new System.EventHandler(this.button_DonHang_Click);
            // 
            // button_GioHang
            // 
            this.button_GioHang.FlatAppearance.BorderSize = 0;
            this.button_GioHang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.button_GioHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_GioHang.Font = new System.Drawing.Font("Century Schoolbook", 13.2F);
            this.button_GioHang.ForeColor = System.Drawing.Color.White;
            this.button_GioHang.Image = ((System.Drawing.Image)(resources.GetObject("button_GioHang.Image")));
            this.button_GioHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_GioHang.Location = new System.Drawing.Point(0, 285);
            this.button_GioHang.Name = "button_GioHang";
            this.button_GioHang.Size = new System.Drawing.Size(260, 51);
            this.button_GioHang.TabIndex = 1;
            this.button_GioHang.Text = "Giỏ hàng";
            this.toolTip1.SetToolTip(this.button_GioHang, "Giò hàng");
            this.button_GioHang.UseVisualStyleBackColor = true;
            this.button_GioHang.Click += new System.EventHandler(this.button_GioHang_Click);
            // 
            // button_TaiKhoan
            // 
            this.button_TaiKhoan.FlatAppearance.BorderSize = 0;
            this.button_TaiKhoan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.button_TaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_TaiKhoan.Font = new System.Drawing.Font("Century Schoolbook", 13.2F);
            this.button_TaiKhoan.ForeColor = System.Drawing.Color.White;
            this.button_TaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("button_TaiKhoan.Image")));
            this.button_TaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_TaiKhoan.Location = new System.Drawing.Point(0, 228);
            this.button_TaiKhoan.Name = "button_TaiKhoan";
            this.button_TaiKhoan.Size = new System.Drawing.Size(260, 51);
            this.button_TaiKhoan.TabIndex = 1;
            this.button_TaiKhoan.Text = "Tài khoản";
            this.toolTip1.SetToolTip(this.button_TaiKhoan, "Tài khoản");
            this.button_TaiKhoan.UseVisualStyleBackColor = true;
            this.button_TaiKhoan.Click += new System.EventHandler(this.button_TaiKhoan_Click);
            // 
            // button_TrangChu
            // 
            this.button_TrangChu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_TrangChu.FlatAppearance.BorderSize = 0;
            this.button_TrangChu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.button_TrangChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_TrangChu.Font = new System.Drawing.Font("Century Schoolbook", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_TrangChu.ForeColor = System.Drawing.Color.White;
            this.button_TrangChu.Image = ((System.Drawing.Image)(resources.GetObject("button_TrangChu.Image")));
            this.button_TrangChu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_TrangChu.Location = new System.Drawing.Point(3, 171);
            this.button_TrangChu.Name = "button_TrangChu";
            this.button_TrangChu.Size = new System.Drawing.Size(260, 51);
            this.button_TrangChu.TabIndex = 1;
            this.button_TrangChu.Text = "Trang chủ";
            this.toolTip1.SetToolTip(this.button_TrangChu, "Trang Chủ");
            this.button_TrangChu.UseVisualStyleBackColor = true;
            this.button_TrangChu.Click += new System.EventHandler(this.button_TrangChu_Click);
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
            // pic_selection
            // 
            this.pic_selection.Image = global::GiaoDien.Properties.Resources.saovang;
            this.pic_selection.Location = new System.Drawing.Point(0, 171);
            this.pic_selection.Name = "pic_selection";
            this.pic_selection.Size = new System.Drawing.Size(16, 16);
            this.pic_selection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_selection.TabIndex = 6;
            this.pic_selection.TabStop = false;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_Interface);
            this.Controls.Add(this.panel_Function);
            this.Name = "User";
            this.Size = new System.Drawing.Size(1500, 808);
            this.panel_Function.ResumeLayout(false);
            this.panel_Function.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel_Interface.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Profile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_selection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_Function;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button_DonHang;
        private System.Windows.Forms.Button button_GioHang;
        private System.Windows.Forms.Button button_TaiKhoan;
        private System.Windows.Forms.Button button_TrangChu;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label_Greeting;
        private System.Windows.Forms.PictureBox pictureBox_Profile;
        private System.Windows.Forms.Button button_DngNhap;
        private System.Windows.Forms.Button button_DangKi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_Interface;
        private TaiKhoanUser taiKhoanUser1;
        private TrangChuUser trangChuUser1;
        private GioHangUser gioHangUser1;
        private DonHang donHang1;
        private System.Windows.Forms.PictureBox pic_selection;
    }
}
