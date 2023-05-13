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
    public class AboutHeaderManager : IAboutHeaderService
    {
        private readonly IAboutHeaderDal _aboutHeaderDal;

        public AboutHeaderManager(IAboutHeaderDal aboutHeaderDal)
        {
            _aboutHeaderDal = aboutHeaderDal;
        }

        public void TDelete(AboutHeader t)
        {
            _aboutHeaderDal.Delete(t);
        }

        public AboutHeader TGetByID(int id)
        {
            return _aboutHeaderDal.GetByID(id);
        }

        public List<AboutHeader> TGetList()
        {
            return _aboutHeaderDal.GetList();
        }

        public void TInsert(AboutHeader t)
        {
            _aboutHeaderDal.Insert(t);
        }

        public void TUpdate(AboutHeader t)
        {
            _aboutHeaderDal.Update(t);
        }
    }
}
