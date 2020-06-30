using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DACNPM.dll;
namespace GiaoDien
{
    public class CreateDB : CreateDatabaseIfNotExists<SE_14X>
    {
        protected override void Seed(SE_14X context)
        {
            context.ChiTiet_SPs.Add(new Source_Code_CSDL.ChiTiet_SP()
            {
                MaSP ="1", TenSP= "Xiaomi Redmi Note 9S",HangSX= "Xiaomi",ManHinh= "6.67 inch",
                BaoHanh= "18 tháng",Ram= "4GB",BoNhoTrong= "64GB",HeDieuHanh= "Android",
                Pin= "5020 mAh",SoSim=1,NoiXuatXu= "Trung Quốc",
                HinhAnh=Convert.ToBase64String(NVQL.Instance.converImgToByte("F:/Năm 2- Kỳ 2/ĐA CNPM/Ảnh_DA/xiaomi-redmi-note-9-pro-max.png"))
            });
            context.ChiTiet_SPs.Add(new Source_Code_CSDL.ChiTiet_SP()
            {
                MaSP = "2",
                TenSP = "Samsung Galaxy A30s",
                HangSX = "SamSung",
                ManHinh = "6.4 inch",
                BaoHanh = "12 tháng",
                Ram = "4GB",
                BoNhoTrong = "64GB",
                HeDieuHanh = "Android",
                Pin = "4000 mAh",
                SoSim = 1,
                NoiXuatXu = "Việt Nam",
                HinhAnh = Convert.ToBase64String(NVQL.Instance.converImgToByte("F:/Năm 2- Kỳ 2/ĐA CNPM/Ảnh_DA/SamSung Galaxy A30.png"))
            });
            context.ChiTiet_SPs.Add(new Source_Code_CSDL.ChiTiet_SP()
            {
                MaSP = "3",
                TenSP = "Samsung Galaxy A71",
                HangSX = "SamSung",
                ManHinh = "6.4 inch",
                BaoHanh = "12 tháng",
                Ram = "4GB",
                BoNhoTrong = "64GB",
                HeDieuHanh = "Android",
                Pin = "4000 mAh",
                SoSim = 1,
                NoiXuatXu = "Việt Nam",
                HinhAnh = Convert.ToBase64String(NVQL.Instance.converImgToByte("F:/Năm 2- Kỳ 2/ĐA CNPM/Ảnh_DA/SamSung Galaxy A71.png"))
            });
            context.ChiTiet_SPs.Add(new Source_Code_CSDL.ChiTiet_SP()
            {
                MaSP = "4",
                TenSP = "iPhone 7 Plus",
                HangSX = "Apple",
                ManHinh = "5.5 inch",
                BaoHanh = "12 tháng",
                Ram = "4GB",
                BoNhoTrong = "64GB",
                HeDieuHanh = "Android",
                Pin = "4000 mAh",
                SoSim = 1,
                NoiXuatXu = "Mỹ",
                HinhAnh = Convert.ToBase64String(NVQL.Instance.converImgToByte("F:/Năm 2- Kỳ 2/ĐA CNPM/Ảnh_DA/iphone-7-plus.jpg"))
            });
            context.ChiTiet_SPs.Add(new Source_Code_CSDL.ChiTiet_SP()
            {
                MaSP = "5",
                TenSP = "iPhone 11",
                HangSX = "Apple",
                ManHinh = "5.5 inch",
                BaoHanh = "12 tháng",
                Ram = "4GB",
                BoNhoTrong = "64GB",
                HeDieuHanh = "Android",
                Pin = "4000 mAh",
                SoSim = 1,
                NoiXuatXu = "Mỹ",
                HinhAnh = Convert.ToBase64String(NVQL.Instance.converImgToByte("F:/Năm 2- Kỳ 2/ĐA CNPM/Ảnh_DA/Iphone11.jpg"))
            });
            context.TaiKhoans.Add(new Source_Code_CSDL.TaiKhoan()
            {
                MaTK = "001",
                TenTK = "ADMIN",
                PassTK = NVQL.Instance.MaHoaMK("123456"),
                LoaiTK= "Admin"
            }) ;
            context.TaiKhoans.Add(new Source_Code_CSDL.TaiKhoan()
            {
                MaTK = "002",
                TenTK = "Manager1",
                PassTK = NVQL.Instance.MaHoaMK("123456"),
                LoaiTK = "Manager"
            });
            context.TaiKhoans.Add(new Source_Code_CSDL.TaiKhoan()
            {
                MaTK = "005",
                TenTK = "Customer1",
                PassTK = NVQL.Instance.MaHoaMK("123"),
                LoaiTK = "Customer"
            });
            context.ThongTinCaNhans.Add(new Source_Code_CSDL.ThongTinCaNhan()
            {
                MaTK = "005",
                TenKH = "Customer1",
                SoDT = "0123345",
                DiaChi = "Quảng Trị",
                NgaySinh = Convert.ToDateTime("2000-08-09"),
                Gender = true
            }) ;
            context.Theodoi_NVs.Add(new Source_Code_CSDL.Theodoi_NV()
            {
                MaTK = "002",
                TenNV = "Thu Ngân",
                SoDT = "01233468234",
                DiaChi = "Huế",
                NgaySinh = Convert.ToDateTime("2000-08-09"),
                Gender = true
            });
            context.KT_Gia_NhapXuats.Add(new Source_Code_CSDL.KT_Gia_NhapXuat()
            {
                MaSP= "1",
                GiaNhap= 2000000,
                GiaBan= 4790000,
                NgayApDung=Convert.ToDateTime("2000-08-09"),
                Soluong=10

            });
            context.KT_Gia_NhapXuats.Add(new Source_Code_CSDL.KT_Gia_NhapXuat()
            {
                MaSP = "2",
                GiaNhap = 2000000,
                GiaBan = 4790000,
                NgayApDung = Convert.ToDateTime("2000-08-09"),
                Soluong = 10

            });
            context.KT_Gia_NhapXuats.Add(new Source_Code_CSDL.KT_Gia_NhapXuat()
            {
                MaSP = "3",
                GiaNhap = 2000000,
                GiaBan = 4790000,
                NgayApDung = Convert.ToDateTime("2000-08-09"),
                Soluong = 10

            });
            context.KT_Gia_NhapXuats.Add(new Source_Code_CSDL.KT_Gia_NhapXuat()
            {
                MaSP = "4",
                GiaNhap = 2000000,
                GiaBan = 4790000,
                NgayApDung = Convert.ToDateTime("2000-08-09"),
                Soluong = 10

            });
            context.KT_Gia_NhapXuats.Add(new Source_Code_CSDL.KT_Gia_NhapXuat()
            {
                MaSP = "5",
                GiaNhap = 2000000,
                GiaBan = 4790000,
                NgayApDung = Convert.ToDateTime("2000-08-09"),
                Soluong = 10

            });
            context.DanhMucs.Add(new Source_Code_CSDL.DanhMuc()
            {
                MaDM = "1",
                TenDM = "Trên 10tr",
                LoaiDM = "Giá"
            });
            context.DanhMucs.Add(new Source_Code_CSDL.DanhMuc()
            {
                MaDM = "2",
                TenDM = "Trên 5tr",
                LoaiDM = "Giá"
            });
            context.DonHangs.Add(new Source_Code_CSDL.DonHang()
            {
                MaDonHang = "1",
                MaTK = "005",
                MaNV = "002",
                NgayTao = Convert.ToDateTime("2000-08-09"),
                TrangThai = true
            }) ;
            context.DonHangs.Add(new Source_Code_CSDL.DonHang()
            {
                MaDonHang = "2",
                MaTK = "005",
                MaNV = "002",
                NgayTao = Convert.ToDateTime("2000-08-09"),
                TrangThai = true
            });
            context.DonHangs.Add(new Source_Code_CSDL.DonHang()
            {
                MaDonHang = "3",
                MaTK = "005",
                MaNV = "002",
                NgayTao = Convert.ToDateTime("2000-08-09"),
                TrangThai = true
            });
            context.MuaHangs.Add(new Source_Code_CSDL.MuaHang()
            {
                MaMuaHang="1",
                MaDonHang="1",
                MaSP="1",
                SoLuong=2,
                ID_Gia=1
            });
            context.MuaHangs.Add(new Source_Code_CSDL.MuaHang()
            {
                MaMuaHang = "2",
                MaDonHang = "1",
                MaSP = "1",
                SoLuong = 2,
                ID_Gia = 1
            });
            context.MuaHangs.Add(new Source_Code_CSDL.MuaHang()
            {
                MaMuaHang = "3",
                MaDonHang = "1",
                MaSP = "1",
                SoLuong = 2,
                ID_Gia = 1
            });
            base.Seed(context);
        }
 
    }
}
