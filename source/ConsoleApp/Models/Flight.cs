using System;

namespace ConsoleApp.Models
{
    public class Flight
    {
        public Guid Id { get; }

        public Airport Departure { get; }

        public Airport Arrival { get; }

        public Flight(Airport departure, Airport arrival)
        {
            Departure = departure;
            Arrival = arrival;
            Id = Guid.NewGuid();
        }
    }
}
