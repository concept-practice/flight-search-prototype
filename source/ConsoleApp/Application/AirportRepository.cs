using ConsoleApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp.Application
{
    public class AirportRepository : IAirportRepository
    {
        private readonly List<Airport> _airports;

        public AirportRepository()
        {
            _airports = new List<Airport>
            {
                new Airport(TimeZoneLocation.Central, "MCI", AirportImportance.FocusCity),
                new Airport(TimeZoneLocation.Pacific, "LAX", AirportImportance.Spoke),
                new Airport(TimeZoneLocation.Central, "ORD", AirportImportance.Spoke),
            };
        }

        public IReadOnlyList<Airport> GetAll()
        {
            return _airports;
        }

        public Airport GetByCode(string code)
        {
            return _airports.First(x => x.Code == code);
        }
    }
}
