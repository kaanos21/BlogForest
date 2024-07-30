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
    public class BlogManager : IBlogService
    {
        private readonly IBlogDal _blogDal;
        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public List<Blog> TGetLast2BlogByAppUser(int id)
        {
            return _blogDal.GetLast2BlogByAppUser(id);
        }

        public void tDelete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Blog> TGetBlogsWithCategoryAndUser()
        {
            return _blogDal.GetBlogsWithCategoryAndUser();
        }

        public Blog tGetById(int id)
        {
            return _blogDal.GetById(id);
        }

        public List<Blog> tGetListAll()
        {
           return _blogDal.GetListAll();
        }

        public void tInsert(Blog entity)
        {
            _blogDal.Insert(entity);
        }

        public void tUpdate(Blog entity)
        {
            throw new NotImplementedException();
        }

        public List<Blog> TGetBlogsByAuppUser(int id)
        {
            return _blogDal.GetBlogsByAuppUser(id);
        }

        public void TIncreaseBlogView(int id)
        {
            _blogDal.IncreaseBlogView(id);
        }
    }
}
