using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trotels.Entity.Abstract;

namespace Trotels.Entity.Concrete
{
    public class Menu:BaseEntity
    {
        public string MenuName { get; set; }
        public string? Area { get; set; }
        public string? Controller { get; set; }
        public string? Action { get; set; }
        public string? Css { get; set; }
        public string? Icon { get; set; }

        public string? IdentityRoleID { get; set; }
        public IdentityRole? Role { get; set; }
    }
}
