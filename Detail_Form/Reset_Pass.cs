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
    public partial class Reset_Pass : Form
    {
        SE_14F db = new SE_14F();
        public Reset_Pass()
        {
            InitializeComponent();
            bt_dangnhap.Hide();
            bt_yes.Hide();
            bt_no.Hide();
            reset11.BringToFront();
        }
        Login l = new Login();
        private void bt_search_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = db.TaiKhoans.Where(p => p.TenTK == reset11.txt_TK).FirstOrDefault();
            reset21.BringToFront();
            bt_yes.Visible = true;
            bt_no.Visible = true;
            bt_search.Hide();
            bt_huy.Hide();
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
            reset31.BringToFront();
            bt_no.Hide();
            bt_yes.Hide(); 
            bt_dangnhap.Visible = true;
        }

        private void bt_no_Click(object sender, EventArgs e)
        {
            reset11.BringToFront();
            bt_yes.Hide(); 
            bt_no.Hide(); 
            bt_search.Visible = true;
            bt_huy.Visible = true;
        }
    }
}
