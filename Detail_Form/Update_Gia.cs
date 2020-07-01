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
using DACNPM.dll;
namespace GiaoDien
{
    public partial class Update_Gia : Form
    {
        private int _IDGia;

        public int IDGia { get => _IDGia; set => _IDGia = value; }
        public ShowGia Show1 { get => _show; set => _show = value; }

        public delegate void ShowGia();
        private ShowGia _show;
        SE_14X db = new SE_14X();
        public Update_Gia(string idgia)
        {
            IDGia = Convert.ToInt32(idgia);
            InitializeComponent();
            SetView();
        }

        private void SetView()
        {
           if(IDGia>0)
            {
                txt_idgia.Enabled = false;
                txt_masp.Enabled = false;
                KT_Gia_NhapXuat kt = db.KT_Gia_NhapXuats.Where(p => p.ID_Gia == IDGia).FirstOrDefault();
                txt_idgia.Text = kt.ID_Gia.ToString();
                txt_masp.Text = kt.ChiTiet_SP.MaSP;
                txt_soluong.Text = kt.Soluong.ToString();
                txt_giaban.Text = kt.GiaBan.ToString();
                txt_gianhap.Text = kt.GiaNhap.ToString();
                dtp_ngayapdung.Value = kt.NgayApDung;
            }
        }
        private void bt_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool Check_Format()
        {
            try
            {
                if(txt_giaban.Text==""||txt_gianhap.Text==""||txt_soluong.Text=="")
                {
                    MessageBox.Show("Chưa nhập đủ thông tin");
                    return false;
                }
                else
                {
                    if (!NVQL.Instance.Check_Number(txt_giaban.Text) || !NVQL.Instance.Check_Number(txt_gianhap.Text) ||
                    !NVQL.Instance.Check_Number(txt_soluong.Text))
                    {
                        MessageBox.Show("Giá nhập, giá bán và số lượng chỉ cho phép nhập kí tự số");
                        return false;
                    }
                    else
                    {
                        if (txt_giaban.Text.Length > 10 || txt_gianhap.Text.Length > 10)
                        {
                            MessageBox.Show("Giá không quá 10 chữ số");
                            return false;
                        }
                        if (Convert.ToInt32(txt_soluong.Text) <= 0 || Convert.ToInt32(txt_giaban.Text) <= 0 ||
                            Convert.ToInt32(txt_gianhap.Text) <= 0)
                        {
                            MessageBox.Show("Số lượng và Giá phải lớn hơn 0");
                            return false;
                        }                      
                    }
                }
                return true;
            }catch(Exception)
            {
                return false;
            }
        }
        private void Run()
        {
            if (Show1 != null)
            {
                Show1();
                this.Close();
            }
        }
        private bool Oke()
        {
            try
            {
                KT_Gia_NhapXuat kt = db.KT_Gia_NhapXuats.Where(p => p.ID_Gia == IDGia).FirstOrDefault();
               if(kt!=null)
                {
                    kt.Soluong = Convert.ToInt32(txt_soluong.Text);
                    kt.GiaBan = Convert.ToInt32(txt_giaban.Text);
                    kt.GiaNhap = Convert.ToInt32(txt_gianhap.Text);
                    kt.NgayApDung = dtp_ngayapdung.Value;
                    db.SaveChanges();
                    MessageBox.Show("Edit Giá thành công");
                }
                else
                {
                    MessageBox.Show("Error!");
                    return false;
                }
                return true;
            }catch(Exception)
            {
                return false;
            }
        }
        private void bt_luu_Click(object sender, EventArgs e)
        {
            if(Check_Format())
            {
                if (Oke()) Run();
            }
            
        }
    }
}
