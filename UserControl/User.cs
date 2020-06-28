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
    public delegate void Get_ListMaSP(List<string> Masp);
    public partial class User : UserControl
    {
        public delegate void Get();
        private Get _d;
        private string _LoaiTK="";
        public string LoaiTK { get => _LoaiTK; set => _LoaiTK = value; }
        public Get D { get => _d; set => _d = value; }

        public User()
        {
            InitializeComponent();
            panel1.Controls.Clear();
            panel1.Controls.Add(new TrangChuUser());
        }
        private void button_DngNhap_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            Login l = new Login(SetValue);
            l.ShowDialog();
        }
        public void SetValue(string value)
        {
            LoaiTK= value;
        }
        private void button_DangKi_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            r.ShowDialog();
        }

        private void button_TrangChu_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new TrangChuUser());
        }

        private void button_TaiKhoan_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new TaiKhoanUser());
        }

        private void button_GioHang_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new GioHangUser());
        }

        private void button_DonHang_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new DonHangCus());
        }
    }
}
