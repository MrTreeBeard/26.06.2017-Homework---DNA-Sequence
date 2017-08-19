using System;
using System.Collections.Generic;
using System.Linq;

namespace task2
{
    class task2
    {
        static void Main()
        {
            List<double> numbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();

            Console.WriteLine(numbers.OrderByDescending(x=>x).Take(3));
        }
    }
}