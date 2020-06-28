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
        
        private string _Madt;
        public GioHangUser()
        {
            InitializeComponent();
        }

        public GioHangUser(string MaDT)
        {
            Madt = MaDT;
            InitializeComponent();
        }
        private void ShowDTGV()
        {
            DGV_Giohang.DataSource = db.ChiTiet_SP.Where(p => p.MaSP == Madt).Select(p => p).ToList();
        }
        public string Madt { get => _Madt; set => _Madt = value; }

        private void button_Lapdonhang_Click(object sender, EventArgs e)
        {
            Detail_LapDH f = new Detail_LapDH();
            f.ShowDialog();
        }

       
    }
}
