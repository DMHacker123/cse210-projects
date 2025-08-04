using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("5. View Activity Log");
            Console.Write("Select an option: ");

            string choice = Console.ReadLine();
            Activity activity = null;

            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity();
                    break;
                case "2":
                    activity = new ReflectionActivity();
                    break;
                case "3":
                    activity = new ListingActivity();
                    break;
                case "4":
                    return;
                case "5":
                    Console.Clear();
                    if (File.Exists("Data/log.txt"))
                        Console.WriteLine(File.ReadAllText("Data/log.txt"));
                    else
                        Console.WriteLine("No activity has been logged yet.");
                    Console.WriteLine("\nPress Enter to return to the menu.");
                    Console.ReadLine();
                    continue;
                default:
                    Console.WriteLine("Invalid choice.");
                    Thread.Sleep(1000);
                    continue;
            }

            activity.RunActivity();
        }
    }
}