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
    public partial class Reset_Pass3 : UserControl
    {
        public Reset_Pass3()
        {
            InitializeComponent();
        }

        private void bt_dangnhap_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Dispose();
        }
    }
}
