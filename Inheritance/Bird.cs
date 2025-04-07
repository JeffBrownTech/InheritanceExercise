using System;

namespace Inheritance;

public class Bird : Animal
{
    public bool CanFly { get; set; } = true;
    public double WingSpanCm { get; set; }
    public string BeakDescription { get; set; }
    public string MigrationPattern { get; set; }

    public void BuildNest()
    {
        Console.WriteLine("🪹");
    }

    public void LayEggs()
    {
        Console.WriteLine("🪺");
    }

    public void Sing()
    {
        Console.WriteLine("🎶");
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Species: {Species}");
        Console.WriteLine($"Genus: {Genus}");
        Console.WriteLine($"Warm-Blooded: {(IsWarmBlooded ? "Yes" : "No")}");
        Console.WriteLine($"Endangered: {(IsEndangered ? "Yes" : "No")}");
        Console.WriteLine($"Can Fly: {(CanFly ? "Yes" : "No")}");
        Console.WriteLine($"Wingspan: {WingSpanCm} cm");
        Console.WriteLine($"Beak Type: {BeakDescription}");
        Console.WriteLine($"Migration Pattern: {MigrationPattern}");
    }
}
