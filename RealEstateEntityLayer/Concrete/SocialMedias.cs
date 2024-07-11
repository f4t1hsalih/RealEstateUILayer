using System.ComponentModel.DataAnnotations;

namespace RealEstateEntityLayer.Concrete
{
    public class SocialMedias
    {
        [Key]
        public int scl_id { get; set; }
        public string scl_title { get; set; }
        public string scl_url { get; set; }
    }
}
