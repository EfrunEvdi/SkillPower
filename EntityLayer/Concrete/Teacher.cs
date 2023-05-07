using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Teacher
    {
        public int TeacherID { get; set; }
        public string TeacherName { get; set; }
        public string TeacherJob { get; set; }
        public string TeacherLink1 { get; set; }
        public string TeacherLink2 { get; set; }
        public bool TeacherStatus { get; set; }

        public int AppUserID { get; set; }
        public AppUser AppUser { get; set; }
    }
}
