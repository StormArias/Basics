using System;
using System.Collections.Generic;

namespace ExerciseThree
{
    public class CharCompare
    {
        public static void Compare(char[] arrayOne, char[] arrayTwo)
        {
            string answer = null;

            for (int i = 0; i < arrayOne.Length; i++)
            {
                if (arrayOne[i] > arrayTwo[i])
                {
                    answer = $"\"{arrayOne[i]}\" comes after \"{arrayTwo[i]}\"";
                }
                else if (arrayOne[i] < arrayTwo[i])
                {
                    answer = $"\"{arrayOne[i]}\" comes before \"{arrayTwo[i]}\"";
                }
                else
                {
                    answer = $"The letters are the same: \"{arrayOne[i]}\"";
                }

                Console.WriteLine(answer);
            }
        }
    }
}
