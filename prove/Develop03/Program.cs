using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter the scripture reference
        Console.WriteLine("Enter the scripture reference:");
        string referenceInput = Console.ReadLine();

        // Prompt the user to enter the scripture text
        Console.WriteLine("Enter the scripture text:");
        string textInput = Console.ReadLine();

        // Create a new instance of the Reference class with the user input
        Reference reference = new Reference(referenceInput);

        // Create a new instance of the Scripture class with the reference and text
        Scripture scripture = new Scripture(reference, textInput);

        // Keep looping until all words are hidden or the user enters "quit"
        while (!scripture.AllWordsHidden)
        {
            // Clear the console screen
            Console.Clear();

            // Display the scripture
            scripture.Display();

            // Prompt the user to hide more words or quit
            Console.WriteLine("Press Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input == "quit")
                break;

            // Hide a random word in the scripture
            scripture.HideRandomWord();
        }
    }

}