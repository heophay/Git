using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GiaoDien.Source_Code_CSDL;

namespace GiaoDien
{
    public partial class QL_SanPham : UserControl
    {
        SE_14X db = new SE_14X();
        //SE_14 db = new SE_14();
        public QL_SanPham()
        {
            InitializeComponent();
            SetView();
        }
        private void SetView()
        {
            cbb_gia.Items.Clear();
            cbb_loaidt.Items.Clear();
            foreach (DanhMuc i in db.DanhMucs)
            {
                cbb_gia.Items.Add(i.TenDM);
            }
            foreach (ChiTiet_SP i in db.ChiTiet_SPs)
            {
                bool kt = true;
                foreach(string j in cbb_loaidt.Items)
                {
                    if (i.HangSX == j) kt = false;
                }
                if (kt == true) cbb_loaidt.Items.Add(i.HangSX);
            }
            cbb_gia.SelectedIndex = 0;
            cbb_loaidt.SelectedIndex = 0;
        }
        private void button_Them_Click(object sender, EventArgs e)
        {

            QLSP q = new QLSP("");
            q.show += new QLSP.ShowDTGV_QLSP(ShowDTGV);
            q.ShowDialog();
        }

        private void button_Sua_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = DGV_QLSP.SelectedRows;
            if (r.Count == 1)
            {
                QLSP f = new QLSP(r[0].Cells["MaSP"].Value.ToString());
                f.show += new QLSP.ShowDTGV_QLSP(ShowDTGV);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng click vào 1 Row");
            }
        }
        private void ShowDTGV()
        {
            DGV_QLSP.DataSource = db.KT_Gia_NhapXuats.Select(p => new { p.MaSP,p.ID_Gia, p.ChiTiet_SP.TenSP, p.GiaNhap, p.GiaBan, p.NgayApDung, p.ChiTiet_SP.HangSX, p.ChiTiet_SP.ManHinh, p.ChiTiet_SP.HeDieuHanh, p.ChiTiet_SP.Ram, p.ChiTiet_SP.SoSim, p.ChiTiet_SP.Pin, p.ChiTiet_SP.NoiXuatXu }).ToList();
        }
        private void button_Xoa_Click(object sender, EventArgs e)
        {
            if (!Del())
            {
                MessageBox.Show("Error!");
            }
            ShowDTGV();
        }
        private bool Del()
        {
            try
            {
                DataGridViewSelectedRowCollection r = DGV_QLSP.SelectedRows;
                if(r.Count<1)
                {
                    MessageBox.Show("Vui lòng click vào 1 Row");
                }
                foreach (ChiTiet_SP i in db.ChiTiet_SPs)
                {
                    foreach (DataGridViewRow j in r)
                    {
                        if (i.MaSP == j.Cells["MaSP"].Value.ToString())
                        {
                            KT_Gia_NhapXuat t =  db.KT_Gia_NhapXuats.Where(p => p.MaSP == i.MaSP).FirstOrDefault();
                            db.KT_Gia_NhapXuats.Remove(t);
                            db.ChiTiet_SPs.Remove(i); 
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
            var list = db.KT_Gia_NhapXuats.Where(p => p.MaSP.Contains(txt_search.Text));
            DGV_QLSP.DataSource = list.ToList();
        }
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (txt_search.Text == "")
            {
                ShowDTGV();
            }
        }

        private void bt_show_SP_Click(object sender, EventArgs e)
        {
            ShowDTGV();
        }
    }
}
