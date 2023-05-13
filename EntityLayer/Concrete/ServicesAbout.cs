using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ServicesAbout
    {
        public int ServicesAboutID { get; set; }
        public string AboutIcon { get; set; }
        public string AboutTitle { get; set; }
        public string AboutDescription { get; set; }
    }
}
