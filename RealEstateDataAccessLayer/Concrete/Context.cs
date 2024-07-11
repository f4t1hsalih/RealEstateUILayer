using RealEstateEntityLayer.Concrete;
using System.Data.Entity;

namespace RealEstateDataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        public DbSet<Categories> tbl_categories { get; set; }
        public DbSet<Customers> tbl_customers { get; set; }
        public DbSet<Products> tbl_products { get; set; }
        public DbSet<Address> tbl_address { get; set; }
        public DbSet<Contact> tbl_contacts { get; set; }
        public DbSet<Features> tbl_features { get; set; }
        public DbSet<FeatureServices> tbl_featureServices { get; set; }
        public DbSet<SocialMedias> tbl_socialMedias { get; set; }
        public DbSet<Subscribes> tbl_subscribes { get; set; }
        public DbSet<Testimonials> tbl_testimonials { get; set; }
    }
}
