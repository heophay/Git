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
        //SE_14 db = new SE_14();
        private List<ItemsGH> listSP = new List<ItemsGH>();
        private bool KQ = false;
        private MyDel _Result;
        private string _Matk;
        public Detail_ThanhToan()
        {
            InitializeComponent();
        }
        public Detail_ThanhToan(MyDel sender, List<ItemsGH> listSP, string matk)
        {
            InitializeComponent();
            this.Result = sender;
            this.ListSP = listSP;
            this.Matk = matk;
            Showsp();
            SetView();
        }

        public MyDel Result { get => _Result; set => _Result = value; }
        public List<ItemsGH> ListSP { get => listSP; set => listSP = value; }
        public string Matk { get => _Matk; set => _Matk = value; }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            this.Result(this.KQ);
            this.Close();
        }

        private void bt_XacNhan_Click(object sender, EventArgs e)
        {
            this.KQ = true;
            this.Result(this.KQ);
            CreateDH();
            this.Close();
        }
        public void Showsp()
        {
            dataGridView1.DataSource = this.ListSP;
        }
        public void SetView()
        {
            int Sum = 0;
            foreach (ItemsGH i in listSP)
            {
                Sum += i.ThanhTien;
            }
            txt_Tongtien1.Text = Sum.ToString();
            txt_maDH.Text = (db.DonHangs.Count() + 1).ToString();
            dtp_DateTao.Value = DateTime.Now;
            dtp_DateTT.Value = DateTime.Now;
            txt_Tongtien2.Text = Sum.ToString();


        }
        public void CreateDH()
        {
            DonHang dh = new DonHang();
            dh.MaDonHang = (db.DonHangs.Count() + 1).ToString();
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
                mh.MaMuaHang = (db.MuaHangs.Count() + 1).ToString();
                MessageBox.Show(mh.MaMuaHang);
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
    }
}
