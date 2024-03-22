using SignalR.EntityLayer.Entities;
using SignalRDataAccessLayer.Abstract;
using SignalRDataAccessLayer.Concrete;
using SignalRDataAccessLayer.Repositories;

namespace SignalRDataAccessLayer.EntityFramework
{
    public class EFSocialMediaDal : GenericRepository<SocialMedia>, ISocialMediaDal

    {
        public EFSocialMediaDal(SignalRContext context) : base(context)
        {
        }
    }
}
