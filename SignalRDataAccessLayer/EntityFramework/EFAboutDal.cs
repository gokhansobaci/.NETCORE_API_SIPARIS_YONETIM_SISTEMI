using SignalR.EntityLayer.Entities;
using SignalRDataAccessLayer.Abstract;
using SignalRDataAccessLayer.Concrete;
using SignalRDataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRDataAccessLayer.EntityFramework
{
    public class EFAboutDal : GenericRepository<About>, IAboutDal

    {
        public EFAboutDal(SignalRContext context) : base(context)
        {
        }
    }

    public class EFBookingDal : GenericRepository<Booking>, IBookingDal

    {
        public EFBookingDal(SignalRContext context) : base(context)
        {
        }
    }
}
