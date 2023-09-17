using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trotels.DAL.Config.Abstract;
using Trotels.Entity.Concrete;

namespace Trotels.DAL.Config.Concrete
{
    public class BookingConfig:BaseConfig<Booking>
    {
        public override void Configure(EntityTypeBuilder<Booking> builder)
        {
            base.Configure(builder);
        }
    }
}
