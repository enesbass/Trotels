using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trotels.DAL.Repository.Abstract;
using Trotels.Entity.Concrete;

namespace Trotels.DAL.Repository.Concrete
{
    public class BookingRepository:BaseRepository<Booking>,IBookingRepository
    {

    }
}
