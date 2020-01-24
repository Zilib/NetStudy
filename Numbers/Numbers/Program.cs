using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // integers
            int a = 10, b = 20;
            int c = a + b;
            Console.WriteLine(c + "\n");
            // endline here

            // integer precision and limits
            a = 7;
            b = 4;
            c = 3;
            int d = (a + b) / c; // 7 + 4 = 11, 11 / 3 = d. d >3 && d < 4
            int e = (a + b) % c; // 11 % 3 = 2
            Console.WriteLine($"quotient: { d }");
            Console.WriteLine($"remainder: { e } \n");

            // Looking for limits
            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is { min } to { max }");

            int what = max + 3;
            Console.WriteLine($"An example of overflow: { what }\n"); // It should be additional*

            // Double
            double x = 5;
            double y = 4;
            double z = 2;
            double xyz = (x + y) / z;
            Console.WriteLine(xyz+ " - XYZ");

            x = 19;
            y = 23;
            z = 8;
            xyz = (x + y) / z;
            Console.WriteLine(xyz+ " - Second XYZ\n");

            // Looking for max range of double
            double MaxDouble = double.MaxValue;
            double MinDouble = double.MinValue;
            Console.WriteLine($"The range of double is { MinDouble } to { MaxDouble }");

            double third = 1.0 / 3.0;
            Console.WriteLine(third + "\n");

            // Fixed point types
            decimal MinDecimal = decimal.MinValue;
            decimal MaxDecimal = decimal.MaxValue;
            Console.WriteLine($"The range of the decimal type is { MinDecimal } to { MaxDecimal }");

            x = 1.0;
            y = 3.0;
            Console.WriteLine(x / y);

            decimal q = 1.0M;
            decimal w = 3.0M;
            Console.WriteLine(q / w);

            // Challengg
            double CircleRadius = 2.50;
            double CircleArea = CircleRadius * CircleRadius * Math.PI;
            Console.WriteLine($"\nArea of circle: { CircleArea }");
        }
    }
}
