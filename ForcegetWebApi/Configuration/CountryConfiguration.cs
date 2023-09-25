using ForcegetWebApi.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ForcegetWebApi.Configuration
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Name).HasMaxLength(100).IsRequired();

            builder.HasData(new City { Id = 1, Name = "Turkey" });
            builder.HasData(new City { Id = 2, Name = "China" });
        }
    }
}
