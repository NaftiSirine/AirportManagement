﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Staff: Passenger
    {
        [DataType(DataType.Currency)]

        public double Salary { get; set; }
        public string Function { get; set; }
        public DateTime   EmployementDate { get; set; }
      
        public override void PassengerType()
        {
            base.PassengerType();
            Console.WriteLine("I am a Staff Member");
        }
    }
}
