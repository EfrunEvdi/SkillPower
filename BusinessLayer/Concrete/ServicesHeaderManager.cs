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
    public class ServicesHeaderManager : IServicesHeaderService
    {
        private readonly IServicesHeaderDal _servicesHeaderDal;

        public ServicesHeaderManager(IServicesHeaderDal servicesHeaderDal)
        {
            _servicesHeaderDal = servicesHeaderDal;
        }

        public void TDelete(ServicesHeader t)
        {
            _servicesHeaderDal.Delete(t);
        }

        public ServicesHeader TGetByID(int id)
        {
            return _servicesHeaderDal.GetByID(id);
        }

        public List<ServicesHeader> TGetList()
        {
            return _servicesHeaderDal.GetList();
        }

        public void TInsert(ServicesHeader t)
        {
            _servicesHeaderDal.Insert(t);
        }

        public void TUpdate(ServicesHeader t)
        {
            _servicesHeaderDal.Update(t);
        }
    }
}
