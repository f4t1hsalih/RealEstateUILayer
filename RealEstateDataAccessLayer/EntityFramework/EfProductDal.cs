using RealEstateDataAccessLayer.Abstract;
using RealEstateDataAccessLayer.Repository;
using RealEstateEntityLayer.Concrete;

namespace RealEstateDataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Products>, IProductDal
    {
    }
}
