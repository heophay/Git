namespace GiaoDien
{
    partial class Register
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
            this.bt_dangky = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbb_nam = new System.Windows.Forms.ComboBox();
            this.cbb_thang = new System.Windows.Forms.ComboBox();
            this.cbb_ngay = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tk = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_confirm = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.label_notice = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_dangky
            // 
            this.bt_dangky.BackColor = System.Drawing.Color.ForestGreen;
            this.bt_dangky.FlatAppearance.BorderSize = 0;
            this.bt_dangky.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_dangky.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_dangky.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_dangky.Location = new System.Drawing.Point(100, 670);
            this.bt_dangky.Name = "bt_dangky";
            this.bt_dangky.Size = new System.Drawing.Size(141, 49);
            this.bt_dangky.TabIndex = 34;
            this.bt_dangky.Text = "Đăng Ký";
            this.bt_dangky.UseVisualStyleBackColor = false;
            this.bt_dangky.Click += new System.EventHandler(this.bt_dangky_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbb_nam);
            this.groupBox2.Controls.Add(this.cbb_thang);
            this.groupBox2.Controls.Add(this.cbb_ngay);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(112, 475);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 79);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ngày sinh";
            // 
            // cbb_nam
            // 
            this.cbb_nam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbb_nam.Font = new System.Drawing.Font("Arial", 10.8F);
            this.cbb_nam.FormattingEnabled = true;
            this.cbb_nam.IntegralHeight = false;
            this.cbb_nam.Items.AddRange(new object[] {
            "Năm"});
            this.cbb_nam.Location = new System.Drawing.Point(196, 31);
            this.cbb_nam.MaxDropDownItems = 19;
            this.cbb_nam.Name = "cbb_nam";
            this.cbb_nam.Size = new System.Drawing.Size(79, 29);
            this.cbb_nam.TabIndex = 2;
            // 
            // cbb_thang
            // 
            this.cbb_thang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbb_thang.Font = new System.Drawing.Font("Arial", 10.8F);
            this.cbb_thang.FormattingEnabled = true;
            this.cbb_thang.Items.AddRange(new object[] {
            "Tháng 1",
            "Tháng 2",
            "Tháng 3",
            "Tháng 4",
            "Tháng 5",
            "Tháng 6",
            "Tháng 7",
            "Tháng 8",
            "Tháng 9",
            "Tháng 10",
            "Tháng 11",
            "Tháng 12"});
            this.cbb_thang.Location = new System.Drawing.Point(76, 31);
            this.cbb_thang.Name = "cbb_thang";
            this.cbb_thang.Size = new System.Drawing.Size(114, 29);
            this.cbb_thang.TabIndex = 1;
            // 
            // cbb_ngay
            // 
            this.cbb_ngay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbb_ngay.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbb_ngay.Font = new System.Drawing.Font("Arial", 10.8F);
            this.cbb_ngay.FormattingEnabled = true;
            this.cbb_ngay.IntegralHeight = false;
            this.cbb_ngay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cbb_ngay.Location = new System.Drawing.Point(6, 31);
            this.cbb_ngay.MaxDropDownItems = 19;
            this.cbb_ngay.Name = "cbb_ngay";
            this.cbb_ngay.Size = new System.Drawing.Size(63, 29);
            this.cbb_ngay.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(112, 580);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 66);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giới Tính";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(145, 30);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(51, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Nữ";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(28, 30);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(65, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Nam";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label1.Location = new System.Drawing.Point(177, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 44);
            this.label1.TabIndex = 25;
            this.label1.Text = "Đăng Ký";
            // 
            // txt_tk
            // 
            this.txt_tk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_tk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tk.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tk.ForeColor = System.Drawing.Color.Black;
            this.txt_tk.Location = new System.Drawing.Point(97, 90);
            this.txt_tk.MaxLength = 32;
            this.txt_tk.Name = "txt_tk";
            this.txt_tk.Size = new System.Drawing.Size(339, 28);
            this.txt_tk.TabIndex = 35;
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_name.Font = new System.Drawing.Font("Arial", 10.8F);
            this.txt_name.ForeColor = System.Drawing.Color.Black;
            this.txt_name.Location = new System.Drawing.Point(97, 151);
            this.txt_name.MaxLength = 32;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(339, 28);
            this.txt_name.TabIndex = 36;
            // 
            // txt_pass
            // 
            this.txt_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_pass.Font = new System.Drawing.Font("Arial", 10.8F);
            this.txt_pass.ForeColor = System.Drawing.Color.Black;
            this.txt_pass.Location = new System.Drawing.Point(97, 210);
            this.txt_pass.MaxLength = 32;
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(339, 28);
            this.txt_pass.TabIndex = 37;
            // 
            // txt_confirm
            // 
            this.txt_confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_confirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_confirm.Font = new System.Drawing.Font("Arial", 10.8F);
            this.txt_confirm.ForeColor = System.Drawing.Color.Black;
            this.txt_confirm.Location = new System.Drawing.Point(97, 270);
            this.txt_confirm.MaxLength = 32;
            this.txt_confirm.Name = "txt_confirm";
            this.txt_confirm.Size = new System.Drawing.Size(339, 28);
            this.txt_confirm.TabIndex = 38;
            // 
            // txt_sdt
            // 
            this.txt_sdt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_sdt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_sdt.Font = new System.Drawing.Font("Arial", 10.8F);
            this.txt_sdt.ForeColor = System.Drawing.Color.Black;
            this.txt_sdt.Location = new System.Drawing.Point(97, 333);
            this.txt_sdt.MaxLength = 32;
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(339, 28);
            this.txt_sdt.TabIndex = 39;
            // 
            // txt_diachi
            // 
            this.txt_diachi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_diachi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_diachi.Font = new System.Drawing.Font("Arial", 10.8F);
            this.txt_diachi.ForeColor = System.Drawing.Color.Black;
            this.txt_diachi.Location = new System.Drawing.Point(97, 395);
            this.txt_diachi.MaxLength = 32;
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(339, 28);
            this.txt_diachi.TabIndex = 40;
            // 
            // bt_cancel
            // 
            this.bt_cancel.BackColor = System.Drawing.Color.White;
            this.bt_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancel.Location = new System.Drawing.Point(298, 670);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(141, 49);
            this.bt_cancel.TabIndex = 41;
            this.bt_cancel.Text = "Hủy";
            this.bt_cancel.UseVisualStyleBackColor = false;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // label_notice
            // 
            this.label_notice.AutoSize = true;
            this.label_notice.BackColor = System.Drawing.Color.White;
            this.label_notice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_notice.ForeColor = System.Drawing.Color.Red;
            this.label_notice.Location = new System.Drawing.Point(94, 439);
            this.label_notice.Name = "label_notice";
            this.label_notice.Size = new System.Drawing.Size(0, 20);
            this.label_notice.TabIndex = 42;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(547, 758);
            this.Controls.Add(this.label_notice);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.txt_diachi);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.txt_confirm);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_tk);
            this.Controls.Add(this.bt_dangky);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_dangky;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbb_nam;
        private System.Windows.Forms.ComboBox cbb_thang;
        private System.Windows.Forms.ComboBox cbb_ngay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tk;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_confirm;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Label label_notice;
    }
}