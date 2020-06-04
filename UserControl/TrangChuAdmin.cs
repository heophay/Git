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
            sanPhamAdMa1.BringToFront();
            pic_selection.Top = bt_SP.Top;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sanPhamAdMa1.BringToFront();
            pic_selection.Top = bt_SP.Top;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nhapXuatAdMa1.BringToFront();
            pic_selection.Top = bt_Gia.Top;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nhanVienAdMa1.BringToFront();
            pic_selection.Top = bt_TTNV.Top;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            doanhThuAd1.BringToFront();
            pic_selection.Top = bt_doanhthu.Top;
        }

        private void button_DanhMuc_Click(object sender, EventArgs e)
        {
            danhMucAd2.BringToFront();
            pic_selection.Top = button_DanhMuc.Top;
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
