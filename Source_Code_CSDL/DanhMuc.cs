using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDien
{
    public partial class DanhMuc
    {
        [Key]
        public string MaDM { get; set; }
        public string MaSP { get; set; }
        public string TenDM { get; set; }
        public string LoaiDM { get; set; }
        [ForeignKey("MaSP")]
        public virtual ICollection<ChiTiet_SP> ChiTiet_SPs { get; set; }
    }
}
