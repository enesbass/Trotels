using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Trotels.DAL.Config.Abstract;
using Trotels.Entity.Concrete;

namespace Trotels.DAL.Config.Concrete
{
    public class HotelConfig:BaseConfig<Hotel>
    {
        public override void Configure(EntityTypeBuilder<Hotel> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.HotelName).HasMaxLength(100);
            //Ayni birimden ikinci kayit olmasin
            builder.HasIndex(p => p.HotelName).IsUnique();
            builder.Property(p => p.HotelAddress).HasMaxLength(200);
        }   
    }
}
