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
   
    public partial class Main_Form : Form
    {
        SE_14X db = new SE_14X();
        //SE_14 db = new SE_14();
        private string text;
        public string Text1 { get => text; set => text = value; }
        public Main_Form(string MaTK)
        {
            Text1 = MaTK;
            InitializeComponent();
            SetView_Login(Text1);
        }
        public void SetView_Login(string matk)
        {
            TaiKhoan tk = db.TaiKhoans.Where(p => p.MaTK == matk).FirstOrDefault();
            string txt1 = tk.LoaiTK;
            if (txt1 == "Customer")
            {
                User u = new User(matk);
                panel2.Controls.Clear();
                panel2.Controls.Add(u);
            }
            else
            {
                if (txt1 == "Manager")
                {
                    panel2.Controls.Clear();
                    TrangChuManager l = new TrangChuManager(matk);
                    panel2.Controls.Add(l);
                }
                if (txt1 == "Admin")
                {
                    panel2.Controls.Clear();
                    TrangChuManager l = new TrangChuManager(matk);
                    panel2.Controls.Add(l);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Visible = false;
            l.ShowDialog();
            this.Dispose();
        }
    }
}
