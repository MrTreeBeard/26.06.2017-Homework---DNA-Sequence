using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regexmon
{
    class Regexmon
    {
        static void Main()
        {
            List<char> strText = Console.ReadLine().ToLower().ToList();

            for (int i = 0; i <= strText.Count; i++)
            {
                char currentElement = strText[i];
                bool alphabetCheck = currentElement.ToString().Any(x => char.IsLetter(x));

                if (strText[i + 1] == '-' || alphabetCheck == true)         // didimon
                {
                    Console.Write(currentElement);

                    if (strText[i + 1] != '-' || alphabetCheck == false)    // checks the next char if, it isn`t letter or '-'
                    {                                                       // writes new line for bojomon
                        Console.WriteLine();
                        break;
                    }
                }
                else if (strText[i + 1] != '-' || alphabetCheck == false)   //bojomon 
                {
                    Console.Write(currentElement);

                    if (strText[i + 1] == '-' || alphabetCheck == true)
                    {
                        Console.WriteLine();
                        break;
                    }
                }
            }
        }
    }
}