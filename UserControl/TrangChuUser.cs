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
        private List<string> ListMaSP = new List<string>();
        private Get_ListMaSP _getSP;
        List<string> TenDT = new List<string>();
        List<string> MaDT = new List<string>();

        public List<string> ListMaSP1 { get => ListMaSP; set => ListMaSP = value; }
        public Get_ListMaSP GetSP { get => _getSP; set => _getSP = value; }

        public TrangChuUser()
        {
            InitializeComponent();
            SetView();
        }

        private void SetView()
        {
            
           foreach(char i in db.ChiTiet_SP.Select(p => new { p.TenSP}).ToString())
            {
                //listView1.Items.Add(i.ToString());
                //listView1.Items[].ImageIndex = imageList1.Images.Count -1;
            }
            foreach (char i in db.ChiTiet_SP.Select(p => new { p.MaSP }).ToString())
            {
                MaDT.Add(i.ToString());
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            Detail_SP d = new Detail_SP("1",GetKQ);
            d.ShowDialog();
        }
        private void GetKQ(bool kq)
        {
            if (kq == true)
            {
                ListMaSP1.Add("2");
                //string s = "";
                //for (int i = 0; i < ListMaSP.Count; i++) s += ListMaSP[i];                            
                //MessageBox.Show(s);
            }
            this.GetSP(ListMaSP1);
        }
    }
}
