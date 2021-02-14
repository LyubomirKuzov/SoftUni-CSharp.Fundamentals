using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            double pricePerPerson = 0;

            switch (dayOfWeek)
            {
                case "Friday":
                    switch (groupType)
                    {
                        case "Students":
                            pricePerPerson = 8.45;
                            break;

                        case "Business":
                            pricePerPerson = 10.90;
                            break;

                        case "Regular":
                            pricePerPerson = 15;
                            break;
                    }
                    break;

                case "Saturday":
                    switch (groupType)
                    {
                        case "Students":
                            pricePerPerson = 9.80;
                            break;

                        case "Business":
                            pricePerPerson = 15.60;
                            break;

                        case "Regular":
                            pricePerPerson = 20;
                            break;
                    }
                    break;

                case "Sunday":
                    switch (groupType)
                    {
                        case "Students":
                            pricePerPerson = 10.46;
                            break;

                        case "Business":
                            pricePerPerson = 16;
                            break;

                        case "Regular":
                            pricePerPerson = 22.50;
                            break;
                    }
                    break;
            }

            double totalPrice = groupSize * pricePerPerson;

            if (groupType == "Students" && groupSize >= 30)
            {
                totalPrice *= 0.85;
            }

            else if (groupType == "Business" && groupSize >= 100)
            {
                totalPrice -= 10 * pricePerPerson;
            }

            else if (groupType == "Regular" && groupSize >= 10 && groupSize <= 20)
            {
                totalPrice *= 0.95;
            }

            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
