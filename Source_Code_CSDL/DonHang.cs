using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDien
{
    public partial class DonHang
    {
        [Key]
        public string MaDonHang { get; set; }
        public string MaTK { get; set; }
        public string MaNV { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayThanhToan { get; set; }
        public Nullable<int> UuDai { get; set; }
        public bool TrangThai { get; set; }
    }
}
