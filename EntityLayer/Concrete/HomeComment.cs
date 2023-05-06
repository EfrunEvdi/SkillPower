using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class HomeComment
    {
        public int CommentID { get; set; }
        public string CommentNameSurname { get; set; }
        public string CommentComment { get; set; }
        public string CommentImageURL { get; set; }
        public bool CommentStatus { get; set; }
    }
}
