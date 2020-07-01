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
            Show_ListGH();
            SetCBB();
        }
        public void SetCBB()
        {
            for (int i = 20; i >= 1; i--)
            {
                domainUpDown1.Items.Add(i);
            }
            if (ListGH.Count > 0) Fill_Soluong(Convert.ToInt32(DGV_Giohang.Rows[0].Cells["Soluong"].Value.ToString()));
        }
        private void Fill_Soluong(int soluong)
        {
            int index = -1;
            for (int i = 0; i < domainUpDown1.Items.Count; i++)
            {
                if (Convert.ToInt32(domainUpDown1.Items[i].ToString()) == soluong) index = i;
            }
            domainUpDown1.SelectedIndex = index;
        }
        public void Show_ListGH()
        {
            DGV_Giohang.DataSource = null;
            DGV_Giohang.DataSource = ListGH;
        }
        private void button_Lapdonhang_Click(object sender, EventArgs e)
        {
            DataGridViewRowCollection r = DGV_Giohang.Rows;
            if(r.Count>0)
            {
                Detail_LapDH f = new Detail_LapDH(ListGH, this.MaTK, this.RS);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Giỏ hàng rỗng chưa thể lập đơn hàng, Vui lòng quay lại mua hàng");
            }
        }
        private void DGV_Giohang_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = DGV_Giohang.SelectedRows;
            if (r.Count != 1)
            {
                domainUpDown1.Text = "";
            }
            else
            {
                Fill_Soluong(Convert.ToInt32(r[0].Cells["Soluong"].Value.ToString()));
            }
        }

        private void btn_ThayDoi_Click(object sender, EventArgs e)
        {
            if(!Change_SoLuong())
            {
                MessageBox.Show("Error!");
            }
        }
        private bool Change_SoLuong()
        {
            try
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
                        if (!Check_Soluong(r[0].Cells["MaSP"].Value.ToString()))
                        {
                            ListGH[index].Soluong = Convert.ToInt32(domainUpDown1.Text);
                            ListGH[index].ThanhTien = ListGH[index].Soluong * ListGH[index].Gia;
                        }
                        Show_ListGH();
                    }
                }
                else
                {
                    if (r.Count > 1) MessageBox.Show("Chỉ được chọn 1 sản phẩm!!");
                    return false;
                }
                return true;
            }catch(Exception)
            {
                return false;
            }
        }
        private bool Check_Soluong(string MaDT)
        {

            KT_Gia_NhapXuat gia = db.KT_Gia_NhapXuats.Where(p => p.MaSP.Equals(MaDT)).FirstOrDefault();
            if (domainUpDown1.Text == "")
            {
                MessageBox.Show("Mời nhập số lượng mua");
                return true;
            }
            foreach (Char c in domainUpDown1.Text)
            {
                if (!Char.IsDigit(c))
                {
                    MessageBox.Show("Ai chơi nhập chữ vô số lượng");
                    return true;
                }
            }
            if (Convert.ToInt32(domainUpDown1.Text) > gia.Soluong)
            {
                MessageBox.Show("Hiện không có đủ số lượng cho sản phẩm này");
                return true;
            }
            if ((Convert.ToInt32(domainUpDown1.Text) > 20) || (Convert.ToInt32(domainUpDown1.Text) < 1))
            {
                MessageBox.Show("Mặt hàng chỉ cho phép mua số lượng từ 1 đến 20");
                return true;
            }
            else return false;
        }
        private bool Xoa_SP_FromGH()
        {
            try
            {
                DataGridViewSelectedRowCollection r = DGV_Giohang.SelectedRows;
                List<ItemsGH> Masp = new List<ItemsGH>();
                if (r.Count > 0)
                {
                    foreach (ItemsGH i in ListGH)
                    {
                        foreach (DataGridViewRow j in r)
                        {
                            if (i.MaSP == j.Cells["MaSP"].Value.ToString())
                            {
                                Masp.Add(i); 
                            }
                           
                        }
                    }
                   foreach(ItemsGH i in Masp)
                    {
                        ListGH.Remove(i);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn 1 hoặc nhiều Row trước khi xóa");
                    return false;
                }
            return true;
        }catch(Exception)
            {
                return false;
            }
}
        private void button_XoaSP_Click(object sender, EventArgs e)
        {
            if(Xoa_SP_FromGH())
            {
                Show_ListGH();
            }
                  
        }
    }
}
