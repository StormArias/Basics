using ExerciseTwo;
using System;

namespace Arrays
{
    // Write a program, which compares two arrays of type char
    // lexicographically (character by character) and checks, which one is first
    // in the lexicographical order.
    class Program
    {
        static void Main(string[] args)
        {
            char[] arrayOne;
            char[] arrayTwo;
            int length;
            bool areEqual;

            Console.Write("Enter first array length: ");
            length = int.Parse(Console.ReadLine());
            arrayOne = ArrayMaker(length);

            Console.Write("Enter second array length: ");
            length = int.Parse(Console.ReadLine());
            arrayTwo = ArrayMaker(length);

            //areEqual = ArrayCompare.CompareArrayInt(arrayOne, arrayTwo);
            //Console.WriteLine($"Array Equivalency = {areEqual}");
        }

        public static char[] ArrayMaker(int arrayLength)
        {
            char[] array = new char[arrayLength];
            char value;

            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write($"Enter the number for index {i}: ");
                value = char.Parse(Console.ReadLine());
                array[i] = value;
            }

            Console.WriteLine("Array is complete!");
            return array;
        }
    }
}
