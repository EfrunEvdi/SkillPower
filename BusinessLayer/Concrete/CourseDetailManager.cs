using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CourseDetailManager : ICourseDetailService
    {
        private readonly ICourseDetailDal _courseDetailDal;

        public CourseDetailManager(ICourseDetailDal courseDetailDal)
        {
            _courseDetailDal = courseDetailDal;
        }

        public void TDelete(CourseDetail t)
        {
            _courseDetailDal.Delete(t);
        }

        public CourseDetail TGetByID(int id)
        {
            return _courseDetailDal.GetByID(id);
        }

        public List<CourseDetail> TGetList()
        {
            return _courseDetailDal.GetList();
        }

        public void TInsert(CourseDetail t)
        {
            _courseDetailDal.Insert(t);
        }

        public void TUpdate(CourseDetail t)
        {
            _courseDetailDal.Update(t);
        }
    }
}
