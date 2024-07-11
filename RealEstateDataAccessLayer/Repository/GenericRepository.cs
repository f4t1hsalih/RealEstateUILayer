using RealEstateDataAccessLayer.Abstract;
using System;
using System.Collections.Generic;

namespace RealEstateDataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T>
    {
        public void Delete(T t)
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<T> GetListAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(T t)
        {
            throw new NotImplementedException();
        }

        public void Update(T t)
        {
            throw new NotImplementedException();
        }
    }
}
