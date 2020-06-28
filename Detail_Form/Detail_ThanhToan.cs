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
        SE_14 db = new SE_14();
        private List<ItemsGH> listSP = new List<ItemsGH>();
        private bool KQ = false;
        private MyDel _Result;
        public Detail_ThanhToan()
        {
            InitializeComponent();
        }
        public Detail_ThanhToan(MyDel sender, List<ItemsGH> listSP)
        {
            InitializeComponent();
            this.Result = sender;
            this.ListSP = listSP;
            Showsp();
            SetView();
        }

        public MyDel Result { get => _Result; set => _Result = value; }
        public List<ItemsGH> ListSP { get => listSP; set => listSP = value; }

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
        public void Showsp()
        {
            dataGridView1.DataSource = this.ListSP;
        }
        public void SetView()
        {
            int Sum = 0;
            foreach (ItemsGH i in listSP)
            {
                Sum += i.ThanhTien;
            }
            txt_Tongtien.Text = Sum.ToString();

        }
    }
}
