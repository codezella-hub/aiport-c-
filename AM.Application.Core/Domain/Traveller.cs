using System;
using System.Collections.Generic;
using System.Text;

namespace AM.Application.Core.Domain
{
    public class Traveller : Passenger
    {
        public string HealthInformation { get; set; }
        public string Nationality {  get; set; }
    }
}
