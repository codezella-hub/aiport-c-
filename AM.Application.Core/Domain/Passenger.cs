using System;
using System.Collections.Generic;
using System.Text;

namespace AM.Application.Core.Domain
{
    public  class Passenger
    {
        public DateTime BirthDate { get; set; }
        public string PassportNumber { get; set; }
        public string EmailAdress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TelNumber { get; set; }
        public ICollection<Flight> Flights { get; set; }

        public override string ToString()
        {
            return " Firstname : " + FirstName + " PassportNumber : "  + PassportNumber + " EmailAdress : " + EmailAdress;
        }
    }
}
