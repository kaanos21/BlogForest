using BlogForest.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogForest.DataAccesLayer.Abstract
{
    public interface IBlogDal :IGenericDal<Blog>
    {
        List<Blog> GetBlogsWithCategoryAndUser();
        List<Blog> GetLast2BlogByAppUser(int id);
        List<Blog> GetBlogsByAuppUser(int id);
        void IncreaseBlogView(int id);
    }
}
