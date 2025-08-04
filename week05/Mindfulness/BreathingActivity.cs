class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity",
        "This activity will help you relax by guiding you through slow breathing.") { }

    public override void RunActivity()
    {
        Start();
        int duration = GetDuration();
        int cycleTime = 6;
        int cycles = duration / cycleTime;

        for (int i = 0; i < cycles; i++)
        {
            Console.Write("Breathe in... ");
            ShowCountdown(3);
            Console.Write("Breathe out... ");
            ShowCountdown(3);
        }

        End();
    }
}