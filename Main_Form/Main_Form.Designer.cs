namespace GiaoDien
{
    partial class Main_Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic_signup = new System.Windows.Forms.PictureBox();
            this.pic_login = new System.Windows.Forms.PictureBox();
            this.pic_logout = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_signup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logout)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.pic_signup);
            this.panel1.Controls.Add(this.pic_login);
            this.panel1.Controls.Add(this.pic_logout);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1482, 50);
            this.panel1.TabIndex = 0;
            // 
            // pic_signup
            // 
            this.pic_signup.Dock = System.Windows.Forms.DockStyle.Right;
            this.pic_signup.Image = global::GiaoDien.Properties.Resources.th;
            this.pic_signup.Location = new System.Drawing.Point(1386, 0);
            this.pic_signup.Name = "pic_signup";
            this.pic_signup.Size = new System.Drawing.Size(48, 50);
            this.pic_signup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_signup.TabIndex = 3;
            this.pic_signup.TabStop = false;
            this.toolTip1.SetToolTip(this.pic_signup, "Đăng Ký");
            this.pic_signup.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pic_login
            // 
            this.pic_login.Dock = System.Windows.Forms.DockStyle.Right;
            this.pic_login.Image = global::GiaoDien.Properties.Resources._1436436153_Login_1024x1024;
            this.pic_login.Location = new System.Drawing.Point(1434, 0);
            this.pic_login.Name = "pic_login";
            this.pic_login.Size = new System.Drawing.Size(48, 50);
            this.pic_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_login.TabIndex = 2;
            this.pic_login.TabStop = false;
            this.toolTip1.SetToolTip(this.pic_login, "Đăng nhập");
            this.pic_login.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pic_logout
            // 
            this.pic_logout.Dock = System.Windows.Forms.DockStyle.Left;
            this.pic_logout.Image = global::GiaoDien.Properties.Resources.pngtree_logout__icon_in_trendy_style_isolated_background_png_image_48599071;
            this.pic_logout.Location = new System.Drawing.Point(0, 0);
            this.pic_logout.Name = "pic_logout";
            this.pic_logout.Size = new System.Drawing.Size(48, 50);
            this.pic_logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_logout.TabIndex = 1;
            this.pic_logout.TabStop = false;
            this.toolTip1.SetToolTip(this.pic_logout, "Đăng xuất");
            this.pic_logout.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1482, 761);
            this.panel2.TabIndex = 1;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 811);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main_Form";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_signup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pic_logout;
        private System.Windows.Forms.PictureBox pic_login;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pic_signup;
    }
}