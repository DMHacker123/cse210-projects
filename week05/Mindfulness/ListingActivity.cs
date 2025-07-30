using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity() : base("Listing", 
        "This activity helps you reflect on the positive in your life.", 
        60)
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are some of your personal heroes?",
            "When have you felt the most peace?"
        };
    }

    public void Run()
    {
        // TODO: Implement listing activity logic
    }

    public string GetRandomPrompt()
    {
        // TODO: Return a random prompt from the list
        return "";
    }

    public List<string> GetListFromUser()
    {
        // TODO: Collect input from user
        return new List<string>();
    }
}
