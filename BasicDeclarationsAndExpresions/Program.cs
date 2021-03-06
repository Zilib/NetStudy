﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

// https://www.w3resource.com/csharp-exercises/basic/index.php

namespace BasicDeclerationsAndExpresions
{
    class Program
    {
        static void Ex1()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Alexandra Abramov");
        }

        static void Ex2()
        {
            Console.WriteLine(2 + 5);
        }

        static void Ex3()
        {
            Console.WriteLine($"{10.0m / 3.0m}");
        }

        static void Ex4()
        {
            Console.WriteLine($"{-1 + 4 * 6}");
            Console.WriteLine($"{(35 + 5) % 7}");
            Console.WriteLine($"{14 + -4 * 6 / 11}");
            Console.WriteLine($"{2 + 15 / 6 * 1 - 7 % 2}");
        }
        /// Simple checking does user entered an integer
        static int InputNumber(string Text) /// Simple checking does user entered an integer
        {
            int OutInteger = 0;

            Console.Write(Text);
            string Input = Console.ReadLine();
            while (!int.TryParse(Input, out OutInteger))
            {
                Console.WriteLine("Incorrect! Again");
                Console.Write(Text);

                Input = Console.ReadLine();
            }

            return OutInteger;
        }

        static void Ex5()
        {
            string sNumber = string.Empty;
            int iNumber1 = 0, iNumber2 = 0; // here will be saved number if will pas through the validate
            iNumber1 = InputNumber("Input the first number: ");
            iNumber2 = InputNumber("Input the second number: ");
            int TemporaryNumber = iNumber1;
            iNumber1 = iNumber2;
            iNumber2 = TemporaryNumber;
            Console.WriteLine($"After Swapping:\nFirst Number: {iNumber1}\nSecond Number: {iNumber2}");
        }

        static void Ex6()
        {
            int number1 = InputNumber("Input the first number to multiply: ");
            int number2 = InputNumber("Input thge second number to multiply: ");
            int number3 = InputNumber("Input the third number to multiply: ");

            Console.WriteLine($"{number1} x {number2} x {number3} = {number1 * number2 * number3}");
        }

        static void Ex7()
        {
            int number1 = InputNumber("Input the first number: ");
            int number2 = InputNumber("Input the second number: ");

            Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
            Console.WriteLine($"{number1} - {number2} = {number1 - number2}");
            Console.WriteLine($"{number1} x {number2} = {number1 * number2}");
            Console.WriteLine($"{number1} / {number2} = {number1 / number2}");
            Console.WriteLine($"{number1} mod {number2} = {number1 % number2}");
        }

        static void Ex8()
        {
            int number1 = InputNumber("Enther the number");

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{number1} * {i} = {number1 * i}");
            }
        }

        static void Ex9()
        {
            int number1 = InputNumber("Enter the First number: ");
            int number2 = InputNumber("Enter the Second number: ");
            int number3 = InputNumber("Enter the third number: ");
            int number4 = InputNumber("Enter the four number: ");

            Console.WriteLine($"The average of {number1}, {number2}, {number3}, {number4} is {(number1 + number2 + number3 + number4) / 4}");
        }

        static void Ex10()
        {
            int x = InputNumber("Enter first number - ");
            int y = InputNumber("Enter second number - ");
            int z = InputNumber("Enter third number - ");

            Console.WriteLine($"Result of specifed numbers {x},{y} and {z}, (x+y).z is {(x + y) * z} and x.y + y.z is { x * y + y * z}");
        }

        static void Ex11()
        {
            int age = InputNumber("Enter your age: ");
            Console.WriteLine($"You look younger than {age}");
        }

        static void Ex12()
        {
            int Digit = InputNumber("Enter a digit: ");
            Console.WriteLine("{0} {0} {0} {0}", Digit);
            Console.WriteLine("{0}{0}{0}{0}", Digit);
            Console.WriteLine("{0} {0} {0} {0}", Digit);
            Console.WriteLine("{0}{0}{0}{0}", Digit);
        }

        static void Ex13()
        {
            int Digit = InputNumber("Enter a digit: ");
            Console.WriteLine("{0}{0}{0}", Digit);
            Console.WriteLine("{0} {0}", Digit);
            Console.WriteLine("{0} {0}", Digit);
            Console.WriteLine("{0} {0}", Digit);
            Console.WriteLine("{0}{0}{0}", Digit);
        }

        static void Ex14()
        {
            int Celsjus = InputNumber("Enter the amount of celsius: ");

            //Kelvin
            Console.WriteLine($"Kelvin = {Celsjus + 273.15}");
            Console.WriteLine($"Fahrenheit = {Celsjus * 1.8 + 32}");
        }

        public static string remove_char(string str, int n) => str.Remove(n, 1);
        static void Ex15()
        {
            string text = "w3resource";
            Console.WriteLine(remove_char(text, 1));
            Console.WriteLine(remove_char(text, 9));
            Console.WriteLine(remove_char(text, 0));
        }
        static void Ex16(string text)
        {
            StringBuilder tex1 = new StringBuilder(text);
            char FirstChar = tex1[0];
            tex1[0] = tex1[tex1.Length - 1];
            tex1[tex1.Length - 1] = FirstChar;
            Console.WriteLine(tex1);
        }

        static void Ex17()
        {
            Console.Write("Input a string: ");
            string InputString = Console.ReadLine();
            StringBuilder BuildedString = new StringBuilder(InputString);
            Console.WriteLine($"{BuildedString[0]}{BuildedString}{BuildedString[0]}");
        }

        static void Ex18()
        {
            int a = InputNumber("Input first integer: ");
            int b = InputNumber("Input second integer: ");

            if ((a > 0 && b <= 0) || (a < 0 && b > 0))
            {
                Console.WriteLine("True");
            }
        }

        static void Ex19()
        {
            int a = InputNumber("Input first integer: ");
            int b = InputNumber("Input second integer: ");
            if (a != b)
                Console.WriteLine($"{a + b}");
            else
                Console.WriteLine($"{(a + b) * 3}");
        }

        private static int Ex2Absolute(int x, int y) => x < y ? Math.Abs(x - y) : Math.Abs(x - y) * 2;

        static void Ex20()
        {
            int Number1 = InputNumber("Input first number: ");
            int Number2 = InputNumber("Input second number: ");
            Console.WriteLine(Ex2Absolute(Number1, Number2));
        }

        private static bool CheckSum(int x, int y) => (x == 20 || y == 20 || x + y == 20) ? true : false;

        static void Ex21()
        {
            int x = InputNumber("Input first number: ");
            int y = InputNumber("Input second number: ");
            Console.WriteLine(CheckSum(x, y));
        }

        static void Ex22()
        {
            int x = InputNumber("Input an integer: ");
            Console.WriteLine((Math.Abs(x - 100) <= 20) || (Math.Abs(x - 200) <= 20));
    
        }
        private static string Ex23(string str) => str.ToLower();

        static void Ex24()
        {
            Console.WriteLine("Write a C# Sharp program to display the following pattern using the alphabet");
            string Str = Console.ReadLine();
            string[] Words = Str.Split(new[] { " " }, StringSplitOptions.None);

            int LongestWordIndex = 0;
            for(int i=1; i < Words.Length; i++)
            {
                if (Words[i].Length > Words[LongestWordIndex].Length)
                    LongestWordIndex = i;
            }
            Console.WriteLine(Words[LongestWordIndex]);
        }

        static void Ex25()
        {
            for (int i = 1; i <= 99; i++)
            {
                if (i % 2 == 1)
                    Console.WriteLine(i);
            }
        }

        static bool IsPrime(int number)
        {
            for(int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }

        static void Ex26()
        {
            int[] PrimeNumbers = new int[500];
            int CurrentPrimeIndex = 0;
            int CurrentNumber = 2;
            int sum = 0;

            while (CurrentPrimeIndex < 500)
            {
                if (IsPrime(CurrentNumber))
                {
                    sum += CurrentNumber;
                    PrimeNumbers[CurrentPrimeIndex++] = CurrentNumber;
                }

                CurrentNumber++;
            }

            Console.WriteLine(sum);
        }

        static void Ex27()
        {
            int x = InputNumber("Input a number(integer): ");
            char[] Digits = x.ToString().ToCharArray();

            int DigitsSum = 0;
            for(int i = 0; i < Digits.Length; i++)
            {
                DigitsSum += (int)Char.GetNumericValue(Digits[i]);
            }
            Console.WriteLine(DigitsSum);
        }

        static void Ex28()
        {
            string String = "Display the pattern like pyramid using the alphabet.";
            string[] SplitedString = String.Split(" ");
            Array.Reverse(SplitedString);
            string ReversedString = string.Join(" ", SplitedString);
            Console.WriteLine(ReversedString);
        }

        static void Ex29()
        {
            string path = @"E:\.NetLearning\BasicDeclarationsAndExpresions\Files\file.txt";
            if (File.Exists(path))
            {
                FileInfo f = new FileInfo(path);
                Console.WriteLine($"Size of a file: {f.Length}");
            }
        }

        static void Ex30()
        {
            string hexval = "4B0";
            Console.WriteLine($"Hexadecimal number: {hexval}");
            int decValue = int.Parse(hexval, System.Globalization.NumberStyles.HexNumber);
            Console.WriteLine($"Decimal number: {decValue}");
        }

        static void Ex31()
        {
            int[] Array1 = new int[4] { 1, 3, -5, 4 };
            int[] Array2 = new int[4] { 1, 4, -5, -2 };

            for (int i = 0; i < 4; i++)
                Console.Write($"{Array1[i] * Array2[i]} ");

        }

        static void Ex32()
        {
            Console.Write("Input a string: ");
            string InputString = Console.ReadLine();
            if (InputString.Length < 4)
            {
                Console.WriteLine("{0}{0}{0}{0}", InputString);
            }
            else if (InputString.Length >= 4)
            {
                string[] SplitedString = InputString.Split(" ");
                Console.WriteLine("{0}{0}{0}{0}", SplitedString[SplitedString.Length - 1]);
            }

        }

        static void Ex33()
        {
            int x = InputNumber("Input first integer: ");
            Console.WriteLine($"{(x % 3 == 0 || x % 7 == 0)}");
        }

        static void Ex34()
        {
            string text = "Hello how are you?";
            Console.WriteLine($"{(text.StartsWith("Hello") && text[5] == ' ')}");
        }

        static void Ex35()
        {
            int a = InputNumber("Input a first number(<100): ");
            int b = InputNumber("Input a second number(>100): ");

            Console.WriteLine(a < 100 && b > 100);
        }

        static void Ex36()
        {
            int a = InputNumber("Input a first number: ");
            int b = InputNumber("Input a second number: ");

            Console.WriteLine(a >= -10 && a <= 10 && b >= -10 && b <= 10);
        }

        static void Ex37()
        {
            Console.Write("Test Data: ");
            string Data = Console.ReadLine();

            if (Data.Substring(1, 2) == "HP")
            {
                Console.WriteLine(Data.Remove(1, 2));
            }
            else
            {
                Console.WriteLine(Data);
            }
        }

        static void Ex38()
        {
            string A = Console.ReadLine();

            if(A.Length >= 1)
            {
                if (A[0] == 'P')
                    Console.Write("P");
                if (A[1] == 'H')
                    Console.Write("H");
            }
        }

        static void Ex39()
        {
            int[] a = new int[3];

            a[0] = InputNumber("Input first integer: ");
            a[1] = InputNumber("Input second integer: ");
            a[2] = InputNumber("Input third integer: ");

            Array.Sort(a);
            Array.Reverse(a);

            Console.WriteLine($"Largest of three: {a[0]}");
            Console.WriteLine($"Lowest of three: {a[2]}");
        }

        static void Ex40()
        {
            int a = InputNumber("Input first integer: ");
            int b = InputNumber("Input second integer: ");

            if (a == b)
                Console.WriteLine("0");
            else
                Console.WriteLine(Math.Abs(a - 20) < Math.Abs(b - 20) ? a : b);
        }

        static void Ex41()
        {
            Console.WriteLine("Input string: ");
            string a = Console.ReadLine();
            var count = a.Count(s => s == 'w');

            Console.WriteLine(count >= 1 && count <= 3);
        }

        static void Main(string[] args)
        {
            //Ex1();
            //Ex2();
            //Ex3();
            //Ex4();
            //Ex5();
            //Ex6();
            //Ex7();
            //Ex8();
            //Ex9();
            //Ex10();
            //Ex11();
            //Ex12();
            //Ex13();
            //Ex14();
            //Ex15();
            //Ex16("w3resource");
            //Ex16("Python");
            //Ex17();
            //Ex18();
            //Ex19();
            //Ex20();
            //Ex21();
            //Ex22();
            //Console.WriteLine(Ex23("THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG."));
            //Ex24();
            //Ex25();
            //Ex26();
            //Ex27();
            //Ex28();
            //Ex29();
            //Ex30();
            //Ex31();
            //Ex32();
            //Ex33();
            //Ex34();
            //Ex35();
            //Ex36();
            //Ex37();
            //Ex38();
            //Ex39();
            //Ex40();
            Ex41();
        }
    }
}
