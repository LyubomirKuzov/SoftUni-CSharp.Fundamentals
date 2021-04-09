using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SantasSecretHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());

            List<string> messages = AddMessages();
            messages = DecryptMessages(messages, key);

            FindGoodKids(messages);
        }

        static List<string> AddMessages()
        {
            List<string> messages = new List<string>();

            while (true)
            {
                string message = Console.ReadLine();

                if (message == "end")
                {
                    break;
                }

                messages.Add(message);
            }

            return messages;
        }

        static List<string> DecryptMessages(List<string> messages, int key)
        {
            int counter = messages.Count;

            for (int i = 0; i < counter; i++)
            {
                string currentMessage = messages[0];
                string decryptedMessage = string.Empty;

                for (int j = 0; j < currentMessage.Length; j++)
                {
                    decryptedMessage += (char)(currentMessage[j] - key);
                }

                messages.Add(decryptedMessage);
                messages.RemoveAt(0);
            }

            return messages;
        }

        static void FindGoodKids(List<string> messages)
        {
            List<string> goodKids = new List<string>();

            string pattern = @".*@(?<name>[A-Za-z]+)[^-!:>]+!(?<attitude>[G|N])!.*";

            for (int i = 0; i < messages.Count; i++)
            {
                if (Regex.IsMatch(messages[i], pattern))
                {
                    Match newMatch = Regex.Match(messages[i], pattern);

                    string name = newMatch.Groups["name"].Value;
                    string attitude = newMatch.Groups["attitude"].Value;

                    if (attitude == "G")
                    {
                        goodKids.Add(name);
                    }
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, goodKids));
        }
    }
}
