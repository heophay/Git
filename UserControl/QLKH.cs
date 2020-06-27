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
    public partial class QLKH : UserControl
    {
        SE_14 db = new SE_14();
        public QLKH()
        {
            InitializeComponent();
        }
        private void ShowDTGV()
        {
            DGV_KH.DataSource = db.ThongTinCaNhans.Select(p => new { p.MaTK, p.TenKH, p.NgaySinh, p.SoDT, p.DiaChi, p.Gender }).ToList();
        }
        private void button_Them_Click(object sender, EventArgs e)
        {
            Detail_KH f = new Detail_KH("");
            f.D += new Detail_KH.SHow(ShowDTGV);
            f.ShowDialog();
        }

        private void button_Sua_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = DGV_KH.SelectedRows;
            if (r.Count == 1)
            {
                Detail_KH f = new Detail_KH(r[0].Cells["MaTK"].Value.ToString());
                f.D += new Detail_KH.SHow(ShowDTGV);
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
                DataGridViewSelectedRowCollection r = DGV_KH.SelectedRows;
                foreach (ThongTinCaNhan i in db.ThongTinCaNhans)
                {
                    foreach (DataGridViewRow j in r)
                    {
                        if (i.MaTK == j.Cells["MaTK"].Value.ToString())
                        {
                            db.ThongTinCaNhans.Remove(i);
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
