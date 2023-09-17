using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trotels.DAL.Config.Abstract;
using Trotels.Entity.Abstract;
using Trotels.Entity.Concrete;

namespace Trotels.DAL.Config.Concrete
{
    public class EmployeeConfig: BaseConfig<Employee>
    {
        public override void Configure(EntityTypeBuilder<Employee> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Title).HasMaxLength(50);
            builder.Property(p => p.FirstName).HasMaxLength(50).IsRequired();
            builder.Property(p => p.LastName).HasMaxLength(50).IsRequired();
            builder.HasIndex(p => p.Email).IsUnique();
            builder.HasIndex(p => p.Phone).IsUnique();
        }
    }
}
