//This program takes various inputs from the user to give a table summary of a planned road trip.

Console.Clear();

Console.WriteLine("We are going to map out a road trip for Fall Break.\nI'm going to ask you some specific questions about the trip, and then I'll callculate a trip summary from that information.");

// Query the user on the needed data, validating important data types
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
Console.Write($"What average speed (MPH) will {driver} be travelling? ");
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

// Calculate all the needed values
double duration = distance / speed;
int durationHours = (int)duration;
int durationMinutes = (int)(duration % 1 * 60);
double fuelNeeded = distance / milesPerGallon;
double range = milesPerGallon * tankCapacity;
int fuelStops = (int)(distance / range);
double fuelCost = fuelNeeded * fuelPrice;

// Return the final report to the user
Console.WriteLine($"{"Driver:",-30}{driver,-30}");
Console.WriteLine($"{"Currency:",-30}{typeCurrency,-30}");

Console.WriteLine("");

Console.WriteLine($"{"Distance (miles):",-30}{distance,-30}");
Console.WriteLine($"{"Average Speed (mph):",-30}{speed,-30}");
Console.WriteLine($"{"Time Driving:",-30}{$"{durationHours}H {durationMinutes}M",-30}");

Console.WriteLine("");

Console.WriteLine($"{"Vehicle Miles per Gallon:",-30}{milesPerGallon,-30}");
Console.WriteLine($"{"Fuel Needed (round trip):",-30}{$"{fuelNeeded:0.00} gallons",-30}");
Console.WriteLine($"{"Range per Tank:",-30}{range,-30:0.00}");
Console.WriteLine($"{"Estimated Fuel Stops:",-30}{fuelStops,-30}");

Console.WriteLine("");

Console.WriteLine($"{"Gas Price per gallon:",-30}{$"{typeCurrency}{fuelPrice:0.00}",-30}");
Console.WriteLine($"{"Time Driving:",-30}{$"{durationHours}H {durationMinutes}M",-30}");
Console.WriteLine($"{"Fuel Cost:",-30}{$"{typeCurrency}{fuelCost:0.00}",-30}");
Console.WriteLine($"{"Riders (split):",-30}{numPassengers + 1,-30}");
Console.WriteLine($"{"Cost per person:",-30}{$"{typeCurrency}{fuelCost / numPassengers + 1:0.00} (+ Snacks)",-30}");
Console.WriteLine($"{"Cost per mile:",-30}{$"{typeCurrency}{fuelCost / distance:0.00}",-30}");
Console.WriteLine($"{"Cost per driving hour:",-30}{$"{typeCurrency}{fuelCost:0.00}",-30}");

Console.WriteLine("");

Console.WriteLine($"{"Average song length (min):",-30}3.5");
Console.WriteLine($"{"Number of songs needed:",-30}{(int)(duration * 60 / 3.5),-30}");