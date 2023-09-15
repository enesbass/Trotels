using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trotels.Entity.Abstract;

namespace Trotels.Entity.Concrete
{
    public class Room:BaseEntity
    {
        public string RoomNo { get; set; }
        public string RoomType { get; set; }
        public string Occupancy { get; set; }
        public string? Price { get; set; }
        public string? Description { get; set; }
        //Hotel ve Room arasındaki bire çok ilişki
        public int? HotelId { get; set; }
        public Hotel? Hotel { get; set; }

        //Room ve Booking arasındaki bire bir ilişki
        public int? BookingId { get; set; }
        public Booking? Booking { get; set; }

    }
}
