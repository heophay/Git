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
            NVQL.Instance.Sort_CBB(cbb_gia.Items.Count, ref cbb_gia);
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

        public KT_Gia_NhapXuat Check_gia(string MaDT)
        {

            KT_Gia_NhapXuat gia = null;
            List<int> songaynn = new List<int>();
            int songay = -1;
            if (db.KT_Gia_NhapXuats.Where(p => p.MaSP.Equals(MaDT)).Count() > 1)
            {
                foreach (KT_Gia_NhapXuat i in db.KT_Gia_NhapXuats.Where(p => p.MaSP.Equals(MaDT)))
                {
                    TimeSpan tsp = DateTime.Now.Subtract(i.NgayApDung);
                    if (tsp.Days >= 0)
                    {
                        songay = tsp.Days;
                        songaynn.Add(tsp.Days);
                    }
                }
                int x = NVQL.Instance.TimSoNN(songaynn);
                foreach (KT_Gia_NhapXuat i in db.KT_Gia_NhapXuats.Where(p => p.MaSP.Equals(MaDT)))
                {
                    if (DateTime.Now.Subtract(i.NgayApDung).Days == x) gia = i;
                }
                return gia;
            }
            else
            {
                gia = db.KT_Gia_NhapXuats.Where(p => p.MaSP.Equals(MaDT)).FirstOrDefault();
                return gia;
            }
        }
        private List<KT_Gia_NhapXuat> List_SP()
        {
            List<KT_Gia_NhapXuat> List_SP = new List<KT_Gia_NhapXuat>();
            double Gia = 100;
            string HangSX = "";
            double Gia2 = 100;
            if (cbb_gia.SelectedItem.ToString() != "All")
            {
                Gia = NVQL.Instance.Cut_Number_Canculate(cbb_gia.SelectedItem.ToString(),ref Gia2);
            }
            if(cbb_thuonghieu.SelectedItem.ToString()!="All")
            {
                HangSX = cbb_thuonghieu.SelectedItem.ToString();
            }
            //giá =0, hangsx =0 & !=0;
            if (cbb_gia.SelectedIndex == 0)
            {
                foreach (ChiTiet_SP i in db.ChiTiet_SPs.Where(
                            p => p.HangSX.Contains(HangSX) &&
                            p.TenSP.Contains(txt_search.Text)))
                {
                    if (Check_gia(i.MaSP).GiaBan < Gia * 1000000) List_SP.Add(Check_gia(i.MaSP));
                }
            }
            else
            {
                if (cbb_gia.SelectedItem.Equals("Dưới 5 triệu"))
                {

                    foreach (ChiTiet_SP i in db.ChiTiet_SPs.Where(
                       p => p.TenSP.Contains(txt_search.Text) &&
                       p.HangSX.Contains(HangSX)))
                    {
                        KT_Gia_NhapXuat gia = Check_gia(i.MaSP);
                        if (gia.GiaBan < Gia * 1000000) List_SP.Add(gia);
                    }
                }
                else
                {

                    foreach (ChiTiet_SP i in db.ChiTiet_SPs.Where(
                       p => p.TenSP.Contains(txt_search.Text) &&
                       p.HangSX.Contains(HangSX)))
                    {
                        KT_Gia_NhapXuat gia = Check_gia(i.MaSP);
                        if (gia.GiaBan < Gia2 * 1000000 && gia.GiaBan > Gia * 1000000) List_SP.Add(gia);
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
