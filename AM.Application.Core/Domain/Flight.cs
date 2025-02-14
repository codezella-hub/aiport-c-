using System;
using System.Collections.Generic;
using System.Text;

namespace AM.Application.Core.Domain
{
    public class Flight
    {
        public  string Destination { get; set; }
        public string Departure { get; set; }

        public DateTime FlightDate { get; set; }
        public int FlightId { get; set; }
        public DateTime EffectiveArrival { get; set; }
        public int EstimatedDuration { get; set; }
        public Plane Plane { get; set; }
        public ICollection<Passenger> Passengers { get; set; }

        public override string ToString()
        {
            return "Destination : " + Destination + " Depatrure : " + Departure + " FlightId : "+ FlightId.ToString();
        }
    }
}
