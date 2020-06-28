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
        private List<string> ListMaSP = new List<string>();
        private string _matk;

        public string Matk { get => _matk; set => _matk = value; }

        public User(string Matk)
        {
            this.Matk = Matk;
            InitializeComponent();
            panel1.Controls.Clear();
            TrangChuUser l = new TrangChuUser();
            panel1.Controls.Add(l);
        }
        private void button_TrangChu_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            TrangChuUser l = new TrangChuUser();
            panel1.Controls.Add(l);
        }
        private void button_TaiKhoan_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            TaiKhoanUser l = new TaiKhoanUser(Matk);
            panel1.Controls.Add(l);
        }

        private void button_GioHang_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            GioHangUser l = new GioHangUser(this.ListMaSP,Matk);
            panel1.Controls.Add(l);
        }

        private void button_DonHang_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            DonHangCus l = new DonHangCus();
            panel1.Controls.Add(l);
        }
        public  void Get_Listmasp(List<string> Masp)
        {
            this.ListMaSP = Masp;
        }

        private void User_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            TrangChuUser l = new TrangChuUser(Get_Listmasp);
            panel1.Controls.Add(l);
        }

    }
}
