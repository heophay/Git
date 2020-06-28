using GiaoDien.Detail_Form;
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

    public partial class Detail_SP : Form
    {
        private MyDel _Result;

        SE_14 db = new SE_14();
        private string _MaSP;

        public string MaSP { get => _MaSP; set => _MaSP = value; }
        public MyDel Result { get => _Result; set => _Result = value; }

        public Detail_SP()
        {
            InitializeComponent();
        }
        public Detail_SP(string masp,MyDel sender)
        {
            InitializeComponent();
            this.MaSP = masp;
            this.Result = sender;
            SetView();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oke");
        }

        private void tabItem1_Click(object sender, EventArgs e)
        {
            //Main_User f = new Main_User();
            this.Visible = false;
            //f.ShowDialog();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Oke");
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_gia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_xuatxu_TextChanged(object sender, EventArgs e)
        {

        }
        private void SetView()
        {
                KT_Gia_NhapXuat gia = db.KT_Gia_NhapXuat.Where(p => p.MaSP == MaSP).FirstOrDefault();
                ChiTiet_SP sp = db.ChiTiet_SPs.Where(p => p.MaSP == MaSP).FirstOrDefault();
                txt_namedt.Text += " " + sp.TenSP;
                txt_hangsx.Text += " " + sp.HangSX;
                txt_HDH.Text += " " + sp.HeDieuHanh;
                txt_manhinh.Text += " " + sp.ManHinh;
                txt_xuatxu.Text += " " + sp.NoiXuatXu;
                txt_baohanh.Text += " " + sp.BaoHanh;
                txt_BNT.Text += " " + sp.BoNhoTrong;
                txt_sim.Text += " " + sp.SoSim.ToString();
                txt_pin.Text += " " + sp.Pin;
                txt_ram.Text += " " + sp.Ram;
                txt_gia.Text += " " + gia.GiaBan.ToString();
        }

        private void btn_Muahang_Click(object sender, EventArgs e)
        {
            this.Result(true);
        }
    }
}
