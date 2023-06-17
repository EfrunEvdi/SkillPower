using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICourseDetailService : IGenericService<CourseDetail>
    {
        List<CourseDetail> TGetListByCourseID(int id);

    }
}
