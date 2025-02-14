using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace AM.Application.Core.Domain
{  
    public enum PlaneType
    {
        Boing,
        Airbus
    }
    
    public  class Plane
    {
        public Plane(int capacity, DateTime manufactureDate, PlaneType planeType)
        {
            Capacity = capacity;
            ManufactureDate = manufactureDate;
            PlaneType = planeType;
        }
        public Plane() { }

        public int Capacity {  get; set; }
        public DateTime ManufactureDate { get; set; }
        public int planedId { get; set; }
        public PlaneType PlaneType { get; set; }
        public ICollection<Flight> Flights { get; set; }

        public override string ToString()
        {
            return "PlaneType : " + PlaneType + " ManufactureDate : " + ManufactureDate + " Capacity : " + Capacity;
        }
    }
}
