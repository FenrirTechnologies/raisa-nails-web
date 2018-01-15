using Microsoft.Extensions.DependencyInjection;

namespace RaisaNails.Users
{
    public static class Module
    {
        public static IServiceCollection AddUsers(this IServiceCollection services)
        {
            return services;
        }
    }
}
