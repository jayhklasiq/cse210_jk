public class Breathing : Mindfulness
{
    public Breathing(string activityName, string activityDescription) : base(activityName, activityDescription) { }

    public void Breathe()
    {
        int timer = GetTimer();
        Console.Clear();
        ContProgram();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(timer);
        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");
            Countdown();
            Console.Write("\nNow breathe Out...");
            Countdown();
            Console.WriteLine("\n");
        }
    }
}