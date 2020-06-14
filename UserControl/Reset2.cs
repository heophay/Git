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
    public partial class Reset2 : UserControl
    {
        public Reset2()
        {
            InitializeComponent();
            for(int i=1;i<=31;i++)
            {
                cbb_ngay.Items.Add(i);
            }
            for(int j=1;j<=12;j++)
            {
                cbb_thang.Items.Add("Tháng " + j);
            }
            cbb_ngay.SelectedIndex = 17;
            cbb_thang.SelectedIndex = 2;

            for (int i = 2020; i >= 1905; i--)
            {
                cbb_nam.Items.Add(i);
            }
            cbb_nam.SelectedIndex = 21;
        }
    }
}
