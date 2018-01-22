using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RaisaNails.Appointments;
using RaisaNails.Facilities;
using RaisaNails.Services;
using RaisaNails.Users;

namespace RaisaNails.Data
{
    public partial class RaisaNailsDbContext : IdentityDbContext<User>
    {
        public RaisaNailsDbContext(DbContextOptions<RaisaNailsDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Facility> Facilities { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServicePrice> ServicePrices { get; set; }
    }
}
