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
            ListMaSP.Add(sp);
            this.GetSP(ListMaSP);
        }
        public void Show_SP_ListView(List<KT_Gia_NhapXuat> SP)
        {
            listView_DSSP.Items.Clear();
            foreach (KT_Gia_NhapXuat sp in db.KT_Gia_NhapXuats)
            {
                imageList1.Images.Add(ByteToImg(sp.ChiTiet_SP.HinhAnh));
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
        private Image ByteToImg(string byteString)
        {
            byte[] imgBytes = Convert.FromBase64String(byteString);
            MemoryStream ms = new MemoryStream(imgBytes, 0, imgBytes.Length);
            ms.Write(imgBytes, 0, imgBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }
        private List<KT_Gia_NhapXuat> List_SP()
        {
            List<KT_Gia_NhapXuat> List_SP = new List<KT_Gia_NhapXuat>();
            if (cbb_gia.SelectedIndex == 0 && cbb_thuonghieu.SelectedIndex == 0)
            {
                foreach (KT_Gia_NhapXuat i in db.KT_Gia_NhapXuats)
                {
                    List_SP.Add(i);
                }
            }
            else
            {
                if(cbb_thuonghieu.SelectedIndex>0&&cbb_gia.SelectedIndex>0)
                {
                    string HangSX = cbb_thuonghieu.SelectedItem.ToString();
                    int GiaBan = Convert.ToInt32(cbb_gia.SelectedItem.ToString());
                    foreach (KT_Gia_NhapXuat i in db.KT_Gia_NhapXuats.Where(
                            p => p.ChiTiet_SP.HangSX == HangSX&&p.GiaBan==GiaBan))
                    {
                        List_SP.Add(i);
                    }
                    return List_SP;
                }
                else
                {
                    if (cbb_gia.SelectedIndex > 0)
                    {
                        string HangSX = cbb_thuonghieu.SelectedItem.ToString();
                        foreach (KT_Gia_NhapXuat i in db.KT_Gia_NhapXuats.Where(
                                p => p.ChiTiet_SP.HangSX == HangSX))
                        {
                            List_SP.Add(i);
                        }
                        return List_SP;
                    }
                   else
                    {
                        if (cbb_thuonghieu.SelectedIndex > 0)
                        {
                            int GiaBan = Convert.ToInt32(cbb_gia.SelectedItem.ToString());
                            foreach (KT_Gia_NhapXuat i in db.KT_Gia_NhapXuats.Where(
                                    p => p.GiaBan == GiaBan))
                            {
                                List_SP.Add(i);
                            }
                        }
                        return List_SP;
                    }
                }
                
            }
            return null;
        }
        private void bt_search_Click(object sender, EventArgs e)
        {
            Show_SP_ListView(List_SP());
        }
    }
}
