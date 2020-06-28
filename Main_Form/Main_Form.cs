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
   
    public partial class Main_Form : Form
    {
        private string text;
        public Main_Form(string text)
        {
            Text1 = text;
            InitializeComponent();
            SetView_Login();
        }
        public void SetView_Login()
        {
            if (user2.LoaiTK == "")
            {
                panel2.Controls.Clear();
                panel2.Controls.Add(user2);
            }
            else
            {
                if (user2.LoaiTK == "Manager")
                {
                    panel2.Controls.Clear();
                    TrangChuManager l = new TrangChuManager("Manager");
                    panel2.Controls.Add(l);
                }
                if (user2.LoaiTK == "Admin")
                {
                    panel2.Controls.Clear();
                    TrangChuManager l = new TrangChuManager("Admin");
                    panel2.Controls.Add(l);
                }
            }
        }
        public string Text1 { get => text; set => text = value; }

        private void Main_Form_Activated(object sender, EventArgs e)
        {
            SetView_Login();
        }
    }
}
