using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogForest.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void tInsert(T entity);
        void tUpdate(T entity);
        void tDelete(int id);
        T tGetById(int id);
        List<T> tGetListAll();
    }
}
