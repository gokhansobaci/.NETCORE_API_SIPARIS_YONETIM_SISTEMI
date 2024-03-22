using SignalR.EntityLayer.Entities;
using SignalRDataAccessLayer.Abstract;
using SignalRDataAccessLayer.Concrete;
using SignalRDataAccessLayer.Repositories;

namespace SignalRDataAccessLayer.EntityFramework
{
    public class EFTestimonialDal : GenericRepository<Testimonial>, ITestimonialDal

    {
        public EFTestimonialDal(SignalRContext context) : base(context)
        {
        }
    }
}
