using Business.Abstracts;
using Business.Concrete;
using Web.Handlers;

namespace Web.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddBusinessServices(this IServiceCollection services)
        {
            services.AddScoped<INodeService, NodeManager>();
            services.AddScoped<IUserService, UserManager>();
            services.AddScoped<AuthTokenHandler>();
        }
    }
}
