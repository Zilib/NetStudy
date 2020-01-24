using System;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 6;

            if (a + b > 10)
            {
                Console.WriteLine("The answer is greater than 10");
            }
            else if(a + b <= 10)
            {
                Console.WriteLine("The answer is not greater than 10");
            }

            b = 3;
            if (a + b > 10)
            {
                Console.WriteLine("The answer is greater than 10");
            }
            else if (a + b <= 10)
            {
                Console.WriteLine("The answer is not greater than 10\n");
            }
            // Counters
            // From 1 to 10
            int counter = 1;
            while (counter <= 10)
            {
                Console.WriteLine($"Hello World! The counter is { counter++ }");
            }
            Console.WriteLine("\n\n");

            counter = 1;
            do
            {
                Console.WriteLine($"Hello World! The counter is { counter++ }");
            } while (counter <= 10);

            Console.WriteLine("\n\n");

            for(counter = 1; counter <= 10; counter++)
            {
                Console.WriteLine($"Hello World! The counter is { counter }");
            }
            // Show even numbers in range from 1 to 20
            for(int i = 1; i<=20;i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
