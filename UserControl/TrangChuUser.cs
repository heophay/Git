using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GiaoDien.Source_Code_CSDL;
using System.IO;
using DACNPM.dll;
namespace GiaoDien
{
    public partial class TrangChuUser : UserControl
    {
        SE_14X db = new SE_14X();
        private List<ItemsGH> ListMaSP = new List<ItemsGH>();
        private Get_ListMaSP _getSP;
        private string _Masp;

        public Get_ListMaSP GetSP { get => _getSP; set => _getSP = value; }
        public string Masp { get => _Masp; set => _Masp = value; }

        public TrangChuUser()
        {
            InitializeComponent();
        }
        public TrangChuUser(Get_ListMaSP Masp)
        {
            InitializeComponent();
            this.GetSP = Masp;
            SetView();
            Show_SP_ListView(List_SP());
        }
        
        private void SetView()
        {
            cbb_thuonghieu.Items.Clear();
            cbb_gia.Items.Clear();
            cbb_thuonghieu.Items.Add("All");
            cbb_gia.Items.Add("All");
            foreach (DanhMuc i in db.DanhMucs)
            {
                cbb_gia.Items.Add(i.TenDM);
            }
           for(int i=1;i<cbb_gia.Items.Count-1;i++)
            {
                for(int j=i+1;j<cbb_gia.Items.Count;j++)
                {
                    if(Cut_Number_Equal(cbb_gia.Items[i].ToString()) >Cut_Number_Equal(cbb_gia.Items[j].ToString()))
                    {
                        string temp = cbb_gia.Items[i].ToString();
                        cbb_gia.Items[i] = cbb_gia.Items[j];
                        cbb_gia.Items[j] = temp;
                    }
                }
            }
            foreach (ChiTiet_SP i in db.ChiTiet_SPs)
            {
                bool kt = true;
                foreach (string j in cbb_thuonghieu.Items)
                {
                    if (i.HangSX == j) kt = false;
                }
                if (kt == true) cbb_thuonghieu.Items.Add(i.HangSX);
            }
            cbb_gia.SelectedIndex = 0;
            cbb_thuonghieu.SelectedIndex = 0;
        }
        private void listView1_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection x = listView_DSSP.SelectedItems;
            Masp = x[0].SubItems[1].Text;
            Detail_SP d = new Detail_SP(Masp, GetKQ);
            d.ShowDialog();
        }
        private void GetKQ(ItemsGH sp)
        {
            this.GetSP(sp);
        }
        public void Show_SP_ListView(List<KT_Gia_NhapXuat> SP)
        {
            listView_DSSP.Items.Clear();
            foreach (KT_Gia_NhapXuat sp in SP)
            {
                imageList1.Images.Add(NVQL.Instance.ByteToImg(sp.ChiTiet_SP.HinhAnh));
                imageList1.ImageSize = new Size(132, 132);
                this.listView_DSSP.View = View.LargeIcon;
                ListViewItem item = new ListViewItem();
                item.Text = sp.ChiTiet_SP.TenSP;
                item.ImageIndex = imageList1.Images.Count-1;
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = sp.MaSP });
                this.listView_DSSP.Items.Add(item);
            }       
            this.listView_DSSP.LargeImageList = imageList1;
        }
        private double Cut_Number_Equal(string item)
        {
            string s = "";
            if(item.Length>15)
            {
                foreach (Char c in item.Substring(9))
                {
                    if (Char.IsDigit(c))
                        s += c;
                }
                return Convert.ToDouble(s)-0.001;
            }
            foreach (Char c in item)
            {
                if (Char.IsDigit(c))
                    s += c;
            }
            return Convert.ToInt32(s);
        }
        private double Cut_Number_Canculate(string item,ref  double x)
        {
            string s = "";
            if (item.Length > 15)
            {
                foreach (Char c in item.Substring(9))
                {
                    if (Char.IsDigit(c))
                        s += c;
                }
                x = Convert.ToInt32(s);
                s = "";
                foreach (Char c in item.Substring(0, 9))
                {
                    if (Char.IsDigit(c))
                        s += c;
                }
                return Convert.ToDouble(s) - 0.001;
            }
            foreach (Char c in item)
            {
                if (Char.IsDigit(c))
                    s += c;
            }
            return Convert.ToInt32(s);
        }
        private List<KT_Gia_NhapXuat> List_SP()
        {
            List<KT_Gia_NhapXuat> List_SP = new List<KT_Gia_NhapXuat>();
            double Gia = 100;
            string HangSX = "";
            double Gia2 = 100;
            if (cbb_gia.SelectedItem.ToString() != "All")
            {
                Gia = Cut_Number_Canculate(cbb_gia.SelectedItem.ToString(),ref Gia2);
            }
            if(cbb_thuonghieu.SelectedItem.ToString()!="All")
            {
                HangSX = cbb_thuonghieu.SelectedItem.ToString();
            }
            //giá =0, hangsx =0 & !=0;
            if (cbb_gia.SelectedIndex == 0)
            {
                foreach (KT_Gia_NhapXuat i in db.KT_Gia_NhapXuats.Where(
                            p =>p.ChiTiet_SP.HangSX.Contains(HangSX)&&
                            p.ChiTiet_SP.TenSP.Contains(txt_search.Text) &&p.GiaBan < Gia * 1000000))
                {
                    List_SP.Add(i);
                }
            }
            else
            {
               if(cbb_gia.SelectedItem.Equals("Dưới 5 triệu"))
                {
                    foreach (KT_Gia_NhapXuat i in db.KT_Gia_NhapXuats.Where(
                       p => p.ChiTiet_SP.TenSP.Contains(txt_search.Text) &&
                       p.ChiTiet_SP.HangSX.Contains(HangSX) && p.GiaBan < Gia * 1000000))
                    {
                        List_SP.Add(i);
                    }
                }
               else
                {
                    foreach (KT_Gia_NhapXuat i in db.KT_Gia_NhapXuats.Where(
                       p => p.ChiTiet_SP.TenSP.Contains(txt_search.Text) &&
                       p.ChiTiet_SP.HangSX.Contains(HangSX) && p.GiaBan < Gia2 * 1000000 && p.GiaBan > Gia * 1000000))
                    {
                        List_SP.Add(i);
                    }
                }
            }
            return List_SP;
        }
        private void bt_search_Click(object sender, EventArgs e)
        {
            Show_SP_ListView(List_SP());
        }
    }
}
