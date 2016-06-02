using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
    static void Main(String[] args)
    {
        int testCasesCount = Convert.ToInt32(Console.ReadLine());
        int max = int.MinValue;
        int[] testCases = new int[testCasesCount];

        for (int i = 0; i < testCases.Length; i++)
        {
            testCases[i] = Convert.ToInt32(Console.ReadLine());
            max = Math.Max(max, testCases[i]);
        }

        int[] winners = getGameWinnersArray(max);
        printOutput(testCases, winners);
    }

    private static int[] getGameWinnersArray(int n)
    {
        int[] array = new int[n + 1];
        initializeArray(array);

        for (int i = 6; i < array.Length; i++)
        {
            bool res1 = array[i - 2] % 2 == 0;
            bool res2 = array[i - 3] % 2 == 0;
            bool res3 = array[i - 5] % 2 == 0;

            if (res1 || res2 || res3)
            {
                array[i] = 1;
            }
            else
            {
                array[i] = 2;
            }
        }

        return array;
    }

    private static void initializeArray(int[] array)
    {
        if (array.Length > 0)
        {
            array[0] = 2;
        }

        if (array.Length > 1)
        {
            array[1] = 2;
        }

        for (int i = 2; i < array.Length && i <= 5; i++)
        {
            array[i] = 1;
        }
    }

    private static void printOutput(int[] testCases, int[] winners)
    {

        for (int i = 0; i < testCases.Length; i++)
        {
            if (winners[testCases[i]] == 1)
            {
                Console.WriteLine("First");
            }
            else
            {
                Console.WriteLine("Second");
            }
        }
    }
}