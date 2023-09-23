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
    public class MenuConfig:BaseConfig<Menu>
    {
        public override void Configure(EntityTypeBuilder<Menu> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.MenuName).HasMaxLength(50);
            builder.Property(p => p.Area).HasMaxLength(50);
            builder.Property(p => p.Controller).HasMaxLength(50);
            builder.Property(p => p.Action).HasMaxLength(50);
            builder.Property(p => p.Css).HasMaxLength(500);
            builder.Property(p => p.Icon).HasMaxLength(500);
        }
    }
}
