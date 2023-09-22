using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trotels.DAL.Config.Abstract;
using Trotels.Entity.Concrete;

namespace Trotels.DAL.Config.Concrete
{
    public class GuestConfig:BaseConfig<Guest>
    {
        public override void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Guest> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.FirstName).HasMaxLength(50).IsRequired();
            builder.Property(p => p.LastName).HasMaxLength(50).IsRequired();
            builder.Property(p => p.Email).HasMaxLength(50).IsRequired();
            builder.Property(p => p.Address).HasMaxLength(200);
            builder.Property(p => p.TcNo).HasMaxLength(11);

            builder.HasIndex(p => p.Email).IsUnique();
            builder.HasIndex(p => p.Phone).IsUnique();
            builder.HasIndex(p => p.TcNo).IsUnique();

            builder.HasData(
           new Guest { Id = 1, FirstName = "Ali", LastName = "Yılmaz", Email = "Ali@gmail.com", Password="ali123"},
           new Guest { Id = 2, FirstName = "Veli", LastName = "Kaya", Email = "Veli@gmail.com", Password = "veli123" });
        }   
    }
}
