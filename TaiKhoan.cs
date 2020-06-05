using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDien
{
    public class TaiKhoan
    {
        [Key]
        public string MaTK { get; set; }
        public string TenTK { get; set; }
        public string Pass { get; set; }
        public string LoaiTK { get; set; }
    }
}
