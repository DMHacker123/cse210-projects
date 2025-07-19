using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string verse = "Trust in the Lord with all thine heart and lean not unto thine own understanding.";

        Scripture scripture = new Scripture(reference, verse);

        while (!scripture.AreAllWordsHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to end.");
            string input = Console.ReadLine();
            if (input == "quit") break;

            scripture.HideSomeWords(3);
        }

        Console.WriteLine("\nProgram ended. Goodbye!");
    }
}
