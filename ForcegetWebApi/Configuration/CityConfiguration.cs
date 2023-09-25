using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ForcegetWebApi.Entities;

namespace ForcegetWebApi.Configuration
{
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Name).HasMaxLength(100).IsRequired();

            builder.HasData(new City { Id = 1, Name = "İstanbul", CountryId = 1 });
            builder.HasData(new City { Id = 2, Name = "İzmir", CountryId = 1 });
        }
    }
}
