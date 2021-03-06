namespace GiaoDien
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using GiaoDien.Source_Code_CSDL;
    public class SE_14X : DbContext
    {
        // Your context has been configured to use a 'SE_14X' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'GiaoDien.SE_14X' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'SE_14X' 
        // connection string in the application configuration file.
        public SE_14X()
            : base("name=SE_14X")
        {
            Database.SetInitializer(new CreateDB());
        }
        public virtual DbSet<ChiTiet_SP> ChiTiet_SPs { get; set; }
        public virtual DbSet<DanhMuc> DanhMucs { get; set; }
        public virtual DbSet<DonHang> DonHangs { get; set; }
        public virtual DbSet<KT_Gia_NhapXuat> KT_Gia_NhapXuats { get; set; }
        public virtual DbSet<MuaHang> MuaHangs { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<Theodoi_NV> Theodoi_NVs { get; set; }
        public virtual DbSet<ThongTinCaNhan> ThongTinCaNhans { get; set; }
        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}