using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien
{
    public partial class Detail_Gia : Form
    {
        public Detail_Gia()
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

        private void cbb_thang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbb_nam_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
