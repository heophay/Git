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
    public partial class QLKH : UserControl
    {
        SE_14X db = new SE_14X();
        //SE_14 db = new SE_14();
        public QLKH()
        {
            InitializeComponent();
            ShowDTGV();
            cbb_search.SelectedIndex = 0;
        }
        private void ShowDTGV()
        {
            DGV_KH.DataSource = db.ThongTinCaNhans.Select(p => new { p.MaTK,p.TaiKhoan.TenTK, p.TenKH, p.NgaySinh, p.SoDT, p.DiaChi, p.Gender }).ToList();
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
                MessageBox.Show("Click vào 1 Row trước khi muốn Edit");
            }
        }
        private bool Del()
        {
            try
            {
                List<string> matk = new List<string>();
                DataGridViewSelectedRowCollection r = DGV_KH.SelectedRows;
                if(r.Count>0)
                {
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
                    foreach (string i in matk)
                    {
                        TaiKhoan del = db.TaiKhoans.Where(p => p.MaTK == i).FirstOrDefault();
                        db.TaiKhoans.Remove(del);
                    }
                    MessageBox.Show("Xóa thành công");
                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Click vào 1 Row trước khi Delete");
                }
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

        private void bt_search_Click(object sender, EventArgs e)
        {
            if(cbb_search.SelectedIndex==0)
            {
                var list = db.ThongTinCaNhans.Where(p => p.TenKH.Contains(txt_search.Text)).Select(p => new { p.MaTK, p.TenKH, p.NgaySinh, p.SoDT, p.DiaChi, p.Gender });
                DGV_KH.DataSource = list.ToList();
            }
            else
            {
                var list = db.ThongTinCaNhans.Where(p => p.MaTK.Contains(txt_search.Text)).Select(p => new { p.MaTK, p.TenKH, p.NgaySinh, p.SoDT, p.DiaChi, p.Gender });
                DGV_KH.DataSource = list.ToList();
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if(txt_search.Text=="")
            {
                ShowDTGV();
            }
        }
    }
}
