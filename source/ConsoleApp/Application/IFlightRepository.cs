using ConsoleApp.Models;
using System.Collections.Generic;

namespace ConsoleApp.Application
{
    interface IFlightRepository
    {
        IReadOnlyList<Flight> GetAllDepartures(string airportCode);
    }
}
