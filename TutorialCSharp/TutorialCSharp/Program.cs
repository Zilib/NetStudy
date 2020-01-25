using System;

namespace TutorialCSharp
{
    public class MethodClass
    {
        public void Method1(string message) { }
        public void Method2(string message) { }
        
    }

    class Program
    {
        public delegate void Del(string message);
        public static void DelegateMethod(string message)
        {
            Console.WriteLine(message);
        }
        void DoWork(int k) { };
        public static void MethodWithCallback(int param1, int param2, Del callback)
        {
            callback($"The number is {param1 + param2}");
        }
        static void Main(string[] args)
        {
            Del handler = DelegateMethod;
            handler("Hello World");
            MethodWithCallback(1, 2, handler);
            Console.WriteLine("\n\n");

            var obj = new MethodClass();
            Del d1 = obj.Method1;
            Del d2 = obj.Method2;
            Del d3 = DelegateMethod;

            Del allMethodsDelegate = d1 + d2;
            allMethodsDelegate += d3;
            Console.WriteLine(allMethodsDelegate);

            Console.WriteLine("\n\n");
        }
    }
}

/*
namespace TutorialCSharp
{
    interface IEnglishDimensions
    {
        float Length();
        float Width();
    }
    interface IMetricDimensions
    {
        float Length();
        float Width();
    }
    class Box : IEnglishDimensions, IMetricDimensions
    {
        float lengthInches { get; }
        float widthInches { get; }
        public float Length() => lengthInches * 2.54f;
        public float Width() => widthInches * 2.54f;

        public Box(float lengthInches, float widthInches)
        {
            this.lengthInches = lengthInches;
            this.widthInches = widthInches;
        }


        float IEnglishDimensions.Length() => lengthInches;
        float IEnglishDimensions.Width() => widthInches;

        float IMetricDimensions.Length() => lengthInches * 2.54f;
        float IMetricDimensions.Width() => widthInches * 2.54f;

        static void Main(string[] args)
        {
            Box box1 = new Box(30.0f, 20.0f);

            IEnglishDimensions eDimensions = box1;
            IMetricDimensions mDimensions = box1;

            Console.WriteLine($"{"Length(in):", -10} {eDimensions.Length(), -5}");
            Console.WriteLine($"{"Width (in):", -10} {eDimensions.Width(), -5}\n");

            Console.WriteLine($"{"Length(in):",-10} {mDimensions.Length(), -5}");
            Console.WriteLine($"{"Width (in):",-10} {mDimensions.Width(), -5}\n");

            Console.WriteLine($"{"Length(in):",-10} {box1.Length(),-5}");
            Console.WriteLine($"{"Width (in):",-10} {box1.Width(),-5}");
        }
    }

}

namespace TutorialCSharp
{
    interface IDimensions
    {
        float getLength();
        float getWidth();
    }


    class Program : IDimensions
    {
        float lengthInches;
        float widthInches;

        Program(float length, float width)
        {
            lengthInches = length;
            widthInches = width;
        }
        float IDimensions.getLength() => lengthInches;
        float IDimensions.getWidth() => widthInches;
        static void Main(string[] args)
        {
            Program box1 = new Program(30.0f, 20.0f);

            IDimensions dimensions = box1;


            Console.WriteLine($"Length: {dimensions.getLength()}");
            Console.WriteLine($"Width: {dimensions.getWidth()}");
        }
    }
}
*/