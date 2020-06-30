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
    public partial class Reset2 : UserControl
    {
        public Reset2()
        {
            InitializeComponent();
        }
        public string txt_TK
        {
            get { return txt_tk.Text; }
            set { txt_tk.Text = value; }
        }
        public string txt_Name
        {
            get { return txt_name.Text; }
            set { txt_name.Text = value; }
        }
        public string txt_SoDT
        {
            get { return txt_sodt.Text; }
            set { txt_sodt.Text = value; }
        }

    }
}
