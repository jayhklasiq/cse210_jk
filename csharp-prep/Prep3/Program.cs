using System;

class Program
{
    static void Main(string[] args)
    {
        gameGuessing();
        //After the game is over, ask the user if they want to play again. 
        //Then, loop back and play the whole game again and continue this 
        //loop as long as they keep saying "yes". at the end of the game.
        Console.Write("Do you want to play again? ");
        string response = Console.ReadLine();
        while (response == "yes")
        {
            gameGuessing();
            Console.Write("Do you want to play again? ");
            response = Console.ReadLine();
        }
    }    
    static void gameGuessing()
    {
        //1. Start by asking the user for the magic number.
        // Console.Write("What is the magic number? ");
        // string mNum = Console.ReadLine();
        // int magicNum = int.Parse(mNum);
        //3. Instead of having the user supply the magic number, 
        //generate a random number from 1 to 100.
        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1,101);
        //1a. Ask the user for a guess.
        Console.Write("What is your guess? ");
        string g = Console.ReadLine();
        int guess = int.Parse(g);
        int total = 0;
        //1b. Using an if statement, determine if the user 
        //needs to guess higher or lower next time, or 
        //tell them if they guessed it.
        //2. Add a loop that keeps looping as long as the
        // guess does not match the magic number.
        while (magicNum != guess)
        {
        if (guess < magicNum)
        {
           Console.WriteLine("Higher");
           Console.Write("What is your guess? ");
            g = Console.ReadLine();
            guess = int.Parse(g);
        }
        else if (guess > magicNum)
        {
            Console.WriteLine("Lower");
            Console.Write("What is your guess? ");
            g = Console.ReadLine();
            guess = int.Parse(g);
        }
        //Keep track of how many guesses the user has made and 
        //inform them of it at the end of the game.
        total = total + 1;
        }
        if (magicNum == guess)
        {
            Console.WriteLine("You guessed it!");
        }
        Console.WriteLine($"You've made {total} guess(es).");
    }
}