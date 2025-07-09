using System;

class Program
{
    static void Main()
    {
        int sum = 0;
        int max = 0;
        int count = 0;

        for (int i = 0; i <= 50; i++)
        {
            sum += i;

            if (i > max)
                max = i;

            count++;
        }

        double average = (double)sum / count;

        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Average: " + average);
        Console.WriteLine("Maximum: " + max);
    }
}
