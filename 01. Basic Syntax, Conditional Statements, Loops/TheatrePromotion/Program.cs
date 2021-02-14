using System;

namespace TheatrePromotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfDay = Console.ReadLine();
            int personAge = int.Parse(Console.ReadLine());

            string ticketPrice = string.Empty;

            if (personAge >= 0 && personAge <= 18)
            {
                switch (typeOfDay)
                {
                    case "Weekday":
                        ticketPrice = "12$";
                        break;

                    case "Weekend":
                        ticketPrice = "15$";
                        break;

                    case "Holiday":
                        ticketPrice = "5$";
                        break;
                }
            }

            else if (personAge >= 19 && personAge <= 64)
            {
                switch (typeOfDay)
                {
                    case "Weekday":
                        ticketPrice = "18$";
                        break;

                    case "Weekend":
                        ticketPrice = "20$";
                        break;

                    case "Holiday":
                        ticketPrice = "12$";
                        break;
                }
            }

            else if (personAge >= 65 && personAge <= 122)
            {
                switch (typeOfDay)
                {
                    case "Weekday":
                        ticketPrice = "12$";
                        break;

                    case "Weekend":
                        ticketPrice = "15$";
                        break;

                    case "Holiday":
                        ticketPrice = "10$";
                        break;
                }
            }

            else
            {
                ticketPrice = "Error!";
            }

            Console.WriteLine(ticketPrice);
        }
    }
}
