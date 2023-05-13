public class Entry
{
    public string _dateText;
    public string _promptGenerated;
    public string _response;


    public string DateTimeText()
    {
        //Get Date and time
         DateTime theCurrentTime = DateTime.Now;
         string dateText = theCurrentTime.ToShortDateString();
        return dateText;
    }
    public void DisplayUserEntry()
    {
        Console.WriteLine($"Prompt: {_promptGenerated}");
        Console.WriteLine($"Response: {_response}");
        Console.WriteLine($"Date: {_dateText}");
        Console.WriteLine();
    }

}

