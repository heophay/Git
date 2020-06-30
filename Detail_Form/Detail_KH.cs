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
            SetView();
        }
        SE_14X db = new SE_14X();
        //SE_14 db = new SE_14();

        public string MaKH { get => _MaKH; set => _MaKH = value; }
        public SHow D { get => d; set => d = value; }

        private void SetView()
        {
            if (MaKH != "")
            {
                txt_makh.Enabled = false;
                txt_tk.Enabled = false;
                txt_pass.Enabled = false;
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
                if (nv != null)
                {
                    if (txt_makh.Enabled ==false)
                    {
                        if (txt_nv.Text == "" || txt_pass.Text == "" || txt_tk.Text == "" || txt_dt.Text == "" || txt_diachi.Text == "")
                        {
                            MessageBox.Show("Không được để trống");
                        }
                        else
                        {
                            nv.TenKH = txt_nv.Text;
                            nv.SoDT = txt_dt.Text;
                            nv.DiaChi = txt_diachi.Text;
                            nv.NgaySinh = dateTimePicker1.Value;
                            nv.Gender = rb_nam.Checked;
                            db.SaveChanges();
                            MessageBox.Show("Edit thành công");
                            Run();
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

        private void bt_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            if(Oke())
            {

            }
        }
    }
}
