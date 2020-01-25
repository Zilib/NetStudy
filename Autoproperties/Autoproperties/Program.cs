using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Autoproperties
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string MiddleName { get; } = "";

        public Person(string first,string middle, string last)
        {
            FirstName = first;
            MiddleName = middle;
            LastName = last;
        }
        public override string ToString() => $"{ FirstName } { LastName }"; // Something like overload. When you call to object of this type, it will be called.
        public string AllCaps() => ToString().ToUpper();

    }
    class Program
    {
        public static void BankAcc()
        {
            var p = new Person("Bill", "The", "Wagner");
            Console.WriteLine("The name, in all caps: " + p.AllCaps());
            Console.WriteLine("The name: " + p);

            // 9 words, letters in order from left to right {3, 5, 5, 3, 5, 4, 3, 4, 3} sum of it is 35. So sum of letters / words = 3.89
            var phrase = "the quick brown fox jumps over the lazy dog";
            var wordLength = from word in phrase.Split(' ') select word.Length;

            Console.WriteLine($"The average word length is: { wordLength.Average():F2}");
        }
        private static void Exceptions()
        {
            try
            {
                string s = null;
                Console.WriteLine(s.Length);
            }
            catch (Exception e) when (LogException(e))
            {

            }
            Console.WriteLine("Exception must have been handled");
        }
        private static bool LogException(Exception e)
        {
            Console.WriteLine($"\tIn the log routine. Caught { e.GetType() }");
            Console.WriteLine($"\tMessage: { e.Message }");
            return false;
        }

        private static void Nulls()
        {
            string s = null;
            char? c = s?[0];

            Console.WriteLine(s?.Length); // WriteLine(s.Length) == error
            Console.WriteLine(c.HasValue);

            bool? hasMore = s?.ToCharArray()?.GetEnumerator()?.MoveNext() ?? false;
            Console.WriteLine(hasMore);
        }

        private static void Nameofs()
        {
            Console.WriteLine(nameof(System.String));

            int j = 5;
            Console.WriteLine(nameof(j));

            List<string> names = new List<string>();
            Console.WriteLine(nameof(names)); // Show me the variable name whoaaa
        }
        private static void Directionaries()
        {
            var messages = new Dictionary<int, string>
            {
                [404] = "Page not Found",
                [302] = "Page moved, but left a forwarding address.",
                [500] = "The web server can't come out to play today."
            };
            Console.WriteLine(messages[302]);
        }
        static void Main(string[] args)
        {
            //BankAcc();
            //Nulls();
            //Exceptions();
            //Nameofs();
            Directionaries();
        }
    }
}
