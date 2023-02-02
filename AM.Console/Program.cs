// See https://aka.ms/new-console-template for more information
using AM.ApplicationCore.Domain;

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