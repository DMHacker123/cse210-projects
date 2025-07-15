using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private readonly List<Entry> _entries = new();

    public void AddEntry(Entry entry) => _entries.Add(entry);

    public void Display()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries yet.\n");
            return;
        }

        foreach (var entry in _entries)
            entry.Display();
    }

    public void Save(string filename)
    {
        File.WriteAllLines(filename, _entries.ConvertAll(e => e.ToFileLine()));
        Console.WriteLine("Journal saved!\n");
    }

    public void Load(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.\n");
            return;
        }

        _entries.Clear();
        foreach (var line in File.ReadAllLines(filename))
            _entries.Add(new Entry(line));

        Console.WriteLine("Journal loaded!\n");
    }
}
