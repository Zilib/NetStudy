using System;
using System.Collections.Generic;

namespace Interpolations
{
    class Program
    {
        static void Begginer()
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
            Console.WriteLine($"[{DateTime.Now,-20:d}] Hour [{DateTime.Now,-10:HH}] [{1063.342,15:N2}] feet");
        }
        static double CalculateHypotenuse(double leg1, double leg2) => Math.Sqrt(leg1 * leg1 + leg2 * leg2);

        private static void Advanced()
        {
            double a = 3;
            double b = 4;
            Console.WriteLine($"Area of the right triangle with legs of {a} and {b} is {.5 * a * b}");
            Console.WriteLine($"Length of the hypotenuse of the right triangle with legs of {a} and {b} is {CalculateHypotenuse(a, b)}");

            var date = new DateTime(1731, 11, 25);
            Console.WriteLine($"On {date:dddd, MMMM dd, yyyy} Leonhard Euler introduced the letter e to denote {Math.E:F5} in a letter to Christian Goldbach.");

            const int NameAligment = -9;
            const int ValueAligment = 7;

            Console.WriteLine($"Three classical Pythagorean means of {a} and {b}:");
            // if the length of the formatted expression result exceeds specified field width, the alignment value is ignored.
            Console.WriteLine($"|{"Arithmetic",NameAligment}|{.5 * (a + b), ValueAligment:F3}|");
            Console.WriteLine($"|{"Geometric",NameAligment}|{Math.Sqrt(a * b), ValueAligment:F3}|");
            Console.WriteLine($"|{"Harmonic",NameAligment}|{2 / (1 / a + 1 / b), ValueAligment:F3}|\n");

            // Escaping sequences in an interpolated string
            var xs = new int[] { 1, 2, 7, 9 };
            var ys = new int[] { 7, 9, 12 };
            Console.WriteLine($"Find the intersection of the {{{string.Join(", ", xs)}}} and {{{string.Join(", ",ys)}}} sets.\n");

            var userName = "Jane";
            var stringWithEscapes = $"C:\\Users\\{userName}\\Documents";
            var verbatimInterpolated = $@"C:\Users\{userName}\Documents";
            Console.WriteLine(stringWithEscapes);
            Console.WriteLine(verbatimInterpolated);

            var rand = new Random();
            for (int i = 0; i < 7; i++)
            {
                // Next double is generating nouber again
                Console.WriteLine($"Coin flip: {(rand.NextDouble() < .5 ? "heads" : "tails")}");
            }

            Console.WriteLine("");

            var cultures = new System.Globalization.CultureInfo[]
            {
                System.Globalization.CultureInfo.GetCultureInfo("en-US"),   
                System.Globalization.CultureInfo.GetCultureInfo("en-GB"),   
                System.Globalization.CultureInfo.GetCultureInfo("nl-NL"),
                System.Globalization.CultureInfo.InvariantCulture
            };
            var number = 31_415_926.536;
            FormattableString message = $"{date,20}{number,20:N3}";

            foreach (var culture in cultures)
            {
                var cultureSpecificMessage = message.ToString(culture);
                Console.WriteLine($"{culture.Name,-10}{cultureSpecificMessage}");
            }
        }


        static void Main(string[] args)
        {
            //Begginer();
            Advanced();
        }
    }
}
