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
    public partial class Reset_Pass1 : UserControl
    {
        public Reset_Pass1()
        {
            InitializeComponent();
        }
        Reset_Pass rp = new Reset_Pass();
        private void bt_search_Click(object sender, EventArgs e)
        {
            //rp.reset_Pass11.Visible = false;
            //rp.reset_Pass31.Visible = false;
        }

        private void bt_huy_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Dispose();
        }
    }
}
