using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Statistic
    {
        public int StatisticID { get; set; }
        public string StatisticIcon { get; set; }
        public int StatisticNumber { get; set; }
        public string StatisticName { get; set; }
        public bool StatisticStatus { get; set; }
    }
}
