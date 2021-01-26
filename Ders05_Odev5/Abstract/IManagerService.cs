using System;
using System.Collections.Generic;
using System.Text;

namespace Ders05_Odev5.Abstract
{
    public interface IManagerService<T>
    {
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        void Get(T entity);
        void GetAll(List<T> entities);
    }
}
