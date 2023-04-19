using FactorySorterApp.Models;
using System;
using System.Diagnostics;

namespace FactorySorterApp.Controller;

public static class Controller
{
    public static void Handler(string sortingMethod, int num) 
    {
        ArrayGenerator arr = new ArrayGenerator(num);
        Console.WriteLine($"Unsorted array: {arr.ToString()}");

        Stopwatch stopWatch = new Stopwatch();
        stopWatch.Start();
        SortFactory.ChosenSort(sortingMethod, arr);
        stopWatch.Stop();

        Console.WriteLine($"Your sorted array is: {arr.ToString()}");
        Console.WriteLine($"Time taken: {stopWatch.ElapsedTicks / 100}ns");
    }

    public static bool CheckNegative(int num)
    {
        if (num <= 0)
        {
            return false;
        }
        return true;
    }

}
