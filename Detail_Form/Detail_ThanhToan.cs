using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien.Detail_Form
{
    public partial class Detail_ThanhToan : Form
    {    
        private bool KQ = false;
        private MyDel _Result;
        public Detail_ThanhToan()
        {
            InitializeComponent();
        }
        public Detail_ThanhToan(MyDel sender)
        {
            InitializeComponent();
            this.Result = sender;
        }

        public MyDel Result { get => _Result; set => _Result = value; }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            this.Result(this.KQ);
            this.Close();
        }
     
        private void bt_XacNhan_Click(object sender, EventArgs e)
        {
            this.KQ = true;
            this.Result(this.KQ);
            this.Close();
        }       
    }
}
