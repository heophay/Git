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
    public partial class Reset3 : UserControl
    {
        public Reset3()
        {
            InitializeComponent();
        }
        public string txt_Pass
        {
            get { return txt_pass.Text; }
            set { txt_pass.Text = value; }
        }
    }
}
