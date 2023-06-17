using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.Dtos.CourseDtos
{
    public class CreateCourseDto
    {
        public string CourseName { get; set; }
        public string CourseImageUrl { get; set; }
        public string CourseDescription { get; set; }
        public int CourseTotalPrice { get; set; }
        public int CourseTotalTime { get; set; }
        public int CourseAttendee { get; set; }
        public int CourseLikes { get; set; }
        public bool CourseStatus { get; set; }

        public int AppUserID { get; set; }
    }
}
