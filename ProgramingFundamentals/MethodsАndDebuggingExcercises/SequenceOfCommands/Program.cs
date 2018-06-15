﻿﻿using System;
using System.Linq;

public class SequenceOfCommands_broken
{
    private const char ArgumentsDelimiter = ' ';

    public static void Main()
    {
        int sizeOfArray = int.Parse(Console.ReadLine());

        long[] array = Console.ReadLine()
            .Split(ArgumentsDelimiter)
            .Select(long.Parse)
            .ToArray();

        string command = Console.ReadLine().Trim();

        while (!command.Equals("stop"))
        {
            string[] stringParams = command.Split(ArgumentsDelimiter);

            int[] args = new int[2];

            if (stringParams[0].Equals("add") ||
                stringParams[0].Equals("subtract") ||
                stringParams[0].Equals("multiply"))
            {
                args[0] = int.Parse(stringParams[1]);
                args[1] = int.Parse(stringParams[2]);

                PerformAction(array, stringParams[0], args);
            }
            else
            {
                PerformAction(array, stringParams[0], args);
            }

            PrintArray(array);
            Console.WriteLine();

            command = Console.ReadLine().Trim();
        }
    }

    static void PerformAction(long[] arr, string action, int[] args)
    {
        //long[] array = arr.Clone() as long[];
        int pos = args[0];
        int value = args[1];

        switch (action)
        {
            case "multiply":
                arr[pos - 1] *= value;
                break;
            case "add":
                arr[pos - 1] += value;
                break;
            case "subtract":
                arr[pos - 1] -= value;
                break;
            case "lshift":
                ArrayShiftLeft(arr);
                break;
            case "rshift":
                ArrayShiftRight(arr);
                break;
            default:
                break;
        }
    }

    private static void ArrayShiftRight(long[] array)
    {
        long changerVar = array[array.Length - 1];
        for (int i = array.Length - 1; i >= 1; i--)
        {
            array[i] = array[i - 1];
        }
        array[0] = changerVar;
    }

    private static void ArrayShiftLeft(long[] array)
    {
        long changerVar = array[0];
        for (int i = 0; i < array.Length - 1; i++)
        {
            array[i] = array[i + 1];
        }
        array[array.Length - 1] = changerVar;
    }

    private static void PrintArray(long[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}