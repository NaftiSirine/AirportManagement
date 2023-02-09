using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    internal class FlightService : IServiceFlight
    {
        public IList<Flight> flights = new List<Flight>();
        public IList<DateTime> getFlightDates(string destination)
        {
            IList<DateTime> dates = new List<DateTime>();   
            for (int i = 0; i < flights.Count; i++)
            {
                if (flights[i].Destination.Equals(destination) )
                {
                    dates.Add(flights[i].FlightDate);
                }
            }
            return dates;
        }
    }
}
