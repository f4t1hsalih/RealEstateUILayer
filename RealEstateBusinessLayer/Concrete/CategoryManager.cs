using RealEstateBusinessLayer.Abstract;
using RealEstateDataAccessLayer.Abstract;
using RealEstateEntityLayer.Concrete;
using System.Collections.Generic;

namespace RealEstateBusinessLayer.Concrete
{
    internal class CategoryManager : IGenericService<Categories>
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public Categories GetById(int id)
        {
            return _categoryDal.GetById(id);
        }

        public List<Categories> GetListAll()
        {
            return _categoryDal.GetListAll();
        }

        public void TDelete(Categories t)
        {
            _categoryDal.Delete(t);
        }

        public void TInsert(Categories t)
        {
            _categoryDal.Insert(t);
        }

        public void TUpdate(Categories t)
        {
            _categoryDal.Update(t);
        }
    }
}
