using System;

namespace HornetWings
{
    class HornetWings
    {
        static void Main(string[] args)
        {
            int numberOfFlaps = int.Parse(Console.ReadLine());      // total number of wing flaps
            float distancePerFlaps = float.Parse(Console.ReadLine());  // distance traveled per 1000 wing flaps
            int endurance = int.Parse(Console.ReadLine());      // endurance - number of available flaps before rest

            int flapsPerSecond = 100;
            int rest = 5;

            float traveledDistance = ((float)numberOfFlaps / 1000) * 5;
            float elapsedTime = 
                (numberOfFlaps / flapsPerSecond) + (numberOfFlaps / flapsPerSecond) * 5;

            Console.WriteLine($"{traveledDistance:F2} m.");
            Console.WriteLine($"{elapsedTime} .");
        }
    }
}