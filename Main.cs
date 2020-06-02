using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            
        }

        private void pictureBox_Out_Click(object sender, EventArgs e)
        {
            this.Close();
            //
        }
    }
}
