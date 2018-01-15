using Microsoft.Extensions.DependencyInjection;

namespace RaisaNails.Data
{
    public static class Module
    {
        public static IServiceCollection AddData(this IServiceCollection services)
        {
            return services;
        }
    }
}
