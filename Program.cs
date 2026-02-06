//This program takes various inputs from the user to give a table summary of a planned road trip.

Console.Clear();

Console.WriteLine("We are going to map out a road trip for Fall Break.\nI'm going to ask you some specific questions about the trip, and then I'll callculate a trip summary from that information.");

Console.Write("Where will you be driving? ");
string destination = Console.ReadLine();

Console.Write("Who will be driving? ");
string driver = Console.ReadLine();

double distance;
Console.Write($"How many miles to get to {destination}? ");
while (Double.TryParse(Console.ReadLine(), out distance) == false) // takes user input and tries to convert it until it works
{
    Console.WriteLine("Invalid response, please try again.");
    Console.Write($"How many miles to get to {destination}? ");
}

double speed;
Console.Write($"What average spped (MPH) will {driver} be travelling? ");
while (Double.TryParse(Console.ReadLine(), out speed) == false)
{
    Console.WriteLine("Invalid response, please try again.");
    Console.Write($"What average spped (MPH) will {driver} be travelling? ");
}

double milesPerGallon;
Console.Write("How many MPG does your car get? ");
while (Double.TryParse(Console.ReadLine(), out milesPerGallon) == false)
{
    Console.WriteLine("Invalid response, please try again.");
    Console.Write("How many MPG does your car get? ");
}

double tankCapacity;
Console.Write("How many gallons of gas does your car hold? ");
while (double.TryParse(Console.ReadLine(), out tankCapacity) == false)
{
    Console.WriteLine("Invalid response, please try again.");
    Console.Write("How many gallons of gas does your car hold? ");
}

int numPassengers;
Console.Write("Excluding the driver, how many riders in the car? ");
while (Int32.TryParse(Console.ReadLine(), out numPassengers) == false)
{
    Console.WriteLine("Invalid response, please try again.");
    Console.Write("Excluding the driver, how many riders in the car? ");
}

Console.Write("What unit of currency ($, £, ¥, €) do you use? ");
string typeCurrency = Console.ReadLine();
while ((typeCurrency == "$" || typeCurrency == "£" || typeCurrency == "¥" || typeCurrency == "€") == false)
{
    Console.WriteLine("Invalid response, please try again.");
    Console.Write("What unit of currency ($, £, ¥, €) do you use? ");
    typeCurrency = Console.ReadLine();
}

double fuelPrice;
Console.Write($"What is the fuel price per gallon ({typeCurrency})?");
while (Double.TryParse(Console.ReadLine(), out fuelPrice) == false)
{
    Console.WriteLine("Invalid response, please try again.");
    Console.Write($"What is the fuel price per gallon ({typeCurrency})?");
}

Console.WriteLine("Recieved:");
Console.WriteLine($"{destination} {driver} {distance} {speed} {milesPerGallon} {tankCapacity} {numPassengers} {typeCurrency} {fuelPrice}");