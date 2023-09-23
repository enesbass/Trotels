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
    public class RoomConfig:BaseConfig<Room>
    {
        public override void Configure(EntityTypeBuilder<Room> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.RoomNo).HasMaxLength(50);
            builder.Property(p => p.RoomType).HasMaxLength(50);
            builder.Property(p => p.Occupancy).HasMaxLength(200);
        }
    }
}
