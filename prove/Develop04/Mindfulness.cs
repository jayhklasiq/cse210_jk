public class Mindfulness
{
    private string _activityName;
    private string _activityDescription;
    private int _timer;

    public void SetTimer(int timer)
    {
        _timer = timer;
    }
    public Mindfulness(string activityName, string activityDescription)
    {
        _activityName = activityName;
        _activityDescription = activityDescription;
    }

    public string GetActivityName()
    {
        return _activityName;

    }
    public string GetActivityDescription()
    {
        return _activityDescription;
    }

    public int GetTimer()
    {
        Console.Write("How long, in seconds, would you like your session for? ");
        string seconds = Console.ReadLine();
        _timer = int.Parse(seconds);
        return _timer;
    }



    public void Countdown(int seconds = 1000)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);

        while (DateTime.Now < endTime)
        {
            for (int i = 5; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(seconds);
                Console.Write("\b \b");
            }
        }

    }

    public void StartProgram()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName} Activity.");
        Console.WriteLine();
        Console.WriteLine($"{_activityDescription}");
        Console.WriteLine();
    }
    public void ContProgram()
    {
        Console.WriteLine($"Get ready in...");
        Countdown();
        Console.WriteLine();
    }

    public void EndProgram()
    {
        Console.WriteLine("Welldone!");
        Countdown();
        Console.WriteLine();
        Console.WriteLine($"You have completed {_timer} seconds of the {_activityName} activity.");
        Countdown();
    }

}