using System;
using System.Collections.Generic;
using System.IO;

// ===== BASE CLASS =====
abstract class Goal
{
    public string Name { get; }
    public string Description { get; }
    public int Points { get; }

    protected Goal(string name, string desc, int points)
    {
        Name = name;
        Description = desc;
        Points = points;
    }

    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public abstract string SaveString();
    public abstract string Status();
}

// ===== SIMPLE GOAL =====
class SimpleGoal : Goal
{
    private bool complete;
    public SimpleGoal(string name, string desc, int points, bool done = false)
        : base(name, desc, points) => complete = done;

    public override int RecordEvent()
    {
        if (!complete) { complete = true; return Points; }
        return 0;
    }
    public override bool IsComplete() => complete;
    public override string SaveString() => $"Simple|{Name}|{Description}|{Points}|{complete}";
    public override string Status() => $"[{(complete ? "X" : " ")}] {Name} ({Description})";
}

// ===== ETERNAL GOAL =====
class EternalGoal : Goal
{
    public EternalGoal(string name, string desc, int points)
        : base(name, desc, points) { }

    public override int RecordEvent() => Points;
    public override bool IsComplete() => false;
    public override string SaveString() => $"Eternal|{Name}|{Description}|{Points}";
    public override string Status() => $"[∞] {Name} ({Description})";
}

// ===== CHECKLIST GOAL =====
class ChecklistGoal : Goal
{
    private int target, count, bonus;
    public ChecklistGoal(string name, string desc, int points, int target, int bonus, int count = 0)
        : base(name, desc, points) { this.target = target; this.bonus = bonus; this.count = count; }

    public override int RecordEvent()
    {
        count++;
        return Points + (count == target ? bonus : 0);
    }
    public override bool IsComplete() => count >= target;
    public override string SaveString() => $"Checklist|{Name}|{Description}|{Points}|{target}|{bonus}|{count}";
    public override string Status() => $"[{(IsComplete() ? "X" : " ")}] {Name} ({Description}) {count}/{target}";
}

// ===== MANAGER =====
class GoalManager
{
    private List<Goal> goals = new();
    private int score;

    public void Start()
    {
        int choice;
        do
        {
            Console.WriteLine($"\nYou have {score} points.");
            Console.WriteLine("1. New Goal  2. List  3. Save  4. Load  5. Record  6. Quit");
            int.TryParse(Console.ReadLine(), out choice);
            if (choice == 1) NewGoal();
            else if (choice == 2) ListGoals();
            else if (choice == 3) Save();
            else if (choice == 4) Load();
            else if (choice == 5) Record();
        } while (choice != 6);
    }

    void NewGoal()
    {
        Console.WriteLine("1 Simple  2 Eternal  3 Checklist");
        int type = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Name: "); string n = Console.ReadLine();
        Console.Write("Desc: "); string d = Console.ReadLine();
        Console.Write("Points: "); int p = int.Parse(Console.ReadLine());
        if (type == 1) goals.Add(new SimpleGoal(n, d, p));
        else if (type == 2) goals.Add(new EternalGoal(n, d, p));
        else
        {
            Console.Write("Target: "); int t = int.Parse(Console.ReadLine());
            Console.Write("Bonus: "); int b = int.Parse(Console.ReadLine());
            goals.Add(new ChecklistGoal(n, d, p, t, b));
        }
    }

    void ListGoals()
    {
        for (int i = 0; i < goals.Count; i++)
            Console.WriteLine($"{i + 1}. {goals[i].Status()}");
    }

    void Save()
    {
        Console.Write("File: "); string file = Console.ReadLine();
        using var sw = new StreamWriter(file);
        sw.WriteLine(score);
        foreach (var g in goals) sw.WriteLine(g.SaveString());
    }

    void Load()
    {
        Console.Write("File: "); string file = Console.ReadLine();
        if (!File.Exists(file)) { Console.WriteLine("Not found."); return; }
        var lines = File.ReadAllLines(file);
        score = int.Parse(lines[0]);
        goals.Clear();
        for (int i = 1; i < lines.Length; i++)
        {
            var p = lines[i].Split('|');
            if (p[0] == "Simple") goals.Add(new SimpleGoal(p[1], p[2], int.Parse(p[3]), bool.Parse(p[4])));
            else if (p[0] == "Eternal") goals.Add(new EternalGoal(p[1], p[2], int.Parse(p[3])));
            else goals.Add(new ChecklistGoal(p[1], p[2], int.Parse(p[3]), int.Parse(p[4]), int.Parse(p[5]), int.Parse(p[6])));
        }
    }

    void Record()
    {
        ListGoals();
        Console.Write("Which goal? "); int idx = int.Parse(Console.ReadLine() ?? "0") - 1;
        if (idx < 0 || idx >= goals.Count) return;
        int pts = goals[idx].RecordEvent();
        score += pts;
        Console.WriteLine($"You earned {pts} points!");
    }
}

// ===== ENTRY POINT =====
class Program
{
    static void Main() => new GoalManager().Start();
}
