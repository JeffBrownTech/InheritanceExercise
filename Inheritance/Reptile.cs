using System;

namespace Inheritance;

public class Reptile : Animal
{
    public bool HasLegs { get; set; }
    public bool IsVenomous { get; set; }
    public string HabitatType { get; set; }
    public bool CanRegrowTail { get; set; }

    public void BaskInSun()
    {
        Console.WriteLine("😎");
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Species: {Species}");
        Console.WriteLine($"Genus: {Genus}");
        Console.WriteLine($"Warm-Blooded: {(IsWarmBlooded ? "Yes" : "No")}");
        Console.WriteLine($"Endangered: {(IsEndangered ? "Yes" : "No")}");
        Console.WriteLine($"Has Legs: {(HasLegs ? "Yes" : "No")}");
        Console.WriteLine($"Venomous: {(IsVenomous ? "Yes" : "No")}");
        Console.WriteLine($"Habitat: {HabitatType}");
        Console.WriteLine($"Can Regrow Tail: {(CanRegrowTail ? "Yes" : "No")}");
    }
}
