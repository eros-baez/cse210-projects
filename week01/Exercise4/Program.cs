using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number = -1;

        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        Console.WriteLine($"The list is: {String.Join(", ", numbers)}");

////////////////////////////////////////////////////////////////////

        int sum = 0;
        foreach (int n in numbers)
        {
            sum += n;
        }



        Console.WriteLine($"The sum is: {sum}");

////////////////////////////////////////////////////////////////////

        if (numbers.Count > 0)
        {
            double averageNumber = (double) sum / (numbers.Count);
            Console.WriteLine($"The average is: {averageNumber}");
        }

        else
        {
            Console.WriteLine("No number was found.");
        }

////////////////////////////////////////////////////////////////////

        int larger = 0;
        foreach (int n in numbers)
        {
            if (n > larger)
            {
                larger = n;
            }
        }
        Console.WriteLine($"The largest number is: {larger}");

        int smaller = numbers[0];
        foreach (int m in numbers)
        {
            if (m < smaller)
            {
                smaller = m;
            }
        }
        Console.WriteLine($"The smallest positive number is: {smaller}");
    }
}