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
        private List<ItemsGH> ListGH = new List<ItemsGH>();
        private string _MaTK;
        private Showdata _RS;

        public string MaTK { get => _MaTK; set => _MaTK = value; }
        public Showdata RS { get => _RS; set => _RS = value; }

        public GioHangUser()
        {
            InitializeComponent();
        }
        public GioHangUser(List<ItemsGH> Masp, string matk,Showdata sender)
        {
            InitializeComponent();
            this.ListGH = Masp;
            this.RS = sender;
            this.MaTK = matk;
            Showsp();
        }
     
        public void Showsp()
        {
            DGV_Giohang.DataSource = "";
            DGV_Giohang.DataSource = ListGH;
        }
        private void button_Lapdonhang_Click(object sender, EventArgs e)
        {
            Detail_LapDH f = new Detail_LapDH(ListGH, this.MaTK,this.RS);
            f.ShowDialog();
        }

        private void button_Tangsoluong_Click(object sender, EventArgs e)
        {
            Change_SoLuong(true);
        }

        private void button_GiamSoLuong_Click(object sender, EventArgs e)
        {
            Change_SoLuong(false);
        }
        public void Change_SoLuong(bool lenh)
        {
            DataGridViewSelectedRowCollection r = DGV_Giohang.SelectedRows;
            if (r.Count == 1)
            {
                int index = -1;
                foreach (ItemsGH i in ListGH)
                {
                    if (r[0].Cells["MaSP"].Value.ToString().Equals(i.MaSP))
                    {
                        index = ListGH.IndexOf(i);
                    }
                }
                if (index != -1)
                {
                    if (lenh) ListGH[index].Soluong += 1;
                    else
                    {
                        if (ListGH[index].Soluong - 1 > 0) ListGH[index].Soluong -= 1;
                        else MessageBox.Show("Số lượng không được nhỏ hơn 1!!!");
                    }
                    ListGH[index].ThanhTien = ListGH[index].Soluong * ListGH[index].Gia;
                    Showsp();
                }
            }
            else MessageBox.Show("Chỉ được chọn 1 sản phẩm!!");
        }

        private void button_XoaSP_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = DGV_Giohang.SelectedRows;
            foreach (DataGridViewRow j in r)
            {
                int index = -1;
                foreach (ItemsGH i in ListGH)
                {
                    if (j.Cells["MaSP"].Value.ToString().Equals(i.MaSP)) index = ListGH.IndexOf(i);
                }
                ListGH.RemoveAt(index);
            }
            Showsp();
        }
    }
}
