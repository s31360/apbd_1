using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = { 3, 7, 2, 9, 1 };

        Console.WriteLine($"Average: {CalculateAverage(numbers)}");
        Console.WriteLine($"Max: {FindMax(numbers)}");
    }

<<<<<<< HEAD
    static double CalculateAverage(int[] numbers)
    {
        if (numbers.Length == 0) return 0;
        return numbers.Average();
=======
    static double CalculateAverage(int[] data)
    {
        if (data.Length == 0) return 0;
        return data.Average();
>>>>>>> feature-new
    }

    static int FindMax(int[] numbers)
    {
        return numbers.Max();
    }
}