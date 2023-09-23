using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trotels.Entity.Authentication
{
    public class AppUser:IdentityUser
    {
        public string? TcNo { get; set; }
    }
}
