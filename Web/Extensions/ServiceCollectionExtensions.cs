using Business.Abstracts;
using Business.Concrete;

namespace Web.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddBusinessServices(this IServiceCollection services)
        {
            services.AddScoped<INodeService, NodeManager>();
        }
    }
}
