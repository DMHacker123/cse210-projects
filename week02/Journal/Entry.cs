using System;

public class Entry
{
    public string Date    { get; }
    public string Prompt  { get; }
    public string Response{ get; }

    // new entry created by the user
    public Entry(string prompt, string response)
    {
        Date     = DateTime.Now.ToString("yyyy-MM-dd");
        Prompt   = prompt;
        Response = response;
    }

    // entry recreated from a line in the file
    public Entry(string line)
    {
        var parts = line.Split('|');
        Date     = parts[0];
        Prompt   = parts[1];
        Response = parts[2];
    }

    public string ToFileLine() => $"{Date}|{Prompt}|{Response}";

    public void Display()
    {
        Console.WriteLine($"{Date} - Q: {Prompt}");
        Console.WriteLine($"    A: {Response}\n");
    }
}
