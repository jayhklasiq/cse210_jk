public class Listing : Mindfulness
{
    public Listing(string activityName, string activityDescription) : base(activityName, activityDescription) { }

    private List<string> _answers = new List<string>();

    private string[] _questionList = {"Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?"
    };

    public void QuestionGenerator()
    {
        int items = 0;
        int timer = GetTimer();
        Console.Clear();
        ContProgram();
        Random random = new Random();
        string question = _questionList[random.Next(_questionList.Length)];
        Console.WriteLine("List as many responses as you can to the following prompt: ");
        Console.WriteLine($"  --- {question} ---");
        Console.Write("You may begin in: ");
        Countdown();
        Console.WriteLine("\n");
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(timer);
        while (DateTime.Now < endTime)
        {
            Console.Write(">");
            string response = Console.ReadLine();
            _answers.Add(response);
            items++;
        }
        Console.WriteLine($"You listed {items} items!");

    }
}