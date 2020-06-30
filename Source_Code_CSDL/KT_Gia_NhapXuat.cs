using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDien.Source_Code_CSDL
{
    public partial class KT_Gia_NhapXuat
    {
        [Key]
        public int ID_Gia { get; set; }
        public string MaSP { get; set; }
        public int Soluong { get; set; }
        public int GiaNhap { get; set; }
        public int GiaBan { get; set; }
        public DateTime NgayApDung { get; set; }

        public KT_Gia_NhapXuat()
        {
            this.MuaHangs = new HashSet<MuaHang>();
        }
        public virtual ICollection<MuaHang> MuaHangs { get; set; }
        public virtual ChiTiet_SP ChiTiet_SP { get; set; }
    }
}
