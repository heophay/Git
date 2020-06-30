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
        private bool Oke()
        {
            try
            {
                Theodoi_NV nv = db.Theodoi_NVs.Where(p => p.MaTK == MaNV).FirstOrDefault();
                if (nv == null)
                {
                    if (txt_nv.Text != "" && txt_pass.Text != "" && txt_tk.Text != "" && txt_dt.Text != "" && txt_diachi.Text != "")
                    {
                        db.TaiKhoans.Add(new TaiKhoan
                        {
                            MaTK = txt_manv.Text,
                            TenTK = txt_tk.Text,
                            PassTK =NVQL.Instance.MaHoaMK(txt_pass.Text),
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
                        MessageBox.Show("Nhập đã đủ thông tin đâu mà đòi Add trời!");
                    }
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
                Theodoi_NV nv = db.Theodoi_NVs.Where(p => p.MaTK == MaNV).FirstOrDefault();
                if (txt_manv.Enabled == true && txt_manv.Text.Equals(nv.MaTK))
                {
                    MessageBox.Show("Mã trùng rồi, nhập lại cái khác đi");
                    return false;
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
