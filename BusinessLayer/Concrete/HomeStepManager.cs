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
    public class HomeStepManager : IHomeStepService
    {
        private readonly IHomeStepDal _homeStepDal;

        public HomeStepManager(IHomeStepDal homeStepDal)
        {
            _homeStepDal = homeStepDal;
        }

        public void TDelete(HomeStep t)
        {
            _homeStepDal.Delete(t);
        }

        public HomeStep TGetByID(int id)
        {
            return _homeStepDal.GetByID(id);
        }

        public List<HomeStep> TGetList()
        {
            return _homeStepDal.GetList();
        }

        public void TInsert(HomeStep t)
        {
            _homeStepDal.Insert(t);
        }

        public void TUpdate(HomeStep t)
        {
            _homeStepDal.Update(t);
        }
    }
}
