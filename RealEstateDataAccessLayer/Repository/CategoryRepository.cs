using RealEstateDataAccessLayer.Abstract;
using RealEstateDataAccessLayer.Concrete;
using RealEstateEntityLayer.Concrete;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace RealEstateDataAccessLayer.Repository
{
    public class CategoryRepository : ICategoryDal
    {
        Context con = new Context();
        DbSet<Categories> _category;
        public void Delete(Categories t)
        {
            _category.Remove(t);
            con.SaveChanges();
        }

        public Categories GetById(int id)
        {
            return _category.Find(id);
        }

        public List<Categories> GetListAll()
        {
            return _category.ToList();
        }

        public void Insert(Categories t)
        {
            _category.Add(t);
            con.SaveChanges();
        }

        public void Update(Categories t)
        {
            con.SaveChanges();
        }
    }
}
