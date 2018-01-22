using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RaisaNails.Facilities;

namespace RaisaNails.Data.Mappings
{
    public class FacilityMap : IEntityTypeConfiguration<Facility>
    {
        public void Configure(EntityTypeBuilder<Facility> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Icon).IsRequired().HasMaxLength(256);
            builder.Property(x => x.Latitude).IsRequired();
            builder.Property(x => x.Longitude).IsRequired();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(60);
          
            builder.HasMany(x => x.Services).WithOne();
        }
    }
}
