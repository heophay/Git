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

    public partial class Login : Form
    {
        string _MaTK ;
        string nameCus;
        SE_14F db = new SE_14F();
        public Login()
        {
            InitializeComponent();
            SetWaterMarkText();  
        }

        private void SetWaterMarkText()
        {
            txt_user.Text = "Tài khoản";
            this.txt_user.Leave += new System.EventHandler(this.txt_user_Leave);
            this.txt_user.Enter += new System.EventHandler(this.txt_user_Enter);
            txt_pass.Text = "Mật khẩu";
            this.txt_pass.Leave += new System.EventHandler(this.txt_pass_Leave);
            this.txt_pass.Enter += new System.EventHandler(this.txt_pass_Enter);
           
        }
        private void txt_user_Enter(object sender, EventArgs e)
        {
            if (txt_user.Text == "Tài khoản")
            {
                txt_user.Text = "";
            }
        }

        private void txt_user_Leave(object sender, EventArgs e)
        {
            if (txt_user.Text == "")
            {
                txt_user.Text = "Tài khoản";
            }
        }
        private void txt_pass_Enter(object sender, EventArgs e)
        {
            if (txt_pass.Text == "Mật khẩu")
            {
                txt_pass.Text = "";
                txt_pass.UseSystemPasswordChar = true;
            }
        }

        private void txt_pass_Leave(object sender, EventArgs e)
        {
            if (txt_pass.Text == "")
            {
                txt_pass.Text = "Mật khẩu";
                txt_pass.UseSystemPasswordChar = false;
            }
        }
        Register r;

        public string MaTK { get => _MaTK; set => _MaTK = value; }
        public string NameCus { get => nameCus; set => nameCus = value; }

        public void bt_dangky_Click(object sender, EventArgs e)
        {
            r = new Register();
            r.Show();
            this.TopMost =true;
            r.TopMost = false;
            timer_go.Start();
        }


        private void timer_go_Tick(object sender, EventArgs e)
        {
            r.Left += 10;
            if(r.Left>=950)
            {
                timer_go.Stop();
                r.TopMost = true;
                timer_back.Start();
            }
        }
        private void timer_back_Tick(object sender, EventArgs e)
        {
            r.Left -= 10;
            if (r.Left <= 555)
            {
                timer_back.Stop();
            }
        }
        private void bt_resetpass_Click(object sender, EventArgs e)
        {
            Reset_Pass rp = new Reset_Pass();
            this.Visible = false;
            rp.ShowDialog();
            this.Dispose();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            NameCus = txt_user.Text;
            string s = Check_User();
            MaTK = s;
            if (s!=null)
            {
                
                if(s== "Customer")
                {
                    this.Visible = false;
                    Main_User mu = new Main_User();
                    mu.ShowDialog();
                    this.Dispose();
                }
                else
                {
                    if (s == "Admin")
                    {
                        Main_Admin ma = new Main_Admin();
                        //this.Visible = false;
                        ma.Show();
                        ma.TopMost = true;
                        this.Dispose();
                    }
                    else
                    {
                        Main_Manager mn = new Main_Manager();
                        this.Visible = false;
                        mn.ShowDialog();
                        mn.TopMost = true;
                        this.Dispose();
                    }
                }

            }
        }
       
        private string Check_User()
        {
            try
            {
                string tam = "";
                TaiKhoan tk = new TaiKhoan();
                tk = db.TaiKhoans.Where(p => p.TenTK == txt_user.Text && p.PassTK==txt_pass.Text).FirstOrDefault();
                if(tk !=null)
                {
                    //MaTK = tk.MaTK;
                    foreach (string i in db.TaiKhoans.Select(p => p.LoaiTK).Distinct().ToList())
                    {
                        if (i == tk.LoaiTK)
                        {
                            tam = tk.LoaiTK;
                        }
                    }
                    return tam;
                }
                else
                {
                    MessageBox.Show("Tên TK hoặc MK sai");
                    return null;
                }
                
            }
            catch(Exception)
            {
                return null;
            }
        }
        private string Determine_User( TaiKhoan tk)
        {
            string s = "";
            string tam = "";
            foreach (string i in db.TaiKhoans.Select(p => p.LoaiTK).Distinct().ToList())
            {
                if (i == tk.LoaiTK)
                {
                    s = i;
                    tam = tk.MaTK;
                }
            }
            MessageBox.Show(s + " đã đăng nhập");
            return tam;
        }
        private void txt_user_Click(object sender, EventArgs e)
        {
            pic_user.Image = Properties.Resources.user_32;
            txt_user.ForeColor = Color.FromArgb(78, 184, 206);
            panel_user.BackColor = Color.FromArgb(78, 184, 206);

            pic_pass.Image = Properties.Resources.padlock_4_32;
            panel_pass.BackColor = Color.White;
            txt_pass.ForeColor = Color.White;
        }

        private void txt_pass_Click(object sender, EventArgs e)
        {
            pic_user.Image = Properties.Resources.user_32__1_;
            txt_user.ForeColor = Color.White;
            panel_user.BackColor = Color.White;

            pic_pass.Image = Properties.Resources.padlock_4_32__1_;
            panel_pass.BackColor = Color.FromArgb(78, 184, 206);
            txt_pass.ForeColor = Color.FromArgb(78, 184, 206);
        }

        private void pic_seenpass_Click(object sender, EventArgs e)
        {
            if(txt_pass.UseSystemPasswordChar==true)
            {
                txt_pass.UseSystemPasswordChar = false;
            }
            else
            {
                txt_pass.UseSystemPasswordChar = true;
            }
        }
    }
}
