using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDien
{
    public partial class Theodoi_NV
    {
        [Key]
        public string MaNV { get; set; }
        public string MaTK { get; set; }
        public string TenNV { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi{ get; set; }
        public string SoDT { get; set; }
        public bool Gender { get; set; }
        public Theodoi_NV()
        {
            this.DonHangs = new HashSet<DonHang>();
        }
        public virtual ICollection<DonHang> DonHangs { get; set; }
        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}
