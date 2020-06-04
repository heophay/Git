namespace GiaoDien
{
    partial class Reset_Pass
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reset31 = new GiaoDien.Reset3();
            this.reset21 = new GiaoDien.Reset2();
            this.reset11 = new GiaoDien.Reset1();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bt_dangnhap = new System.Windows.Forms.Button();
            this.bt_no = new System.Windows.Forms.Button();
            this.bt_yes = new System.Windows.Forms.Button();
            this.bt_search = new System.Windows.Forms.Button();
            this.bt_huy = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(848, 100);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(848, 100);
            this.button1.TabIndex = 1;
            this.button1.Text = "Mobile App";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reset31);
            this.panel2.Controls.Add(this.reset21);
            this.panel2.Controls.Add(this.reset11);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(848, 499);
            this.panel2.TabIndex = 1;
            // 
            // reset31
            // 
            this.reset31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reset31.Location = new System.Drawing.Point(0, 0);
            this.reset31.Name = "reset31";
            this.reset31.Size = new System.Drawing.Size(848, 408);
            this.reset31.TabIndex = 20;
            // 
            // reset21
            // 
            this.reset21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reset21.Location = new System.Drawing.Point(0, 0);
            this.reset21.Name = "reset21";
            this.reset21.Size = new System.Drawing.Size(848, 408);
            this.reset21.TabIndex = 19;
            // 
            // reset11
            // 
            this.reset11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reset11.Location = new System.Drawing.Point(0, 0);
            this.reset11.Name = "reset11";
            this.reset11.Size = new System.Drawing.Size(848, 408);
            this.reset11.TabIndex = 18;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bt_dangnhap);
            this.groupBox3.Controls.Add(this.bt_no);
            this.groupBox3.Controls.Add(this.bt_yes);
            this.groupBox3.Controls.Add(this.bt_search);
            this.groupBox3.Controls.Add(this.bt_huy);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 408);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(848, 91);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            // 
            // bt_dangnhap
            // 
            this.bt_dangnhap.BackColor = System.Drawing.Color.Blue;
            this.bt_dangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_dangnhap.ForeColor = System.Drawing.Color.White;
            this.bt_dangnhap.Location = new System.Drawing.Point(324, 24);
            this.bt_dangnhap.Name = "bt_dangnhap";
            this.bt_dangnhap.Size = new System.Drawing.Size(138, 37);
            this.bt_dangnhap.TabIndex = 14;
            this.bt_dangnhap.Text = "Đăng nhập";
            this.bt_dangnhap.UseVisualStyleBackColor = false;
            this.bt_dangnhap.Click += new System.EventHandler(this.bt_huy_Click);
            // 
            // bt_no
            // 
            this.bt_no.BackColor = System.Drawing.Color.White;
            this.bt_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_no.Location = new System.Drawing.Point(672, 24);
            this.bt_no.Name = "bt_no";
            this.bt_no.Size = new System.Drawing.Size(155, 37);
            this.bt_no.TabIndex = 13;
            this.bt_no.Text = "Không phải tôi?";
            this.bt_no.UseVisualStyleBackColor = false;
            this.bt_no.Click += new System.EventHandler(this.bt_no_Click);
            // 
            // bt_yes
            // 
            this.bt_yes.BackColor = System.Drawing.Color.Blue;
            this.bt_yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_yes.ForeColor = System.Drawing.Color.White;
            this.bt_yes.Location = new System.Drawing.Point(528, 24);
            this.bt_yes.Name = "bt_yes";
            this.bt_yes.Size = new System.Drawing.Size(138, 37);
            this.bt_yes.TabIndex = 12;
            this.bt_yes.Text = "Chính là tôi";
            this.bt_yes.UseVisualStyleBackColor = false;
            this.bt_yes.Click += new System.EventHandler(this.bt_yes_Click);
            // 
            // bt_search
            // 
            this.bt_search.BackColor = System.Drawing.Color.Blue;
            this.bt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_search.ForeColor = System.Drawing.Color.White;
            this.bt_search.Location = new System.Drawing.Point(19, 23);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(121, 36);
            this.bt_search.TabIndex = 10;
            this.bt_search.Text = "Tìm kiếm";
            this.bt_search.UseVisualStyleBackColor = false;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // bt_huy
            // 
            this.bt_huy.BackColor = System.Drawing.Color.White;
            this.bt_huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_huy.Location = new System.Drawing.Point(146, 23);
            this.bt_huy.Name = "bt_huy";
            this.bt_huy.Size = new System.Drawing.Size(121, 36);
            this.bt_huy.TabIndex = 11;
            this.bt_huy.Text = "Hủy";
            this.bt_huy.UseVisualStyleBackColor = false;
            this.bt_huy.Click += new System.EventHandler(this.bt_huy_Click);
            // 
            // Reset_Pass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 599);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Reset_Pass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reset_Pass";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.Button bt_huy;
        private System.Windows.Forms.Button bt_no;
        private System.Windows.Forms.Button bt_yes;
        private System.Windows.Forms.Button bt_dangnhap;
        private Reset1 reset11;
        private Reset3 reset31;
        private Reset2 reset21;
    }
}