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
        private List<string> ListMaSP = new List<string>();
        private Get_ListMaSP _getSP;

        public Get_ListMaSP GetSP { get => _getSP; set => _getSP = value; }

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
            Detail_SP d = new Detail_SP("2",GetKQ);
            d.ShowDialog();
        }
        private void GetKQ(bool kq)
        {
            if (kq == true)
            {
                ListMaSP.Add("2");
                //string s = "";
                //for (int i = 0; i < ListMaSP.Count; i++) s += ListMaSP[i];                            
                //MessageBox.Show(s);
            }
            this.GetSP(ListMaSP);
        }
    }
}
