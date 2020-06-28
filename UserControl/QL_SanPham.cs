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
    public partial class QL_SanPham : UserControl
    {
        SE_14 db = new SE_14();
        public QL_SanPham()
        {
            InitializeComponent();
            SetView();
            cbb_gia.SelectedIndex = 0;
            cbb_xuatxu.SelectedIndex = 0;
        }
        private void button_Them_Click(object sender, EventArgs e)
        {

            QLSP q = new QLSP("");
            q.show += new QLSP.ShowDTGV_QLSP(SetView);
            q.ShowDialog();
        }

        private void button_Sua_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = DGV_QLSP.SelectedRows;
            if (r.Count == 1)
            {
                QLSP f = new QLSP(r[0].Cells["MaSP"].Value.ToString());
                f.show += new QLSP.ShowDTGV_QLSP(SetView);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }
        public void SetView()
        {
            DGV_QLSP.DataSource = db.ChiTiet_SP.Select(p => new { p.MaSP, p.TenSP, p.HangSX, p.ManHinh, p.HeDieuHanh, p.Ram, p.SoSim, p.Pin, p.NoiXuatXu }).ToList();
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            if (!Del())
            {
                MessageBox.Show("Error");
            }
            SetView();
        }
        private bool Del()
        {
            try
            {
                DataGridViewSelectedRowCollection r = DGV_QLSP.SelectedRows;
                foreach (ChiTiet_SP i in db.ChiTiet_SP)
                {
                    foreach (DataGridViewRow j in r)
                    {
                        if (i.MaSP == j.Cells["MaSP"].Value.ToString())
                        {
                            KT_Gia_NhapXuat t =  db.KT_Gia_NhapXuat.Where(p => p.MaSP == i.MaSP).FirstOrDefault();
                            db.KT_Gia_NhapXuat.Remove(t);
                            db.ChiTiet_SP.Remove(i); 
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

        private void bt_search_Click(object sender, EventArgs e)
        {
            var list = db.ChiTiet_SP.Where(p => p.TenSP.Contains(txt_search.Text));
            DGV_QLSP.DataSource = list.ToList();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (txt_search.Text == "")
            {
                SetView();
            }
        }
    }
}
