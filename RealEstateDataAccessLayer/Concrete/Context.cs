using RealEstateEntityLayer.Concrete;
using System.Data.Entity;

namespace RealEstateDataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        public DbSet<Categories> tbl_categories { get; set; }
        public DbSet<Customers> tbl_customers { get; set; }
        public DbSet<Products> tbl_products { get; set; }
    }
}
