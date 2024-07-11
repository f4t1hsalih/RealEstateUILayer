using System.ComponentModel.DataAnnotations;

namespace RealEstateEntityLayer.Concrete
{
    public class Testimonials
    {
        [Key]
        public int tst_id { get; set; }
        public string tst_name { get; set; }
        public string tst_job { get; set; }
        public string tst_title { get; set; }
        public string tst_description { get; set; }
        public string tst_image { get; set; }
    }
}
