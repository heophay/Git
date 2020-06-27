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
            for (int i = 1; i <= 31; i++)
            {
                cbb_ngay.Items.Add(i);
            }
            cbb_thang.Items.Add("Tháng");
            for (int i = 1; i <= 12; i++)
            {
                cbb_thang.Items.Add("Tháng " + i);
            }
            cbb_ngay.SelectedIndex = 17;
            cbb_thang.SelectedIndex = 3;
            cbb_nam.Items.Add("Năm");
            for (int i = 2020; i >= 1905; i--)
            {
                cbb_nam.Items.Add(i);
            }
            cbb_nam.SelectedIndex = 21;
            Login l = new Login();
            MessageBox.Show(l.MaTK);
            ThongTinCaNhan Cus = new ThongTinCaNhan();

            //Cus = db.ThongTinCaNhans.Where(p => p.MaTK == l.MaTK).FirstOrDefault();
            //txt_HotenKH.Text = Cus.TenKH;
            //txt_SoDT.Text = Cus.SoDT;
            //txt_Diachi.Text = Cus.DiaChi;

        }
    }
}
