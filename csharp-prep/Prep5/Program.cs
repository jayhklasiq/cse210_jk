using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int squared = PromptUserNumber();

        DisplayResult(userName, squared);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program");
    }
    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string UserName = Console.ReadLine();
        return UserName;
    }
    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        string response = Console.ReadLine();
        int UserNumber = int.Parse(response);
        int NumberSquared = UserNumber * UserNumber;
        return NumberSquared;
    }
    static void DisplayResult(string userName, int squared)
    {
        Console.WriteLine($"{userName}, the square of your number is {squared}.");
    }
    
}