using System;
using System.Collections.Generic;

namespace Interpolations
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "Adrian";
            Console.WriteLine($"Hello, { name }. It's a pleasure to meet you!");

            var Item = (Name: "eggplant", Price: 1.99m, perPackage: 3); // That is a tuple
            var date = DateTime.Now;
            // {x} good
            // { x } bad, because of instances as {item.Price:C2} dosn't work when use { item.Price:C2 }
            // :C probabbly it mean "Currencty" :O :O Amazing!
            Console.WriteLine($"On {date:y}, the price of {Item.Name} was {Item.Price} per {Item.perPackage} items.");

            var inventory = new Dictionary<string, int>()
            {
                ["hammer ball pein"] = 18,
                ["hammer, cross pein"] = 5,
                ["screwdriver, Philips #2"] = 14
            };

            Console.WriteLine($"Inventory on ${DateTime.Now:d}");
            Console.WriteLine(" ");
            Console.WriteLine($"|{"Item",-25}|{"Quantity",10}|"); // Wow! Amazing setting size of field
            foreach (var item in inventory)
            {
                Console.WriteLine($"|{item.Key,-25}|{item.Value,10}|");
            }
            Console.WriteLine(" ");
            Console.WriteLine($"[{DateTime.Now,-20:d}] Hour [{DateTime.Now, -10:HH}] [{1063.342, 15:N2}] feet");
        }
    }
}
