using System;
using System.Linq;

namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine()
                .Split(", ")
                .ToArray();

            usernames = usernames
                .Where(x => x.Length >= 3 && x.Length <= 16 && IsUsernameValid(x))
                .ToArray();

            Console.WriteLine(string.Join(Environment.NewLine, usernames));
        }

        public static bool IsUsernameValid(string username)
        {
            for (int i = 0; i < username.Length; i++)
            {
                if (!char.IsLetterOrDigit(username[i]) && username[i] != '_' && username[i] != '-')
                {
                    return false;
                }
            }

            return true;
        }
    }
}
