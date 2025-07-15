using System;

class Program
{
    static void Main()
    {
        Journal         journal  = new();
        PromptGenerator prompts  = new();
        string choice;

        do
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");
            choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    string prompt = prompts.GetPrompt();
                    Console.WriteLine("Prompt: " + prompt);
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();
                    journal.AddEntry(new Entry(prompt, response));
                    Console.WriteLine("Entry added!\n");
                    break;

                case "2":
                    journal.Display();
                    break;

                case "3":
                    Console.Write("Enter filename: ");
                    journal.Save(Console.ReadLine());
                    break;

                case "4":
                    Console.Write("Enter filename: ");
                    journal.Load(Console.ReadLine());
                    break;

                case "5":
                    Console.WriteLine("Good‑bye!");
                    break;

                default:
                    Console.WriteLine("Invalid option.\n");
                    break;
            }

        } while (choice != "5");
    }
}
