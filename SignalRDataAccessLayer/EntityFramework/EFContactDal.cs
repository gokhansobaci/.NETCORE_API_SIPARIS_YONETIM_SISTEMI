using SignalR.EntityLayer.Entities;
using SignalRDataAccessLayer.Abstract;
using SignalRDataAccessLayer.Concrete;
using SignalRDataAccessLayer.Repositories;

namespace SignalRDataAccessLayer.EntityFramework
{
    public class EFContactDal : GenericRepository<Contact>, IContactDal

    {
        public EFContactDal(SignalRContext context) : base(context)
        {
        }
    }
}
