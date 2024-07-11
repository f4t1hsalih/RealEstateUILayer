using RealEstateDataAccessLayer.Abstract;
using RealEstateDataAccessLayer.Concrete;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace RealEstateDataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        Context context = new Context();
        DbSet<T> _object;

        public GenericRepository()
        {
            _object = context.Set<T>();
        }
        public void Delete(T t)
        {
            _object.Remove(t);
            context.SaveChanges();
        }

        public T GetById(int id)
        {
            return _object.Find(id);
        }

        public List<T> GetListAll()
        {
            return _object.ToList();
        }

        public void Insert(T t)
        {
            _object.Add(t);
            context.SaveChanges();
        }

        public void Update(T t)
        {
            context.SaveChanges();
        }
    }
}
