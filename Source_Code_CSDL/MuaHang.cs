using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDien
{
    public partial class MuaHang
    {
        [Key]
        public string MaMuaHang { get; set; }
        public string MaDonHang { get; set; }
        public string MaSP { get; set; }
        public int SoLuong { get; set; }
        public int ID_Gia { get; set; }
        public int ThanhTien { get; set; }

        public virtual DonHang DonHang { get; set; }
        public virtual ChiTiet_SP ChiTiet_SP { get; set; }
        public virtual KT_Gia_NhapXuat KT_Gia_NhapXuat { get; set; }
    }
}
