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
    public class ServicesFeaturedManager : IServicesFeaturedService
    {
        private readonly IServicesFeaturedDal _servicesFeaturedDal;

        public ServicesFeaturedManager(IServicesFeaturedDal servicesFeaturedDal)
        {
            _servicesFeaturedDal = servicesFeaturedDal;
        }

        public void TDelete(ServicesFeatured t)
        {
            _servicesFeaturedDal.Delete(t);
        }

        public ServicesFeatured TGetByID(int id)
        {
            return _servicesFeaturedDal.GetByID(id);
        }

        public List<ServicesFeatured> TGetList()
        {
            return _servicesFeaturedDal.GetList();
        }

        public void TInsert(ServicesFeatured t)
        {
            _servicesFeaturedDal.Insert(t);
        }

        public void TUpdate(ServicesFeatured t)
        {
            _servicesFeaturedDal.Update(t);
        }
    }
}
