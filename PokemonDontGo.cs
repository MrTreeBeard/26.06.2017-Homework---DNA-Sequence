using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PokemonDontGo
{
    class PokemonDontGo
    {
        static void Main()
        {
            List<int> numList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                int num = int.Parse(Console.ReadLine());
                int index = numList[num];
                int sum = 0;

                if (numList[0] == null)
                {
                    Console.WriteLine(sum);
                    break;
                }
                if (index < 0)
                {
                    sum += numList[numList.First()];
                    //foreach (int x => numList.FindAll(item => item > index) in numList)
                    //{
                    //    x += index;
                    //}
                    for (int i = 0; i <= numList.Count; i++)
                    {
                        if (numList[i] <= index)
                        {
                            numList[i] += index;
                        }
                        else if (numList[i] > index)
                        {
                            numList[i] -= index;
                        }
                    }
                    numList.RemoveAt(numList[numList.First()]);
                    numList.Insert(numList[numList.Last()], numList[numList.First()]);
                }
                else if (index > numList[numList.Last()])
                {
                    sum += numList[numList.Last()];

                    for (int i = 0; i <= numList.Count; i++)
                    {
                        if (numList[i] <= index)
                        {
                            numList[i] += index;
                        }
                        else if (numList[i] > index)
                        {
                            numList[i] -= index;
                        }
                    }
                    numList.RemoveAt(numList[numList.Last()]);
                    numList.Insert(numList[numList.First()], numList[numList.Last()]);
                }
                else if (numList[i] <= index)
                {
                    for (int i = 0; i <= numList.Count; i++)
                    {
                        numList[i] += index;
                    }
                }
            }

        }
        //public static int elementManipulator(List<int> numList, int num)
        //{
        //    int index = numList[num];

        //    for (int i = 0; i <= numList.Count; i++)
        //    {
        //        if (numList[i] <= index)
        //        {
        //            numList[i] += index;
        //        }
        //        else if (numList[i] > index)
        //        {
        //            numList[i] -= index;
        //        }
        //    }
        //    return num; //placeholder
        //}
    }
}
