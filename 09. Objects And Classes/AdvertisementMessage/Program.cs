using System;

namespace AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = new string[] { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            string[] events = new string[] { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] authors = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            int messagesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < messagesCount; i++)
            {
                string phrase = phrases[GenerateRandomElement(phrases)];
                string eve = events[GenerateRandomElement(events)];
                string author = authors[GenerateRandomElement(authors)];
                string city = cities[GenerateRandomElement(cities)];

                Console.WriteLine($"{phrase} {eve} {author} - {city}");
            }
        }

        private static int GenerateRandomElement(string[] arr)
        {
            Random rand = new Random();

            return rand.Next(0, arr.Length);
        }
    }
}
