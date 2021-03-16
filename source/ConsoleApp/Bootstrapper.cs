using ConsoleApp.Application;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace ConsoleApp
{
    public class Bootstrapper
    {
        public static void Register(IServiceCollection serviceCollection)
        {
            serviceCollection.AddMediatR(Assembly.GetExecutingAssembly());

            serviceCollection.AddSingleton<IAirportRepository, AirportRepository>();
        }
    }
}
