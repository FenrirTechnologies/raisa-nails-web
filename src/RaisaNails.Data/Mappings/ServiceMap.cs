using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RaisaNails.Services;

namespace RaisaNails.Data.Mappings
{
    public class ServiceMap : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasMany(x => x.Prices).WithOne();

            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Icon).IsRequired().HasMaxLength(256);
            builder.Property(x => x.Duration).IsRequired();
            builder.Property(x => x.Description).IsRequired().HasMaxLength(256);
        }
    }
}
