using System;

namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            if (DetermineIfPasswordIsValid(password))
            {
                Console.WriteLine("Password is valid");
            }

            else
            {
                if (password.Length < 6 || password.Length > 10)
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }

                if (!PasswordConsistsOnlyLettersAndDigits(password))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }
                
                if (FindDigitsCount(password) < 2)
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
            }
        }

        public static bool DetermineIfPasswordIsValid(string password)
        {
            if (password.Length >= 6 && password.Length <= 10
                && PasswordConsistsOnlyLettersAndDigits(password)
                && FindDigitsCount(password) >= 2)
            {
                return true;
            }

            return false;
        }

        public static bool PasswordConsistsOnlyLettersAndDigits(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (!char.IsLetterOrDigit(password[i]))
                {
                    return false;
                }
            }

            return true;
        }

        public static int FindDigitsCount(string password)
        {
            int digitsCount = 0;

            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password[i]))
                {
                    digitsCount++;
                }
            }

            return digitsCount;
        }
    }
}
