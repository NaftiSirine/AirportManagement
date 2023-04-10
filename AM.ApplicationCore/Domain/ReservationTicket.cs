using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class ReservationTicket
    {


        public DateTime DateReservation { get; set; }
        public float Prix { get; set; }

        //declaration de la propriéte de clé etranger PassengerFk ena samit"h ou lieu de faire appel a la cle primaire de Passenger

        public string PassengerFk { get; set; }

        [ForeignKey("PassengerFk")]
        public Passenger Passenger { get; set; }

        public int TicketFk { get; set; }

        [ForeignKey("TicketFk")]
        public Ticket Ticket { get; set; }
    }
}