using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RaisaNails.Appointments;

namespace RaisaNails.Data.Mappings
{
    public class AppointmentsMap : IEntityTypeConfiguration<Appointment>
    {
        public void Configure(EntityTypeBuilder<Appointment> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Date).IsRequired();

            builder.HasOne(x => x.Service).WithMany().IsRequired();
            builder.HasOne(x => x.Customer).WithMany().IsRequired();
            builder.HasOne(x => x.Employee).WithMany().IsRequired();
            builder.HasOne(x => x.ServicePrice).WithMany().IsRequired();
        }
    }
}
