using System.ComponentModel.DataAnnotations;

namespace RealEstateEntityLayer.Concrete
{
    public class Subscribes
    {
        [Key]
        public int sbs_id { get; set; }
        public string sbs_email { get; set; }
    }
}
