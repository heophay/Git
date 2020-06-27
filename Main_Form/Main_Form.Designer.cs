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
            this.panel1 = new System.Windows.Forms.Panel();
            this.user1 = new GiaoDien.User();
            this.trangChuManager1 = new GiaoDien.TrangChuManager();
            this.trangChuAdmin1 = new GiaoDien.TrangChuAdmin();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1482, 50);
            this.panel1.TabIndex = 0;
            // 
            // user1
            // 
            this.user1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.user1.LoaiTK = null;
            this.user1.Location = new System.Drawing.Point(0, 50);
            this.user1.Name = "user1";
            this.user1.Size = new System.Drawing.Size(1482, 761);
            this.user1.TabIndex = 14;
            // 
            // trangChuManager1
            // 
            this.trangChuManager1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trangChuManager1.Location = new System.Drawing.Point(0, 50);
            this.trangChuManager1.Name = "trangChuManager1";
            this.trangChuManager1.Size = new System.Drawing.Size(1482, 761);
            this.trangChuManager1.TabIndex = 13;
            // 
            // trangChuAdmin1
            // 
            this.trangChuAdmin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trangChuAdmin1.Location = new System.Drawing.Point(0, 50);
            this.trangChuAdmin1.Name = "trangChuAdmin1";
            this.trangChuAdmin1.Size = new System.Drawing.Size(1482, 761);
            this.trangChuAdmin1.TabIndex = 12;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 811);
            this.Controls.Add(this.user1);
            this.Controls.Add(this.trangChuManager1);
            this.Controls.Add(this.trangChuAdmin1);
            this.Controls.Add(this.panel1);
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main_Form";
            this.Activated += new System.EventHandler(this.Main_Form_Activated);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private TrangChuAdmin trangChuAdmin1;
        private TrangChuManager trangChuManager1;
        private User user1;
    }
}