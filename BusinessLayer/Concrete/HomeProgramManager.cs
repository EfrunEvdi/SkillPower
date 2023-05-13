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
    public class HomeProgramManager : IHomeProgramService
    {
        private readonly IHomeProgramDal _homeProgramDal;

        public HomeProgramManager(IHomeProgramDal homeProgramDal)
        {
            _homeProgramDal = homeProgramDal;
        }

        public void TDelete(HomeProgram t)
        {
            _homeProgramDal.Delete(t);
        }

        public HomeProgram TGetByID(int id)
        {
            return _homeProgramDal.GetByID(id);
        }

        public List<HomeProgram> TGetList()
        {
            return _homeProgramDal.GetList();
        }

        public void TInsert(HomeProgram t)
        {
            _homeProgramDal.Insert(t);
        }

        public void TUpdate(HomeProgram t)
        {
            _homeProgramDal.Update(t);
        }
    }
}
