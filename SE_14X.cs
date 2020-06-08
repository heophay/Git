namespace GiaoDien
{
    using System;
    using System.Data.Entity;
    using System.Linq;

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
        }

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