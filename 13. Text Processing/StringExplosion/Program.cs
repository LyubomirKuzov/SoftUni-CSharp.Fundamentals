using System;

namespace StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            int removeCount = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))
                {
                    removeCount += int.Parse(text[i].ToString());
                }

                if (removeCount > 0 && text[i] != '>')
                {
                    text = text.Remove(i, 1);
                    removeCount--;
                    i--;
                }
            }

            Console.WriteLine(text);
        }
    }
}
