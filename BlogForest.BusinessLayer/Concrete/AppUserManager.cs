using BlogForest.BusinessLayer.Abstract;
using BlogForest.DataAccesLayer.Abstract;
using BlogForest.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogForest.BusinessLayer.Concrete
{
    public class AppUserManager : IAppUserService
    {
        private readonly IAppUserDal _appUserDal;

        public AppUserManager(IAppUserDal appUserDal)
        {
            _appUserDal = appUserDal;
        }

        public void tDelete(int id)
        {
            throw new NotImplementedException();
        }

        public AppUser TGetAppUserDetail(int id)
        {
            return _appUserDal.GetAppUserDetail(id);
        }

        public AppUser tGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<AppUser> tGetListAll()
        {
            throw new NotImplementedException();
        }

        public void tInsert(AppUser entity)
        {
            throw new NotImplementedException();
        }

        public void tUpdate(AppUser entity)
        {
            throw new NotImplementedException();
        }
    }
}
