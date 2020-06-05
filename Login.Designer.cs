namespace GiaoDien
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.bt_resetpass = new System.Windows.Forms.Button();
            this.bt_dangky = new System.Windows.Forms.Button();
            this.checkBox_nhoMK = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_login = new System.Windows.Forms.Button();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.panel_user = new System.Windows.Forms.Panel();
            this.panel_pass = new System.Windows.Forms.Panel();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.pic_pass = new System.Windows.Forms.PictureBox();
            this.pic_user = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer_go = new System.Windows.Forms.Timer(this.components);
            this.timer_back = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic_pass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_resetpass
            // 
            this.bt_resetpass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_resetpass.BackColor = System.Drawing.Color.White;
            this.bt_resetpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_resetpass.ForeColor = System.Drawing.Color.Red;
            this.bt_resetpass.Location = new System.Drawing.Point(250, 605);
            this.bt_resetpass.Name = "bt_resetpass";
            this.bt_resetpass.Size = new System.Drawing.Size(168, 30);
            this.bt_resetpass.TabIndex = 17;
            this.bt_resetpass.Text = "Quên mật khẩu?";
            this.bt_resetpass.UseVisualStyleBackColor = false;
            this.bt_resetpass.Click += new System.EventHandler(this.bt_resetpass_Click);
            // 
            // bt_dangky
            // 
            this.bt_dangky.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_dangky.BackColor = System.Drawing.Color.Fuchsia;
            this.bt_dangky.FlatAppearance.BorderSize = 0;
            this.bt_dangky.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_dangky.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_dangky.ForeColor = System.Drawing.Color.Black;
            this.bt_dangky.Location = new System.Drawing.Point(97, 527);
            this.bt_dangky.Name = "bt_dangky";
            this.bt_dangky.Size = new System.Drawing.Size(321, 36);
            this.bt_dangky.TabIndex = 16;
            this.bt_dangky.Text = "Đăng Ký";
            this.bt_dangky.UseVisualStyleBackColor = false;
            this.bt_dangky.Click += new System.EventHandler(this.bt_dangky_Click);
            // 
            // checkBox_nhoMK
            // 
            this.checkBox_nhoMK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_nhoMK.AutoSize = true;
            this.checkBox_nhoMK.BackColor = System.Drawing.Color.White;
            this.checkBox_nhoMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_nhoMK.ForeColor = System.Drawing.Color.Navy;
            this.checkBox_nhoMK.Location = new System.Drawing.Point(97, 605);
            this.checkBox_nhoMK.Name = "checkBox_nhoMK";
            this.checkBox_nhoMK.Size = new System.Drawing.Size(152, 28);
            this.checkBox_nhoMK.TabIndex = 14;
            this.checkBox_nhoMK.Text = "Nhớ Mật Khẩu";
            this.checkBox_nhoMK.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label1.Location = new System.Drawing.Point(142, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 52);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mobile App";
            // 
            // bt_login
            // 
            this.bt_login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.bt_login.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.bt_login.FlatAppearance.BorderSize = 0;
            this.bt_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_login.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_login.Location = new System.Drawing.Point(97, 447);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(321, 36);
            this.bt_login.TabIndex = 15;
            this.bt_login.Text = "Đăng Nhập";
            this.bt_login.UseVisualStyleBackColor = false;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // txt_user
            // 
            this.txt_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txt_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_user.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.ForeColor = System.Drawing.Color.White;
            this.txt_user.Location = new System.Drawing.Point(136, 260);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(282, 27);
            this.txt_user.TabIndex = 20;
            this.txt_user.Text = "Tài khoản";
            this.txt_user.Click += new System.EventHandler(this.txt_user_Click);
            // 
            // panel_user
            // 
            this.panel_user.BackColor = System.Drawing.Color.White;
            this.panel_user.Location = new System.Drawing.Point(92, 297);
            this.panel_user.Name = "panel_user";
            this.panel_user.Size = new System.Drawing.Size(330, 1);
            this.panel_user.TabIndex = 25;
            // 
            // panel_pass
            // 
            this.panel_pass.BackColor = System.Drawing.Color.White;
            this.panel_pass.Location = new System.Drawing.Point(92, 388);
            this.panel_pass.Name = "panel_pass";
            this.panel_pass.Size = new System.Drawing.Size(330, 1);
            this.panel_pass.TabIndex = 28;
            // 
            // txt_pass
            // 
            this.txt_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txt_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pass.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.ForeColor = System.Drawing.Color.White;
            this.txt_pass.Location = new System.Drawing.Point(136, 351);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(282, 27);
            this.txt_pass.TabIndex = 26;
            this.txt_pass.Text = "Mật khẩu";
            this.txt_pass.Click += new System.EventHandler(this.txt_pass_Click);
            // 
            // pic_pass
            // 
            this.pic_pass.Image = global::GiaoDien.Properties.Resources.padlock_4_32;
            this.pic_pass.Location = new System.Drawing.Point(92, 346);
            this.pic_pass.Name = "pic_pass";
            this.pic_pass.Size = new System.Drawing.Size(38, 36);
            this.pic_pass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_pass.TabIndex = 27;
            this.pic_pass.TabStop = false;
            // 
            // pic_user
            // 
            this.pic_user.Image = global::GiaoDien.Properties.Resources.user_32__1_;
            this.pic_user.Location = new System.Drawing.Point(92, 255);
            this.pic_user.Name = "pic_user";
            this.pic_user.Size = new System.Drawing.Size(38, 36);
            this.pic_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_user.TabIndex = 23;
            this.pic_user.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GiaoDien.Properties.Resources.telephone_symbol_icon_png_clipart_2965774;
            this.pictureBox1.Location = new System.Drawing.Point(219, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // timer_go
            // 
            this.timer_go.Interval = 30;
            this.timer_go.Tick += new System.EventHandler(this.timer_go_Tick);
            // 
            // timer_back
            // 
            this.timer_back.Interval = 10;
            this.timer_back.Tick += new System.EventHandler(this.timer_back_Tick);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(547, 758);
            this.Controls.Add(this.panel_pass);
            this.Controls.Add(this.pic_pass);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.panel_user);
            this.Controls.Add(this.pic_user);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.bt_resetpass);
            this.Controls.Add(this.bt_dangky);
            this.Controls.Add(this.checkBox_nhoMK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_pass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_resetpass;
        private System.Windows.Forms.Button bt_dangky;
        private System.Windows.Forms.CheckBox checkBox_nhoMK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pic_user;
        private System.Windows.Forms.Panel panel_user;
        private System.Windows.Forms.Panel panel_pass;
        private System.Windows.Forms.PictureBox pic_pass;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Timer timer_go;
        private System.Windows.Forms.Timer timer_back;
    }
}