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
        //public void Tesst()
        //{
        //    listView_DSSP.Items.Clear();
        //    foreach (ChiTiet_SP i in db.ChiTiet_SPs)
        //    {
        //        ListViewItem i1 = new ListViewItem();
        //        i1.Text = i.TenSP;
        //        i1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = i.MaSP });
        //        imageList1.Images.Add(new Bitmap(Application.StartupPath + "\\Images\\" + i.TenSP + ".png"));
        //        i1.ImageIndex = imageList1.Images.Count - 1;
        //        //string x = "SamSung Galaxy A71";

        //        listView_DSSP.Items.Add(i1);
        //    }
        //}
    }
}
