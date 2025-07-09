using System;

class Program
{
    static void Main(string[] args)
    {
        // Generate a random number between 1 and 100
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101); // 101 is exclusive, so this gives 1–100

        int guess = 0;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}
