using System.ComponentModel.DataAnnotations;

namespace RealEstateEntityLayer.Concrete
{
    public class Customers
    {
        [Key]
        public int ctm_id { get; set; }
        public string ctm_name { get; set; }
        public string ctm_surname { get; set; }
        public string ctm_phone { get; set; }
        public string ctm_email { get; set; }
    }
}
