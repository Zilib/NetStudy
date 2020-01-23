using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("The current time is " + DateTime.Now);

            // String
            string aFriend = "Adrian";
            Console.WriteLine(aFriend);

            // Change variable value and write
            aFriend = "Bartek";
            Console.WriteLine(aFriend);

            Console.WriteLine("Hello " + aFriend);
            Console.WriteLine("*****************************");

            // Something new and amazing for me, string interpolation
            Console.WriteLine($"Hello {aFriend}");

            // String lengths
            Console.WriteLine($"The name { aFriend } has { aFriend.Length } letters");

            aFriend = "Adrian";
            Console.WriteLine($"And name { aFriend } has { aFriend.Length } letters");
            Console.WriteLine(""); // Endline, probabbly for beginner. I do not know how to do it, in the other way. Untill 

            string greeting = "      Hello World!       ";
            Console.WriteLine($"[{greeting}]"); // Show without changes variable greeting

            string trimmedGreeting = greeting.TrimStart();
            Console.WriteLine($"[{trimmedGreeting}]"); // Remove spaces from start

            trimmedGreeting = greeting.TrimEnd();
            Console.WriteLine($"[{trimmedGreeting}]"); // Remove spaces from end

            trimmedGreeting = greeting.Trim();
            Console.WriteLine($"[{trimmedGreeting}]"); // Remove spaces from start and end.

            string HelloWorld = "Hello World";
            Console.WriteLine("");
            Console.WriteLine(HelloWorld);

            HelloWorld = HelloWorld.Replace("Hello", "Grettings");
            Console.WriteLine(HelloWorld);

            Console.WriteLine("");
            Console.WriteLine("");

            // Both work, doesn't matter which kind of char
            Console.WriteLine(HelloWorld.ToUpper() + '\n');
            Console.WriteLine(HelloWorld.ToLower() + "\n"); // Searching for another way to insert end line

            // Search string
            string songLyrics = "You say goodbye, and I say hello";
            Console.WriteLine(songLyrics.Contains("goodbye"));
            Console.WriteLine(songLyrics.Contains("greetigs"));

            Console.WriteLine("");
            Console.WriteLine("\tCHALLENGE");

            // Challenge
            Console.WriteLine(songLyrics.StartsWith("You"));
            Console.WriteLine(songLyrics.EndsWith("goodbye"));

        }
    }
}
