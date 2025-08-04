abstract class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void Start()
    {
        Console.Clear();
        Console.WriteLine($"--- {_name} ---");
        Console.WriteLine(_description);
        Console.Write("Enter duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3);
    }

    public void End()
    {
        Console.WriteLine("\nWell done!");
        ShowSpinner(2);
        Console.WriteLine($"You have completed {_name} for {_duration} seconds.");
        ShowSpinner(3);
        LogActivity();
    }

    public int GetDuration() => _duration;

    protected void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        DateTime end = DateTime.Now.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < end)
        {
            Console.Write(spinner[i]);
            Thread.Sleep(250);
            Console.Write("\b ");
            i = (i + 1) % spinner.Length;
        }
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b ");
        }
        Console.WriteLine();
    }

    protected void LogActivity()
    {
        string logEntry = $"{DateTime.Now}: Completed {_name} for {_duration} seconds.";
        string logPath = "Data/log.txt";
        Directory.CreateDirectory("Data");
        File.AppendAllText(logPath, logEntry + Environment.NewLine);
    }

    public abstract void RunActivity();
}