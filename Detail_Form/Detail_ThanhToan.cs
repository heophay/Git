using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GiaoDien.Source_Code_CSDL;

namespace GiaoDien.Detail_Form
{
    public partial class Detail_ThanhToan : Form
    {
        SE_14X db = new SE_14X();
        private List<ItemsGH> listSP = new List<ItemsGH>();
        private string _MaDH;
        private Showdata _Reset;
        private MyDel _Result;
        private string _Matk;
        public Detail_ThanhToan(MyDel sender, string madh,string matk)
        {
            InitializeComponent();
            this.Result = sender;
            this.MaDH = madh;
            Matk = matk;
            Get_listSP();
            Showsp();
            SetView_Update();
        }
        public Detail_ThanhToan(MyDel sender, List<ItemsGH> listSP, string matk,Showdata rs)
        {
            InitializeComponent();
            this.Result = sender;
            Reset = rs;
            this.ListSP = listSP;
            this.Matk = matk;
            Showsp();
            SetView_New();
        }

        public MyDel Result { get => _Result; set => _Result = value; }
        public List<ItemsGH> ListSP { get => listSP; set => listSP = value; }
        public string Matk { get => _Matk; set => _Matk = value; }
        public string MaDH { get => _MaDH; set => _MaDH = value; }
        public Showdata Reset { get => _Reset; set => _Reset = value; }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            this.Result(false);
            this.Close();
        }

        private void bt_XacNhan_Click(object sender, EventArgs e)
        {
            if (db.DonHangs.Where(p => p.MaDonHang.Equals(MaDH)).Count() == 1)
            {
                UpdateDH();
            }
            else
            {
                CreateDH();
                Reset();
            }
            this.Result(true);
            this.Close();
        }
        public void Showsp()
        {
            dataGridView1.DataSource = this.ListSP;
        }
        public void SetView_New()
        {
            int Sum = 0;
            foreach (ItemsGH i in listSP)
            {
                Sum += i.ThanhTien;
            }
            txt_Tongtien1.Text = Sum.ToString();
            txt_maDH.Text = (db.DonHangs.Count() + 1).ToString();
            if (MaDH == null) dtp_DateTao.Value = DateTime.Now;
            else
            {
                DonHang dh = db.DonHangs.Where(p => p.MaDonHang.Equals(MaDH)).FirstOrDefault();
                dtp_DateTao.Value = dh.NgayTao;
            }
            dtp_DateTT.Value = DateTime.Now;
        }
        public void SetView_Update()
        {
            int Sum = 0;
            foreach (ItemsGH i in listSP)
            {
                Sum += i.ThanhTien;
            }
            txt_Tongtien1.Text = Sum.ToString();
            txt_maDH.Text = this.MaDH;
            dtp_DateTao.Value = DateTime.Now;
            dtp_DateTT.Value = DateTime.Now;
        }
        public void Get_listSP()
        {
            foreach (MuaHang mh in db.MuaHangs)
            {
                if (mh.MaDonHang.Equals(MaDH))
                {
                    KT_Gia_NhapXuat gia = db.KT_Gia_NhapXuats.Where(p => p.MaSP == mh.MaSP).FirstOrDefault();
                    ItemsGH gh = new ItemsGH();
                    gh.MaSP = mh.MaSP;
                    gh.TenSP = mh.ChiTiet_SP.TenSP;
                    gh.Gia = gia.GiaBan;
                    gh.Soluong = mh.SoLuong;
                    gh.ThanhTien = gh.Soluong * gh.Gia;
                    listSP.Add(gh);
                }
            }
        }
        public void UpdateDH()
        {
            DonHang dh = db.DonHangs.Where(p => p.MaDonHang.Equals(MaDH)).FirstOrDefault();
            dh.NgayThanhToan = DateTime.Now;
            dh.TrangThai = true;
            db.SaveChanges();
        }
        public void CreateDH()
        {
            DonHang dh = new DonHang();
            dh.MaDonHang = Get_MaDH();
            dh.MaTK = this.Matk;
            dh.MaNV = "002";
            dh.NgayTao = DateTime.Now;
            dh.NgayThanhToan = DateTime.Now;
            dh.UuDai = 0;
            dh.TrangThai = true;
            db.DonHangs.Add(dh);
            foreach (ItemsGH i in ListSP)
            {
                MuaHang mh = new MuaHang();
                mh.MaMuaHang = Get_MaMH();
                mh.MaDonHang = dh.MaDonHang;
                mh.MaSP = i.MaSP;
                mh.SoLuong = i.Soluong;
                KT_Gia_NhapXuat gia = db.KT_Gia_NhapXuats.Where(p => p.MaSP == mh.MaSP).FirstOrDefault();
                mh.ID_Gia = gia.ID_Gia;
                mh.ThanhTien = i.ThanhTien;
                db.MuaHangs.Add(mh);
                db.SaveChanges();
            }
            db.SaveChanges();
        }
        public string Get_MaDH()
        {
            string x = (db.DonHangs.Count() + 1).ToString();
            while (db.DonHangs.Where(p => p.MaDonHang.Equals(x)).Count() != 0)
            {
                x = (Convert.ToInt32(x) + 1).ToString();
            }
            return x;
        }
        public string Get_MaMH()
        {
            string x = (db.MuaHangs.Count() + 1).ToString();
            while (db.MuaHangs.Where(p => p.MaMuaHang.Equals(x)).Count() != 0)
            {
                x = (Convert.ToInt32(x) + 1).ToString();
            }
            return x;
        }

        private void cbox_TenTK_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_TenTK.Checked)
            {
                txt_TenKH.Text = db.ThongTinCaNhans.Where(p => p.MaTK.Equals(Matk)).FirstOrDefault().TenKH;
            }
            else
            {
                txt_TenKH.Text = "";
            }
        }

        private void cbox_SDT_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_SDT.Checked)
            {
                txt_SDT.Text = db.ThongTinCaNhans.Where(p => p.MaTK.Equals(Matk)).FirstOrDefault().SoDT;
            }
            else
            {
                txt_SDT.Text = "";
            }
        }

        private void cbox_DiaChi_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_DiaChi.Checked)
            {
                txt_DiaChi.Text = db.ThongTinCaNhans.Where(p => p.MaTK.Equals(Matk)).FirstOrDefault().DiaChi;
            }
            else
            {
                txt_DiaChi.Text = "";
            }
        }
    }
}
