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
    public delegate void MyDel(bool KQ);
    public partial class Detail_LapDH : Form
    {
        private bool KQTT;
        private List<ItemsGH> listCTSP;
        public Detail_LapDH()
        {
            InitializeComponent();
        }
        public Detail_LapDH(List<ItemsGH> listCTSP)
        {
            InitializeComponent();
            this.listCTSP = listCTSP;
            Showdata();
        }
        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_ThanhToan_Click(object sender, EventArgs e)
        {
            Detail_ThanhToan f = new Detail_ThanhToan(ResultThanhToan,this.listCTSP);
            f.ShowDialog();
            if (KQTT == true)
            {
                this.Close();
            }
        }
        public void ResultThanhToan(bool KQ)
        {
            this.KQTT = KQ;
        }
        public void Showdata()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = listCTSP;
        }
    }
}
