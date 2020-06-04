namespace GiaoDien
{
    partial class Main_Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Manager));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox_Out = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.trangChuManager1 = new GiaoDien.TrangChuManager();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Out)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.pictureBox_Out);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1482, 42);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox_Out
            // 
            this.pictureBox_Out.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox_Out.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Out.Image")));
            this.pictureBox_Out.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Out.InitialImage")));
            this.pictureBox_Out.Location = new System.Drawing.Point(1447, 0);
            this.pictureBox_Out.Name = "pictureBox_Out";
            this.pictureBox_Out.Size = new System.Drawing.Size(35, 42);
            this.pictureBox_Out.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Out.TabIndex = 1;
            this.pictureBox_Out.TabStop = false;
            this.pictureBox_Out.Click += new System.EventHandler(this.pictureBox_Out_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.trangChuManager1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1482, 761);
            this.panel2.TabIndex = 2;
            // 
            // trangChuManager1
            // 
            this.trangChuManager1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trangChuManager1.Location = new System.Drawing.Point(0, 0);
            this.trangChuManager1.Name = "trangChuManager1";
            this.trangChuManager1.Size = new System.Drawing.Size(1482, 761);
            this.trangChuManager1.TabIndex = 0;
            // 
            // Main_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 803);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main_Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main_Manager";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Out)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox_Out;
        private System.Windows.Forms.Panel panel2;
        private TrangChuManager trangChuManager1;
    }
}