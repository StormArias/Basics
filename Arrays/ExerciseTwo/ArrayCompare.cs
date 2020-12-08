using System;

namespace ExerciseTwo
{
    // Write a program, which reads two arrays from the console and checks
    // whether they are equal(two arrays are equal when they are of equal
    // length and all of their elements, which have the same index, are equal).
    public class ArrayCompare
    {
        public static bool CompareArrayInt(int[] arrayOne, int[] arrayTwo)
        {
            bool isEqualLength;
            bool? hasEqualIndexValues = null;

            isEqualLength = (arrayOne.Length == arrayTwo.Length);

            if (!isEqualLength)
            {
                return false;
            }

            for (int i = 0; i < arrayOne.Length; i++)
            {
                hasEqualIndexValues = (arrayOne[i] == arrayTwo[i]);
                if ((bool)!hasEqualIndexValues)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
