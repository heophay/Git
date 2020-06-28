using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien
{
    public delegate void KQ(bool kq);
    public partial class Detail_SP : Form
    {
        private string _MaDT;
        private KQ _Result;
        SE_14 db = new SE_14();

        public string MaDT { get => _MaDT; set => _MaDT = value; }
        public KQ Result { get => _Result; set => _Result = value; }

        public Detail_SP()
        {
            InitializeComponent();
            SetView();
        }
        public Detail_SP(string Madt)
        {
            MaDT = Madt;
            InitializeComponent();
            SetView();
        }
        public Detail_SP(string Madt,KQ sender)
        {
            MaDT = Madt;
            this.Result = sender;
            InitializeComponent();
            SetView();
        }
        private void SetView()
        {
            ChiTiet_SP ct = db.ChiTiet_SP.Where(p => p.MaSP == MaDT).FirstOrDefault();
            txt_baohanh.Text += ct.BaoHanh;
            txt_BNT.Text += ct.BoNhoTrong;
            txt_hangsx.Text += ct.HangSX;
            txt_HDH.Text += ct.HeDieuHanh;
            txt_manhinh.Text += ct.ManHinh;
            txt_namedt.Text += ct.TenSP;
            txt_pin.Text += ct.Pin;
            txt_ram.Text += ct.Ram;
            txt_sim.Text += ct.Ram.ToString();
            txt_xuatxu.Text += ct.Ram;
            KT_Gia_NhapXuat kt = db.KT_Gia_NhapXuat.Where(p => p.MaSP == MaDT).Select(p => p).FirstOrDefault();
            txt_gia.Text +="  "+ kt.GiaBan.ToString();
        }


        private void btn_Muahang_Click_1(object sender, EventArgs e)
        {
            this.Result(true);
            this.Close();
        }

        private void btn_Huy_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
