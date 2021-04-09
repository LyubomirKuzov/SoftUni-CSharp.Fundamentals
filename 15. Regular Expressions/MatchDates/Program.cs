using System;
using System.Text.RegularExpressions;

namespace MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?<day>\d{2})(?<separator>[.\-\/])(?<month>[A-Z][a-z]{2})\k<separator>(?<year>\d{4})\b";

            string allDates = Console.ReadLine();

            var validDates = Regex.Matches(allDates, pattern);

            foreach (Match date in validDates)
            {
                var day = date.Groups["day"].Value;
                var month = date.Groups["month"].Value;
                var year = date.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
