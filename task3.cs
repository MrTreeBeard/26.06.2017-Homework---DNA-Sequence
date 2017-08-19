using System;
using System.Linq;

namespace task3
{
    class task3
    {
        static void Main()
        {
            char[] separators = ",.;:!?[]()\"'/\\ ".ToCharArray();

            string[] text = Console.ReadLine()
                .ToLower()
                .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                .Distinct()
                .Where(w => w.Length < 5)
                .OrderBy(w => w)
                .ToArray();

            Console.WriteLine(string.Join(", ", text));
        }
    }
}