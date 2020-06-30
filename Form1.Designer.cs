namespace GiaoDien
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pic_byte = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.byte_pic = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.bt_pic = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(92, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(621, 227);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(139, 282);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(543, 22);
            this.textBox1.TabIndex = 1;
            // 
            // pic_byte
            // 
            this.pic_byte.Location = new System.Drawing.Point(13, 358);
            this.pic_byte.Name = "pic_byte";
            this.pic_byte.Size = new System.Drawing.Size(75, 75);
            this.pic_byte.TabIndex = 2;
            this.pic_byte.Text = "byte sang hình ảnh";
            this.pic_byte.UseVisualStyleBackColor = true;
            this.pic_byte.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(139, 335);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(520, 146);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // byte_pic
            // 
            this.byte_pic.Location = new System.Drawing.Point(13, 565);
            this.byte_pic.Name = "byte_pic";
            this.byte_pic.Size = new System.Drawing.Size(75, 76);
            this.byte_pic.TabIndex = 4;
            this.byte_pic.Text = "hình ảnh sang byte";
            this.byte_pic.UseVisualStyleBackColor = true;
            this.byte_pic.Click += new System.EventHandler(this.button2_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(139, 514);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(520, 166);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // bt_pic
            // 
            this.bt_pic.Location = new System.Drawing.Point(790, 281);
            this.bt_pic.Name = "bt_pic";
            this.bt_pic.Size = new System.Drawing.Size(75, 23);
            this.bt_pic.TabIndex = 6;
            this.bt_pic.Text = "Chọn hình ảnh";
            this.bt_pic.UseVisualStyleBackColor = true;
            this.bt_pic.Click += new System.EventHandler(this.button3_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(732, 382);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 725);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bt_pic);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.byte_pic);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pic_byte);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button pic_byte;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button byte_pic;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button bt_pic;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}