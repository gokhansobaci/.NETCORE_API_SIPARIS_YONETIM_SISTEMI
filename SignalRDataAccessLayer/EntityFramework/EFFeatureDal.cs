using SignalR.EntityLayer.Entities;
using SignalRDataAccessLayer.Abstract;
using SignalRDataAccessLayer.Concrete;
using SignalRDataAccessLayer.Repositories;

namespace SignalRDataAccessLayer.EntityFramework
{
    public class EFFeatureDal : GenericRepository<Feature>, IFeatureDal

    {
        public EFFeatureDal(SignalRContext context) : base(context)
        {
        }
    }
}
