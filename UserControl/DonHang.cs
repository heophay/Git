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
    public partial class DonHang : UserControl
    {
        public DonHang()
        {
            InitializeComponent();
            ShowDTGV();
        }
        SE_14 db = new SE_14();
        private void ShowDTGV()
        {
            DGV_Donhang.DataSource=db.TaiKhoans.Select(p => new { p.MaTK, p.TenTK, p.Pass, p.LoaiTK }).ToList();
        }
    }
}
