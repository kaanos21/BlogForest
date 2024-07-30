using BlogForest.DataAccesLayer.Abstract;
using BlogForest.DataAccesLayer.Context;
using BlogForest.DataAccesLayer.Repositories;
using BlogForest.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogForest.DataAccesLayer.EntityFramework
{
    public class EfAppUserDal : GenericRepository<AppUser>, IAppUserDal
    {
        public EfAppUserDal(BlogContext context) : base(context)
        {
        }

        public AppUser GetAppUserDetail(int id)
        {
            var context=new BlogContext();
            var value=context.Blogs.Where(x=>x.BlogId==id).Select(x=>x.AppUser).FirstOrDefault();
            return value;
        }
    }
}
