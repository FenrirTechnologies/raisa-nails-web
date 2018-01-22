using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RaisaNails.Services;

namespace RaisaNails.Data.Mappings
{
    public class ServicePriceMap : IEntityTypeConfiguration<ServicePrice>
    {
        public void Configure(EntityTypeBuilder<ServicePrice> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.CreationDate).IsRequired();
            builder.Property(x => x.EffectiveDate).IsRequired();
            builder.Property(x => x.Price).IsRequired();
        }
    }
}
