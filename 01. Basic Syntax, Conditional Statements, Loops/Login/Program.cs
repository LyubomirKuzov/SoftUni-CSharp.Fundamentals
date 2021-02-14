using System;
using System.Linq;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            string correctPassword = string.Concat(username.Reverse());
            int attemptsCounter = 0;

            while (true)
            {
                string currentPassword = Console.ReadLine();
                attemptsCounter++;

                if (currentPassword == correctPassword)
                {
                    Console.WriteLine($"User {username} logged in.");
                    return;
                }

                if (attemptsCounter == 4)
                {
                    Console.WriteLine($"User {username} blocked! ");
                    return;
                }

                Console.WriteLine("Incorrect password. Try again.");
            }
        }
    }
}
