using StrategyPattern.Strategies;
using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            TravelPlanner travelPlanner = new TravelPlanner();

            travelPlanner.SetTravelStrategy(new Plane());
            travelPlanner.Drive(999);

            Console.ReadLine();
        }
    }
}
