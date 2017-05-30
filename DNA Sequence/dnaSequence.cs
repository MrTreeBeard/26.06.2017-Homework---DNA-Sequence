using System;
using System.Text;

class DNASolution
{
    static void Main(string[] args)
    {
        const String nucleicAcids = "ACGT";
        StringBuilder line = new StringBuilder();

        int n = int.Parse(Console.ReadLine());
        int count = 0;
        for (int firstLetter = 0; firstLetter < nucleicAcids.Length; firstLetter++)
        {
            for (int secondLetter = 0; secondLetter < nucleicAcids.Length; secondLetter++)
            {
                for (int thirdLetter = 0; thirdLetter < nucleicAcids.Length; thirdLetter++)
                {
                    StringBuilder acid = new StringBuilder()
                                            .Append(nucleicAcids[firstLetter])
                                            .Append(nucleicAcids[secondLetter])
                                            .Append(nucleicAcids[thirdLetter]);

                    int sum = firstLetter + secondLetter + thirdLetter + 3;

                    if (sum >= n)
                    {
                        line.Append('O').Append(acid).Append('O').Append(' ');
                    }
                    else
                    {
                        line.Append('X').Append(acid).Append('X').Append(' ');
                    }

                    // Counts the acids
                    count++;
                    if (count % 4 == 0)
                    {
                        Console.WriteLine(line);
                        line.Clear();
                    }
                }
            }
        }
    }
}