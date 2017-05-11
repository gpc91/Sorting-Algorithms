using System;
using SortingAlgorithms;

public class Program
{
    static void Main(string[] args)
    {
        int[] test = new int[] { 7, 3, 9, 2, 6, 1 };
        test = Sorting.Insertion(test);
        foreach(int i in test)
        {
            Console.WriteLine(i);
        }
        Console.ReadLine();
    }
}