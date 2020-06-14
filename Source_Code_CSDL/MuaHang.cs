using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDien
{
    public partial class MuaHang
    {
        [Key]
        public string MaMuaHang { get; set; }
        [ForeignKey("DonHang")]
        public string MaDonHang { get; set; }
        [ForeignKey("ChiTiet_SP")]
        public string MaSP { get; set; }
        
        public int SoLuong { get; set; }
        [ForeignKey("KT_Gia_NhapXuat")]
        public int ID_Gia { get; set; }
       
        public int ThanhTien { get; set; }

        public virtual DonHang DonHang { get; set; }
        public virtual ChiTiet_SP ChiTiet_SP { get; set; }
        public virtual KT_Gia_NhapXuat KT_Gia_NhapXuat { get; set; }
    }
}
