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

        public bool CheckProfile(string nom, string prenom)
        {
            if (this.FirstName == nom || this.LastName == prenom)   { return true; }
            return false;
        }
        public bool CheckProfile(string nom, string prenom,string email)
        {
            if (this.FirstName == nom || this.LastName == prenom || this.EmailAdress == email) { return true; }
            return false;
        }
        public virtual string PassengerType()
        {
            return "I'm a passenger";
        }
    }
}
