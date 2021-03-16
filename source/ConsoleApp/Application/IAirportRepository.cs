using ConsoleApp.Models;
using System.Collections.Generic;

namespace ConsoleApp.Application
{
    public interface IAirportRepository
    {
        public IReadOnlyList<Airport> GetAll();

        public Airport GetByCode(string code);
    }
}
