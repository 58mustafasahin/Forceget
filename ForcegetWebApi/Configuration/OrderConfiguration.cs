using ForcegetWebApi.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace ForcegetWebApi.Configuration
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.CityId).IsRequired();
            builder.Property(p => p.Mode).IsRequired();
            builder.Property(p => p.MovementType).IsRequired();
            builder.Property(p => p.Incoterm).IsRequired();
            builder.Property(p => p.PackageType).IsRequired();
            builder.Property(p => p.Unit1).IsRequired();
            builder.Property(p => p.Unit2).IsRequired();
            builder.Property(p => p.Currency).IsRequired();
        }
    }
}
