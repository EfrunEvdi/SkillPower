using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class CourseDetail
    {
        public int CourseDetailID { get; set; }
        public string CourseImageUrl { get; set; }
        public string CourseName { get; set; }
        public string CourseLink { get; set; }
        public string CourseDescription { get; set; }
        public decimal CoursePrice { get; set; }
        public decimal CourseTime { get; set; }

        public int CourseID { get; set; }
        public Course Course { get; set; }

        public int TeacherID { get; set; }
        public Teacher Teacher { get; set; }

        public int AppUserID { get; set; }
        public AppUser AppUser { get; set; }
    }
}
