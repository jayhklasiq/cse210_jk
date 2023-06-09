using System;

class Program
{
    static void Main(string[] args)
    {
        bool continueProgram = true;
        while (continueProgram)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflection Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Start Affirmation Activity");
            Console.WriteLine("  5. Quit");
            Console.Write("Select a choice from the menu: ");
            string reply = Console.ReadLine();
            Console.WriteLine();
            int numChoice = int.Parse(reply);

            if (numChoice == 1)
            {
                Breathing breathing = new Breathing("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                breathing.StartProgram();
                breathing.Breathe();
                breathing.EndProgram();
                Console.Clear();
            }
            else if (numChoice == 2)
            {
                Reflection reflection = new Reflection("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                reflection.StartProgram();
                reflection.PromptGenerator();
                Console.WriteLine();
                reflection.EndProgram();
                Console.Clear();
            }
            else if (numChoice == 3)
            {
                Listing listing = new Listing("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                listing.StartProgram();
                listing.QuestionGenerator();
                Console.WriteLine();
                listing.EndProgram();
                Console.Clear();
            }

            else if (numChoice == 4)
            {
                Affirmation affirmation = new Affirmation("Affirmation", "This activity will help you reflect on the good things in your life by having you say as many words of affirmation aloud.");
                affirmation.StartProgram();
                affirmation.AffirmationGenerator();
                Console.WriteLine();
                affirmation.EndProgram();
                Console.Clear();
            }
            else if (numChoice == 5)
            {
                Console.WriteLine("See you tomorrow for another mindfulness activity.");
                continueProgram = false;
            }
            Console.WriteLine();
        }
    }

}