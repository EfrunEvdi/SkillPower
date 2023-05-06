using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Blog
    {
        public int BlogID { get; set; }
        public string BlogTitle { get; set; }
        public string BlogDescription { get; set; }
        public string BlogContent1 { get; set; }
        public string BlogContent2 { get; set; }
        public string BlogContent3 { get; set; }
        public string BlogContent4 { get; set; }
        public string BlogContent5 { get; set; }
        public string BlogContent16 { get; set; }
        public string BlogContent7 { get; set; }
        public string BlogContent8 { get; set; }
        public string BlogContent9 { get; set; }
        public string BlogContent10 { get; set; }
        public string BlogContent11 { get; set; }
        public string BlogContent12 { get; set; }
        public string BlogContent13 { get; set; }
        public string BlogThumbnailImage { get; set; }
        public string BlogImage { get; set; }
        public DataType BlogDate { get; set; }
        public bool BlogStatus { get; set; }
    }
}
