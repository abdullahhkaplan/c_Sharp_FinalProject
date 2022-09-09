using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.Entityframework
{
    // contex: db tabloları ile proje claslarını bağlamak
    // overide on yazınca en üsttekine tıkla protected clasını olusturur 
    public class NorthwindContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=(localdb)\MSSQLLocalDB; Database =Northwind; Trusted_Connection=True"); // key sensitive değil 
           //  optionsBuilder.UseSqlServer(@"server=175.45.2.12"); database ip address
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}
