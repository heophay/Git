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
    public partial class Detail_Gia : Form
    {
        private int _IDGia;
        public delegate void SHow();
        SHow d;
        public Detail_Gia(int magia)
        {
            IDGia = magia;
            InitializeComponent();
        }
        SE_14 db = new SE_14();

        public int IDGia { get => _IDGia; set => _IDGia = value; }
        public SHow D { get => d; set => d = value; }

        private void SetView()
        {
            if (IDGia != 0)
            {
                txt_idgia.Enabled = false;
                txt_masp.Enabled = false;
                KT_Gia_NhapXuat nv = db.KT_Gia_NhapXuat.Where(p => p.ID_Gia == IDGia).FirstOrDefault();
                txt_idgia.Text = nv.ID_Gia.ToString();
                txt_masp.Text = nv.MaSP;
                txt_giaban.Text = nv.GiaBan.ToString();
                txt_gianhap.Text = nv.GiaNhap.ToString();
                ngayapdung.Value = Convert.ToDateTime(nv.NgayApDung.ToString());
            }
        }
        private void Run()
        {
            if (D != null)
            {
                D();
                this.Close();
            }
        }
        private bool Oke()
        {
            try
            {
                KT_Gia_NhapXuat nv = db.KT_Gia_NhapXuat.Where(p => p.ID_Gia == IDGia).FirstOrDefault();
                if (nv!= null)
                {
                    if (txt_idgia.Enabled == false &&txt_masp.Enabled==false)
                    {
                        if (txt_masp.Text == "" || txt_giaban.Text == "" || txt_gianhap.Text == "")
                        {
                            MessageBox.Show("Không được để trống");
                        }
                        nv.ID_Gia = Convert.ToInt32(txt_idgia.Text.ToString());
                        nv.MaSP = txt_masp.Text;
                        nv.GiaNhap = Convert.ToInt32(txt_gianhap.Text.ToString());
                        nv.GiaBan = Convert.ToInt32(txt_giaban.Text.ToString());
                        nv.NgayApDung = ngayapdung.Value;
                        db.SaveChanges();
                        Run();
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
