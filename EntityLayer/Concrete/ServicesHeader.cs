using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ServicesHeader
    {
        public int HeaderID { get; set; }
        public string HeaderTitle { get; set; }
        public string HeaderDescription { get; set; }
        public string HeaderArticle1 { get; set; }
        public string HeaderArticle2 { get; set; }
        public string HeaderArticle3 { get; set; }
        public string HeaderArticle4 { get; set; }
        public bool HeaderStatus { get; set; }
    }
}
