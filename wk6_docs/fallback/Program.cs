using System;

class Program
{
    // static void Main(string[] args)
    // {
    //     // Prompt the user to enter the scripture reference
    //     Console.WriteLine("Enter the scripture reference:");
    //     string referenceInput = Console.ReadLine();

    //     // Prompt the user to enter the scripture text
    //     Console.WriteLine("Enter the scripture text:");
    //     string textInput = Console.ReadLine();

    //     // Create a new instance of the Reference class with the user input
    //     Reference reference = new Reference(referenceInput);

    //     // Create a new instance of the Scripture class with the reference and text
    //     Scripture scripture = new Scripture(reference, textInput);

    //     // Keep looping until all words are hidden or the user enters "quit"
    //     while (!scripture.AllWordsHidden)
    //     {
    //         // Clear the console screen
    //         Console.Clear();

    //         // Display the scripture
    //         scripture.Display();

    //         // Prompt the user to hide more words or quit
    //         Console.WriteLine("Press Enter to hide more words or type 'quit' to exit.");
    //         string input = Console.ReadLine();

    //         if (input == "quit")
    //             break;

    //         // Hide a random word in the scripture
    //         scripture.HideRandomWord();
    //     }
    // }


    //==========================================================================================


    static void Main(string[] args)
    {
        // Read scriptures from file
        List<Scripture> scriptures = ReadScripturesFromFile("scripture_mastery.txt");

        // Display the available scriptures
        Console.WriteLine("Select a scripture mastery:");
        for (int i = 0; i < scriptures.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {scriptures[i].Reference}");
        }

        // Prompt the user to select a mastery
        Console.WriteLine("Enter the number of the scripture mastery:");
        int selectedMasteryIndex = int.Parse(Console.ReadLine()) - 1;

        // Get the selected scripture mastery
        Scripture selectedScripture = scriptures[selectedMasteryIndex];

        // Keep looping until all words are hidden or the user enters "quit"
        while (!selectedScripture.AllWordsHidden)
        {
            // Clear the console screen
            Console.Clear();

            // Display the scripture
            selectedScripture.Display();

            // Prompt the user to hide more words or quit
            Console.WriteLine("Press Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input == "quit")
                break;

            // Hide a random word in the scripture
            selectedScripture.HideRandomWord();
        }
    }

    static List<Scripture> ReadScripturesFromFile(string fileName)
    {
        List<Scripture> scriptures = new List<Scripture>();
        string[] lines = File.ReadAllLines(fileName);

        for (int i = 0; i < lines.Length; i += 2)
        {
            string reference = lines[i];
            string text = lines[i + 1];
            scriptures.Add(new Scripture(reference, text));
        }

        return scriptures;
    }
}

