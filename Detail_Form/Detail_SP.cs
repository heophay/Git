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
    public partial class Detail_SP : Form
    {
        public Detail_SP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oke");
        }

        private void tabItem1_Click(object sender, EventArgs e)
        {
            //Main_User f = new Main_User();
            this.Visible = false;
            //f.ShowDialog();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Oke");
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_gia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_xuatxu_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
