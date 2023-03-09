using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Plane
    {
        #region exemple
        //   string name; 
        //   public string getName (){  return name; } 
        //   public void   setName(string name) { name = name; }
        //   //prop + 2 tab : light version
        //   public int MyProperty { get; set; }
        ////propfull  : full version
        //   private int number;

        //   public int Number
        //   {
        //       get { return number; }
        //       set { number = value; }
        //   }
        //   // propg

        //   public int MyProperty { get; private set; }
        #endregion

        [Range(1,int.MaxValue)] 
        public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }
        public int PlaneId { get; set; }    
        public PlaneType PlaneType { get; set; }   
        public Plane(int capacity, DateTime manufactureDate)
        {
            Capacity = capacity;    
            ManufactureDate = manufactureDate;  
        }
        public IList<Flight> Flights { get; set; }
        public Plane()
        {
        }
    }
}
    