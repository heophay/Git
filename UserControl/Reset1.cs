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
    public partial class Reset1 : UserControl
    {
        public Reset1()
        {
            InitializeComponent();
        }
        public string txt_TK
        {
            get { return txt_user.Text; }
            set { txt_user.Text = value; }
        }
        public string txt_SDT
        {
            get { return txt_sdt.Text; }
            set { txt_sdt.Text = value; }
        }
    }
}
