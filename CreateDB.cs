using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDien
{
    public class CreateDB : CreateDatabaseIfNotExists<SE_14>
    {
        protected override void Seed(SE_14 context)
        {
            context.TaiKhoans.Add(new TaiKhoan
            {
                MaTK = "001",
                TenTK = "ADMIN",
                PassTK = "123456",
                LoaiTK = "Admin"
            });
            context.TaiKhoans.Add(new TaiKhoan
            {
                MaTK = "002",
                TenTK = "Manager1",
                PassTK = "123456",
                LoaiTK = "Manager"
            });
            context.TaiKhoans.Add(new TaiKhoan
            {
                MaTK = "005",
                TenTK = "Customer1",
                PassTK = "123",
                LoaiTK = "Customer"
            });
            base.Seed(context);
        }
    }
}
