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
    public partial class SanPhamAdMa : UserControl
    {
        public SanPhamAdMa()
        {
            InitializeComponent();
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            Detail_QLSP d = new Detail_QLSP();
            d.ShowDialog();
        }

        private void button_Sua_Click(object sender, EventArgs e)
        {
            Detail_QLSP d = new Detail_QLSP();
            d.ShowDialog();
        }
    }
}
