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

namespace GiaoDien
{
    
    public partial class GioHangUser : UserControl
    {
        private string _Ma;
        private List<string> ListSP = new List<string>();
        public GioHangUser()
        {
            InitializeComponent();
            
        }
        public GioHangUser(string MaSP)
        {
            InitializeComponent();
            this.Ma = MaSP;
            MessageBox.Show("OK");
            kt();
        }

        public void kt()
        {
            ListSP.Add(this.Ma);
            MessageBox.Show(ListSP.Count.ToString());
        }
        public string Ma { get => _Ma; set => _Ma = value; }

        private void button_Lapdonhang_Click(object sender, EventArgs e)
        {
            Detail_LapDH f = new Detail_LapDH();
            f.ShowDialog();
        }
       
    }
}
