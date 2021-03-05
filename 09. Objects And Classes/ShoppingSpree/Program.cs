using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = AddPeopleToArray();
            List<Product> products = AddProductsToArray();

            while (true)
            {
                string[] command = Console.ReadLine()
                    .Split()
                    .ToArray();

                if (command[0] == "END")
                {
                    break;
                }

                string personName = command[0];
                string productName = command[1];

                Person person = people.First(p => p.Name == personName);
                Product product = products.First(p => p.Name == productName);

                person.BuyProduct(product);
            }

            Print(people);
        }

        private static List<Person> AddPeopleToArray()
        {
            string[] peopleArgs = Console.ReadLine()
                .Split(new char[] { '=', ';' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            List<Person> people = new List<Person>();

            for (int i = 0; i < peopleArgs.Length; i += 2)
            {
                string name = peopleArgs[i];
                decimal money = decimal.Parse(peopleArgs[i + 1]);

                Person person = new Person(name, money);
                people.Add(person);
            }

            return people;
        }

        private static List<Product> AddProductsToArray()
        {
            string[] productArgs = Console.ReadLine()
                .Split(new char[] { '=', ';' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            List<Product> products = new List<Product>();

            for (int i = 0; i < productArgs.Length; i += 2)
            {
                string name = productArgs[i];
                decimal money = decimal.Parse(productArgs[i + 1]);

                Product product = new Product(name, money);
                products.Add(product);
            }

            return products;
        }

        private static void Print(List<Person> people)
        {
            foreach (var p in people)
            {
                if (p.Products.Count == 0)
                {
                    Console.WriteLine($"{p.Name} - Nothing bought");
                }

                else
                {
                    Console.WriteLine($"{p.Name} - {string.Join(", ", p.Products)}");
                }
            }
        }
    }

    public class Person
    {
        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.Products = new List<Product>();
        }



        public string Name { get; set; }

        public decimal Money { get; set; }

        public List<Product> Products { get; set; }



        public void BuyProduct(Product product)
        {
            if (this.Money >= product.Cost)
            {
                Console.WriteLine($"{this.Name} bought {product.Name}");
                this.Products.Add(product);
                this.Money -= product.Cost;
            }

            else
            {
                Console.WriteLine($"{this.Name} can't afford {product.Name}");
            }
        }
    }

    public class Product
    {
        public Product(string name, decimal cost)
        {
            this.Name = name;
            this.Cost = cost;
        }



        public string Name { get; set; }

        public decimal Cost { get; set; }



        public override string ToString()
        {
            return this.Name;
        }
    }
}
