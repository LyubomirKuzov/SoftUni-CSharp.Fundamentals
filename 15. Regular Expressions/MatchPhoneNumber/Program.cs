using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\+359([ -])2\1\d{3}\1\d{4}\b";

            string allNumbers = Console.ReadLine();

            MatchCollection validNumbersCollection = Regex.Matches(allNumbers, regex);

            string[] validNumbersArray = validNumbersCollection
                .Cast<Match>()
                .Select(x => x.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(", ", validNumbersArray));
        }
    }
}
