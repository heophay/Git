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
        public TrangChuUser()
        {
            InitializeComponent();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            Detail_SP d = new Detail_SP();
            d.ShowDialog();
        }
    }
}
