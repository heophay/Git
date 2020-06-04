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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            SetWaterMarkText();
            cbb_ngay.SelectedIndex = 17;
            cbb_thang.SelectedIndex = 2;

            for (int i = 2020; i >= 1905; i--)
            {
                cbb_nam.Items.Add(i);
            }
            cbb_nam.SelectedIndex = 21;
        }
        private void SetWaterMarkText()
        {
            txt_tk.Text = "Tài khoản";
            this.txt_tk.Leave += new System.EventHandler(this.txt_tk_Leave);
            this.txt_tk.Enter += new System.EventHandler(this.txt_tk_Enter);
            txt_name.Text = "Tên người dùng";
            this.txt_name.Leave += new System.EventHandler(this.txt_name_Leave);
            this.txt_name.Enter += new System.EventHandler(this.txt_name_Enter);
            txt_pass.Text = "Mật khẩu";
            this.txt_pass.Leave += new System.EventHandler(this.txt_pass_Leave);
            this.txt_pass.Enter += new System.EventHandler(this.txt_pass_Enter);
            txt_confirm.Text = "Xác nhận mật khẩu";
            this.txt_confirm.Leave += new System.EventHandler(this.txt_confirm_Leave);
            this.txt_confirm.Enter += new System.EventHandler(this.txt_confirm_Enter);
            txt_sdt.Text = "Số điện thoại";
            this.txt_sdt.Leave += new System.EventHandler(this.txt_sdt_Leave);
            this.txt_sdt.Enter += new System.EventHandler(this.txt_sdt_Enter);
            txt_diachi.Text = "Địa chỉ";
            this.txt_diachi.Leave += new System.EventHandler(this.txt_diachi_Leave);
            this.txt_diachi.Enter += new System.EventHandler(this.txt_diachi_Enter);
        }
        private void txt_tk_Enter(object sender, EventArgs e)
        {
            if (txt_tk.Text == "Tài khoản")
            {
                txt_tk.Text = "";
            }
        }

        private void txt_tk_Leave(object sender, EventArgs e)
        {
            if (txt_tk.Text == "")
            {
                txt_tk.Text = "Tài khoản";
            }
        }
        private void txt_name_Enter(object sender, EventArgs e)
        {
            if (txt_name.Text == "Tên người dùng")
            {
                txt_name.Text = "";
            }
        }

        private void txt_name_Leave(object sender, EventArgs e)
        {
            if (txt_name.Text == "")
            {
                txt_name.Text = "Tên người dùng";
            }
        }
        private void txt_pass_Enter(object sender, EventArgs e)
        {
            if (txt_pass.Text == "Mật khẩu")
            {
                txt_pass.Text = "";
            }
        }

        private void txt_pass_Leave(object sender, EventArgs e)
        {
            if (txt_pass.Text == "")
            {
                txt_pass.Text = "Mật khẩu";
            }
        }
        private void txt_confirm_Enter(object sender, EventArgs e)
        {
            if (txt_confirm.Text == "Xác nhận mật khẩu")
            {
                txt_confirm.Text = "";
            }
        }

        private void txt_confirm_Leave(object sender, EventArgs e)
        {
            if (txt_confirm.Text == "")
            {
                txt_confirm.Text = "Xác nhận mật khẩu";
            }
        }
        private void txt_sdt_Enter(object sender, EventArgs e)
        {
            if (txt_sdt.Text == "Số điện thoại")
            {
                txt_sdt.Text = "";
            }
        }

        private void txt_sdt_Leave(object sender, EventArgs e)
        {
            if (txt_sdt.Text == "")
            {
                txt_sdt.Text = "Số điện thoại";
            }
        }
        private void txt_diachi_Enter(object sender, EventArgs e)
        {
            if (txt_diachi.Text == "Địa chỉ")
            {
                txt_diachi.Text = "";
            }
        }

        private void txt_diachi_Leave(object sender, EventArgs e)
        {
            if (txt_diachi.Text == "")
            {
                txt_diachi.Text = "Địa chỉ";
            }
        }
        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
