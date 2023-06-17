using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Course
    {
        public int CourseID { get; set; }
        public string CourseImageUrl { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public decimal CourseTotalPrice { get; set; }
        public decimal CourseTotalTime { get; set; }
        public int CourseAttendee { get; set; }
        public int CourseLikes { get; set; }
        public bool CourseStatus { get; set; }

        public int AppUserID { get; set; }
        public AppUser AppUser { get; set; }

        public List<CourseDetail> CourseDetails { get; set; }

    }
}
