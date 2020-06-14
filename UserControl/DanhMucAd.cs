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
        SE_14F db = new SE_14F();
        public DanhMucAd()
        {
            InitializeComponent();
            ShowDGV();
            cbb_danhmuc.SelectedIndex = 0;
        }

        public void SetView()
        {
            DataGridViewSelectedRowCollection r = DGV_DanhMuc.SelectedRows;
            if(r.Count==1)
            {
                txt_madanhmuc.Text = r[0].Cells["MaDM"].Value.ToString();
                txt_tenDM.Text = r[0].Cells["TenDM"].Value.ToString();
                cbb_danhmuc.SelectedItem= r[0].Cells["LoaiDM"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Chỉ chọn 1 Row thôi!");
            }
        }
        public void ShowDGV()
        {
            DGV_DanhMuc.DataSource = db.DanhMucs.Select(p => new { p.MaDM, p.TenDM, p.LoaiDM }).ToList();
            if (cbb_danhmuc.Items.Count > 0)
            {
                cbb_danhmuc.Items.Clear();
            }
            else
            {
                foreach(string i in db.DanhMucs.Select(p=>p.LoaiDM).Distinct())
                {
                    cbb_danhmuc.Items.Add(i);
                }
            }
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
    }
}
