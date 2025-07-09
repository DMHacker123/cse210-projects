using System;

class Program
{
    // Function 1: Display welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // Function 2: Prompt user for their name
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    // Function 3: Prompt user for their favorite number
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    // Function 4: Square the given number
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // Function 5: Display the result
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }

    // Main function
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int squared = SquareNumber(favoriteNumber);

        DisplayResult(userName, squared);
    }
}
