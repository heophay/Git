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
        SE_14 db = new SE_14();
        public delegate void Showdata();
        private int _IDGia;
        private Showdata _ShowGia;

        public int IDGia { get => _IDGia; set => _IDGia = value; }
        public Showdata ShowGia { get => _ShowGia; set => _ShowGia = value; }

        public Detail_Gia()
        {
            InitializeComponent();
        }
        public Detail_Gia(int IDGia)
        {
            InitializeComponent();
            this.IDGia = IDGia;
        }
        private void SetView()
        {
            if (IDGia != -1)
            {
                txt_IDGia.Enabled = false;
                KT_Gia_NhapXuat gia = db.KT_Gia_NhapXuat.Where(p => p.ID_Gia == IDGia).FirstOrDefault();
                txt_MaSP.Text = gia.MaSP;
                txt_GiaNhap.Text = gia.GiaNhap.ToString();
                txt_GiaBan.Text = gia.GiaBan.ToString();
            }
        }
        private void Run()
        {
            if (ShowGia != null)
            {
                ShowGia();
                this.Close();
            }
        }
        private bool Oke()
        {
            try
            {
                KT_Gia_NhapXuat sp = db.KT_Gia_NhapXuat.Where(p => p.ID_Gia == IDGia).FirstOrDefault();
                if (sp == null)
                {                                      
                        MessageBox.Show("Không có thông tin giá cần sửa!");
                }
                else
                {
                    if (Check_MaSP())
                    {

                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private bool Check_MaSP()
        {
            try
            {
                KT_Gia_NhapXuat gia = db.KT_Gia_NhapXuat.Where(p => p.ID_Gia == IDGia).FirstOrDefault();
                if (txt_GiaBan.Text == "" || txt_GiaNhap.Text == "" || txt_MaSP.Text == "")
                {
                     MessageBox.Show("Không được để trống");
                }
                gia.GiaNhap = Convert.ToInt32(txt_GiaNhap.Text);
                gia.GiaBan = Convert.ToInt32(txt_GiaBan.Text);
                gia.MaSP = txt_MaSP.Text;
                db.SaveChanges();
                Run();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
