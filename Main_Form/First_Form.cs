using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien
{
    public partial class First_Form : Form
    {
        public First_Form()
        {
            InitializeComponent();
            timer1.Start();
            timer2.Start();
            var a = this.PointToScreen(label_running.Location);
            a = pictureBox1.PointToClient(a);
            label_running.Parent = pictureBox1;
            label_running.Location = a;
            label_running.BackColor = Color.Transparent;

            var b = this.PointToScreen(label_load.Location);
            b = pictureBox1.PointToClient(b);
            label_load.Parent = pictureBox1;
            label_load.Location = b;
            label_load.BackColor = Color.Transparent;
        }
        //Main_User mu = new Main_User();
        int i = 10;
        int tam = 0;
        private void run()
        {
            this.Visible = false;
            //mu.ShowDialog();
            this.Close();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            i += 1;
            pn_inside.Width += 8;
            label_running.Text = "";
            label_running.Text += i.ToString() + "%";
            if(pn_inside.Width>=615 && i>99)
            {
                timer1.Stop();
                run();
            }
           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            tam++;
            label_load.Text += ".";
            if (tam == 4)
            {
                tam = 0;
                label_load.Text = "Loading data.";
            }
        }
    }
}
