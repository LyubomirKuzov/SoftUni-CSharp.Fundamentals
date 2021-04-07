using System;

namespace ASCIISumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            string text = Console.ReadLine();

            int sum = 0;

            foreach (var symbol in text)
            {
                if (symbol > Math.Min(firstChar, secondChar) && symbol < Math.Max(firstChar, secondChar))
                {
                    sum += symbol;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
