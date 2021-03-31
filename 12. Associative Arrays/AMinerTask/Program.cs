using System;
using System.Collections.Generic;

namespace AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resourcesDict = new Dictionary<string, int>();

            while (true)
            {
                string resource = Console.ReadLine();

                if (resource == "stop")
                {
                    break;
                }

                int quantity = int.Parse(Console.ReadLine());

                if (resourcesDict.ContainsKey(resource))
                {
                    resourcesDict[resource] += quantity;
                }

                else
                {
                    resourcesDict.Add(resource, quantity);
                }
            }

            foreach (var resource in resourcesDict)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value}");
            }
        }
    }
}
