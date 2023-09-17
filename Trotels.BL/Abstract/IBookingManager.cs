using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trotels.Entity.Concrete;

namespace Trotels.BL.Abstract
{
    public interface IBookingManager:IBaseManager<Booking>
    {
        Task<bool> CheckInVarMi(TimeSpan checkin);
        Task<bool> CheckOutVarMi(TimeSpan checkout);
        
    }
}
