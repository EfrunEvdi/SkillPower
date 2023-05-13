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
    public class ServicesAboutManager : IServicesAboutService
    {
        private readonly IServicesAboutDal _servicesAboutDal;

        public ServicesAboutManager(IServicesAboutDal servicesAboutDal)
        {
            _servicesAboutDal = servicesAboutDal;
        }

        public void TDelete(ServicesAbout t)
        {
            _servicesAboutDal.Delete(t);
        }

        public ServicesAbout TGetByID(int id)
        {
            return _servicesAboutDal.GetByID(id);
        }

        public List<ServicesAbout> TGetList()
        {
            return _servicesAboutDal.GetList();
        }

        public void TInsert(ServicesAbout t)
        {
            _servicesAboutDal.Insert(t);
        }

        public void TUpdate(ServicesAbout t)
        {
            _servicesAboutDal.Update(t);
        }
    }
}
