using SignalR.EntityLayer.Entities;
using SignalRDataAccessLayer.Abstract;
using SignalRDataAccessLayer.Concrete;
using SignalRDataAccessLayer.Repositories;

namespace SignalRDataAccessLayer.EntityFramework
{
    public class EFDiscountDal : GenericRepository<Discount>, IDiscountDal

    {
        public EFDiscountDal(SignalRContext context) : base(context)
        {
        }
    }
}
