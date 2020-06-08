using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDien
{
    public partial class KT_Gia_NhapXuat
    {
        [Key]
        public int ID_Gia { get; set; }
        public string MaSP { get; set; }
        public int GiaNhap { get; set; }
        public int GiaBan { get; set; }
        public DateTime NgayApDung { get; set; }
    }
}
