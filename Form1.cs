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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(panel4.Width.ToString() + " " + pictureBox3.Width.ToString());
            if (panel1.Width == 206)
            {
                panel1.Width = 46;
                panel4.Visible = false;
            }
            else
            {
                panel1.Width = 206;
                panel4.Visible = true;
            }
        }
    }
}
