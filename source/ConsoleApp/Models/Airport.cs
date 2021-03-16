using System;
using System.Collections.Generic;

namespace ConsoleApp.Models
{
    public class Airport
    {
        public Guid Id { get; }

        public TimeZoneLocation TimeZoneLocation { get; }

        public string Code { get; }

        public AirportImportance Importance { get; }

        public Airport(TimeZoneLocation timeZoneLocation, string code, AirportImportance importance)
        {
            TimeZoneLocation = timeZoneLocation;
            Code = code;
            Importance = importance;
            Id = Guid.NewGuid();
        }

        public IEnumerable<DateTime> GetDepartures()
        {
            const int departuresPerDay = 8;
            var rand = new Random();

            var start = new DateTime(2000, 1, 1, 6, 0, 0);
            var end = new DateTime(2000, 1, 1, 20, 0, 0);

            var difference = end - start;

            var periods = difference / departuresPerDay;

            var periodTimes = new List<DateTime>
            {
                start,
            };

            for (int i = 0; i < departuresPerDay; i++)
            {
                periodTimes.Add(start += periods);
            }


            for (int i = 0; i < periodTimes.Count - 1; i++)
            {
                var hour = rand.Next(periodTimes[i].Hour, periodTimes[i + 1].Hour);
                var minute = rand.Next(0, 59);

                yield return new DateTime(2000, 1, 1, hour, minute, 0);
            }
        }
    }
}
