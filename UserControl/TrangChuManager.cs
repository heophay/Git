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
        private string _Loai;
        public TrangChuManager(string LoaiTK)
        {
            Loai = LoaiTK;
            InitializeComponent();
            if(Loai=="Manager")
            {
                bt_Nhanvien.Visible = false;
            }
            if(Loai == "Admin")
            {
                
                bt_TTCN.Visible = false;
            }
        }

        public string Loai { get => _Loai; set => _Loai = value; }

        private void bt_Gia_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new KT_Gia());
        }

        private void button_DanhMuc_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new DanhMucAd());
        }

        private void bt_KH_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new QLKH());
        }

        private void bt_TTCN_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new TT_NhanVien());
        }

        private void bt_SP_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new QL_SanPham());
        }

        private void bt_Nhanvien_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new TT_NhanVien());
        }
    }
}
