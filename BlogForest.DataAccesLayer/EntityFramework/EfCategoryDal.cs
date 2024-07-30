using BlogForest.DataAccesLayer.Abstract;
using BlogForest.DataAccesLayer.Context;
using BlogForest.DataAccesLayer.Repositories;
using BlogForest.DtoLayerr.CategoryDto;
using BlogForest.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogForest.DataAccesLayer.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        private readonly BlogContext _context;

        public EfCategoryDal(BlogContext context) : base(context)
        {
            _context = context;
        }

        public List<ResultCategoryWithCountDto> GetCategoryWithCount()
        {
            
            var categoryBlogCounts = _context.Category.Select(c => new ResultCategoryWithCountDto
            {
                CategoryName = c.CategoryName,
                CategoryCount=c.Blogs.Count
            }).ToList();
            return categoryBlogCounts;
        }
    }
}
