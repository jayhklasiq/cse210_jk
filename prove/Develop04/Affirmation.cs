public class Affirmation : Mindfulness
{
    public Affirmation(string activityName, string activityDescription) : base(activityName, activityDescription) { }

    private string[] _affirmationList = {"I am successful.",
    "I am confident.",
    "I am powerful.",
    "I am strong.",
    "I am getting better and better every day.",
    "All I need is within me right now.",
    "I wake up motivated.",
    "I am an unstoppable force of nature.",
    "I am a living, breathing example of motivation.",
    "I am living with abundance.",
    "I am having a positive and inspiring impact on the people I come into contact with.",
    "I am inspiring people through my work.",
    "I am rising above the thoughts that are trying to make me angry or afraid.",
    "Today is a phenomenal day.",
    "I am turning DOWN the volume of negativity in my life, while simultaneously turning UP the volume of positivity.",
    "I am filled with focus.",
    "I am not pushed by my problems; I am led by my dreams.",
    "I am grateful for everything I have in my life.",
    "I am independent and self-sufficient.",
    "I can be whatever I want to be."};


    public void AffirmationGenerator()
    {
        int timer = GetTimer();
        Console.Clear();
        ContProgram();
        Random random = new Random();
        Console.WriteLine("Say the following affirmations ALOUD:");
        Console.WriteLine();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(timer);
        while (DateTime.Now < endTime)
        {
            Random randomQuestion = new Random();
            string affirm = _affirmationList[random.Next(_affirmationList.Length)];
            Console.Write($"> {affirm} ");
            Countdown();
            Console.Write("\n");
        }
    }
}