using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GiaoDien.Detail_Form;

namespace GiaoDien
{
    
    public partial class GioHangUser : UserControl
    {
        SE_14 db = new SE_14();
        private List<string> ListSP = new List<string>();
        private string _MaTK;

        public string MaTK { get => _MaTK; set => _MaTK = value; }

        public GioHangUser()
        {
            InitializeComponent();
        }
        public GioHangUser(List<string> Masp, string matk)
        {
            InitializeComponent();
            this.ListSP = Masp;
            this.MaTK = matk;
            Showsp();
        }

        public List<ItemsGH> Get_ListCTSP()
        {
            List<ItemsGH> sp = new List<ItemsGH>();
            foreach (string i in ListSP)
            {
                ChiTiet_SP temp = db.ChiTiet_SP.Where(p => p.MaSP.Contains(i)).FirstOrDefault();
                KT_Gia_NhapXuat gia = db.KT_Gia_NhapXuat.Where(p => p.MaSP.Contains(i)).FirstOrDefault();
                ItemsGH t = new ItemsGH();
                t.MaSP = temp.MaSP;
                t.TenSP = temp.TenSP;
                t.Soluong = 1;
                t.Gia = gia.GiaBan;
                t.ThanhTien = t.Soluong * t.Gia;
                sp.Add(t);
            }
            return sp;

        }

        public void Showsp()
        {
            DGV_Giohang.DataSource = Get_ListCTSP();
        }
        private void button_Lapdonhang_Click(object sender, EventArgs e)
        {
            Detail_LapDH f = new Detail_LapDH(Get_ListCTSP(), this.MaTK);
            f.ShowDialog();
        }

        private void button_Tangsoluong_Click(object sender, EventArgs e)
        {

        }

        private void button_GiamSoLuong_Click(object sender, EventArgs e)
        {

        }
    }
}
