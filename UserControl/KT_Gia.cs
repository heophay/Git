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
    public partial class KT_Gia : UserControl
    {
        SE_14 db = new SE_14();
        public KT_Gia()
        {
            InitializeComponent();
            ShowDTGV();
        }
        private void ShowDTGV()
        {
            DGV_Gia.DataSource = db.KT_Gia_NhapXuat.Select(p => new { p.ID_Gia, p.MaSP, p.GiaNhap, p.GiaBan, p.NgayApDung }).ToList();
        }

        private void button_Sua_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = DGV_Gia.SelectedRows;
            if (r.Count == 1)
            {
                Detail_Gia f = new Detail_Gia(Convert.ToInt32(r[0].Cells["ID_GIa"].Value.ToString()));
                f.D += new Detail_Gia.SHow(ShowDTGV);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }

    }
}
