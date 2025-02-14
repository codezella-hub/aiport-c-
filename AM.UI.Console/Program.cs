// See https://aka.ms/new-console-template for more information


using AM.Application.Core.Domain;



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


Plane p = new Plane(150, DateTime.Now, PlaneType.Boing);
Console.WriteLine(p.ToString());