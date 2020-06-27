using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien
{
    public delegate void Get_User(string value);
    public partial class User : UserControl
    {
        
        private string _LoaiTK;
        public string LoaiTK { get => _LoaiTK; set => _LoaiTK = value; }

        public User()
        {
            InitializeComponent();
        }
        private void button_DngNhap_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            Login l = new Login(SetValue);
            l.ShowDialog();
        }
        public void SetValue(string value)
        {
            LoaiTK= value;
        }
        private void button_DangKi_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            r.ShowDialog();
        }
    }
}
