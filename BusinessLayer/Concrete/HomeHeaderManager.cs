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
    public class HomeHeaderManager : IHomeHeaderService
    {
        private readonly IHomeHeaderDal _homeHeaderDal;

        public HomeHeaderManager(IHomeHeaderDal homeHeaderDal)
        {
            _homeHeaderDal = homeHeaderDal;
        }

        public void TDelete(HomeHeader t)
        {
            _homeHeaderDal.Delete(t);
        }

        public HomeHeader TGetByID(int id)
        {
            return _homeHeaderDal.GetByID(id);
        }

        public List<HomeHeader> TGetList()
        {
            return _homeHeaderDal.GetList();
        }

        public void TInsert(HomeHeader t)
        {
            _homeHeaderDal.Insert(t);
        }

        public void TUpdate(HomeHeader t)
        {
            _homeHeaderDal.Update(t);
        }
    }
}
