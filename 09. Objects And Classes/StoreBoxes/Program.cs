using System;
using System.Collections.Generic;
using System.Linq;

namespace StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();

            while (true)
            {
                string[] inputArgs = Console.ReadLine().Split().ToArray();

                if (inputArgs[0] == "end")
                {
                    break;
                }

                string serialNumber = inputArgs[0];
                string itemName = inputArgs[1];
                int itemQuantity = int.Parse(inputArgs[2]);
                decimal itemPrice = decimal.Parse(inputArgs[3]);

                Item item = new Item()
                {
                    Name = itemName,
                    Price = itemPrice
                };

                Box box = new Box()
                {
                    SerialNumber = serialNumber,
                    Item = item,
                    ItemQuantity = itemQuantity
                };

                boxes.Add(box);
            }

            boxes = boxes
                .OrderByDescending(b => b.Price)
                .ToList();

            foreach (var box in boxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.Price:f2}");
            }
        }
    }

    public class Item
    {
        public string Name { get; set; }

        public decimal Price { get; set; }
    }

    public class Box
    {
        public string SerialNumber { get; set; }

        public Item Item { get; set; }

        public int ItemQuantity { get; set; }

        public decimal Price => this.Item.Price * this.ItemQuantity;
    }
}
