using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trotels.Entity.Concrete;

namespace Trotels.BL.Abstract
{
    public interface IGuestManager:IBaseManager<Guest>
    {
        Task<Guest?> Login(string email, string password);
        Task<bool> Logout(Guest guest);
    }
}
