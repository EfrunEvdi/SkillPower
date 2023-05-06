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
        public string CourseName { get; set; }
        public string CourseTime { get; set; }
        public int CourseAttendee { get; set; }
        public bool CourseStatus { get; set; }
    }
}
