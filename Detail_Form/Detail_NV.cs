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
    public partial class Detail_NV : Form
    {
        private string _MaNV;
        public delegate void SHow();
        SHow d;
        public Detail_NV(string manv)
        {
            MaNV = manv;
            InitializeComponent();
            SetView();
            rb_nam.Checked = true;
        }
        SE_14X db = new SE_14X();

        public string MaNV { get => _MaNV; set => _MaNV = value; }
        public SHow D { get => d; set => d = value; }

        private void SetView()
        {
            if (MaNV != "")
            {
                txt_pass.UseSystemPasswordChar = true;
                txt_manv.Enabled = false;
                txt_pass.Enabled = false;
                txt_tk.Enabled = false;
                Theodoi_NV nv = db.Theodoi_NVs.Where(p => p.MaTK == MaNV).FirstOrDefault();
                txt_manv.Text = nv.MaTK;
                txt_nv.Text = nv.TenNV;
                txt_pass.Text = nv.TaiKhoan.PassTK;
                txt_tk.Text = nv.TaiKhoan.TenTK;
                txt_dt.Text = nv.SoDT;
                txt_diachi.Text = nv.DiaChi;
                rb_nam.Checked = nv.Gender;
                dateTimePicker1.Value = Convert.ToDateTime(nv.NgaySinh.ToString());
            }
            txt_pass.UseSystemPasswordChar = true;
        }
        private void Run()
        {
            if (D != null)
            {
                D();
                this.Close();
            }
        }
        private bool Check_Format()
        {
            try
            {
                if (NVQL.Instance.Check_String(txt_tk.Text) && NVQL.Instance.Check_String(txt_pass.Text)
                    && NVQL.Instance.Check_String(txt_manv.Text))
                {
                    if (txt_pass.Text.Length < 5)
                    {
                        MessageBox.Show("mật khẩu ít nhất 5 kí tự bao gồm số hoặc chữ cái");
                        return false;
                    }
                    else
                    {
                        if (!NVQL.Instance.Check_Number(txt_dt.Text))
                        {
                            MessageBox.Show("Số điện thoại chỉ bao gồm kí tự số");
                            return false;
                        }
                        else
                        {
                            if (txt_dt.Text.Length != 10)
                            {
                                MessageBox.Show("số điện thoại phải đủ 10 số");
                                return false;
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Sai định dạng! Tên tài khoản, mã nhân viên và mật khẩu không được có dấu");
                    return false;
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private bool Oke()
        {
            try
            {
                if (txt_manv.Text == "" || txt_pass.Text == ""||txt_nv.Text=="" || txt_tk.Text == "" || txt_dt.Text == "" || txt_diachi.Text == "")
                {
                    MessageBox.Show("Nhập đã đủ thông tin đâu mà đòi Add trời!");
                }
                else
                {
                    if (Check_Format())
                    {
                        TaiKhoan tk = db.TaiKhoans.Where(p => p.MaTK == txt_manv.Text).FirstOrDefault();
                        if (tk == null)
                        {
                            db.TaiKhoans.Add(new TaiKhoan
                            {
                                MaTK = txt_manv.Text,
                                TenTK = txt_tk.Text,
                                PassTK = NVQL.Instance.MaHoaMK(txt_pass.Text),
                                LoaiTK = "Customer",
                            });
                            db.Theodoi_NVs.Add(new Theodoi_NV
                            {
                                MaTK = txt_manv.Text,
                                TenNV = txt_nv.Text,
                                SoDT = txt_dt.Text,
                                DiaChi = txt_diachi.Text,
                                NgaySinh = dateTimePicker1.Value,
                                Gender = rb_nam.Checked
                            });
                            MessageBox.Show("Add thành công");
                            db.SaveChanges();
                            Run();
                        }
                        else
                        {
                            if (Check_MaSP())
                            {

                            }
                        }
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
                Theodoi_NV nv = db.Theodoi_NVs.Where(p => p.MaTK == MaNV).FirstOrDefault();
                TaiKhoan tk = db.TaiKhoans.Where(p => p.MaTK == txt_manv.Text).FirstOrDefault();
                if (txt_manv.Enabled == true&&tk!=null)
                {
                    MessageBox.Show("Mã trùng rồi, nhập lại cái khác đi");
                }
                else
                {
                    if (txt_nv.Text == "" || txt_pass.Text == "" || txt_tk.Text == "" || txt_dt.Text == "" || txt_diachi.Text == "")
                    {
                        MessageBox.Show("Không được để trống");
                    }
                    else
                    {
                        nv.TenNV = txt_nv.Text;
                        nv.SoDT = txt_dt.Text;
                        nv.DiaChi = txt_diachi.Text;
                        nv.NgaySinh = dateTimePicker1.Value;
                        nv.Gender = rb_nam.Checked;
                        db.SaveChanges();
                        MessageBox.Show("Edit thành công");
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

        private void bt_luu_Click(object sender, EventArgs e)
        {
            if(Oke())
            {

            }
        }

        private void bt_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
