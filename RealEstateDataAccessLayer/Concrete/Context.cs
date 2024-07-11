using RealEstateEntityLayer.Concrete;
using System.Data.Entity;

namespace RealEstateDataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        public DbSet<Categories> tbl_categories { get; set; }
    }
}
