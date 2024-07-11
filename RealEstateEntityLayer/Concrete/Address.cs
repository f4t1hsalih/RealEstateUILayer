using System.ComponentModel.DataAnnotations;

namespace RealEstateEntityLayer.Concrete
{
    public class Address
    {
        [Key]
        public int ads_id { get; set; }
        public string ads_address { get; set; }
        public string ads_phone1 { get; set; }
        public string ads_phone2 { get; set; }
        public string ads_email1 { get; set; }
        public string ads_email2 { get; set; }
        public string ads_mapLocation { get; set; }

    }
}
