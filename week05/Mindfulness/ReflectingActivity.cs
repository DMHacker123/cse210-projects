using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity() : base("Reflecting", 
        "This activity will help you reflect on times in your life when you have shown strength and resilience.", 
        60)
    {
        _prompts = new List<string>
        {
            "Think of a time when you did something truly difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you overcame a personal fear."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "What did you learn from it?",
            "How did you feel during and after?",
            "What did you learn about yourself?"
        };
    }

    public void Run()
    {
        // TODO: Implement reflecting activity logic
    }

    public string GetRandomPrompt()
    {
        // TODO: Return a random prompt
        return "";
    }

    public string GetRandomQuestion()
    {
        // TODO: Return a random question
        return "";
    }

    public void DisplayPrompt()
    {
        // TODO: Show the selected prompt
    }

    public void DisplayQuestions()
    {
        // TODO: Show and reflect on random questions
    }
}
