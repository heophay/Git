using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDien
{
    public partial class ThongTinCaNhan
    {
        [Key,ForeignKey("TaiKhoan")]
        public string MaTK { get; set; }
        public string TenKH { get; set; }
        public string SoDT { get; set; }
        public string DiaChi { get; set; }
        public DateTime NgaySinh { get; set; }
        public bool Gender { get; set; }

        public virtual TaiKhoan TaiKhoan { get; set; }
        public ThongTinCaNhan()
        {

        }
    }
}
