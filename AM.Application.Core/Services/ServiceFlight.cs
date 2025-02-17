using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AM.Application.Core.Domain;
using AM.Application.Core.Interfaces;

namespace AM.Application.Core.Services
{
    public class ServiceFlight : IServiceFlight
    {
        public List<Flight> flights { get; set; } = new List<Flight>();

        //public List<DateTime> GetFlightDates(string destination)
        //{

        //    List<DateTime> result = new List<DateTime>();
        //    foreach (var item in flights)
        //    {
        //        if (item.Destination.Equals(destination))
        //        {
        //            result.Add(item.FlightDate);
        //        }
        //    }
        //    return result;
        //}
        public List<DateTime> GetFlightDates(string destination)
        {
            var result = from item in flights where item.Destination == destination select item.FlightDate;
             var query2 = flights.Where(el =>  el.Destination == destination).Select(el => el.FlightDate);
            
            return result.ToList() ;
        }
        public List<Flight> GetFlightDates(string filterType, string filterValue)
        {
            List<Flight> result = new List<Flight>();
            switch (filterType)
            {
                case "Destination":
                    foreach (var item in flights)
                    {
                        if (item.Destination.Equals(filterValue))
                        {
                            result.Add(item);
                        }
                    }
                    return result;
                case "FlightDate":
                    foreach (var item in flights)
                    {
                        if (item.FlightDate.ToString().Equals(filterValue.ToString()))
                        {
                            result.Add(item);
                        }
                    }
                    return result;

                case "EffectiveArrival":
                    foreach (var item in flights)
                    {
                        if (item.EffectiveArrival.ToString().Equals(filterValue.ToString()))
                        {
                            result.Add(item);
                        }
                    }
                    return result;

                default:
                    return result;
                  
            }




        }   


    }
}
