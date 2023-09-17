using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trotels.BL.Abstract;
using Trotels.DAL.Repository.Abstract;
using Trotels.DAL.Repository.Concrete;
using Trotels.Entity.Concrete;

namespace Trotels.BL.Concrete
{
    public class BookingManager : BaseManager<Booking>, IBookingManager
    {
        private readonly IBookingRepository repository;

        public BookingManager(IBookingRepository repository) : base(repository)
        {
            this.repository = repository;
        }

        public async Task<bool> CheckInVarMi(TimeSpan checkin)
        {
            var booking = await repository.GetBy(p => p.CheckIn == checkin);
            if (booking == null)
            {
                return true;
            }
            return false;

        }

        public async Task<bool> CheckOutVarMi(TimeSpan checkout)
        {
            var booking = await repository.GetBy(p => p.CheckOut == checkout);
            if (booking == null)
            {
                return true;
            }
            return false;
        }
    }
}
