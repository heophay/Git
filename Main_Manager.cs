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
    public partial class Main_Manager : Form
    {
        public Main_Manager()
        {
            InitializeComponent();
        }

        private void pictureBox_Out_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void trangChuManager1_Load(object sender, EventArgs e)
        {

        }

        private void pic_logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
