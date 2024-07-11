using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateEntityLayer.Concrete
{
    public class Contact
    {
        [Key]
        public int cnt_id { get; set; }
        public string cnt_name { get; set; }
        public string cnt_subject { get; set; }
        public string cnt_email { get; set; }
        public string cnt_description { get; set; }
        public DateTime cnt_date { get; set; }
    }
}
