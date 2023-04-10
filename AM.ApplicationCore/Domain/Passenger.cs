using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public  class Passenger
    {
        [Key, StringLength(7)]
        public string PassportNumber { get; set; }
        [MinLength(3,ErrorMessage ="invalid username"),MaxLength(25)]
        public string FirstName { get; set;}

        public string LastName { get; set;}
        [DisplayName("Date of birth")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set;}
        [RegularExpression(@"^[0-9]{8}$", ErrorMessage = "Invalid Phone Number!")]

        public int TelNumber { get; set;}
       // [DataType(DataType.EmailAddress)]
        [EmailAddress]

        public string EmailAddress { get; set;}  
        //public int Id { get; set;}
        public IList<Flight> Flights { get; set; }
        public IList<ReservationTicket> Reservations { get; set; }

        public bool checkProfile(string firstName, string lastName)
        {
            return FirstName== firstName && LastName == lastName;
        }
        public bool checkProfile(string firstName, string lastName, string email)
        {
            return checkProfile( firstName, lastName) && EmailAddress==email;
        }
        public bool login(string firstName, string lastName,string email=null)
        {
            return email!=null ? checkProfile(lastName, firstName, email) : checkProfile(firstName, lastName); 
           
        }
        public virtual void PassengerType()
        {
            Console.WriteLine( "I am a passenger");
        }
    }
}
