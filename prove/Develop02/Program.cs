using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journalEntry = new Journal();
        bool rerunPregram = true;
        while (rerunPregram)
    {
        Console.WriteLine("Please select one of the following: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Delete Entry");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Load");
        Console.WriteLine("6. Quit");
        string response = Console.ReadLine();
        int numChoice = int.Parse(response);
        

        if (numChoice == 1)
        {
            //Generate and display a random prompt for user to respond to.
            PromptGenerator generator = new PromptGenerator();
            string prompt = generator.RandomPromptGenerator();
            Console.WriteLine(prompt);
            string promptResponse = Console.ReadLine();
            //Save the generated prompt, response, and date it was responded to.
            Entry userEntry = new Entry();
            string date = userEntry.DateTimeText();
            userEntry._promptGenerated = prompt;
            userEntry._response = promptResponse;
            userEntry._dateText = date;

            journalEntry.AddEntry(userEntry);
            // journalEntry._storedEntries.Add(userEntry);
        }
        else if (numChoice == 2)
        {
            journalEntry.DisplayEntryList();
        }
        else if (numChoice == 3)
        {
            Console.WriteLine("What entry do you want to delete?");
            string entryToDelete = Console.ReadLine();
            int index = int.Parse(entryToDelete);
            index -= 1;
            journalEntry.DeleteEntry(journalEntry._storedEntries[index]);
            Console.WriteLine("Entry deleted successfully");
        }
        else if (numChoice == 4)
        {
            Console.WriteLine("What would you like to save this document as?");
            string docName = Console.ReadLine();
            journalEntry._filename = docName;
            journalEntry.SaveJournal();

        }
        else if (numChoice == 5)
        {
            Console.WriteLine("What document do you want to load from?");
            string docName = Console.ReadLine();
            journalEntry._filename = docName;
            journalEntry.LoadJournal();
        }
        else if (numChoice == 6)
        {
            Console.WriteLine("See you tomorrow for another experience.");
            rerunPregram = false;
        }
        Console.WriteLine();

    }
    }
}    

