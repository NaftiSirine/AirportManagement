using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Ticket
    {
        public String Classe { get; set; }
        public String Destination { get; set; }
        public int id { get; set; }

        public IList<ReservationTicket> Reservations { get; set; }  
    }
}
