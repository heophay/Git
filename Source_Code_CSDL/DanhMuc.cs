using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDien.Source_Code_CSDL
{
    public partial class DanhMuc
    {
        [Key]
        public string MaDM { get; set; }
        public string TenDM { get; set; }
        public string LoaiDM { get; set; }

        public virtual ICollection<ChiTiet_SP> ChiTiet_SPs { get; set; }
    }
}
