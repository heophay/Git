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
    public partial class Detail_KH : Form
    {
        private string _MaKH;
        public delegate void SHow();
        SHow d;
        public Detail_KH(string makh)
        {
            MaKH = makh;
            InitializeComponent();
        }
        SE_14 db = new SE_14();

        public string MaKH { get => _MaKH; set => _MaKH = value; }
        public SHow D { get => d; set => d = value; }

        private void SetView()
        {
            if (MaKH != "")
            {
                txt_makh.Enabled = false;
                ThongTinCaNhan nv = db.ThongTinCaNhans.Where(p => p.MaTK == MaKH).FirstOrDefault();
                txt_makh.Text = nv.MaTK;
                txt_nv.Text = nv.TenKH;
                txt_pass.Text = nv.TaiKhoan.PassTK;
                txt_tk.Text = nv.TaiKhoan.TenTK;
                txt_dt.Text = nv.SoDT;
                txt_diachi.Text = nv.DiaChi;
                dateTimePicker1.Value = Convert.ToDateTime(nv.NgaySinh.ToString());
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
                ThongTinCaNhan nv = db.ThongTinCaNhans.Where(p => p.MaTK == MaKH).FirstOrDefault();
                if (nv == null)
                {
                    if (txt_makh.Text != "" && txt_pass.Text != "" && txt_tk.Text != "" && txt_dt.Text != "" && txt_diachi.Text != "")
                    {
                        db.ThongTinCaNhans.Add(new ThongTinCaNhan
                        {
                            MaTK = txt_makh.Text,
                            TenKH = txt_nv.Text,
                            SoDT = txt_dt.Text,
                            DiaChi = txt_diachi.Text,
                            NgaySinh = dateTimePicker1.Value,
                            Gender = rb_nam.Checked
                        });
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
                ThongTinCaNhan nv = db.ThongTinCaNhans.Where(p => p.MaTK == MaKH).FirstOrDefault();
                if (txt_makh.Enabled == true && txt_makh.Text.Equals(nv.MaTK))
                {
                    MessageBox.Show("MSSV trùng rồi, nhập lại cái khác đi");
                    return false;
                }
                else
                {
                    if (txt_nv.Text == "" || txt_pass.Text == "" || txt_tk.Text == "" || txt_dt.Text == "" || txt_diachi.Text == "")
                    {
                        MessageBox.Show("Không được để trống");
                    }
                    nv.MaTK = txt_nv.Text;
                    nv.TenKH = txt_nv.Text;
                    nv.SoDT = txt_dt.Text;
                    nv.DiaChi = txt_diachi.Text;
                    nv.NgaySinh = dateTimePicker1.Value;
                    nv.Gender = rb_nam.Checked;
                    db.SaveChanges();
                    Run();
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
