using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trotels.Entity.Abstract;

namespace Trotels.Entity.Concrete
{
    public class Employee:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Title { get; set; }  
        public string? Email { get; set; }
        
        public string? Phone { get; set; }
        //Hotel ve Employee arasındaki bire çok ilişki
        public int HotelId { get; set; }
        public Hotel? Hotel { get; set; }
    }
}
