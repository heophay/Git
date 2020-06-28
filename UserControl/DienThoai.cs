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
    public partial class DienThoai : UserControl
    {
        private string Value;
        private string _txt;
        public DienThoai()
        {
            InitializeComponent();
        }
        public string Value1 { get => Value; set => Value = value; }
        public string Txt { get => _txt; set => _txt = value; }

        private void tendt_Click(object sender, EventArgs e)
        {
            Detail_SP d = new Detail_SP("1");
            d.ShowDialog();
        }
    }
}
