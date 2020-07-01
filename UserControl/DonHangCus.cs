using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GiaoDien.Detail_Form;
using GiaoDien.Source_Code_CSDL;

namespace GiaoDien
{
    public delegate void Showdata();
    public partial class DonHangCus : UserControl
    {
        private string _MaTK;

        public DonHangCus(string matk)
        {
            InitializeComponent();
            this.MaTK = matk;
            ShowDTGV();
        }
        SE_14X db = new SE_14X();

        public string MaTK { get => _MaTK; set => _MaTK = value; }

        private void ShowDTGV()
        {
            DGV_Donhang.DataSource = db.DonHangs.Where(p => p.MaTK == this.MaTK).Select(p => new { p.MaDonHang, p.NgayTao, p.NgayThanhToan, p.UuDai, p.TrangThai }).ToList();
        }
        private void button_Xemdonhang_Click(object sender, EventArgs e)
        {
            SE_14X db = new SE_14X();
            List<ItemsGH> listsp = new List<ItemsGH>();
            DataGridViewSelectedRowCollection dr = DGV_Donhang.SelectedRows;
            if (dr.Count == 1)
            {
                string x = dr[0].Cells["MaDonHang"].Value.ToString();
                DonHang dh = db.DonHangs.Where(p => p.MaDonHang.Equals(x)).FirstOrDefault();
                foreach (MuaHang mh in db.MuaHangs)
                {
                    if (dh.MaDonHang == mh.MaDonHang)
                    {
                        KT_Gia_NhapXuat gia = db.KT_Gia_NhapXuats.Where(p => p.MaSP == mh.MaSP).FirstOrDefault();
                        ItemsGH gh = new ItemsGH();
                        gh.MaSP = mh.MaSP;
                        gh.TenSP = mh.ChiTiet_SP.TenSP;
                        gh.Gia = gia.GiaBan;
                        gh.Soluong = mh.SoLuong;
                        gh.ThanhTien = gh.Gia * gh.Soluong;
                        listsp.Add(gh);
                    }
                }
                if (dh.TrangThai == true)
                {
                    Detail_LapDH f = new Detail_LapDH(dh.MaDonHang, true,ShowDTGV,MaTK);
                    f.ShowDGV += ShowDTGV;
                    f.ShowDialog();
                }
                else
                {
                    Detail_LapDH f = new Detail_LapDH(dh.MaDonHang, false, ShowDTGV, MaTK);
                    f.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Chỉ được chọn 1 Row!!");
            }
        }

        private void button_XoaDonHang_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection row = DGV_Donhang.SelectedRows;
            if (row.Count < 1)
            {
                MessageBox.Show("Chọn 1 hoặc nhiều đơn hàng trước khi muốn xóa!!");
            }
            else
            {
                if(!Delete_MH())
                {
                    MessageBox.Show("Error");
                }
                else
                {
                    if(!Delete_DH())
                    {
                        MessageBox.Show("Error");
                    }
                    else
                    {
                        ShowDTGV();
                    }
                }
                
            }
        }
        public bool Delete_DH()
        {
            DataGridViewSelectedRowCollection dr = DGV_Donhang.SelectedRows;
            try
            {
                MessageBox.Show("qua dơn hàng");
                foreach (DonHang i in db.DonHangs)
                {
                    foreach (DataGridViewRow r in dr)
                    {
                        if (i.MaDonHang.Equals(r.Cells["MaDonHang"].Value.ToString()))
                        {
                            db.DonHangs.Remove(i);
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
        public bool Delete_MH()
        {
            DataGridViewSelectedRowCollection dr = DGV_Donhang.SelectedRows;
            try
            {
                foreach (DataGridViewRow r in dr)
                {
                    foreach (MuaHang i in db.MuaHangs)
                    {
                        if (i.MaDonHang==r.Cells["MaDonHang"].Value.ToString())
                        {
                            db.MuaHangs.Remove(i);
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
    }
}
