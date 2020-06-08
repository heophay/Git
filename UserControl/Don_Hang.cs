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
    public partial class Don_Hang : UserControl
    {
        public Don_Hang()
        {
            InitializeComponent();
            ShowDTGV();
        }
        SE_14Q db = new SE_14Q();
        private void ShowDTGV()
        {
            DGV_Donhang.DataSource=db.TaiKhoans.Select(p => new { p.MaTK, p.TenTK, p.PassTK, p.LoaiTK }).ToList();
        }

        private void button_Xemdonhang_Click(object sender, EventArgs e)
        {
            Detail_LapDH f = new Detail_LapDH();
            f.ShowDialog();
        }

        private void button_XoaDonHang_Click(object sender, EventArgs e)
        {

        }
    }
}
