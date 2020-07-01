using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GiaoDien.Source_Code_CSDL;
using DACNPM.dll;
using System.Text.RegularExpressions;

namespace GiaoDien
{
    public partial class Register : Form
    {
        SE_14X db = new SE_14X();
        //SE_14 db = new SE_14();
        public Register()
        {
            InitializeComponent();
            SetWaterMarkText();
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

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool Check_Format()
        {
            try
            {
                if(NVQL.Instance.Check_String(txt_tk.Text)&&NVQL.Instance.Check_String(txt_pass.Text)
                    &&NVQL.Instance.Check_String(txt_confirm.Text))
                {
                    if(txt_pass.Text.Length<5)
                    {
                        MessageBox.Show("mật khẩu ít nhất 5 kí tự bao gồm số hoặc chữ cái");
                        return false;
                    }
                    else
                    {
                        if (!NVQL.Instance.Check_Number(txt_sdt.Text))
                        {
                            MessageBox.Show("Số điện thoại không bao gồm chữ cái");
                        }
                        else
                        {
                            if (txt_sdt.Text.Length != 10)
                            {
                                MessageBox.Show("số điện thoại phải đủ 10 số");
                                return false;
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Sai định dạng! Tên tài khoản và mật khẩu không được có dấu");
                    return false;
                }
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
        private void bt_dangky_Click(object sender, EventArgs e)
        {
            if (Check_Format())
            {
                if (db.TaiKhoans.Where(p => p.TenTK.Contains(txt_tk.Text)).Count() != 0)
                {
                    MessageBox.Show("Tai khoan da ton tai!");
                }
                else
                {
                    if (!txt_pass.Text.ToString().Equals(txt_confirm.Text.ToString()))
                    {
                        MessageBox.Show("Password xac nhan sai!!");
                    }
                    else
                    {
                        string x = (db.TaiKhoans.Count() + 1).ToString();
                        foreach (char i in db.TaiKhoans.Select(p => new { p.MaTK }).ToString())
                        {
                            if (x == i.ToString())
                            {
                                x = (Convert.ToInt32(x) + 1).ToString();
                            }
                        }
                        db.TaiKhoans.Add(new TaiKhoan
                        {
                            MaTK = x,
                            TenTK = txt_tk.Text,
                            PassTK = NVQL.Instance.MaHoaMK(txt_pass.Text),
                            LoaiTK = "Customer",
                        });
                        db.ThongTinCaNhans.Add(new ThongTinCaNhan
                        {
                            MaTK = x,
                            TenKH = txt_name.Text,
                            SoDT = txt_sdt.Text,
                            DiaChi = txt_diachi.Text,
                            NgaySinh = dtp_ngaysinh.Value,
                            Gender = rdb_Nam.Checked
                        });
                        db.SaveChanges();
                        MessageBox.Show("Success");
                        this.Close();
                    }
                }
            }
        }
        private void txt_tk_TextChanged(object sender, EventArgs e)
        {
            foreach(char i in txt_tk.Text)
            {
                //MessageBox.Show(System.Convert.ToInt32(i).ToString());
            }
        }
    }
}
