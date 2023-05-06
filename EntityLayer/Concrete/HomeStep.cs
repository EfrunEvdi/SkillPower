using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class HomeStep
    {
        public int StepID { get; set; }
        public string StepTitle { get; set; }
        public string StepDescription { get; set; }
        public bool StepStatus { get; set; }

    }
}
