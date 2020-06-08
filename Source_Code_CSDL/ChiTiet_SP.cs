using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDien
{
    public partial class ChiTiet_SP
    {
        [Key]
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string HangSX { get; set;}
        public string ManHinh { get; set; }
        public string BaoHanh { get; set; }
        public string Ram { get; set; }
        public string BoNhoTrong { get; set; }
        public string HeDieuHanh { get; set; }
        public string Pin { get; set; }
        public int SoSim { get; set; }
        public string NoiXuatXu { get; set; }
    }
}
