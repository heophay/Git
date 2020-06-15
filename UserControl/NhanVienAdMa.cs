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
    public partial class NhanVienAdMa : UserControl
    {
        SE_14F db = new SE_14F();
        public NhanVienAdMa()
        {
            InitializeComponent();
            SetView();
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            Detail_NV d = new Detail_NV();
            d.ShowDialog();
        }

        private void button_Sua_Click(object sender, EventArgs e)
        {
            Detail_NV d = new Detail_NV();
            d.ShowDialog();
        }
        public void SetView()
        {
            DGV_NV.DataSource = db.Theodoi_NVs.Select(p => new { p.MaTK, p.TaiKhoan.TenTK, p.TenNV, p.NgaySinh, p.SoDT, p.DiaChi, p.Gender }).ToList();
        }
    }
}
