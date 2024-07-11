using System.ComponentModel.DataAnnotations;

namespace RealEstateEntityLayer.Concrete
{
    public class FeatureServices
    {
        [Key]
        public int fsr_id { get; set; }
        public string fsr_title { get; set; }
        public string fsr_description { get; set; }
        public string fsr_image { get; set; }
    }
}
