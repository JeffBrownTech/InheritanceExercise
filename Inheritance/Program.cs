using System;
using System.Data;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var robin = new Bird();
            robin.Genus = "Erithacus";
            robin.Species = "Erithacus rubecula";
            robin.IsWarmBlooded = true;
            robin.IsEndangered = false;
            robin.CanFly = true;
            robin.WingSpanCm = 21;
            robin.BeakDescription = "short, slender, pointed";
            robin.MigrationPattern = "flies to warmer weather for winter";

            Console.WriteLine("Robin Facts");
            Console.WriteLine("---------------------");
            robin.DisplayInfo();
            robin.BuildNest();
            robin.LayEggs();

            var garterSnake = new Reptile();
            garterSnake.Genus = "Thamnophis";
            garterSnake.Species = "Thamnophis elegans";
            garterSnake.IsWarmBlooded = false;
            garterSnake.IsEndangered = false;
            garterSnake.HasLegs = false;
            garterSnake.IsVenomous = false;
            garterSnake.HabitatType = "grasslands near water sources";
            garterSnake.CanRegrowTail = false;

            Console.WriteLine("Garter Snake Facts");
            Console.WriteLine("---------------------");
            garterSnake.DisplayInfo();
            garterSnake.BaskInSun();
        }
    }
}
