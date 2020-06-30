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
    public partial class DonHangCus : UserControl
    {
        private string _MaTK;

        public DonHangCus(string matk)
        {
            InitializeComponent();
            this.MaTK = matk;
            ShowDTGV();
        }
        SE_14X db = new SE_14X();
        //SE_14 db = new SE_14();

        public string MaTK { get => _MaTK; set => _MaTK = value; }

        private void ShowDTGV()
        {
            DGV_Donhang.DataSource = db.DonHangs.Where(p => p.MaTK == this.MaTK).Select(p => new { p.MaDonHang, p.NgayTao, p.NgayThanhToan, p.UuDai, p.TrangThai }).ToList();
        }
        private void button_Xemdonhang_Click(object sender, EventArgs e)
        {
            List<ItemsGH> listsp = new List<ItemsGH>();

            Detail_LapDH f = new Detail_LapDH();
            f.ShowDialog();
        }

        private void button_XoaDonHang_Click(object sender, EventArgs e)
        {

        }
    }
}
