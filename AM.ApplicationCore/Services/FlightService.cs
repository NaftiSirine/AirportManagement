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
        public Flight flight = new Flight();
        public IList<DateTime> getFlightDates(string destination)
        {
            //IList<DateTime> dates = new List<DateTime>();   
            //for (int i = 0; i < flights.Count; i++)
            //{
            //    if (flights[i].Destination.Equals(destination) )
            //    {
            //        dates.Add(flights[i].FlightDate);
            //    }
            //}
            //return dates;
            var query = from flight in flights where flight.Destination == destination select flight.FlightDate;
            return query.ToList();
        }
        public void ShowFlightDetails(Plane plane)
        {
            var query = from f in flights where f.Plane == plane 
                        select new { f.FlightDate, f.Destination };
            foreach (var f in query)
            {
                Console.WriteLine(f.Destination + f.FlightDate);
            }
                        
        }
        public int ProgrammedFlightNumber(DateTime startDate)
        {
            //var flightNumber = (from flight in flights where flight.FlightDate.AddDays(7) <=  startDate
            //            select flight).Count();
            //return flightNumber; 
            return flights.Where(f=> (f.FlightDate - startDate).TotalDays<7).Count();

        }
        public double DurationAverage(string destination)
        {
            var query = (from flight in flights where flight.Destination.Equals(destination) select flight.EstimatedDuration).Average();
            return query;

        }
        public IList<Flight> OrderedDurationFlights()
        {
            var query = (from flight in flights select flight).OrderByDescending(flight => flight.EstimatedDuration);
            return query.ToList();  
        }
        public IList<Traveller> SeniorTravellers(Flight flight)
        {
            var query = (from f in flight.Passengers.OfType<Traveller>() orderby f.BirthDay descending select f).Take(3);
            return query.ToList(); 
        }
    }
}
