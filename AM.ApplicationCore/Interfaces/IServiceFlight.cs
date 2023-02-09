using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Interfaces
{
    internal interface IServiceFlight
    {
        IList<DateTime> getFlightDates(string destination);
        public void ShowFlightDetails(Plane plane);
        public int ProgrammedFlightNumber(DateTime startDate);

        public double DurationAverage(string destination);

        public IList<Flight> OrderedDurationFlights();
        public IList<Traveller> SeniorTravellers(Flight flight);
    }
}
