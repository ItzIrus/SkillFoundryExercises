// Declare variables
double temperature, conversion;
string unit1, unit2;

// Print Header 
Console.WriteLine("Welcome to the Temperature Conversion!");
Console.WriteLine("========================================");
Console.WriteLine("Available units are (C)elcius, (F)ahrenheit, and (K)elvin.");
Console.WriteLine("");

// Prompt the user to enter details
Console.Write("Enter the Temperature: ");
temperature = double.Parse(Console.ReadLine());

Console.Write("Enter Unit: ");
unit1 = Console.ReadLine().ToUpper();

Console.Write("Enter Conversion Unit: ");
unit2 = Console.ReadLine().ToUpper();

// Conditions

if (unit1 == unit2)
{
    Console.WriteLine("There's no conversion to be done.");
}
else if (unit1 != "C" && unit1 != "K" && unit1 != "F")
{
    Console.WriteLine($"The unit {unit1} picked is not valid!");
}
else if (unit2 != "C" && unit2 != "K" && unit2 != "F")
{
    Console.WriteLine($"The unit {unit2} picked is not valid!");
}
else
{
    if (unit1 == "C")
    {
        if (unit2 == "K")
        {
            conversion = temperature + 273.15;
        }
        else
        {
            conversion = temperature * (9.0 / 5.0) + 32;
        }
    }
    else if (unit1 == "K")
    {
        if (unit2 == "C")
        {
            conversion = temperature - 273.15;
        }
        else 
        {
            conversion = (temperature - 273.15) * (9.0 / 5.0) + 32;
        }
    }
    else
    {
        if (unit2 == "C")
        {
            conversion = (temperature - 32) * (5.0 / 9.0);
        }
        else
        {
            conversion = (temperature - 32) * (5.0 / 9.0) + 273.15;
        }
    }
    // Print conversion message
    Console.WriteLine($"A temperature of {temperature}{unit1} is {Math.Round(conversion, 2)}{unit2}.");
}
