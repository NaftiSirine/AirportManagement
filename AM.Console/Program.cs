// See https://aka.ms/new-console-template for more information
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using AM.ApplicationCore.Services;

Console.WriteLine("Hello, World!");
Plane p1= new Plane();
p1.Capacity = 10;
p1.ManufactureDate= DateTime.Now;
p1.PlaneType = PlaneType.Boing;
Plane p2 = new Plane(2, new DateTime(2023 - 10 - 10));
Plane p3 = new Plane
{
    Capacity = 10,  
    ManufactureDate= DateTime.Now,
    PlaneType = PlaneType.Boing,
};

FlightService sf = new FlightService();
sf.flights = TestData.listFlights;
foreach (var flight in sf.getFlightDates("Paris"))
{
    Console.WriteLine(flight);
}

//Console.WriteLine("**showFlightdate***");
//sf.ShowFlightDetails(TestData.BoingPlane);

//Console.WriteLine("**ProgrammedFlightNumber***");
//sf.ProgrammedFlightNumber(new DateTime(2022, 01, 01));


//Console.WriteLine("**SeniorTravellers***");
//foreach (var flight in sf.SeniorTravellers(TestData.flight1))
//{
//    Console.WriteLine(flight.BirthDate);
//}