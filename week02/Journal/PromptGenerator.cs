using System;

public class PromptGenerator
{
    private readonly string[] _prompts =
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    private readonly Random _random = new Random();

    public string GetPrompt()
    {
        return _prompts[_random.Next(_prompts.Length)];
    }
}
