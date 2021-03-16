using ConsoleApp.Models;
using System;
using System.Collections.Generic;

namespace ConsoleApp.Application
{
    public class FlightRepository : IFlightRepository
    {
        private readonly IAirportRepository _airportRepository;

        public FlightRepository(IAirportRepository airportRepository)
        {
            _airportRepository = airportRepository;
        }

        public IReadOnlyList<Flight> GetAllDepartures(string airportCode)
        {
            throw new NotImplementedException();
        }
    }
}
