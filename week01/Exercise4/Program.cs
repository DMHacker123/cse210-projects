using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create an empty list to store the numbers
        List<int> numbers = new List<int>();

        // Ask the user for numbers
        Console.WriteLine("Enter numbers (type 0 to stop):");

        int number = -1; // Start with a number that is not 0
        while (number != 0)
        {
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        // Calculate the sum
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        // Calculate the average
        float average = (float)sum / numbers.Count;

        // Find the largest number
        int max = numbers[0];
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }

        // Show the results
        Console.WriteLine("The sum is: " + sum);
        Console.WriteLine("The average is: " + average);
        Console.WriteLine("The largest number is: " + max);
    }
}
