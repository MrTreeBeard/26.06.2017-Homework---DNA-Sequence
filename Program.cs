using System;
using System.Collections.Generic;
using System.Linq;

namespace HornetAssault
{
    class Program
    {
        static void Main()
        {
            long[] beehives = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            List<long> hornets = Console.ReadLine().Split(' ').Select(long.Parse).ToList();

            for (int i = 0; i < beehives.Length; i++)
            {
                if (hornets.Count == 0)
                    break;

                long beehiveCount = beehives[i];
                long hornetsTotalPower = hornets.Sum();

                beehiveCount -= hornetsTotalPower;

                if (hornetsTotalPower <= beehiveCount)
                {
                    hornets.RemoveAt(0);
                }
            }
            WinningSide(beehives, hornets);
        }
        private static void WinningSide(long[] beehives, List<long> hornets)
        {
            List<long> aliveBeehives = new List<long>();

            foreach (var beehive in beehives)
            {
                if (beehive > 0)
                {
                    aliveBeehives.Add(beehive);
                }
            }
            if (aliveBeehives.Count > 0)
            {
                Console.WriteLine(string.Join(" ", aliveBeehives));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
        }
    }
}