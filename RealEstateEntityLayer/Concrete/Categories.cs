using System.ComponentModel.DataAnnotations;

namespace RealEstateEntityLayer.Concrete
{
    public class Categories
    {
        [Key]
        public int ctg_id { get; set; }
        public string ctg_name { get; set; }
        public string ctg_details { get; set; }
        public bool ctg_status { get; set; }
    }
}
