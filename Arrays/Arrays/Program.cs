using ExerciseTwo;
using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOne;
            int[] arrayTwo;
            int length;
            bool areEqual;

            Console.Write("Enter first array length: ");
            length = int.Parse(Console.ReadLine());
            arrayOne = ArrayMaker(length);

            Console.Write("Enter second array length: ");
            length = int.Parse(Console.ReadLine());
            arrayTwo = ArrayMaker(length);

            areEqual = ArrayCompare.CompareArray(arrayOne, arrayTwo);
            Console.WriteLine($"Array Equivalency = {areEqual}");
        }

        public static int[] ArrayMaker(int arrayLength)
        {
            int[] array = new int[arrayLength];
            int value;

            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write($"Enter the number for index {i}: ");
                value = int.Parse(Console.ReadLine());
                array[i] = value;
            }

            Console.WriteLine("Array is complete!");
            return array;
        }
    }
}
