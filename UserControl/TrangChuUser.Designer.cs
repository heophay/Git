namespace GiaoDien
{
    partial class TrangChuUser
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Product1", 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Product2", 0);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Product3", 0);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Product4", 0);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Product5", 0);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Product6", 0);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChuUser));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_TimKiem = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label_Gia = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label_ThuongHieu = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label_TimTheo = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.label_TimKiem);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1228, 129);
            this.panel2.TabIndex = 1;
            // 
            // label_TimKiem
            // 
            this.label_TimKiem.AutoSize = true;
            this.label_TimKiem.BackColor = System.Drawing.Color.Gray;
            this.label_TimKiem.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.label_TimKiem.ForeColor = System.Drawing.Color.White;
            this.label_TimKiem.Location = new System.Drawing.Point(332, 84);
            this.label_TimKiem.Name = "label_TimKiem";
            this.label_TimKiem.Size = new System.Drawing.Size(103, 27);
            this.label_TimKiem.TabIndex = 2;
            this.label_TimKiem.Text = "Tìm kiếm";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(450, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(476, 22);
            this.textBox1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.comboBox2);
            this.panel3.Controls.Add(this.label_Gia);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.label_ThuongHieu);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1228, 62);
            this.panel3.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(802, 20);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(294, 24);
            this.comboBox2.TabIndex = 3;
            // 
            // label_Gia
            // 
            this.label_Gia.AutoSize = true;
            this.label_Gia.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.label_Gia.Location = new System.Drawing.Point(750, 19);
            this.label_Gia.Name = "label_Gia";
            this.label_Gia.Size = new System.Drawing.Size(46, 27);
            this.label_Gia.TabIndex = 2;
            this.label_Gia.Text = "Giá";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(353, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(261, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // label_ThuongHieu
            // 
            this.label_ThuongHieu.AutoSize = true;
            this.label_ThuongHieu.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.label_ThuongHieu.Location = new System.Drawing.Point(212, 19);
            this.label_ThuongHieu.Name = "label_ThuongHieu";
            this.label_ThuongHieu.Size = new System.Drawing.Size(134, 27);
            this.label_ThuongHieu.TabIndex = 2;
            this.label_ThuongHieu.Text = "Thương hiệu";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.IndianRed;
            this.panel5.Controls.Add(this.label_TimTheo);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(163, 62);
            this.panel5.TabIndex = 1;
            // 
            // label_TimTheo
            // 
            this.label_TimTheo.AutoSize = true;
            this.label_TimTheo.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TimTheo.ForeColor = System.Drawing.Color.White;
            this.label_TimTheo.Location = new System.Drawing.Point(34, 19);
            this.label_TimTheo.Name = "label_TimTheo";
            this.label_TimTheo.Size = new System.Drawing.Size(98, 27);
            this.label_TimTheo.TabIndex = 0;
            this.label_TimTheo.Text = "Tìm theo";
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(0, 129);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1228, 679);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "10044940_DTDD_SAMSUNG_SM-A715FDS-128GB-DEN_01_96en-r2.jpg");
            // 
            // TrangChuUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel2);
            this.Name = "TrangChuUser";
            this.Size = new System.Drawing.Size(1228, 808);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_TimKiem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label_Gia;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label_ThuongHieu;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label_TimTheo;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageList1;
    }
}
