﻿using BlogForest.DtoLayerr.CategoryDto;
using BlogForest.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogForest.BusinessLayer.Abstract
{
    public interface ICategoryService : IGenericService<Category>
    {
        public List<ResultCategoryWithCountDto> TGetCategoryWithCount();
    }
}
