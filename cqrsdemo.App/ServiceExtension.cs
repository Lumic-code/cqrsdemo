using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace cqrsdemo.App
{
    public static class ServiceExtension
    {
        public static void AddApplicationServices( this IServiceCollection services)
        {
           services.AddMediatR(Assembly.GetExecutingAssembly());
        }
    }
}