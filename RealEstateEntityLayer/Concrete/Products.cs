using System.ComponentModel.DataAnnotations;

namespace RealEstateEntityLayer.Concrete
{
    public class Products
    {
        [Key]
        public int prd_id { get; set; }
        public string prd_type { get; set; }
        public decimal prd_price { get; set; }
        public string prd_title { get; set; }
        public string prd_size { get; set; }

    }
}
