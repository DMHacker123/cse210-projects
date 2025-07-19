using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a scripture reference (single or range)
        Reference reference = new Reference("Proverbs", 3, 5, 6);

        // Scripture text
        string verse = "Trust in the Lord with all thine heart and lean not unto thine own understanding.";

        // Create the scripture object
        Scripture scripture = new Scripture(reference, verse);

        // Main loop
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            // Stop immediately if all words are hidden
            if (scripture.AreAllWordsHidden())
            {
                Console.WriteLine("\nAll words are hidden. Well done!");
                break;
            }

            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to end.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            scripture.HideSomeWords(3); // Hide more words
        }

        Console.WriteLine("\nProgram ended. Goodbye!");
    }
}
