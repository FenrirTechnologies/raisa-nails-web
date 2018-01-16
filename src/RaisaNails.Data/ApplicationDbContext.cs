using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RaisaNails.Appointments;
using RaisaNails.Facilities;
using RaisaNails.Services;
using RaisaNails.Users;

namespace RaisaNails.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Service> Services { get; set; }
        public DbSet<ServicePrice> ServicePrices { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Facility> Facilities { get; set; }
    }
}
