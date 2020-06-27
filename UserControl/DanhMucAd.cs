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
    public partial class DanhMucAd : UserControl
    {
        SE_14 db = new SE_14();
        public DanhMucAd()
        {
            InitializeComponent();
            ShowDGV();
            if (cbb_danhmuc.Items.Count > 0)
            {
                cbb_danhmuc.Items.Clear();
            }
            else
            {
                foreach (string i in db.DanhMucs.Select(p => p.LoaiDM).Distinct())
                {
                    cbb_danhmuc.Items.Add(i);
                }
            }
            //cbb_danhmuc.SelectedIndex = 0;
        }

        public void SetView()
        {
            DataGridViewSelectedRowCollection r = DGV_DanhMuc.SelectedRows;
            if (r.Count == 1)
            {
                txt_madanhmuc.Text = r[0].Cells["MaDM"].Value.ToString();
                txt_tenDM.Text = r[0].Cells["TenDM"].Value.ToString();
                foreach (string i in cbb_danhmuc.Items)
                {
                    if (i == r[0].Cells["LoaiDM"].Value.ToString())
                    {
                        cbb_danhmuc.SelectedIndex = cbb_danhmuc.Items.IndexOf(i);
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Chỉ chọn 1 Row thôi!");
            }
        }
        public void ShowDGV()
        {
            DGV_DanhMuc.DataSource = db.DanhMucs.Select(p => new { p.MaDM, p.TenDM, p.LoaiDM }).ToList();

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            txt_madanhmuc.Enabled = true;
            txt_madanhmuc.Text = "";
            txt_tenDM.Text = "";
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            txt_madanhmuc.Enabled = false;
            SetView();
        }

        private bool Oke()
        {
            try
            {
                if (txt_madanhmuc.Enabled == true)
                {
                    if (txt_madanhmuc.Text != "" && txt_tenDM.Text != "")
                    {
                        db.DanhMucs.Add(new DanhMuc
                        {
                            MaDM = txt_madanhmuc.Text,
                            TenDM = txt_tenDM.Text,
                            LoaiDM = cbb_danhmuc.SelectedItem.ToString()
                        });
                        db.SaveChanges();
                        ShowDGV();
                    }
                    else
                    {
                        MessageBox.Show("Điền đủ thông tin đi");
                    }
                }
                else
                {
                    Check_DM();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private bool Check_DM()
        {
            try
            {
                DanhMuc dm = db.DanhMucs.Where(p => p.MaDM == txt_madanhmuc.Text).FirstOrDefault();
                if (txt_madanhmuc.Enabled == true && dm == null)
                {
                    MessageBox.Show("Trùng");
                }
                else
                {
                    if (txt_tenDM.Text == "")
                    {
                        MessageBox.Show("Không được để trống");
                    }
                    dm.TenDM = txt_tenDM.Text;
                    dm.LoaiDM = cbb_danhmuc.SelectedItem.ToString();
                    db.SaveChanges();
                    ShowDGV();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private void bt_luu_Click(object sender, EventArgs e)
        {
            if (!Oke())
            {
                MessageBox.Show("Error");
            }
        }
        private bool Del()
        {
            try
            {
                DataGridViewSelectedRowCollection r = DGV_DanhMuc.SelectedRows;
                foreach (DanhMuc i in db.DanhMucs)
                {
                    foreach (DataGridViewRow j in r)
                    {
                        if (i.MaDM == j.Cells["MaDM"].Value.ToString())
                        {
                            db.DanhMucs.Remove(i);
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
        private void bt_xoa_Click(object sender, EventArgs e)
        {
            if (!Del())
            {
                MessageBox.Show("Error");
            }
            ShowDGV();
        }
    }
}
