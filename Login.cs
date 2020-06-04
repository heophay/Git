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
        public Login()
        {
            InitializeComponent();
        }

        private void bt_dangky_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            this.Visible = false;
            r.ShowDialog();
            this.Dispose();
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
            //Main_User mu = new Main_User();
            this.Visible = false;
            //mu.ShowDialog();
            this.Dispose();
        }
    }
}
