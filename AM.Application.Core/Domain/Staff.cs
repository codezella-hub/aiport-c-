using System;
using System.Collections.Generic;
using System.Text;

namespace AM.Application.Core.Domain
{
    public  class Staff : Passenger
    {
        public DateTime EmployementDate { get; set; }
        public string Function { get; set;}
        public float Salary { get; set;}
        public override string PassengerType()
        {
            return "I'm a Staff ";
        }
    }
}
