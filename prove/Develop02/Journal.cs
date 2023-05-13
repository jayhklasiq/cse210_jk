using System.IO;
public class Journal
{
    public List<Entry> _storedEntries = new List<Entry>();

    public string _filename;

    public void DisplayEntryList()
    {
        Console.WriteLine("Your Entries for today: ");
        foreach (Entry entry in _storedEntries)
        {
            entry.DisplayUserEntry();
            Console.WriteLine();
        }
    }

    public void AddEntry(Entry entry)
    {
        _storedEntries.Add(entry);
    }
    public void SaveJournal()
    {
        string filename = _filename;
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _storedEntries)
            {
                outputFile.WriteLine($"{entry._dateText}|{entry._promptGenerated}|{entry._response}");
                Console.WriteLine();
            }
        }
   
    }

    public void LoadJournal()
    {
        string filename = _filename;
        string[] journal = System.IO.File.ReadAllLines(filename);
        foreach (string line in journal)
        {
            string[] parts = line.Split("|");
            string date = parts[0];
            string prompt = parts[1];
            string response = parts[2];
            Console.WriteLine($"Prompt: {date}");
            Console.WriteLine($"Response: {prompt}");
            Console.WriteLine($"Date: {response}");
            Console.WriteLine();
        }
    }

    public void DeleteEntry(Entry entry)
    {
        _storedEntries.Remove(entry);
    }
}    