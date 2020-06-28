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
    public delegate void Get_User(string value);
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
            panel5.Controls.Add(new TrangChuUser());
        }
        private string _LoaiTK ;
        public string LoaiTK { get => _LoaiTK; set => _LoaiTK = value; }
        private void button_DngNhap_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            Login l = new Login(SetValue);
            l.ShowDialog();
            SetView_Login();
        }
        public void SetValue(string value)
        {
            LoaiTK = value;
        }
        private void button_DangKi_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            r.ShowDialog();
        }

        private void button_TrangChu_Click(object sender, EventArgs e)
        {
            panel5.Controls.Clear();
            panel5.Controls.Add(new TrangChuUser());
        }

        private void button_TaiKhoan_Click(object sender, EventArgs e)
        {
            panel5.Controls.Clear();
            panel5.Controls.Add(new TaiKhoanUser());
        }

        private void button_GioHang_Click(object sender, EventArgs e)
        {
            panel5.Controls.Clear();
            panel5.Controls.Add(new GioHangUser());
        }

        private void button_DonHang_Click(object sender, EventArgs e)
        {
            panel5.Controls.Clear();
            panel5.Controls.Add(new DonHangCus());
        }
        Panel p = new Panel();
        public void SetView_Login()
        {
            if (LoaiTK == "")
            {

            }
            else
            {
                if (LoaiTK == "Manager")
                {

                    panel2.Controls.Clear();
                    TrangChuManager l = new TrangChuManager("Manager");
                    panel2.Controls.Add(l);
                    
                }
                if(LoaiTK == "Admin")
                {
                    panel2.Controls.Clear();
                    TrangChuManager l = new TrangChuManager("Admin");
                    panel2.Controls.Add(l);
                    

                }
            }
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
