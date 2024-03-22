using SignalR.EntityLayer.Entities;
using SignalRDataAccessLayer.Abstract;
using SignalRDataAccessLayer.Concrete;
using SignalRDataAccessLayer.Repositories;

namespace SignalRDataAccessLayer.EntityFramework
{
    public class EFCategoryDal : GenericRepository<Category>, ICategoryDal

    {
        public EFCategoryDal(SignalRContext context) : base(context)
        {
        }
    }
}
