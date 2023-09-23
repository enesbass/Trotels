using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trotels.Entity.Abstract;

namespace Trotels.Entity.Concrete
{
    public class Hotel:BaseEntity
    {
        public string HotelName { get; set; }
        public string HotelAddress { get; set; }
        public string HotelCity { get; set; }
        public string HotelCountry { get; set; }

        public string? PhoneNo { get; set; }
        public string? Rating { get; set; }
        //Hotel ve Room arasındaki bire çok ilişki
        public ICollection<Room>? RoomNum { get; set; }

        //Hotel ve Rezervasyon arasındaki bire çok ilişki
        public ICollection<Booking>? Bookings { get; set; }

    }
}
