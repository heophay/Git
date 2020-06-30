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
    public delegate void MyDel(bool KQ);
    public partial class Detail_LapDH : Form
    {
        SE_14X db = new SE_14X();
        private bool _KQTT;
        private string _MaTK;
        private string _MaDH;
        private Showdata _ShowDGV;
        private List<ItemsGH> listCTSP = new List<ItemsGH>();

        public bool KQTT { get => _KQTT; set => _KQTT = value; }
        public string MaTK { get => _MaTK; set => _MaTK = value; }
        public string MaDH { get => _MaDH; set => _MaDH = value; }
        public Showdata ShowDGV { get => _ShowDGV; set => _ShowDGV = value; }

        public Detail_LapDH(List<ItemsGH> listCTSP, string Matk)
        {
            InitializeComponent();
            this.listCTSP = listCTSP;
            this.MaTK = Matk;
           
            Showdata();
        }
        public Detail_LapDH(string MaDH, bool kt, Showdata sender)
        {
            InitializeComponent();
            ShowDGV = sender;
            this.MaDH = MaDH;
            Get_listSP();
            if (kt == true) bt_ThanhToan.Enabled = false;
            bt_LuuDH.Enabled = false;
            Showdata();
        }
        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_ThanhToan_Click(object sender, EventArgs e)
        {
            if (bt_LuuDH.Enabled)
            {
                Detail_ThanhToan f = new Detail_ThanhToan(ResultThanhToan, this.listCTSP, MaTK);
                f.ShowDialog();
                if (KQTT == true)
                {
                    this.Close();
                    //ShowDGV();
                }
            }
            else
            {
                Detail_ThanhToan f = new Detail_ThanhToan(ResultThanhToan, MaDH);
                f.ShowDialog();
                if (KQTT == true)
                {
                    this.Close();
                    ShowDGV();
                }
            }
        }
        public void ResultThanhToan(bool KQ)
        {
            this.KQTT = KQ;
        }
        public void Showdata()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = listCTSP;
        }

        private void bt_LuuDH_Click(object sender, EventArgs e)
        {
            CreateDH();
            this.Close();
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
                    listCTSP.Add(gh);
                }
            }
        }
        public void CreateDH()
        {
            try
            {
                DonHang dh = new DonHang();
                dh.MaDonHang = (db.DonHangs.Count() + 1).ToString();
                dh.MaTK = this.MaTK;
                dh.MaNV = "002";
                dh.NgayTao = DateTime.Now;
                dh.NgayThanhToan = DateTime.Now;
                dh.UuDai = 0;
                dh.TrangThai = false;
                db.DonHangs.Add(dh);
                foreach (ItemsGH i in listCTSP)
                {
                    MuaHang mh = new MuaHang();
                    mh.MaMuaHang = (db.MuaHangs.Count() + 1).ToString();
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
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }
    }
}
