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
    public partial class User : UserControl
    {
        public User()
        {
            InitializeComponent();
        }

        private void button_DngNhap_Click(object sender, EventArgs e)
        {
            button_DngNhap.Visible = false;
            button_DangKi.Visible = false;
            pictureBox_Profile.Visible = true;
            label_Greeting.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(panel_Function.Width.ToString());
            //273
            //45
            if (panel_Function.Width == 205)
            {
                panel_Function.Width = 45;
                button_DangKi.Visible = false;
                button_DngNhap.Visible = false;
            }
            else
            {
                panel_Function.Width = 205;
                button_DangKi.Visible = true;
                button_DngNhap.Visible = true;
            }
           // if(panel_Function.Width)
        }

        private void button_TrangChu_Click(object sender, EventArgs e)
        {
           trangChuUser1.BringToFront();
        }

        private void button_TaiKhoan_Click(object sender, EventArgs e)
        {
            taiKhoanUser1.BringToFront();
        }

        private void button_GioHang_Click(object sender, EventArgs e)
        {
            gioHangUser1.BringToFront();
        }

        private void button_DonHang_Click(object sender, EventArgs e)
        {
            donHang1.BringToFront();
        }
    }
}
