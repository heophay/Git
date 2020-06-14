using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDien
{
    public partial class DonHang
    {
        [Key]
        public string MaDonHang { get; set; }
        [ForeignKey("ThongTinCaNhan")]
        public string MaTK { get; set; }
        [ForeignKey("Theodoi_NV")]
        public string MaNV { get; set; }
        
        public DateTime NgayTao { get; set; }
        public DateTime NgayThanhToan { get; set; }
        public Nullable<int> UuDai { get; set; }
        public bool TrangThai { get; set; }

        public DonHang()
        {
            this.MuaHangs = new HashSet<MuaHang>();
        }
        public virtual ICollection<MuaHang> MuaHangs { get; set; }
        public virtual Theodoi_NV Theodoi_NV { get; set; }
        public virtual ThongTinCaNhan ThongTinCaNhan { get; set; }
    }
}
