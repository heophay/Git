using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDien
{
    public partial class TaiKhoan
    {
        [Key]
        public string MaTK { get; set; }
        public string TenTK { get; set; }
        public string PassTK { get; set; }
        public string LoaiTK { get; set; }

        public TaiKhoan()
        {
            this.DonHangs = new HashSet<DonHang>();
            
                    
        }
        public virtual ICollection<DonHang> DonHangs { get; set; }
        public virtual Theodoi_NV Theodoi_NVs { get; set; }
        public virtual ThongTinCaNhan ThongTinCaNhans { get; set; }
    }
}
