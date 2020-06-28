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
    public partial class TaiKhoanUser : UserControl
    {
        SE_14 db = new SE_14();
        public TaiKhoanUser()
        {
            InitializeComponent();
            SetView();
        }
        public void SetView()
        {
            Login l = new Login();
            ThongTinCaNhan Cus = new ThongTinCaNhan();

            //Cus = db.ThongTinCaNhans.Where(p => p.MaTK == l.MaTK).FirstOrDefault();
            //txt_HotenKH.Text = Cus.TenKH;
            //txt_SoDT.Text = Cus.SoDT;
            //txt_Diachi.Text = Cus.DiaChi;

        }
    }
}
