using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trotels.Entity.Abstract;

namespace Trotels.Entity.Concrete
{
   public class Guest:BaseEntity
   {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? GuestAmount { get; set; }
        public bool? Gender { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public string? TcNo { get; set; }
        public string? Adress { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        //Guest ve Booking arasındaki bire çok ilişki
        public ICollection<Booking>? Bookings { get; set; }
    }
}
