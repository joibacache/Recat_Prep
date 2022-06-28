// See https://aka.ms/new-console-template for more information
using DynamicBinding;
using DynamicBinding.Vehicles;

Console.WriteLine("Hello, World!");

dynamic car = new Car();
dynamic truck = new Truck();

var vc = new VehicleControl();
Console.WriteLine(vc.MoveForward(car));
Console.WriteLine(vc.MoveForward(truck));
Console.ReadLine();