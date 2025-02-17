using System;
using System.Collections.Generic;
using System.Text;
using AM.Application.Core.Domain;

namespace AM.Application.Core.Interfaces
{
    public interface IServiceFlight
    {
        List<DateTime> GetFlightDates(string destination);
        List<Flight> GetFlightDates(string filterType,string filterValue);
    }
}
