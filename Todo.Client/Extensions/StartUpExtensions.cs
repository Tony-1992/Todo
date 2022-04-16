using Microsoft.EntityFrameworkCore;
using Todo.DataAccess;
using Todo.Services.UnitOfWork;

namespace Todo.Client.Extensions
{
    public static class StartUpExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            // Add all services here
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
