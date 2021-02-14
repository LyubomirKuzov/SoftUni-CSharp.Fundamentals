using System;

namespace TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int a = 97; a < 97 + N; a++)
            {
                for (int b = 97; b < 97 + N; b++)
                {
                    for (int c = 97; c < 97 + N; c++)
                    {
                        Console.WriteLine($"{(char)a}{(char)b}{(char)c}");
                    }
                }
            }
        }
    }
}
