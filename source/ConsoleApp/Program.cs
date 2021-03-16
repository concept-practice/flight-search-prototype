using ConsoleApp.Models;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var collection = new ServiceCollection();

            Bootstrapper.Register(collection);

            var provider = collection.BuildServiceProvider();

            var airport = new Airport(TimeZoneLocation.Pacific, "LAX", AirportImportance.Spoke);

            var times = airport.GetDepartures();

            foreach (var dateTime in times)
            {
                Console.WriteLine(dateTime);
            }


            Console.ReadLine();
        }
    }
}
