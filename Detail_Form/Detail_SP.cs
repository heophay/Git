using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GiaoDien.Source_Code_CSDL;
using DACNPM.dll;
namespace GiaoDien
{
    public delegate void KQ(ItemsGH sp);
    public partial class Detail_SP : Form
    {
        private string _MaDT;
        private KQ _Result;
        SE_14X db = new SE_14X();
        //SE_14 db = new SE_14();

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
        public Detail_SP(string Madt, KQ sender)
        {
            MaDT = Madt;
            this.Result = sender;
            InitializeComponent();
            SetView();
        }
        private void SetView()
        {
            ChiTiet_SP ct = db.ChiTiet_SPs.Where(p => p.MaSP == MaDT).FirstOrDefault();
            txt_baohanh.Text += ct.BaoHanh;
            txt_BNT.Text += ct.BoNhoTrong;
            txt_hangsx.Text += ct.HangSX;
            txt_HDH.Text += ct.HeDieuHanh;
            txt_manhinh.Text += ct.ManHinh;
            txt_namedt.Text += ct.TenSP;
            txt_pin.Text += ct.Pin;
            txt_ram.Text += ct.Ram;
            txt_sim.Text += ct.SoSim;
            txt_xuatxu.Text += ct.Ram;
            KT_Gia_NhapXuat kt = Check_gia(MaDT);
            txt_gia.Text += " " + kt.GiaBan.ToString();
            for (int i = 20; i >= 1; i--)
            {
                domainUpDown1.Items.Add(i);
            }
            domainUpDown1.SelectedIndex = domainUpDown1.Items.Count - 1;
            pic_dt.Image = NVQL.Instance.ByteToImg(ct.HinhAnh);
        }

        private void btn_Muahang_Click_1(object sender, EventArgs e)
        {
            if(Check_bt_Mua())
            {
                
            }         
        }
        private bool Check_bt_Mua()
        {
            try
            {
                KT_Gia_NhapXuat kt = db.KT_Gia_NhapXuats.Where(p => p.MaSP.Equals(MaDT)).FirstOrDefault();
                if (domainUpDown1.Text == "")
                {
                    MessageBox.Show("Mời nhập số lượng mua");
                    return false;
                }
                else
                {
                    if (!NVQL.Instance.Check_Number(domainUpDown1.Text))
                    {
                        MessageBox.Show("Chỉ cho phép nhập số");
                    }
                    if (Convert.ToInt32(domainUpDown1.Text) > kt.Soluong)
                    {
                        MessageBox.Show("Hiện không có đủ số lượng cho sản phẩm này");
                        return false;
                    }
                    else
                    {
                        
                        ItemsGH sp = new ItemsGH();
                        sp.MaSP = this.MaDT;
                        sp.Soluong = Convert.ToInt32(domainUpDown1.Text);
                        sp.TenSP = txt_namedt.Text.Substring(16);
                        
                        sp.Gia = Convert.ToInt32(txt_gia.Text.Substring(5));
                        sp.ThanhTien = sp.Gia * sp.Soluong;
                        MessageBox.Show("s");
                        this.Result(sp);
                        this.Close();
                        return true;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        private void btn_Huy_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        public KT_Gia_NhapXuat Check_gia(string MaDT)
        {

            KT_Gia_NhapXuat gia = null;
            List<int> songaynn = new List<int>();
            int songay = -1;
            if (db.KT_Gia_NhapXuats.Where(p => p.MaSP.Equals(MaDT)).Count() > 1)
            {
                foreach (KT_Gia_NhapXuat i in db.KT_Gia_NhapXuats.Where(p => p.MaSP.Equals(MaDT)))
                {
                    TimeSpan tsp = DateTime.Now.Subtract(i.NgayApDung);
                    if (tsp.Days >= 0)
                    {
                        songay = tsp.Days;
                        songaynn.Add(tsp.Days);
                    }
                }
                int x = NVQL.Instance.TimSoNN(songaynn);
                foreach (KT_Gia_NhapXuat i in db.KT_Gia_NhapXuats.Where(p => p.MaSP.Equals(MaDT)))
                {
                    if (DateTime.Now.Subtract(i.NgayApDung).Days == x) gia = i;
                }
                return gia;
            }
            else
            {
                gia = db.KT_Gia_NhapXuats.Where(p => p.MaSP.Equals(MaDT)).FirstOrDefault();
                return gia;
            }
        }
    }
}
