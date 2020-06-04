namespace GiaoDien
{
    partial class First_Form
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
            this.pn_border = new System.Windows.Forms.Panel();
            this.pn_inside = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_running = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_load = new System.Windows.Forms.Label();
            this.pn_border.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_border
            // 
            this.pn_border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pn_border.Controls.Add(this.pn_inside);
            this.pn_border.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_border.Location = new System.Drawing.Point(0, 628);
            this.pn_border.Name = "pn_border";
            this.pn_border.Size = new System.Drawing.Size(992, 23);
            this.pn_border.TabIndex = 0;
            // 
            // pn_inside
            // 
            this.pn_inside.BackColor = System.Drawing.Color.Blue;
            this.pn_inside.Location = new System.Drawing.Point(3, 3);
            this.pn_inside.Name = "pn_inside";
            this.pn_inside.Size = new System.Drawing.Size(51, 17);
            this.pn_inside.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_running
            // 
            this.label_running.AutoSize = true;
            this.label_running.BackColor = System.Drawing.Color.Blue;
            this.label_running.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_running.ForeColor = System.Drawing.Color.White;
            this.label_running.Location = new System.Drawing.Point(905, 584);
            this.label_running.Name = "label_running";
            this.label_running.Size = new System.Drawing.Size(75, 32);
            this.label_running.TabIndex = 1;
            this.label_running.Text = "10%";
            // 
            // timer2
            // 
            this.timer2.Interval = 350;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::GiaoDien.Properties.Resources.ff;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(992, 628);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label_load
            // 
            this.label_load.AutoSize = true;
            this.label_load.BackColor = System.Drawing.Color.Blue;
            this.label_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_load.ForeColor = System.Drawing.Color.White;
            this.label_load.Location = new System.Drawing.Point(12, 577);
            this.label_load.Name = "label_load";
            this.label_load.Size = new System.Drawing.Size(214, 39);
            this.label_load.TabIndex = 4;
            this.label_load.Text = "Loading data";
            // 
            // First_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(992, 651);
            this.Controls.Add(this.label_load);
            this.Controls.Add(this.label_running);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pn_border);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "First_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "First_Form";
            this.pn_border.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pn_border;
        private System.Windows.Forms.Panel pn_inside;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_running;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_load;
    }
}