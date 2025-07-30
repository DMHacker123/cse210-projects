using System;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        // TODO: Display the welcome message
    }

    public void DisplayEndingMessage()
    {
        // TODO: Display the ending message
    }

    public void ShowSpinner(int seconds)
    {
        // TODO: Show spinner animation
    }

    public void ShowCountDown(int seconds)
    {
        // TODO: Show countdown timer
    }
}
