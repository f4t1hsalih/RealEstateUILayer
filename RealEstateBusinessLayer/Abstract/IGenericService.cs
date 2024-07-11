using System.Collections.Generic;

namespace RealEstateBusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void TInsert(T t);
        void TDelete(T t);
        void TUpdate(T t);
        T GetById(int id);
        List<T> GetListAll();
    }
}
