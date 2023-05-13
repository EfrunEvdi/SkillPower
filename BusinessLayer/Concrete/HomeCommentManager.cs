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
    public class HomeCommentManager : IHomeCommentService
    {
        private readonly IHomeCommentDal _homeCommentDal;

        public HomeCommentManager(IHomeCommentDal homeCommentDal)
        {
            _homeCommentDal = homeCommentDal;
        }

        public void TDelete(HomeComment t)
        {
            _homeCommentDal.Delete(t);
        }

        public HomeComment TGetByID(int id)
        {
            return _homeCommentDal.GetByID(id);
        }

        public List<HomeComment> TGetList()
        {
            return _homeCommentDal.GetList();
        }

        public void TInsert(HomeComment t)
        {
            _homeCommentDal.Insert(t);
        }

        public void TUpdate(HomeComment t)
        {
            _homeCommentDal.Update(t);
        }
    }
}
