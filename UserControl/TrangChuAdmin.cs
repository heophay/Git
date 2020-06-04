using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien
{
    public partial class AdminManager : UserControl
    {
        public AdminManager()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sanPhamAdMa1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nhapXuatAdMa1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nhanVienAdMa1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            doanhThuAd1.BringToFront();
        }

        private void button_DanhMuc_Click(object sender, EventArgs e)
        {
            danhMucAd2.BringToFront();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(panel1.Width.ToString());
            if (panel1.Width == 205)
            {
                panel1.Width = 45;
            }
            else
            {
                panel1.Width = 205;

            }
        }
    }
}
