using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trotels.BL.Abstract;
using Trotels.DAL.Repository.Abstract;
using Trotels.Entity.Concrete;

namespace Trotels.BL.Concrete
{
    public class GuestManager : BaseManager<Guest>, IGuestManager
    {
        private readonly IGuestRepository repository;
        public GuestManager(IGuestRepository repository) : base(repository)
        {
            this.repository = repository;
        }

        public async Task<Guest?> Login(string email, string password)
        {
            var guest = await repository.GetBy(p => p.Email == email && p.Password == password);
            if (guest != null)
            {
                return guest;
            }
            return null;
        }

        public Task<bool> Logout(Guest guest)
        {
            throw new NotImplementedException();
        }
    }
}
