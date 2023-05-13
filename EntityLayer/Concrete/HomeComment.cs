using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class HomeComment
    {
        public int HomeCommentID { get; set; }
        public string CommentNameSurname { get; set; }
        public string CommentComment { get; set; }
        public string CommentImageURL { get; set; }
        public bool CommentStatus { get; set; }

        public int AppUserID { get; set; }
        public AppUser AppUser { get; set; }
    }
}
