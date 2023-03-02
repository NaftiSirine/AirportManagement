using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public  class Passenger
    {
        public string PassportNumber { get; set; } 
        public string FirstName { get; set;}
        public string LastName { get; set;} 
        public DateTime BirthDate { get; set;}    
        public int TelNumber { get; set;} 
        public string EmailAddress { get; set;}  
        public int Id { get; set;}
        public IList<Flight> Flights { get; set; }
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
