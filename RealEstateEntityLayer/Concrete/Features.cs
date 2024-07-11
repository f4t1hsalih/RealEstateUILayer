using System.ComponentModel.DataAnnotations;

namespace RealEstateEntityLayer.Concrete
{
    public class Features
    {
        [Key]
        public int ftr_id { get; set; }
        public string ftr_title { get; set; }
        public string ftr_title2 { get; set; }
        public string ftr_description { get; set; }

    }
}
