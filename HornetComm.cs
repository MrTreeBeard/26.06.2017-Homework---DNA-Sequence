using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HornetComm
{
    class HornetComm
    {
        static void Main()
        {
                List<string> messages = new List<string>();
                List<string> broadcasts = new List<string>();

                string messagePattern = @"^(\d+) \<\-\> ([a-zA-Z0-9]+)$";
                string broadcastPattern = @"^(\D+) \<\-\> ([a-zA-Z0-9]+)$";

                Regex messageRegex = new Regex(messagePattern);
                Regex broadcastRegex = new Regex(broadcastPattern);

                string inputText = Console.ReadLine();

                while (inputText != "Hornet is Green")
                {
                    if (messageRegex.IsMatch(inputText))
                    {
                        Match match = messageRegex.Match(inputText);
                        string recipientCode = string.Join("", match.Groups[1].Value.Reverse());
                        string message = match.Groups[2].Value;
                        messages.Add(recipientCode + " -> " + message);
                    }
                    if (broadcastRegex.IsMatch(inputText))
                    {
                        Match match = broadcastRegex.Match(inputText);
                        string message = match.Groups[2].Value;
                        string frequency = DecryptFrequency(match.Groups[2].Value);
                        broadcasts.Add(frequency + " -> " + message);
                    }
                inputText = Console.ReadLine();
                }
            Console.WriteLine("Broadcasts: ");
            Console.WriteLine(broadcasts.Any() ? string.Join("\n", broadcasts) : "None");
            Console.WriteLine("Messages: ");
            Console.WriteLine(messages.Any() ? string.Join("\n", messages) : "None");
        }
        public static string DecryptFrequency(string encryptedFrerquency)
        {
            string decryptedFrequency = "";

            foreach (char currentChar in encryptedFrerquency)
            {
                if (currentChar >= 65 && currentChar <= 90)
                {
                    decryptedFrequency += (char)(currentChar + 32);
                }
                else if (currentChar >= 97 && currentChar <= 122)
                {
                    decryptedFrequency += (char)(currentChar - 32);
                }
                else
                {
                    decryptedFrequency += currentChar;
                }
            }
            return decryptedFrequency;
        }
    }
}