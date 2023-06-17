using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AppUser : IdentityUser<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ImageUrl { get; set; }
        public int ConfirmCode { get; set; }

        public List<Blog> Blogs { get; set; }
        public List<Course> Courses { get; set; }
        public List<HomeComment> HomeComments { get; set; }
    }
}
