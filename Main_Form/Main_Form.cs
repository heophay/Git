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
        }
        public void SetView_Login()
        {
            if (user1.LoaiTK == "")
            {
                user1.BringToFront();
            }
            else
            {
                if (user1.LoaiTK == "Admin")
                {
                    trangChuAdmin1.BringToFront();
                }
                if (user1.LoaiTK == "Manager")
                {
                    trangChuManager1.BringToFront();
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
