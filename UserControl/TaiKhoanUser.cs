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
    public partial class TaiKhoanUser : UserControl
    {
        SE_14 db = new SE_14();
        private string _MaTK;
        public TaiKhoanUser(string matk)
        {
            InitializeComponent();
            this.MaTK = matk;
            SetView();
        }
        public string MaTK { get => _MaTK; set => _MaTK = value; }
        private bool Check_MaTK()
        {
                TaiKhoan tk = db.TaiKhoans.Where(p => p.MaTK == MaTK).FirstOrDefault();
                if (tk.LoaiTK.Equals("Customer"))
                {
                    return true;
                }
                return false;
        }

        public void SetView()
        {
            //Login l = new Login();
            TaiKhoan tk = db.TaiKhoans.Where(p => p.MaTK == MaTK).FirstOrDefault();
            txt_tk.Enabled = false;
            txt_tk.Text = tk.TenTK;
            if (tk.LoaiTK.Equals("Customer"))
            {
                ThongTinCaNhan kh = db.ThongTinCaNhans.Where(p => p.MaTK == MaTK).FirstOrDefault();
                txt_HotenKH.Text = kh.TenKH;
                txt_SoDT.Text = kh.SoDT;
                txt_Diachi.Text = kh.DiaChi;
                if (kh.Gender)
                {
                    radioButton_Nam.Checked = true;
                }
                Ngaysinh.Value = kh.NgaySinh;
            }
            else
            {
                Theodoi_NV nv = db.Theodoi_NV.Where(p => p.MaTK == MaTK).FirstOrDefault();
                txt_HotenKH.Text = nv.TenNV;
                txt_SoDT.Text = nv.SoDT;
                txt_Diachi.Text = nv.DiaChi;
                if (nv.Gender)
                {
                    radioButton_Nam.Checked = true;
                }
                Ngaysinh.Value = nv.NgaySinh;
            }
        }

        private void button_changepass_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = db.TaiKhoans.Where(p => p.MaTK == MaTK).FirstOrDefault();
            if (txt_pass.Text==""||txt_confirmpass.Text=="")
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
            }
           else
            {
                if(!txt_pass.Text.Equals(txt_confirmpass.Text))
                {
                    MessageBox.Show("Mật Khẩu và Xác Nhận phải giống nhau");
                }
                tk.PassTK = txt_confirmpass.Text;
                db.SaveChanges();
                MessageBox.Show("Lưu thành công");
            }

        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = db.TaiKhoans.Where(p => p.MaTK == MaTK).FirstOrDefault();
            if (tk.LoaiTK.Equals("Customer"))
            {
                ThongTinCaNhan kh = db.ThongTinCaNhans.Where(p => p.MaTK == MaTK).FirstOrDefault();
                 kh.TenKH= txt_HotenKH.Text;
                kh.SoDT = txt_SoDT.Text;
                kh.DiaChi = txt_Diachi.Text;
                kh.Gender=radioButton_Nam.Checked;
                kh.NgaySinh=Ngaysinh.Value;
                db.SaveChanges();
                MessageBox.Show("Lưu thay đổi");
            }
            else
            {
                Theodoi_NV nv = db.Theodoi_NV.Where(p => p.MaTK == MaTK).FirstOrDefault();
                nv.TenNV=txt_HotenKH.Text;
                nv.SoDT=txt_SoDT.Text;
                nv.DiaChi=txt_Diachi.Text;
                nv.Gender = radioButton_Nam.Checked;
                nv.NgaySinh=Ngaysinh.Value;
                db.SaveChanges();
                MessageBox.Show("Lưu thay đổi"); 
            }

        }
    }
}
