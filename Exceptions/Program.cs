// See https://aka.ms/new-console-template for more information
using Exceptions;

var vehicle = new Vehicle();
while(true)
{
    Console.Clear();
    Console.WriteLine("Please select a movemet:");
    foreach(var action in vehicle.Actions)
    {
        Console.WriteLine(action);
    }
    Console.WriteLine("E - Exit");
    Console.Write("Option: ");
    var option = Console.ReadLine();
    if (option == null)
    {
        continue;
    }

    if (option.ToLower() == "e")
        break;
    try
    {
        vehicle.ExecuteAction(option);
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine("Something went wrong...please try again.");
        Console.WriteLine(ex.ToString());
    }
    Console.WriteLine("Press a key to continue...");
    Console.ReadKey();
}


