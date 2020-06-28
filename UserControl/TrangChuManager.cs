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
    public partial class TrangChuManager : UserControl
    {
        private string _Loai;
        public TrangChuManager(string LoaiTK)
        {
            Loai = LoaiTK;
            InitializeComponent();
            if(Loai=="Manager")
            {
                bt_Nhanvien.Visible = false;
            }
            if(Loai == "Admin")
            {
                
                bt_TTCN.Visible = false;
            }
        }

        public string Loai { get => _Loai; set => _Loai = value; }
    }
}
