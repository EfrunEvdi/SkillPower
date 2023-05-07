using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class HomeStep
    {
        [Key]
        public int StepID { get; set; }
        public string StepTitle { get; set; }
        public string StepDescription { get; set; }
        public bool StepStatus { get; set; }

    }
}
