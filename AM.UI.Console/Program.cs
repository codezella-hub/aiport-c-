// See https://aka.ms/new-console-template for more information


using AM.Application.Core.Domain;
using AM.Application.Core.Services;
using AM.ApplicationCore;



//Plane plane = new Plane();
//plane.PlaneType = PlaneType.Airbus;
//plane.Capacity = 33;
//plane.ManufactureDate = DateTime.Now;

//Console.WriteLine(plane.ToString());


//Plane plane = new Plane
//{
//    Capacity = 150,
//    ManufactureDate = DateTime.Now,
//    PlaneType = PlaneType.Boing
//};
//Console.WriteLine(plane.ToString());


//Plane p = new Plane(150, DateTime.Now, PlaneType.Boing);
//Console.WriteLine(p.ToString());

//Passenger p = new Passenger
//{
//    FirstName = "louay",
//    LastName = "benslimen",
//    EmailAdress = "louay"
//};
//Passenger p = new Traveller();
//Console.WriteLine(p.PassengerType());

ServiceFlight sf = new ServiceFlight();

sf.flights = TestData.listFlights;
foreach (var flight in sf.GetFlightDates("Madrid"))
     Console.WriteLine(flight);


foreach (var flight in sf.GetFlightDates("Destination","Madrid"))
    Console.WriteLine(flight);
