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
    public partial class TT_NhanVien : UserControl
    {
        SE_14X db = new SE_14X();
        //SE_14 db = new SE_14();
        public TT_NhanVien()
        {
            InitializeComponent();
            ShowDTGV();
            cbb_search.SelectedIndex = 0;
        }
        private void ShowDTGV()
        {
            DGV_NV.DataSource = db.Theodoi_NVs.Select(p => new { p.MaTK, p.TenNV, p.NgaySinh, p.SoDT,p.DiaChi,p.Gender }).ToList();
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
                MessageBox.Show("Click vào 1 Row trước khi muốn Edit");
            }
        }
        private bool Del()
        {
            try
            {
                List<string> matk = new List<string>();
                DataGridViewSelectedRowCollection r = DGV_NV.SelectedRows;
                if(r.Count>0)
                {
                    foreach (Theodoi_NV i in db.Theodoi_NVs)
                    {
                        foreach (DataGridViewRow j in r)
                        {
                            if (i.MaTK == j.Cells["MaTK"].Value.ToString())
                            {
                                db.Theodoi_NVs.Remove(i);
                                matk.Add(i.MaTK);
                            }
                        }
                    }
                    foreach (string i in matk)
                    {
                        TaiKhoan del = db.TaiKhoans.Where(p => p.MaTK == i).FirstOrDefault();
                        db.TaiKhoans.Remove(del);
                    }
                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Chưa chọn Row");
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
            else
            {
                MessageBox.Show("Xóa thành công");
            }
            ShowDTGV();
        }
    }
}
