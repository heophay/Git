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
    public partial class Reset_Pass2 : UserControl
    {
        public Reset_Pass2()
        {
            InitializeComponent();
            for (int j = 1; j <= 31; j++)
            {
                cbb_ngay.Items.Add(j);
            }
            cbb_ngay.SelectedIndex = 17;
            for (int k = 1; k <= 12; k++)
            {
                cbb_thang.Items.Add("Tháng" + k);
            }
            cbb_thang.SelectedIndex = 2;

            for (int i = 2020; i >= 1905; i--)
            {
                cbb_nam.Items.Add(i);
            }
            for (int j = 1; j <= 31; j++)
            {
                cbb_ngay.Items.Add(j);
            }
            cbb_nam.SelectedIndex = 21;
        }
        Reset_Pass rp = new Reset_Pass();
        private void bt_yes_Click(object sender, EventArgs e)
        {
            //rp.reset_Pass11.Visible = false;
            //rp.reset_Pass21.Visible = false;
            //rp.reset_Pass31.Visible = true;
        }

        private void bt_no_Click(object sender, EventArgs e)
        {
            //rp.reset_Pass11.Visible = true;
            //rp.reset_Pass21.Visible = false;
            //rp.reset_Pass31.Visible = false;
        }
    }
}
