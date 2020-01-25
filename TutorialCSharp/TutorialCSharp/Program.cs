using System;

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
