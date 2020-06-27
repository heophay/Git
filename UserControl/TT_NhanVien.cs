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
    public partial class TT_NhanVien : UserControl
    {
        SE_14 db = new SE_14();
        public TT_NhanVien()
        {
            InitializeComponent();
        }
        private void ShowDTGV()
        {
            DGV_NV.DataSource = db.Theodoi_NV.Select(p => new { p.MaTK, p.TenNV, p.NgaySinh, p.SoDT,p.DiaChi,p.Gender }).ToList();
        }
        private void button_Them_Click(object sender, EventArgs e)
        {
            Detail_NV f = new Detail_NV("");
            f.D += new Detail_NV.SHow(ShowDTGV);
            f.ShowDialog();
        }

        private void button_Sua_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = DGV_NV.SelectedRows;
            if (r.Count == 1)
            {
                Detail_NV f = new Detail_NV(r[0].Cells["MaTK"].Value.ToString());
                f.D += new Detail_NV.SHow(ShowDTGV);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }
        private bool Del()
        {
            try
            {
                DataGridViewSelectedRowCollection r = DGV_NV.SelectedRows;
                foreach (Theodoi_NV i in db.Theodoi_NV)
                {
                    foreach (DataGridViewRow j in r)
                    {
                        if (i.MaTK == j.Cells["MaTK"].Value.ToString())
                        {
                            db.Theodoi_NV.Remove(i);
                        }
                    }
                }
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            if (!Del())
            {
                MessageBox.Show("Error!");
            }
            ShowDTGV();
        }
    }
}
