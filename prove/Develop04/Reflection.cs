public class Reflection : Mindfulness
{
    public Reflection(string activityName, string activityDescription) : base(activityName, activityDescription) { }

    private string[] _reflectionList = {"Think of a time when you stood up for someone else.",
    "Think of a time when you did something really difficult.",
    "Think of a time when you helped someone in need.",
    "Think of a time when you helped someone in need."
    };

    private string[] _reflectionQuestions = {"Why was this experience meaningful to you?",
    "Have you ever done anything like this before?",
    "How did you get started?",
    "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?",
    "What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?",
    "How can you keep this experience in mind in the future?"
    };

    public void PromptGenerator()
    {
        int timer = GetTimer();
        Console.Clear();
        ContProgram();
        Random random = new Random();
        string prompt = _reflectionList[random.Next(_reflectionList.Length)];
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"  --- {prompt} ---");
        Console.WriteLine();
        Console.Write("When you have something in mind, press enter to continue.");
        string input = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        Countdown();
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(timer);
        while (DateTime.Now < endTime)
        {
            Random randomQuestion = new Random();
            string question = _reflectionQuestions[randomQuestion.Next(_reflectionQuestions.Length)];
            Console.Write($"> {question} ");
            Countdown(2500);
            Console.Write("\n");
        }

    }





}