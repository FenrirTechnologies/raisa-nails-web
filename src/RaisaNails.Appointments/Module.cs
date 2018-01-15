using Microsoft.Extensions.DependencyInjection;

namespace RaisaNails.Appointments
{
    public static class Module
    {
        public static IServiceCollection AddAppointments(this IServiceCollection services)
        {
            return services;
        }
    }
}
