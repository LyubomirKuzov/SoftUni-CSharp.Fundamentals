using System;
using System.Text.RegularExpressions;

namespace ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string emailPattern = @"\s([A-Za-z0-9]+[A-Za-z0-9.\-_]*[A-Za-z0-9]+)@[A-Za-z]+[A-Za-z-]*[A-Za-z]+\.[A-Za-z]+[A-Za-z-]*[A-Za-z]+(\.[A-Za-z]+)?";

            MatchCollection emails = Regex.Matches(text, emailPattern);

            foreach (var item in emails)
            {
                Console.WriteLine(item.ToString().Trim());
            }
        }
    }
}
