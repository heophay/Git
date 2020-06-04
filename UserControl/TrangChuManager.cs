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
    public partial class TrangChuManager : UserControl
    {
        public TrangChuManager()
        {
            InitializeComponent();
        }

        private void bt_SP_Click(object sender, EventArgs e)
        {
            sanPhamAdMa1.BringToFront();
        }

        private void button_DanhMuc_Click(object sender, EventArgs e)
        {
            danhMucAd1.BringToFront();
        }

        private void bt_Gia_Click(object sender, EventArgs e)
        {
            nhapXuatAdMa1.BringToFront();
        }

        private void bt_TTNV_Click(object sender, EventArgs e)
        {
            taiKhoanUser1.BringToFront();
        }

        private void bt_doanhthu_Click(object sender, EventArgs e)
        {
            manage_User1.BringToFront();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(panel1.Width.ToString());
            if (panel1.Width == 202)
            {
                panel1.Width = 45;
                //button_DangKi.Visible = false;
                //button_DngNhap.Visible = false;
            }
            else
            {
                panel1.Width = 202;
                //button_DangKi.Visible = true;
                //button_DngNhap.Visible = true;

            }
        }
    }
}
