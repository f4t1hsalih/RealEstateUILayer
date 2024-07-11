using RealEstateDataAccessLayer.Abstract;
using RealEstateDataAccessLayer.Repository;
using RealEstateEntityLayer.Concrete;

namespace RealEstateDataAccessLayer.EntityFramework
{
    public class EfSocialMediaDal : GenericRepository<SocialMedias>, ISocialMediaDal
    {
    }
}
