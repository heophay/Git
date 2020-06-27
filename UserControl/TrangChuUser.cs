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
    public partial class TrangChuUser : UserControl
    {
        SE_14 db = new SE_14();
        List<string> TenDT = new List<string>();
        List<string> MaDT = new List<string>();
        public TrangChuUser()
        {
            InitializeComponent();
            SetView();
        }

        private void SetView()
        {
            
           foreach(char i in db.ChiTiet_SP.Select(p => new { p.TenSP}).ToString())
            {
                TenDT.Add(i.ToString());
            }
            foreach (char i in db.ChiTiet_SP.Select(p => new { p.MaSP }).ToString())
            {
                MaDT.Add(i.ToString());
            }
            dienThoai1.Txt = TenDT[0];
            dienThoai1.Value1 = MaDT[0];
            dienThoai2.Txt = TenDT[1];
            dienThoai2.Value1 = MaDT[1];
            dienThoai3.Txt = TenDT[2];
            dienThoai3.Value1 = MaDT[2];
            dienThoai4.Txt = TenDT[3];
            dienThoai4.Value1 = MaDT[3];
            dienThoai5.Txt = TenDT[4];
            dienThoai5.Value1 = MaDT[4];
            dienThoai6.Txt = TenDT[5];
            dienThoai6.Value1 = MaDT[5];
            dienThoai7.Txt = TenDT[6];
            dienThoai7.Value1 = MaDT[6];
            dienThoai8.Txt = TenDT[7];
            dienThoai8.Value1 = MaDT[7];
        }
        private void dienThoai1_Click(object sender, EventArgs e)
        {
            Detail_SP d = new Detail_SP(((DienThoai)sender).Value1);
            d.ShowDialog();
        }
    }
}
