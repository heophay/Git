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
    public partial class Reset_Pass : Form
    {
        Reset1 r1 = new Reset1();
        Reset2 r2 = new Reset2();
        Reset3 r3 = new Reset3();
        SE_14X db = new SE_14X();
        //SE_14 db = new SE_14();
        Login l = new Login();
        public Reset_Pass()
        {
            InitializeComponent();
            bt_dangnhap.Hide();
            bt_yes.Hide();
            bt_no.Hide();
            panel2.Controls.Clear();
            panel2.Controls.Add(r1);
        }
        
        //me no chu
        private void bt_huy_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            l.ShowDialog();
            this.Dispose();
            l.Dispose();
        }

        private void bt_yes_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = db.TaiKhoans.Where(p => p.TenTK == r1.txt_TK).FirstOrDefault();
            if(tk.ThongTinCaNhans.TenKH.Equals(r2.txt_Name)&&tk.ThongTinCaNhans.SoDT.Equals(r2.txt_SoDT))
            {
                panel2.Controls.Clear();
                panel2.Controls.Add(r3);
                r3.txt_Pass += " 123";
                tk.PassTK = "123";
                db.SaveChanges();
                bt_no.Hide();
                bt_yes.Hide();
                bt_dangnhap.Visible = true;
            }
            else
            {
                MessageBox.Show("Xác thực thông tin sai");
            }
        }

        private void bt_no_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(r1);
            r1.txt_TK = "";
            bt_yes.Hide(); 
            bt_no.Hide(); 
            bt_search.Visible = true;
            bt_huy.Visible = true;
        }

        private void bt_search_Click(object sender, EventArgs e)
        {         
            if (r1.txt_TK == "")
            {
                MessageBox.Show("Nhập tên tài khoản");
            }
            else
            {
                TaiKhoan tk = db.TaiKhoans.Where(p => p.TenTK == r1.txt_TK).FirstOrDefault();
                if (tk == null)
                {
                    MessageBox.Show("Tên Tài khoản không tồn tại");
                }
                else
                {
                    panel2.Controls.Clear();
                    panel2.Controls.Add(r2);
                    r2.txt_TK += " " + tk.TenTK;
                    bt_yes.Visible = true;
                    bt_no.Visible = true;
                    bt_search.Hide();
                    bt_huy.Hide();
                }
            }
        }
    }
}
