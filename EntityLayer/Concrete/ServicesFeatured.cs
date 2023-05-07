using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ServicesFeatured
    {
        [Key]
        public int FeaturedID { get; set; }
        public string FeaturedIcon { get; set; }
        public string FeaturedTitle { get; set; }
        public string FeaturedDescription { get; set; }
    }
}
