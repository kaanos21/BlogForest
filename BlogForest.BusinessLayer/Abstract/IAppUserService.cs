﻿using BlogForest.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BlogForest.BusinessLayer.Abstract
{
    public interface IAppUserService : IGenericService<AppUser>
    {
        public AppUser TGetAppUserDetail(int id);
    }
}
