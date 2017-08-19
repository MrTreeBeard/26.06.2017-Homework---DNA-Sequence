using System;

namespace PokeMon
{
    class PokeMon
    {
        static void Main()
        {
            double N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());
            int count = 0;
            double halfN = Math.Floor(N / 2.0);

            while (true)
            {
                if (N == halfN && halfN % 2 == 0 && N % 2 == 0)
                {
                    N = Math.Floor(N / Y);
                    Console.WriteLine($"{N:F0}\n{count}");
                    break;
                }
                else if (N > M)
                {
                    N -= M;
                    count++;
                }
                if (N < M)
                {
                    Console.WriteLine($"{N:F0}\n{count}");
                    break;
                }
            }
        }
    }
}