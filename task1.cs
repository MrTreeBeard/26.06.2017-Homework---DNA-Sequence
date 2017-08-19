using System;
using System.Collections.Generic;
using System.Linq;

namespace task1
{
    class task1
    {
        static void Main()
        {
            int nums = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();

            for (int i = 0; i < nums; i++)
            {
                int numsToAdd = int.Parse(Console.ReadLine());
                numbers.Add(numsToAdd);
            }

            Console.WriteLine($"Sum = {numbers.Sum()}");
            Console.WriteLine($"Min = {numbers.Min()}");
            Console.WriteLine($"Max = {numbers.Max()}");
            Console.WriteLine($"Average = {numbers.Average()}");
        }
    }
}