using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trotels.Entity.Abstract;

namespace Trotels.Entity.Concrete
{
    public class Booking:BaseEntity
    {
        public TimeSpan CheckIn { get; set; }
        public TimeSpan CheckOut { get; set; }
        public int? NumberOfGuests { get; set; }

        //Rezervasyon ve Room arasındaki bire bir ilişki
        public int? RoomId { get; set; }
        public Room? Room { get; set; }

        //Rezervasyon ve Hotel arasındaki bire çok ilişki
        public int? HotelId { get; set; }
        public Hotel? Hotel { get; set; }
    }
}
