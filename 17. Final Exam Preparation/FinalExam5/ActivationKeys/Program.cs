using System;
using System.Linq;

namespace ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();

            while (true)
            {
                string[] commandArgs = Console.ReadLine()
                    .Split(">>>")
                    .ToArray();

                if (commandArgs[0] == "Generate")
                {
                    Console.WriteLine($"Your activation key is: {activationKey}");
                    break;
                }

                string command = commandArgs[0];

                commandArgs = commandArgs
                    .Skip(1)
                    .ToArray();

                switch (command)
                {
                    case "Contains":
                        Console.WriteLine(Contains(activationKey, commandArgs));
                        break;

                    case "Flip":
                        activationKey = Flip(activationKey, commandArgs);
                        Console.WriteLine(activationKey);
                        break;

                    case "Slice":
                        activationKey = Slice(activationKey, commandArgs);
                        Console.WriteLine(activationKey);
                        break;
                }
            }
        }

        private static string Contains(string activationKey, string[] commandArgs)
        {
            string substring = commandArgs[0];

            if (activationKey.Contains(substring))
            {
                return $"{activationKey} contains {substring}";
            }

            else
            {
                return "Substring not found!";
            }
        }

        private static string Flip(string activationKey, string[] commandArgs)
        {
            string collation = commandArgs[0];
            int startIndex = int.Parse(commandArgs[1]);
            int endIndex = int.Parse(commandArgs[2]);

            string substring = activationKey.Substring(startIndex, endIndex - startIndex);

            switch (collation)
            {
                case "Upper":
                    substring = substring.ToUpper();
                    break;

                case "Lower":
                    substring = substring.ToLower();
                    break;
            }

            activationKey = activationKey.Remove(startIndex, substring.Length);
            activationKey = activationKey.Insert(startIndex, substring);

            return activationKey;
        }

        private static string Slice(string activationKey, string[] commandArgs)
        {
            int startIndex = int.Parse(commandArgs[0]);
            int endIndex = int.Parse(commandArgs[1]);

            activationKey = activationKey.Remove(startIndex, endIndex - startIndex);

            return activationKey;
        }
    }
}
