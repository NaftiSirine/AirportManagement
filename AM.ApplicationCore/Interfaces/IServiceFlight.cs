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
    }
}
