public class PromptGenerator
{
    public string [] _promptList = {"How are you feeling today?", 
    "What was the most memorable event of the day?", 
    "What did you wish you did today that you didn't do?",
    "Who did you meet with today?", 
    "Did something funny happen today?", 
    "Did you have a random thought today?", 
    "What is one thing someone said to you that made you smile today?",
    "What did you read about today? Don't forget it could be from anywhere."};

    public string RandomPromptGenerator()
    {
        Random random = new Random();
        string randomPrompt = _promptList[random.Next(_promptList.Length)];
        return randomPrompt;
    }
}



    