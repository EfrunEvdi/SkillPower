using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ServicesHeader
    {
        public int ServicesHeaderID { get; set; }
        public string HeaderTitle { get; set; }
        public string HeaderDescription { get; set; }
        public string HeaderArticle1 { get; set; }
        public string HeaderArticle2 { get; set; }
        public string HeaderArticle3 { get; set; }
        public string HeaderArticle4 { get; set; }
        public bool HeaderStatus { get; set; }
    }
}
