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
using GiaoDien.Source_Code_CSDL;
namespace GiaoDien
{
    
    public partial class GioHangUser : UserControl
    {
        SE_14X db = new SE_14X();
        //SE_14 db = new SE_14();
        private List<ItemsGH> ListGH = new List<ItemsGH>();
        private string _MaTK;

        public string MaTK { get => _MaTK; set => _MaTK = value; }

        public GioHangUser()
        {
            InitializeComponent();
        }
        public GioHangUser(List<ItemsGH> Masp, string matk)
        {
            InitializeComponent();
            this.ListGH = Masp;
            this.MaTK = matk;
            Showsp();
        }

        /*public List<ItemsGH> Get_ListCTSP()
        {
            List<ItemsGH> sp = new List<ItemsGH>();
            foreach (string i in ListGH)
            {
                ChiTiet_SP temp = db.ChiTiet_SPs.Where(p => p.MaSP.Contains(i)).FirstOrDefault();
                KT_Gia_NhapXuat gia = db.KT_Gia_NhapXuats.Where(p => p.MaSP.Contains(i)).FirstOrDefault();
                ItemsGH t = new ItemsGH();
                t.MaSP = temp.MaSP;
                t.TenSP = temp.TenSP;
                t.Soluong = 1;
                t.Gia = gia.GiaBan;
                t.ThanhTien = t.Soluong * t.Gia;
                sp.Add(t);
            }
            return sp;
            
        }*/

        public void Showsp()
        {
            DGV_Giohang.DataSource = ListGH;
        }
        private void button_Lapdonhang_Click(object sender, EventArgs e)
        {
            Detail_LapDH f = new Detail_LapDH(ListGH, this.MaTK);
            f.ShowDialog();
        }

        private void button_Tangsoluong_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = DGV_Giohang.SelectedRows;
            int x = Convert.ToInt32(r[0].Cells["Soluong"].Value.ToString());
            x++;
            r[0].Cells["Soluong"].Value = x;
            int index = -1;
            foreach (ItemsGH i in ListGH)
            {
                if (r[0].Cells["MaSP"].Value.ToString().Equals(i.MaSP))
                {
                    index = ListGH.IndexOf(i);
                }
            }
            if (index != -1) ListGH[index].Soluong += 1;
            ListGH[index].ThanhTien = ListGH[index].Soluong * ListGH[index].Gia;
        }

        private void button_GiamSoLuong_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = DGV_Giohang.SelectedRows;
            int x = Convert.ToInt32(r[0].Cells["Soluong"].Value.ToString());
            x--;
            r[0].Cells["Soluong"].Value = x;
            int index = -1;
            foreach (ItemsGH i in ListGH)
            {
                if (r[0].Cells["MaSP"].Value.ToString().Equals(i.MaSP))
                {
                    index = ListGH.IndexOf(i);
                }
            }
            if (index != -1) ListGH[index].Soluong -= 1;
            ListGH[index].ThanhTien = ListGH[index].Soluong * ListGH[index].Gia;
        }
    }
}
