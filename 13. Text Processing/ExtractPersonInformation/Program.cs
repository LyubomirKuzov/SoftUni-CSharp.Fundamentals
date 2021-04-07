using System;

namespace ExtractPersonInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            int linesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < linesCount; i++)
            {
                string input = Console.ReadLine();

                int nameStartIndex = input.IndexOf('@') + 1;
                int nameEndIndex = input.IndexOf('|') - 1;
                int ageStartIndex = input.IndexOf('#') + 1;
                int ageEndIndex = input.IndexOf('*') - 1;

                string name = input.Substring(nameStartIndex, nameEndIndex - nameStartIndex + 1);
                string age = input.Substring(ageStartIndex, ageEndIndex - ageStartIndex + 1);

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
