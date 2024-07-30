using BlogForest.BusinessLayer.Abstract;
using BlogForest.DataAccesLayer.Abstract;
using BlogForest.DtoLayerr.CategoryDto;
using BlogForest.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogForest.BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void tDelete(int id)
        {
            throw new NotImplementedException();
        }

        public Category tGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<ResultCategoryWithCountDto> TGetCategoryWithCount()
        {
            return _categoryDal.GetCategoryWithCount();
        }

        public List<Category> tGetListAll()
        {
            throw new NotImplementedException();
        }

        public void tInsert(Category entity)
        {
            throw new NotImplementedException();
        }

        public void tUpdate(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
