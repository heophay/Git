//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GiaoDien
{
    using System;
    using System.Collections.Generic;
    
    public partial class MuaHang
    {
        public string MaMuaHang { get; set; }
        public string MaDonHang { get; set; }
        public string MaSP { get; set; }
        public int SoLuong { get; set; }
        public int ID_Gia { get; set; }
        public int ThanhTien { get; set; }
    
        public virtual ChiTiet_SP ChiTiet_SP { get; set; }
        public virtual DonHang DonHang { get; set; }
        public virtual KT_Gia_NhapXuat KT_Gia_NhapXuat { get; set; }
    }
}