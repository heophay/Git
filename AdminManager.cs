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
    public partial class AdminManager : UserControl
    {
        public AdminManager()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sanPhamAdMa1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nhapXuatAdMa1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nhanVienAdMa1.BringToFront();
        }
    }
}
