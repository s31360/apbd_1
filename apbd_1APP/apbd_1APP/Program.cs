using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };

        Console.WriteLine($"Max: {FindMax(numbers)}");
    }

    static int FindMax(int[] numbers)
    {
        return numbers.Max();
    }
}