using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Show1();
        }

        SE_14 db = new SE_14();
        public void Show1()
        {
            dataGridView1.DataSource = db.TaiKhoans.Select(p => new { p.MaTK, p.TenTK,p.PassTK,p.LoaiTK }).ToList();
        }
    }
}
