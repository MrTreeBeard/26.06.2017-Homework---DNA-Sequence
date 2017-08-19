using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HornetArmada
{
    class HornetArmada
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            Dictionary<string, int> legionsWithActivity = new Dictionary<string, int>();
            Dictionary<string, Dictionary<string, long>> legionsWithSoldiers = new Dictionary<string, Dictionary<string, long>>();

            string inputPattern = @"(\d+)\s\=\s(.+)\s\-\>\s(.+)\:(\d+)";
            Regex inputRegex = new Regex(inputPattern);

            for (int i = 0; i < N; i++)
            {
                Match inputMatch = inputRegex.Match(Console.ReadLine());

                int lastActivity = int.Parse(inputMatch.Groups[1].Value);
                string legionName = inputMatch.Groups[2].Value;
                string soldierType = inputMatch.Groups[3].Value;
                int soldierCount = int.Parse(inputMatch.Groups[4].Value);

                if (!legionsWithActivity.ContainsKey(legionName))
                {
                    legionsWithActivity.Add(legionName, lastActivity);
                    legionsWithSoldiers.Add(legionName, new Dictionary<string, long>());
                }
                if (lastActivity > legionsWithActivity[legionName])
                {
                    legionsWithActivity[legionName] = lastActivity;
                }
                if (!legionsWithSoldiers[legionName].ContainsKey(soldierType))
                {
                    legionsWithSoldiers[legionName].Add(soldierType, 0);
                }
                legionsWithSoldiers[legionName][soldierType] += soldierCount;
            }
            string[] querryParameters = Console.ReadLine().Split('\\');

            if (querryParameters.Length > 1)
            {
                int activity = int.Parse(querryParameters[0]);
                string soldierType = querryParameters[1];

                foreach (var legionEntry in legionsWithSoldiers
                    .Where(legion => legion.Value.ContainsKey(soldierType))
                    .OrderByDescending(legion => legion.Value[soldierType]))
                {
                    if (legionsWithActivity[legionEntry.Key] < activity)
                    {
                        Console.WriteLine($"{legionEntry.Key} -> {legionsWithSoldiers[legionEntry.Key][soldierType]}");
                    }
                }
            }
            else
            {
                string soldierType = querryParameters[0];
                foreach (var legionEntry in legionsWithActivity.OrderByDescending(legion => legion.Value))
                {
                    if (legionsWithSoldiers[legionEntry.Key].ContainsKey(soldierType))
                    {
                        Console.WriteLine($"{legionEntry.Value} -> {legionEntry.Key}");
                    }
                }
            }
        }
    }
}
