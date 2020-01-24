using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            // Finally i know how to create my own function!
            // WorkingWithStrings();

            var fibonacciNumbers = new List<int> { 1, 1 };
            for (int i = 0; i < 18; i++)
            {
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
                fibonacciNumbers.Add(previous + previous2);
            }
            foreach (var item in fibonacciNumbers)
            {
                Console.WriteLine(item);
            }
        }

        public static void WorkingWithStrings()
        {
            var names = new List<string> { "Adrian", "Ana", "Felipe" };
            foreach (var name in names)
            {
                Console.WriteLine($"Hello { name.ToUpper() }!");
            }

            Console.WriteLine();
            names.Add("Maria");
            names.Add("Bill");
            names.Remove("Ana");
            foreach (var name in names)
            {
                Console.WriteLine($"Hello { name.ToUpper() }");
            }
            Console.WriteLine();

            Console.WriteLine($"My name is { names[0] }");
            Console.WriteLine($"I've added {names[2] } and { names[3] } to the list");

            Console.WriteLine();
            Console.WriteLine($"The list has { names.Count } people in it");

            // Searching in list
            var index = names.IndexOf("Felipe");
            if (index == -1)
            {
                Console.WriteLine($"When an item is not found, IndexOf returns { index }");
            }
            else
            {
                Console.WriteLine($"The name { names[index] } is at index { index }");
            }

            index = names.IndexOf("Not Found");
            if (index == -1)
            {
                Console.WriteLine($"When an item is not found, IndexOf returns { index }");
            }
            else
            {
                Console.WriteLine($"The name { names[index] } is at index { index }");
            }
            // Sorting
            names.Sort();
            Console.WriteLine();
            foreach (var name in names)
            {
                Console.WriteLine($"Hello { name.ToUpper() }!");
            }
        }
    }
}
