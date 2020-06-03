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
    public partial class NhapXuatAdMa : UserControl
    {
        public NhapXuatAdMa()
        {
            InitializeComponent();
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            Detail_Gia d = new Detail_Gia();
            d.ShowDialog();
        }

        private void button_Sua_Click(object sender, EventArgs e)
        {
            Detail_Gia d = new Detail_Gia();
            d.ShowDialog();
        }
    }
}
