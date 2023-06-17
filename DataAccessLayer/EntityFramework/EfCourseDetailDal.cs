using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfCourseDetailDal : GenericRepository<CourseDetail>, ICourseDetailDal
    {
        public List<CourseDetail> GetListByCourseID(int id)
        {
            using (var c = new Context())
            {
                return c.Courses
                        .Include(x => x.CourseDetails)  // CourseDetail'ı include et
                        .Where(x => x.CourseID == id)   // CourseID'ye göre filtrele
                        .SelectMany(x => x.CourseDetails)  // CourseDetails'i düzleştir
                        .ToList();
            }
        }
    }
}
